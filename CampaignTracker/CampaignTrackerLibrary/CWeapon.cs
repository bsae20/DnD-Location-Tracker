using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignTrackerLibrary
{
    class CWeapon
    {
        public string Name { get; set; }
        public string Type { get; set; } // Simple Melee, Simple Ranged, Martial Melee, or Martial Ranged
        public string NumberOfDice { get; set; }
        public string DamageDie { get; set; }
        public string DamageType { get; set; }
        public string StrengthRequirement { get; set; } // a number
        public string AbleToThrow { get; set; } // str to bool
        public string ThrownMaxRange { get; set; } // str to bool
        public string ThrownMinRange { get; set; } // str to bool
        public string CanBeLit { get; set; } // str to bool
        public string Finesse { get; set; } // str to bool
        public string TwoHanded { get; set; } // str to bool
        public string Versatile { get; set; } // str to bool
        public string VersatileNumberOfDice { get; set; } // str to byte
        public string VersatileDamageDie { get; set; } // str to byte
        public string Ammunition { get; set; } // str to bool
        public string AmmunitionMaxRange { get; set; } //str to byte
        public string AmmunitionMinRange { get; set; } //str to byte
        public string Heavy { get; set; } //str to bool
        public string Reach { get; set; } //str to bool
        public string Loading { get; set; } //str to bool
        public string Weight { get; set; }
        public string Cost { get; set; }
    }
}
