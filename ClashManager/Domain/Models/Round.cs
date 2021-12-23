using Newtonsoft.Json;
using System.Collections.Generic;

namespace ClashManager.Domain.Models
{
    public class Round
    {
        [JsonProperty(PropertyName = "warTags")]
        public List<string> WarTags { get; set; }
    }
}
