using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaAPI.Response
{
    public class SsmlOutputSpeech : IOutputSpeech
    {
        [JsonProperty("type")]
        [JsonRequired]
        public string Type { get; set; }

        [JsonRequired]
        [JsonProperty("ssml")]
        public string Ssml {get; set;}


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

    }
}
