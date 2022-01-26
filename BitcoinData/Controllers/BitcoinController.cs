using BitcoinData.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BitcoinData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BitcoinController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BitcoinController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            var response = await _httpClientFactory
                .CreateClient()
                .GetAsync("https://api.coingecko.com/api/v3/coins/bitcoin?tickers=false&market_data=true&community_data=false&developer_data=false&sparkline=false");
            var parsedResponse = JsonConvert.DeserializeObject<CoinInfo>(await response.Content.ReadAsStringAsync());
            var price = parsedResponse
                ?.MarketData
                ?.CurrentPrice
                .FirstOrDefault(x => x.Key == "gbp");
            
            return price.Value.Key == null
            ? "No Data"
            : price.Value.Value.ToString("C");
        }
    }
}
