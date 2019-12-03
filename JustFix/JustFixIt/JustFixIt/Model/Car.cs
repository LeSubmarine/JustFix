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

        public enum Conditions
        {
            Good,
            Bad,
            Deece
        }
        #endregion


        #region Constructor
        public Car(int age, CarTypes carType, Conditions condition)
        {
            Age = age;
            CarType = carType;
            Condition = condition;
        }
        #endregion


        #region Properties
        public int Age { get; set; }
        public CarTypes CarType { get; set; }
        public Conditions Condition { get; set; }
        #endregion


        #region Methods
        public double TimeModifier()
        {
            return 1.0;
        }
        public double PriceModifier()
        {
            double modifier = 1.0;
            switch (CarType)
            {
                case CarTypes.Citroën:
                    //modifier = modifier;
                    break;
                case CarTypes.Peugeot:
                    modifier = modifier * 1.3;
                    break;
                case CarTypes.Renault:
                    modifier = modifier * 0.7;
                    break;
                default:
                    //modifier = modifier;
                    break;
            }
            switch (Condition)
            {
                case Conditions.Deece:
                    //modifier = modifier;
                    break;
                case Conditions.Bad:
                    modifier = modifier * 1.3;
                    break;
                case Conditions.Good:
                    modifier = modifier * 0.7;
                    break;
                default:
                    //modifier = modifier;
                    break;
            }
            return modifier;
        } 
        #endregion
    }
}
