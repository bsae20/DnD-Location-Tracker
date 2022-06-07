using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Skills
{
    Athletics,
    Acrobatics,
    SleightOfHand,
    Stealth,
    Arcana,
    History,
    Investigation,
    Nature,
    Religion,
    AnimalHandling,
    Insight,
    Medicine,
    Perception,
    Survival,
    Deception,
    Intimidation,
    Performance,
    Persuasion
}
namespace CampaignTrackerLibrary
{
    public class CSkill
    {
        public string SkillName { get; set; }
        public byte Modifier { get; set; }


    }
}
