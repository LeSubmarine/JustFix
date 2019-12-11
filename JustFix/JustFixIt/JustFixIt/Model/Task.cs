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
        public int Time { get; set; }

        public int Price { get; set; } 


        #endregion




    }
}