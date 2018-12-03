using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*
 * Class Event keeps information about the registrants who swim that event 
 */

namespace SwimLibrary
{
    public class Event
    {
        Dictionary<uint, Registrant> members = new Dictionary<uint, Registrant>();
        Dictionary<uint, Swim> membersSwims = new Dictionary<uint, Swim>();

        private EventDistance distance;
        private Stroke stroke;
        private SwimMeet swimMeet;

        public EventDistance Distance
        {
            get
            {
                return distance;
            }

            set
            {
                distance = value;
            }
        }

        public Stroke Stroke
        {
            get
            {
                return stroke;
            }
            set
            {
                stroke = value;
            }
        }

        public SwimMeet SwimMeet
        {
            set
            {
                swimMeet = value;
            }
        }


        public Event() { } 


        public Event(EventDistance distance, Stroke stroke)
        {
            Distance = distance;
            Stroke = stroke;
        }

        public override string ToString()
        {
            String infoResult = "Distance: " + (int)Distance + "\n";
            infoResult += "Stroke: " + Stroke.ToString() + "\n";

            return infoResult;
        }


        public String GetMembersInfo()
        {
            String infoResult = "\tSwimmers: \n";
            foreach (Registrant swimmer in members.Values)
            {
                infoResult += "\t" + swimmer.Name;
                if (membersSwims.ContainsKey(swimmer.RegistrationNumber))
                {
                    infoResult += membersSwims[swimmer.RegistrationNumber].ToString();
                }
                else
                {
                    infoResult += "\n\t\tNot seeded/no swim";
                }
                infoResult += "\n";
            }

            return infoResult;
        }


        public Registrant AddSwimmer(Registrant swimmer)
        {
            if (members.ContainsKey(swimmer.RegistrationNumber))
            {
                throw new Exception($"Swimmer {swimmer.Name}, {swimmer.RegistrationNumber} is already entered");
            }
            members.Add(swimmer.RegistrationNumber, swimmer);
            return swimmer;
        }


        public void Seed()
        {
            int i = 0;
            foreach (Registrant swimmer in members.Values)
            {
                membersSwims.Add(swimmer.RegistrationNumber, new Swim());
                membersSwims[swimmer.RegistrationNumber].Heat = i / swimMeet.NoOfLanes + 1;
                membersSwims[swimmer.RegistrationNumber].Lane = i % swimMeet.NoOfLanes + 1;
                ++i;
            }
        }


        private void EnterSwimerTimeByTimeSpan(Registrant swimmer, TimeSpan time)
        {
            if (members.ContainsKey(swimmer.RegistrationNumber))
            {
                Swimmer aSwimmer = (Swimmer)swimmer;
                aSwimmer.AddAsBestTime(swimMeet.Course, distance, stroke, time);
                membersSwims[swimmer.RegistrationNumber].TimeSwam = time;
            }
            else
            {
                throw new Exception("Swimmer has not entered event");
            }
        }


        public void EnterSwimmersTime(Registrant swimmer, String strTime)
        {
            String[] partsOfTime = strTime.Split(new char[] { ':', '.' });
            int minutes;
            int seconds;
            float partsOfSec;
            int ms;
            if (int.TryParse(partsOfTime[0], out minutes) && int.TryParse(partsOfTime[1], out seconds) && float.TryParse("0." + partsOfTime[2], out partsOfSec))
            {
                ms = (int)Math.Round(1000 * partsOfSec);
                TimeSpan ts = new TimeSpan(0, 0, minutes, seconds, ms);

                EnterSwimerTimeByTimeSpan(swimmer, ts);
            }
            else
            {
                throw new ArgumentException("Swim time incorrect format");
            }
        }
    }
}