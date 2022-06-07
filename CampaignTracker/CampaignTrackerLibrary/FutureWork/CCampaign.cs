using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignTrackerLibrary
{
    class CCampaign
    {
        public string CampaignGUID { get; set; }
        public Dictionary<short, Guid> ChildrenActs { get; set; } = new Dictionary<short, Guid>();
    }
}
