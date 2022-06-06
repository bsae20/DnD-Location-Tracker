using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum CharacterRaces
{
    Dwarf = 1,
    Elf,
    Halfling,
    Human,
    Dragonborn,
    Gnome,
    HalfElf,
    HalfOrc,
    Tiefling
}

enum CharacterSubRaces
{
    HillDwarf = 1,
    MountainDwarf,
    HighElf,
    WoodElf,
    DarkElf,
    LightFoot,
    Stout,
    VariantHuman,
    BlackDragon,
    BlueDragon,
    BrassDragon,
    BronzeDragon,
    CopperDragon,
    GoldDragon,
    GreenDragon,
    RedDragon,
    SilverDragon,
    WhiteDragon,
    ForestGnome,
    RockGnome
}

namespace CampaignTrackerLibrary
{
    public class CPlayerCharacter : CCharacter
    {
        public string Level { get; set; }
        public string Race { get; set; }
        public string SubRace { get; set; }
        public string Class { get; set; }
    }
}
