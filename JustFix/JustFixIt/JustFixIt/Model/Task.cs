using System.Diagnostics;

namespace JustFixIt.Model
{
    abstract class Task
    {
        #region Constants
        public enum TaskTypes
        {
            ChangeTires,
            ChangeBrakes,
            Suspension,
            ExhaustSystem,
            OilLubricationSystem,
            StarterSystem,
            Engine,
            Electronics,
            Gearbox
        }
        #endregion

        #region Properties
        public int TimeChunk30Min { get; set; }

        public int Price { get; set; }

        public TaskTypes TaskType { get; set; }
        #endregion

        public int TimeAndPrice()
        {
            switch (TaskType)
            {
                case: TaskTypes.ChangeTires;
                    TimeChunk30Min = 1;
                    Price = 4500;
                case: TaskTypes.ChangeBrakes;
                    TimeChunk30Min = 2;
                    Price = 2500;
                case: TaskTypes.Suspension;
                    TimeChunk30Min = 2;
                    Price = 1500;
                case: TaskTypes.ExhaustSystem;
                    TimeChunk30Min = 4;
                    Price = 3000;
                case: TaskTypes.OilLubricationSystem;
                    TimeChunk30Min = 2;
                    Price = 1250;
                case: TaskTypes.StarterSystem;
                    TimeChunk30Min = 3;
                    Price = 1750;
                case: TaskTypes.Engine;
                    TimeChunk30Min = 8;
                    Price = 10000;
                case: TaskTypes.Electronics;
                    TimeChunk30Min = 2;
                    Price = 750;
                case: TaskTypes.Gearbox;
                    TimeChunk30Min = 4;
                    Price = 3500;
                default:
                    TimeChunk30Min = 0;
                    Price = 0;
                    break;
            }
        }
        



    }
}