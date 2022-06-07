using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignTrackerLibrary
{
    class CEncounter
    {
        public string ParentAct { get; set; }
        public Guid EncounterGUID { get; set; }
        public string EncounterType { get; set; }
        public string ParentEncounter { get; set; }
    }
}
