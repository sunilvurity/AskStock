using Newtonsoft.Json;

namespace Microsoft.Bot.AskStock.Contracts
{
    public class LuisIntent
    {
        [JsonProperty(PropertyName = "intent")]
        public Intent Intent { get; set; }

        [JsonProperty(PropertyName = "score")]
        public double Score { get; set; }
    }
}
