using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFixIt.Model
{
    abstract class WorkTask
    {
        #region Constructor
        public WorkTask(Car car)
        {
            Car = car;
        }
        #endregion


        #region Properties
        public int Time { get; set; }
        public int Price { get; set; }
        public Car Car { get; set; }

        #endregion

        public int TimeIncrement15(int antalKvarter)
        {
            int totalTid = antalKvarter * 15;
            return totalTid;
        }
    }
}
