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
            Peugeot = 1,
            Citroen,
            Renault
        }
        #endregion

        

        #region Constructor
        public Car(int carYear, int carType, string licensePlate)
        {
            CarYear = carYear;
            CarType = (CarTypes)carType;
            LicensePlate = licensePlate;
        }
        #endregion


        #region Properties
        public int CarYear  { get; set; }
        public CarTypes CarType { get; set; }
        public string LicensePlate { get; set; }
        public static List<string> CarTypesString { get; set; } = new List<string>() { "Peugeot", "Citroen", "Renault" };
        #endregion


        #region Methods
        public double PriceModifier()
        {
            double modifier = 1.0;
            switch (CarType)
            {
                case CarTypes.Citroen:
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
