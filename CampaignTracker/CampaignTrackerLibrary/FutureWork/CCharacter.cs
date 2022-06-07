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
        public Dictionary<string, string> StatBlock { get; set; } = new Dictionary<string, string>();
        public string ArmorClass { get; set; }
    }
}
