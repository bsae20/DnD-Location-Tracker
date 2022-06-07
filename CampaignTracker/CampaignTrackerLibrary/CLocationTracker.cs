using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignTrackerLibrary
{
    class CLocationTracker
    {
        public Guid TrackerGUID { get; set; }
        public Dictionary<Guid, bool> ShowLocation { get; set; } = new Dictionary<Guid, bool>(); //LocationGUID, true/false to show on display

    }
}
