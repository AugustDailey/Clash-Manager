using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashManager.Domain.Models
{
    public class Round
    {
        [JsonProperty(PropertyName = "warTags")]
        public List<string> WarTags { get; set; }
    }
}
