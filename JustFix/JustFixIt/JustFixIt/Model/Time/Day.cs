using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFixIt.Model
{
    class Day
    {
        #region Constants

        public enum Weekdays
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }
        #endregion


        #region Constructor
        public Day(int weekday)
        {
            Weekday = (Weekdays)weekday;
            TimeAvailable = true;
            Tasks = new List<List<WorkTask>>();
        }
        #endregion


        #region Properties

        public Weekdays Weekday { get; set; }
        public List<List<WorkTask>> Tasks { get; set; }
        public bool TimeAvailable { get; set; }
        #endregion


        #region Methods
        public void AddTask(List<WorkTask> task)
        {
            if (TimeAvailable)
            {

                Tasks.Add(task);

            }
            if (Tasks.Count >= 4)
            {
                TimeAvailable = false;
            }
        }

        public void RemoveTask(int index)
        {
            Tasks.RemoveAt(index);
            if (Tasks.Count < 4)
            {
                TimeAvailable = true;
            }
        }

        public string DayToString()
        {
            string returnString = "";
            switch (Weekday)
            {
                case Weekdays.Monday:
                    returnString = "Monday\n";
                    break;
                case Weekdays.Tuesday:
                    return "Tuesday";
                case Weekdays.Wednesday:
                    return "Wednesday";
                case Weekdays.Thursday:
                    return "Thursday";
                case Weekdays.Friday:
                    return "Friday";
                default:
                    return "que";
                    
            }
            returnString += TimeAvailable ? "Available" : "Not Available";
            return returnString;
        }
        #endregion
    }
}
