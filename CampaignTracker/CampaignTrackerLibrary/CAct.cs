using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignTrackerLibrary
{
    class CAct
    {
        public string ParentCampaign { get; set; } // the campaign this act belongs to
        public string ActGUID { get; set; } // uniqe identifier for Act
        public Dictionary<short, Guid> ChildrenEncounters { get; set; }  = new Dictionary<short, Guid>(); // encounters 1 level down
    }
}
