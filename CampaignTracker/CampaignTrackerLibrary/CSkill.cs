using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Skills
{
    Athletics,
    Dexterity,
    Acrobatics,
    SleightOfHand,
    Stealth,
    Intelligence,
    Arcana,
    History,
    Investigation,
    Nature,
    Religion,
    Wisdom,
    AnimalHandling,
    Insight,
    Medicine,
    Perception,
    Survival,
    Charisma,
    Deception,
    Intimidation,
    Performance,
    Persuasion
}
namespace CampaignTrackerLibrary
{
    class CSkill
    {
        public string SkillName { get; set; }
        public byte Modifier { get; set; }


    }
}
