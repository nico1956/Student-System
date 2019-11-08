using System;

namespace StudentSystem
{

    [Serializable]
    class DormStudent : Student, IComparable
    {
        private string dorm;
        private string mealplan;

        //Dorm Parameter
        public string Dorm
        {
            get
            {
                return dorm;
            }
            set
            {
                if (dorm != "")
                {
                    dorm = value;
                }
                else
                {
                    dorm = "Unknown";
                }
            }
        }

        //MealPlan Parameter
        public string MealPlan
        {
            get
            {
                return mealplan;
            }
            set
            {
                if (mealplan != "")
                {
                    mealplan = value;
                }
                else
                {
                    mealplan = "Unknown";
                }
            }
        }

        //1st Overloaded Constructor
        public DormStudent(int id, string name, string dorm, string mealplan) : base(id, name)
        {
            Id = id;
            Name = name;
            Dorm = dorm;
            MealPlan = mealplan;
        }

        //ToString Override
        public override string ToString()
        {
            return String.Format("{0,-8}{1,-30}", Id.ToString("00000"), Name) + String.Format("{0,-15}{1,-15}", Dorm, MealPlan);
        }
    }
}