using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class FteReal
    {
        private double actualFte = 0;

        public int EmpId { get; set; }
        public DateTime Date { get; set; }
        public double ActualFte { get { return actualFte; } set { actualFte = value; } }
        public FteReal(int empid,DateTime dateTime,double fte)
        {
            EmpId = empid;
            Date = dateTime;
            actualFte = fte;
        }
    }
}
