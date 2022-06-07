using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum MonsterType
{
    Aberrations,
    Beasts,
    Celestials,
    Constructs,
    Dragons,
    Elementals,
    Fey,
    Fiends,
    Giants,
    Humanoids,
    Monstrosities,
    Oozes,
    Plants,
    Undead
}

enum AdditionalMonsterMovementModes
{
    Burrow,
    Climb,
    Fly,
    Swim
}

namespace CampaignTrackerLibrary
{
    public class CEnemyCharacter : CCharacter
    {
        public string NumberOfTheseEnemies { get; set; }
    }
}
