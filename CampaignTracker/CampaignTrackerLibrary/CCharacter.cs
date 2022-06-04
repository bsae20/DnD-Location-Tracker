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
    public class CCharacter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Race { get; set; }
        public byte SubRace { get; set; }
        public string Alignment { get; set; }
        public string ArmorClass { get; set; }
        public byte HitPoints { get; set; }
        public sbyte Speed { get; set; }
        public byte[] BaseStatBlock { get; set; } // str, dex, con, int, wis, cha
        public byte[] BaseSavingThrows { get; set; } // str, dex, con, int, wis, cha
        public sbyte[] StatBlockModifiers { get; set; }
        public List<Skills> NonZeroSkills { get; set; } = new List<Skills>();

        public CCharacter(string FirstName, string LastName, 
            byte Race, byte SubRace, 
            string Alignment, byte HitPoints)
        {

        }

    }
}
