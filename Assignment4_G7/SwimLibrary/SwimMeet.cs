using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*
 * Class SwimMeet holds the following information:
 * a. name of the meet
 * b. start date of the meet
 * c. end date of the meet
 * d. number of lanes * 
 */

namespace SwimLibrary
{
    public class SwimMeet
    {
        List<Event> events = new List<Event>();

        private String name;
        private DateTime startDate;
        private DateTime endDate;
        private PoolType course;
        private readonly int noOfLanes = 8;

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
            }
        }

        public PoolType Course
        {
            get
            {
                return course;
            }
        }

        public int NoOfLanes
        {
            get
            {
                return noOfLanes;
            }
        }


        public SwimMeet() { }


        public SwimMeet(String name, DateTime startDate, DateTime endDate, PoolType course, int noOfLanes)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            this.course = course;
            this.noOfLanes = noOfLanes;
        }

        public override string ToString()
        {
            String infoResult = "Sweem meet name: " + Name + "\n";
            infoResult += "From-to: " + StartDate.Date.ToString("yyyy-MM-dd") + " to " + EndDate.Date.ToString("yyyy-MM-dd") + "\n";
            infoResult += "Pool type: " + Course.ToString() + "\n";
            infoResult += "No lanes: " + noOfLanes + "\n";
            infoResult += "Events: ";

            foreach (Event ev in events)
            {
                if (ev != null)
                {
                    infoResult += "\n\t" + ev.Distance + " " + ev.Stroke + "\n";
                    infoResult += ev.GetMembersInfo();
                }
            }
            return infoResult;
        }

        public void AddEvent(Event ev)
        {
            events.Add(ev);
            ev.SwimMeet = this;
        }


        public void Seed()
        {
            foreach (Event ev in events)
            {
                ev.Seed();
            }
        }
    }
}