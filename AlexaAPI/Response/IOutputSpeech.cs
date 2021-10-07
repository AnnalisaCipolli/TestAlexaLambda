using System;
using Newtonsoft.Json;

namespace AlexaAPI.Response
{
    public interface IOutputSpeech 
    {
        string Type {get;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Ssml { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
    }
}
