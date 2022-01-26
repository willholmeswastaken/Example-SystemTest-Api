using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AutoFixture;
using BitcoinData.Models;
using FluentAssertions;
using JustEat.HttpClientInterception;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace BitcoinData.Tests;

public class BitcoinControllerTests
{
    private readonly Fixture _fixture = new();
    private readonly HttpClientInterceptorOptions _options = new();
    private readonly HttpRequestInterceptionBuilder _builder = new();
    private readonly Mock<IHttpClientFactory> _httpClientFactory = new();
    private const string _apiHost = "api.coingecko.com";
    private const string _apiPath = "api/v3/coins/bitcoin";
    private const string _apiQuery = "tickers=false&market_data=true&community_data=false&developer_data=false&sparkline=false";

    public BitcoinControllerTests()
    {
        _options.ThrowsOnMissingRegistration();
    }

    [Fact]
    public async Task BitcoinController_Should_Return_Ok_With_Price()
    {
        var expectedCoinResponse = _fixture
            .Build<CoinInfo>()
            .With(x => x.MarketData,
                _fixture
                    .Build<MarketData>()
                    .With(y => y.CurrentPrice, new Dictionary<string, double> {{"gbp", 10.00}})
                    .Create())
            .Create();

        _builder
            .Requests()
            .ForGet()
            .ForHttps()
            .ForHost(_apiHost)
            .ForPath(_apiPath)
            .ForQuery(_apiQuery)
            .Responds()
            .WithStatus(200)
            .WithJsonContent(expectedCoinResponse)
            .RegisterWith(_options);

        _httpClientFactory.Setup(x => x.CreateClient(It.IsAny<string>()))
            .Returns(_options.CreateHttpClient());

        var client = CreateApiHttpClient();

        var response = await client.GetAsync("/api/Bitcoin");

        response.EnsureSuccessStatusCode();
    }

    [Fact]
    public async Task BitcoinController_Should_Return_NoData_When_GBP_not_returned()
    {
        var expectedCoinResponse = _fixture
            .Build<CoinInfo>()
            .With(x => x.MarketData,
                _fixture
                    .Build<MarketData>()
                    .With(y => y.CurrentPrice, new Dictionary<string, double> { })
                    .Create())
            .Create();

        _builder
            .Requests()
            .ForGet()
            .ForHttps()
            .ForHost(_apiHost)
            .ForPath(_apiPath)
            .ForQuery(_apiQuery)
            .Responds()
            .WithStatus(200)
            .WithJsonContent(expectedCoinResponse)
            .RegisterWith(_options);

        _httpClientFactory.Setup(x => x.CreateClient(It.IsAny<string>()))
            .Returns(_options.CreateHttpClient());

        var client = CreateApiHttpClient();

        var response = await client.GetAsync("/api/Bitcoin");
        var content = await response.Content.ReadAsStringAsync();

        response.EnsureSuccessStatusCode();
        content.Should().Be("No Data");
    }

    [Fact]
    public async Task BitcoinController_Should_break_When_coinGecko_fails()
    {
        _builder
            .Requests()
            .ForGet()
            .ForHttps()
            .ForHost(_apiHost)
            .ForPath(_apiPath)
            .ForQuery(_apiQuery)
            .Responds()
            .WithStatus(500)
            .RegisterWith(_options);

        _httpClientFactory.Setup(x => x.CreateClient(It.IsAny<string>()))
            .Returns(_options.CreateHttpClient());

        var client = CreateApiHttpClient();

        var response = await client.GetAsync("/api/Bitcoin");

        response.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
    }

    private HttpClient CreateApiHttpClient()
    {
        var application = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    services.AddSingleton(_httpClientFactory.Object);
                });
            });
        var client = application.CreateClient();
        return client;
    }
}