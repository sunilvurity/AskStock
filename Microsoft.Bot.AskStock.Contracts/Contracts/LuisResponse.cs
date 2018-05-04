using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.Bot.AskStock.Contracts
{
    public class LuisResponse
    {
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        [JsonProperty(PropertyName = "topScoringIntent")]
        public LuisIntent TopScoringIntent { get; set; }

        [JsonProperty(PropertyName = "intents")]
        public IList<LuisIntent> Intents { get; set; }

        [JsonProperty(PropertyName = "entities")]
        public JArray Entities { get; set; }
    }
}
