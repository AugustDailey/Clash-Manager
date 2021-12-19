using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashManager.Domain.Models
{
    public class Achievement
    {
        [JsonProperty(PropertyName = "stars")]
        public int Stars { get; set; }

        [JsonProperty(PropertyName = "value")]
        public int Value { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "target")]
        public int Target { get; set; }

        [JsonProperty(PropertyName = "info")]
        public string Info { get; set; }

        [JsonProperty(PropertyName = "completionInfo")]
        public string CompletionInfo { get; set; }

        [JsonProperty(PropertyName = "village")]
        public string Village { get; set; }
    }
}
