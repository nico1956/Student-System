using System;

namespace StudentSystem
{

    [Serializable]
    public class Assignments
    {
        private string assignName;
        private double points;
        private double maxPoints;

        //Assignment name Parameter
        public string AssignName
        {
            get
            {
                return assignName;
            }
            set
            {
                if (assignName != "")
                {
                    assignName = value;
                }
                else
                {
                    assignName = "Unknown";
                }
            }
        }

        //Points Parameter
        public double Points
        {
            get
            {
                return points;
            }
            set
            {
                if (points < 0)
                {
                    points = 0;
                }
                else if (points > 100)
                {
                    points = 100;
                }
                else
                {
                    points = value;
                }
            }
        }

        //Points possible Parameter
        public double MaxPoints
        {
            get
            {
                return maxPoints;
            }
            set
            {
                if (maxPoints < 0)
                {
                    maxPoints = 0;
                }
                else if (maxPoints > 100)
                {
                    maxPoints = 100;
                }
                else
                {
                    maxPoints = value;
                }
            }
        }

        //1st Overloaded Constructor
        public Assignments(string assignName, double points, double maxPoints)
        {
            AssignName = assignName;
            Points = points;
            MaxPoints = maxPoints;
        }
    }
}
