using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFixIt.Model
{
    class Week
    {
        private static Week _weekTable;

        #region Constructor
        public Week()
        {
            Days = new List<Day>();
            for (int i = 0; i < 5; i++)
            {
                Days.Add(new Day(i + 1));
            }
        }
        #endregion


        #region Properties
        public List<Day> Days { get; set; }

        public static Week WeekTable
        {
            get
            {
                if (WeekTable == null)
                {
                    WeekTable = new Week();
                }
                return _weekTable;
            }
            set
            {
                _weekTable = value;
            }
        }

        #endregion
    }
}
