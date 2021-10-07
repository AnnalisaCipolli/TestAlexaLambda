﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaAPI.Response
{
    public class Reprompt
    {
        [JsonProperty("outputSpeech", NullValueHandling = NullValueHandling.Ignore)]
        public PlainTextOutputSpeech OutputSpeech {get; set;}
    }
}
