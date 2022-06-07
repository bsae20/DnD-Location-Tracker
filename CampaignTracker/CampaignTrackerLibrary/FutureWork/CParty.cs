using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignTrackerLibrary
{
    public class CParty
    {
        public string PartyName { get; set; }
        public Dictionary<Guid, string> PartyMembers { get; set; } = new Dictionary<Guid, string>();
        public Dictionary<Guid, string> PartyMemberCurrentHitPoints { get; set; } = new Dictionary<Guid, string>();
    }
}
