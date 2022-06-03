using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignTrackerLibrary
{
    public class CCharacter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Race { get; set; }
        public string Alignment { get; set; }
        public string ArmorClass { get; set; }
        public byte HitPoints { get; set; }
        public sbyte Speed { get; set; }
        public byte[] BaseStatBlock { get; set; } // str, dex, con, int, wis, cha
        public byte[] BaseSavingThrows { get; set; } // str, dex, con, int, wis, cha
        public sbyte[] StatBlockModifiers { get; set; }
        public List<Skills> NonZeroSkills { get; set; } = new List<Skills>();

    }
}
