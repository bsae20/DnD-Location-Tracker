using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Classes 
{
    Barbarian = 1,
    Bard,
    Cleric,
    Druid,
    Fighter,
    Monk,
    Paladin,
    Ranger,
    Rogue,
    Sorcerer,
    Warlock,
    Wizard
}

enum Armors
{
    Light = 1,
    Medium,
    Heavy,
    Shield,
    All
}

enum Weapons 
{
    SimpleMelee = 1,
    SimpleRanged,
    MartialMelee,
    MartialRanged,
    All
}

namespace CampaignTrackerLibrary
{
    class CClass
    {
        public string ClassName { get; set; }
        public string HitDieForClass { get; set; } //default barbarian -> d12, etc.
        public string PrimaryAbility { get; set; } //defualt barbarian -> STR, etc.
        public string SavingThrowProficiencies { get; set; } //defualt barbarian -> STR & CON, etc.
        public string ArmorProficiencies { get; set; } //default barbarian -> Light & Medium
        public string WeaponProficiencies { get; set; } // default barbarian -> Simple & Martial
    }
}
