using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFixIt.Model.TaskTypes
{
    class RemoveTiresTask : WorkTask
    {
        public RemoveTiresTask(Car car) : base(car)
        {
            Price = Convert.ToInt32(0 * Car.PriceModifier());
            Time = Convert.ToInt32(0 * Car.TimeModifier());
        }
    }
}
