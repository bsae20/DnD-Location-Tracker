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
    class CEnemyCharacter : CCharacter
    {
        public string Type { get; set; }
        public string Size { get; set; }
        public string AdditionalMovementMode { get; set; }
        public string ChallengeRating { get; set; }
        public sbyte ExperiencePoints { get; set; }
        public List<EnemyAction> Actions {get;set;} = new List<EnemyAction>();
    }
}
