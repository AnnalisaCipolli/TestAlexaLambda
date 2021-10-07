using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaAPI.Response
{
    public class PlainTextOutputSpeech:  IOutputSpeech
    {
        //[JsonProperty("type")]
        //[JsonRequired]
        //public string Type {get {return "PlainText";}}

        [JsonProperty("type")]
        [JsonRequired]
        public string Type { get; set; }

        [JsonRequired]
        [JsonProperty("text")]
        public string Text {get; set;}


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Ssml { get; set; }
    }
}
