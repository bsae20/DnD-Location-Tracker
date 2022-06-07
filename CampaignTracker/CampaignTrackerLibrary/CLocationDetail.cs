using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignTrackerLibrary
{
    class CLocationDetail
    {
        public Guid LocationGUID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Guid> CharactersOnLocation { get; set; } // CharacterGUID
    }
}
