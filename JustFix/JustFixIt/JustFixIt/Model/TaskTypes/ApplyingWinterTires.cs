using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFixIt.Model.TaskTypes
{
    class ApplyingWinterTires : WorkTask
    {
        public ApplyingWinterTires(Car car) : base(car)
        {
            Price = Convert.ToInt32(0 * Car.PriceModifier());
            Time = TimeIncrement15(1);
        }
    }
}
