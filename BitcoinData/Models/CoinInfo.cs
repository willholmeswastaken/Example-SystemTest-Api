using Newtonsoft.Json;

namespace BitcoinData.Models
{
    public class CoinInfo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("asset_platform_id")]
        public object AssetPlatformId { get; set; }

        [JsonProperty("platforms")]
        public Platforms Platforms { get; set; }

        [JsonProperty("block_time_in_minutes")]
        public long BlockTimeInMinutes { get; set; }

        [JsonProperty("hashing_algorithm")]
        public string HashingAlgorithm { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("public_notice")]
        public object PublicNotice { get; set; }

        [JsonProperty("additional_notices")]
        public object[] AdditionalNotices { get; set; }

        [JsonProperty("localization")]
        public Tion Localization { get; set; }

        [JsonProperty("description")]
        public Tion Description { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("country_origin")]
        public string CountryOrigin { get; set; }

        [JsonProperty("genesis_date")]
        public DateTimeOffset GenesisDate { get; set; }

        [JsonProperty("sentiment_votes_up_percentage")]
        public double SentimentVotesUpPercentage { get; set; }

        [JsonProperty("sentiment_votes_down_percentage")]
        public double SentimentVotesDownPercentage { get; set; }

        [JsonProperty("market_cap_rank")]
        public long MarketCapRank { get; set; }

        [JsonProperty("coingecko_rank")]
        public long CoingeckoRank { get; set; }

        [JsonProperty("coingecko_score")]
        public double CoingeckoScore { get; set; }

        [JsonProperty("developer_score")]
        public double DeveloperScore { get; set; }

        [JsonProperty("community_score")]
        public double CommunityScore { get; set; }

        [JsonProperty("liquidity_score")]
        public double LiquidityScore { get; set; }

        [JsonProperty("public_interest_score")]
        public double PublicInterestScore { get; set; }

        [JsonProperty("market_data")]
        public MarketData MarketData { get; set; }

        [JsonProperty("public_interest_stats")]
        public PublicInterestStats PublicInterestStats { get; set; }

        [JsonProperty("status_updates")]
        public object[] StatusUpdates { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }
    }

    public partial class Tion
    {
        [JsonProperty("en")]
        public string En { get; set; }

        [JsonProperty("de")]
        public string De { get; set; }

        [JsonProperty("es")]
        public string Es { get; set; }

        [JsonProperty("fr")]
        public string Fr { get; set; }

        [JsonProperty("it")]
        public string It { get; set; }

        [JsonProperty("pl")]
        public string Pl { get; set; }

        [JsonProperty("ro")]
        public string Ro { get; set; }

        [JsonProperty("hu")]
        public string Hu { get; set; }

        [JsonProperty("nl")]
        public string Nl { get; set; }

        [JsonProperty("pt")]
        public string Pt { get; set; }

        [JsonProperty("sv")]
        public string Sv { get; set; }

        [JsonProperty("vi")]
        public string Vi { get; set; }

        [JsonProperty("tr")]
        public string Tr { get; set; }

        [JsonProperty("ru")]
        public string Ru { get; set; }

        [JsonProperty("ja")]
        public string Ja { get; set; }

        [JsonProperty("zh")]
        public string Zh { get; set; }

        [JsonProperty("zh-tw")]
        public string ZhTw { get; set; }

        [JsonProperty("ko")]
        public string Ko { get; set; }

        [JsonProperty("ar")]
        public string Ar { get; set; }

        [JsonProperty("th")]
        public string Th { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("thumb")]
        public Uri Thumb { get; set; }

        [JsonProperty("small")]
        public Uri Small { get; set; }

        [JsonProperty("large")]
        public Uri Large { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("homepage")]
        public string[] Homepage { get; set; }

        [JsonProperty("blockchain_site")]
        public string[] BlockchainSite { get; set; }

        [JsonProperty("official_forum_url")]
        public string[] OfficialForumUrl { get; set; }

        [JsonProperty("chat_url")]
        public string[] ChatUrl { get; set; }

        [JsonProperty("announcement_url")]
        public string[] AnnouncementUrl { get; set; }

        [JsonProperty("twitter_screen_name")]
        public string TwitterScreenName { get; set; }

        [JsonProperty("facebook_username")]
        public string FacebookUsername { get; set; }

        [JsonProperty("bitcointalk_thread_identifier")]
        public object BitcointalkThreadIdentifier { get; set; }

        [JsonProperty("telegram_channel_identifier")]
        public string TelegramChannelIdentifier { get; set; }

        [JsonProperty("subreddit_url")]
        public Uri SubredditUrl { get; set; }

        [JsonProperty("repos_url")]
        public ReposUrl ReposUrl { get; set; }
    }

    public partial class ReposUrl
    {
        [JsonProperty("github")]
        public Uri[] Github { get; set; }

        [JsonProperty("bitbucket")]
        public object[] Bitbucket { get; set; }
    }

    public partial class MarketData
    {
        [JsonProperty("current_price")]
        public Dictionary<string, double> CurrentPrice { get; set; }

        [JsonProperty("total_value_locked")]
        public object TotalValueLocked { get; set; }

        [JsonProperty("mcap_to_tvl_ratio")]
        public object McapToTvlRatio { get; set; }

        [JsonProperty("fdv_to_tvl_ratio")]
        public object FdvToTvlRatio { get; set; }

        [JsonProperty("roi")]
        public object Roi { get; set; }

        [JsonProperty("ath")]
        public Dictionary<string, double> Ath { get; set; }

        [JsonProperty("ath_change_percentage")]
        public Dictionary<string, double> AthChangePercentage { get; set; }

        [JsonProperty("ath_date")]
        public Dictionary<string, DateTimeOffset> AthDate { get; set; }

        [JsonProperty("atl")]
        public Dictionary<string, double> Atl { get; set; }

        [JsonProperty("atl_change_percentage")]
        public Dictionary<string, double> AtlChangePercentage { get; set; }

        [JsonProperty("atl_date")]
        public Dictionary<string, DateTimeOffset> AtlDate { get; set; }

        [JsonProperty("market_cap")]
        public Dictionary<string, double> MarketCap { get; set; }

        [JsonProperty("market_cap_rank")]
        public long MarketCapRank { get; set; }

        [JsonProperty("fully_diluted_valuation")]
        public Dictionary<string, double> FullyDilutedValuation { get; set; }

        [JsonProperty("total_volume")]
        public Dictionary<string, double> TotalVolume { get; set; }

        [JsonProperty("high_24h")]
        public Dictionary<string, double> High24H { get; set; }

        [JsonProperty("low_24h")]
        public Dictionary<string, double> Low24H { get; set; }

        [JsonProperty("price_change_24h")]
        public long PriceChange24H { get; set; }

        [JsonProperty("price_change_percentage_24h")]
        public double PriceChangePercentage24H { get; set; }

        [JsonProperty("price_change_percentage_7d")]
        public double PriceChangePercentage7D { get; set; }

        [JsonProperty("price_change_percentage_14d")]
        public double PriceChangePercentage14D { get; set; }

        [JsonProperty("price_change_percentage_30d")]
        public double PriceChangePercentage30D { get; set; }

        [JsonProperty("price_change_percentage_60d")]
        public double PriceChangePercentage60D { get; set; }

        [JsonProperty("price_change_percentage_200d")]
        public double PriceChangePercentage200D { get; set; }

        [JsonProperty("price_change_percentage_1y")]
        public double PriceChangePercentage1Y { get; set; }

        [JsonProperty("market_cap_change_24h")]
        public long MarketCapChange24H { get; set; }

        [JsonProperty("market_cap_change_percentage_24h")]
        public double MarketCapChangePercentage24H { get; set; }

        [JsonProperty("price_change_24h_in_currency")]
        public Dictionary<string, double> PriceChange24HInCurrency { get; set; }

        [JsonProperty("price_change_percentage_1h_in_currency")]
        public Dictionary<string, double> PriceChangePercentage1HInCurrency { get; set; }

        [JsonProperty("price_change_percentage_24h_in_currency")]
        public Dictionary<string, double> PriceChangePercentage24HInCurrency { get; set; }

        [JsonProperty("price_change_percentage_7d_in_currency")]
        public Dictionary<string, double> PriceChangePercentage7DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_14d_in_currency")]
        public Dictionary<string, double> PriceChangePercentage14DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_30d_in_currency")]
        public Dictionary<string, double> PriceChangePercentage30DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_60d_in_currency")]
        public Dictionary<string, double> PriceChangePercentage60DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_200d_in_currency")]
        public Dictionary<string, double> PriceChangePercentage200DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_1y_in_currency")]
        public Dictionary<string, double> PriceChangePercentage1YInCurrency { get; set; }

        [JsonProperty("market_cap_change_24h_in_currency")]
        public Dictionary<string, double> MarketCapChange24HInCurrency { get; set; }

        [JsonProperty("market_cap_change_percentage_24h_in_currency")]
        public Dictionary<string, double> MarketCapChangePercentage24HInCurrency { get; set; }

        [JsonProperty("total_supply")]
        public long TotalSupply { get; set; }

        [JsonProperty("max_supply")]
        public long MaxSupply { get; set; }

        [JsonProperty("circulating_supply")]
        public long CirculatingSupply { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }
    }

    public partial class Platforms
    {
        [JsonProperty("")]
        public string Empty { get; set; }
    }

    public partial class PublicInterestStats
    {
        [JsonProperty("alexa_rank")]
        public long AlexaRank { get; set; }

        [JsonProperty("bing_matches")]
        public object BingMatches { get; set; }
    }
}
