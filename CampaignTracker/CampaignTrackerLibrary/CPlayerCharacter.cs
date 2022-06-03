using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum CharacterRaces
{
    Dwarf,
    Elf,
    Halfling,
    Human,
    Dragonborn,
    Gnome,
    HalfElf,
    HalfOrc,
    Tiefling
}
namespace CampaignTrackerLibrary
{
    class CPlayerCharacter : CCharacter
    {
        public string CharacterClass { get; set; }
        public string Level { get; set; }
    }
}
