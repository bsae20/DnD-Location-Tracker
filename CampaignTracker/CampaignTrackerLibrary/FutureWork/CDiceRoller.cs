using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignTrackerLibrary
{
    public class CDiceRoller
    {
        /// <summary>
        /// Dice Sides , Number of that dice to roll
        /// </summary>
        public Dictionary<byte, byte> DiceToRoll { get; set; } = new Dictionary<byte, byte>(); //dice sides, number of that dice being rolled

    }
}
