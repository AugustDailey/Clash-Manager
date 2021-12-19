using System;
using System.Collections.Generic;
using System.Text;

namespace ClashManager.Domain.Models
{
    public class WarReinforcementResult
    {
        public bool Success { get; set; }
        public Dictionary<string, int> TroopCounts { get; set; }
        public List<string> Errors { get; set; }
    }
}
