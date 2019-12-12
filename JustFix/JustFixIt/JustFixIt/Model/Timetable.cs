using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFixIt.Model
{
    class Timetable
    {
        #region Instance field

        private int _startTime = 60 * 8;
        private int _endTime = 60 * 16;

        #endregion


        #region Constructor
        public Timetable()
        {

        }
        #endregion


        #region Properties
        public string UserId { get; set; }
        public List<WorkTask> TaskList { get; set; }
        #endregion


        #region Methods

        public bool TimeAvailable(int startOrderTime, int endOrderTime)
        {
            return false;
        }
        #endregion
    }
}
