using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class DatatableDepartment
    {
        private int id;
        private string name;
        private double fte;
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double FTE
        {
            get { return this.fte; }
            set { this.fte = value; }
        }

        public DatatableDepartment(int id, string name, double fte)
        {
            this.id = id;
            this.name = name;
            this.fte = fte;
        }
    }
}
