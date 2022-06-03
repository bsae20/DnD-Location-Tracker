using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignTrackerLibrary
{
    public class CParty
    {
        public List<Character> PartyMembers { get; set; } = new List<Character>();
        public string PartyName { get; set; }
    }
}
