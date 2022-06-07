using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum SettlementSize 
{
    Village = 1,
    Town,
    City
} //limits the population size, defense, commerece, and organizations

enum Government 
{
    Autocracy = 1,
    Bureaucracy,
    Confederacy,
    Democracy,
    Feudalism,
    Gerontocracy,
    Hierarchym,
    Magocracy,
    Matriarchy,
    Militocracy,
    Monarchy,
    Oligarchy,
    Patriarchy,
    Meritocracy,
    Plutocracy,
    Republic,
    Satrapy,
    Kleptocracy,
    Theocracy
} 

namespace CampaignTrackerLibrary
{
    public class CSettlement
    {
        public string Atmosphere { get; set; } // randomly generated or chosen
        public string Size { get; set; } // randomly generated or chosen. Might limit number of other factors like number of factions in settlement
        public string Population { get; set; } //randomly generated or chosen within limit
        public string Government { get; set; } //randomly generated or chosen
        public List<Guid> Factions { get; set; } //randomly genrated based on previous factors or chosen

    }
}
