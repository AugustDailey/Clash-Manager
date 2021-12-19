using Newtonsoft.Json;
using System.Collections.Generic;

namespace ClashManager.Domain.Models
{
    public class WarLog
    {
        [JsonProperty(PropertyName = "items")]
        public List<War> Wars { get; set; }
    }
}
