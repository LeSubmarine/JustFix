using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFixIt.Model
{
    class Car
    {
        #region Constant

        public enum CarTypes
        {
            Peugeot,
            Citroën,
            Renault
        }
        #endregion


        #region Constructor
        public Car(int carYear, CarTypes carType)
        {
            CarYear = carYear;
            CarType = carType;
        }
        #endregion


        #region Properties
        public int CarYear  { get; set; }
        public CarTypes CarType { get; set; }
        #endregion


        #region Methods
        public double PriceModifier()
        {
            double modifier = 1.0;
            switch (CarType)
            {
                case CarTypes.Citroën:
                    //modifier = modifier;
                    break;
                case CarTypes.Peugeot:
                    modifier = modifier + 0.3;
                    break;
                case CarTypes.Renault:
                    modifier = modifier - 0.3;
                    break;
                default:
                    //modifier = modifier;
                    break;
            }

            if (CarYear <= 2010)
            {
                modifier = modifier + 0.1;
            }
            return modifier;
        } 
        #endregion
    }
}
