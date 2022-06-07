using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignTrackerLibrary
{
    class CArmor
    {
        public string Name { get; set; }
        public string Type { get; set; } // Light, Medium, Heavy, or Shield
        public string ArmorClass { get; set; }
        public string StrengthRequirement { get; set; } // a number
        public string StealthDisadvantage { get; set; } // true or false
        public string Weight { get; set; }
        public string Cost { get; set; }
    }
}
