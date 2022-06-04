using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignTrackerLibrary
{
    public class CRaceTraits
    {
        public string AbilityScoreIncrease { get; set; }
        public string Size { get; set; }
        public string Speed { get; set; }
        public List<Languages> KnownLanguages { get; set; } = new List<Languages>();
        public Dictionary<Skills, byte> RaceSkills { get; set; } = new Dictionary<Skills, byte>();
    }
}
