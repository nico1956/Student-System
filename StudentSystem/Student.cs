using System;
using System.Collections.Generic;

namespace StudentSystem
{

    [Serializable]
    public class Student : Object, IComparable
    {
        //Properties
        private int id;
        private string name;

        //Id Parameter
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (id >= 0)
                {
                    id = value;
                }
                else
                {
                    id = 12345;
                }
            }
        }

        //Name Parameter
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != "")
                {
                    name = value;
                }
                else
                {
                    name = "Unknown";
                }
            }
        }

        public List<Assignments> AssignmentsList { get; set; }

        //1st Overloaded constructor
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //2nd Overloaded Constructor
        public Student(int id, string name, List<Assignments> a)
        {
            Id = id;
            Name = name;
            AssignmentsList = a;
        }

        //3rd Overloaded constructor
        public Student(int id) : this(id, "Joe Average")
        {
            Id = id;
        }

        //4th Overloaded constructor
        public Student(string name) : this(99999, name)
        {
            Name = name;
        }

        //IComparable to sort students by ID number
        int IComparable.CompareTo(object s)
        {
            int returnVal;

            Student temp = (Student)s;
            if (this.Id > temp.Id)
                returnVal = 1;
            else
               if (this.Id < temp.Id)
                returnVal = -1;
            else
                returnVal = 0;

            return returnVal;
        }

        //ToString override
        public override string ToString()
        {
            return String.Format("{0,-8}{1,-15}", Id.ToString("00000"), Name);
        }
    }
}