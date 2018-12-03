using System;
using System.Collections.Generic;

/*
 * Class swimmer is a Registrant who have additional class members:
 * a. list of the best times for each event and course
 * b. coach that is being coached by
 */

namespace SwimLibrary
{
    public class Swimmer : Registrant
    {
        Coach coach;

        Dictionary<(PoolType, EventDistance, Stroke), TimeSpan> bestTimes =
            new Dictionary<(PoolType, EventDistance, Stroke), TimeSpan>();

        public Coach Coach
        {
            get
            {
                return coach;
            }
            set
            {
                if (value.Club == null)
                {
                    throw new Exception("Coach is not assigned to the club");
                }

                if (value.Club == this.Club)
                {
                    if (coach != null && coach != value)
                    {
                        coach.RemoveFosterling(this);
                    }

                    if (coach != value)
                    {
                        coach = value;
                        coach.AddSwimmer(this);
                    }
                }
                else
                { 
                    throw new Exception("Coach and swimmer are not in the same club");
                }
            }
        }

        public Swimmer(String name, DateTime dateOfBirth, Address address, uint phoneNumber) : base(name, dateOfBirth, address, phoneNumber) { }

        public Swimmer() : base()
        {
        }

        public Swimmer(string[] fields) : base(fields)
        {

        }

        public TimeSpan GetBestTime(PoolType course, Stroke stroke, EventDistance distance)
        {
            //GetBestTime behaviour is not defined for not previously added PoolType course, EventDistance and Stroke in the Assignment description.
            //There are two options: a) throw exception b) return 'zero' TimeSpan.
            //I implement zero 'logic' here
            if (bestTimes.ContainsKey((course, distance, stroke)))
            {
                return bestTimes[(course, distance, stroke)];
            }
            else
            {
                return new TimeSpan();
            }
        }

        public void AddAsBestTime(PoolType course, EventDistance distance, Stroke stroke, TimeSpan time)
        {

            if (!bestTimes.ContainsKey((course, distance, stroke)) || bestTimes[(course, distance, stroke)] >= time)
            {
                bestTimes[(course, distance, stroke)] = time;
            }
        }


        public override string ToString()
        {
            String infoResult = base.ToString();

            String strCoachInfo = "not assigned";
            if (coach!= null)
            {
                strCoachInfo = coach.Name;
            }

            infoResult += "\nCoach: " + strCoachInfo;

            return infoResult;
        }
    }
}