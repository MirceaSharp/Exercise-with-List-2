using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_with_List_2
{
    class StudentResult
    {
        private string _name;
        private double _points;

        public StudentResult(string name, double points)
        {
            this.Name = name;
            this.Points = points;

        }

        public StudentResult()
        {
            this.Name = "";
            this.Points = 0;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
        public double Points
        {
            get { return _points; }
            set { _points = value; }

        }

        public string Result
        {
            get
            {
                if (Points < 50)
                {
                    return "NIET GESLAAGD";

                }
                else
                {
                    return "GESLAAGD";
                }
            }
        }

        public override string ToString()
        {
            return Name + "  " + Points.ToString("0.00") + "   " + Result;
        }
    }
}
