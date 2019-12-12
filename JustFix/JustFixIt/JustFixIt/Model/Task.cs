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



        public void TimeAndPrice()
        {
            switch (TaskType)
            {
                case TaskTypes.ChangeTires:
                    TimeChunk30Min = 1;
                    Price = 4500;
                    break;
                case TaskTypes.ChangeBrakes:
                    TimeChunk30Min = 2;
                    Price = 2500;
                    break;
                case TaskTypes.Suspension:
                    TimeChunk30Min = 2;
                    Price = 1500;
                    break;
                case TaskTypes.ExhaustSystem:
                    TimeChunk30Min = 4;
                    Price = 3000;
                    break;
                case TaskTypes.OilLubricationSystem:
                    TimeChunk30Min = 2;
                    Price = 1250;
                    break;
                case TaskTypes.StarterSystem:
                    TimeChunk30Min = 3;
                    Price = 1750;
                    break;
                case TaskTypes.Engine:
                    TimeChunk30Min = 8;
                    Price = 10000;
                    break;
                case TaskTypes.Electronics:
                    TimeChunk30Min = 2;
                    Price = 750;
                    break;
                case TaskTypes.Gearbox:
                    TimeChunk30Min = 4;
                    Price = 3500;
                    break;
                default:
                    TimeChunk30Min = 0;
                    Price = 0;
                    break;
            }
        }
        



    }
}