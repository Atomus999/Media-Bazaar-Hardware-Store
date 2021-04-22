using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class DayPlan
    {
        DateTime date;
        int empID;
        int morning;
        int afternoon;
        int evening;
        int minsLate;

        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int Morning
        {
            get { return morning; }
            set { morning = value; }
        }
        public int Afternoon
        {
            get { return afternoon; }
            set { afternoon = value; }
        }
        public int Evening
        {
            get { return evening; }
            set { evening = value; }
        }
        public int MinsLate
        {
            get { return this.minsLate; }
            set { this.minsLate = value; }
        }
        public DayPlan(DateTime date, int empid, int morning,int afternoon,int evening)
        {
            this.date = date;
            this.empID = empid;
            this.morning = morning;
            this.afternoon = afternoon;
            this.evening = evening;
        }

        public int GetMonth()
        {
            int month = this.date.Month;
            return month;
        }
    }
}
