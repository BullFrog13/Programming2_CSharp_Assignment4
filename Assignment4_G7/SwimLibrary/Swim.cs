using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*
 * Class Swim holds the following information:
 * a. time of a swim
 * b. number of the heat
 * c. number of the lane
 */

namespace SwimLibrary
{
    public class Swim
    {
        private TimeSpan timeSwam;
        private int heat;
        private int lane;

        public TimeSpan TimeSwam
        {
            get
            {
                return timeSwam;
            }
            set
            {
                timeSwam = value;
            }
        }

        public int Heat
        {
            get
            {
                return heat;
            }
            set
            {
                heat = value;
            }
        }

        public int Lane
        {
            get
            {
                return lane;
            }
            set
            {
                lane = value;
            }
        }


        public Swim() { }


        public Swim(TimeSpan timeSwam, int heat, int lane)
        {
            TimeSwam = timeSwam;
            Heat = heat;
            Lane = lane;
        }


        public override string ToString()
        {
            String infoResult = "\t\t";
            if (Heat == 0 || Lane == 0)
            {
                infoResult += "Not seeded/no swim";
            }
            else
            {
                infoResult += "H" + Heat + "L" + Lane + " time: ";

                if (TimeSwam.Ticks == 0)
                {
                    infoResult += "no time";
                }
                else
                {
                    infoResult += TimeSwam.ToString(@"mm\:ss\.ff");
                }
            }

            return infoResult;
        }
    }
}