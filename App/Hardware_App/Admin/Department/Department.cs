using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class Department
    {
        private int id;
        public ShiftPerDept ShiftPerDept { get; set; } = new ShiftPerDept();

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name { get; set; }
        public double FTE { get; set; }

        public bool ShowFTE { get; set; }

        public Department(string name)
        {
            Name = name;
            ShowFTE = false;
            FTE = 0;
        }

        public Department(string name, double fte)
        {
            Name = name;
            FTE = fte;
            ShowFTE = false;
        }

        public Department(int id, string name, double fte)
        {
            this.id = id;
            Name = name;
            FTE = fte;
            ShowFTE = false;
        }
        public double calculateWeeklyFte(DateTime dateCalendar, List<Employee> employees)
        {
            double countFte = 0;
            foreach (Employee employee in employees)
            {
                if (employee.Department == this.Name)
                {
                    foreach (FteReal fte in employee.ActualFtes)
                    {
                        //replace datetime now with selected calendar date
                        if (DatesAreInTheSameWeek(dateCalendar, fte.Date))
                            countFte += fte.ActualFte;
                    }
                }
            }
            return countFte;

        }
        public bool DatesAreInTheSameWeek(DateTime date1, DateTime date2)
        {
            var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
            var d1 = date1.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date1));
            var d2 = date2.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date2));

            return d1 == d2;
        }

        public int trackEmployees(List<Employee> employees)
        {
            int numberOfEmployees = 0;
            foreach (Employee emp in employees)
            {
                if (emp.Department == this.Name)
                {
                    numberOfEmployees++;
                }
            }
            return numberOfEmployees;
        }

        public override string ToString()
        {
            if (ShowFTE)
                return Name + "- " + FTE + "FTE required";
            else return Name;
        }
    }
}
