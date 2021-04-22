using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App.Admin.Schedule.ScheduleAlgorithm
{
    class FteConstraint :IConstraintStrategy
    {
        private double quantifier;
       

        public FteConstraint(double quantifier)
        {
            this.quantifier = quantifier;            
        } 
        public bool CheckConstraint(Employee employee, DateTime dateTime)
        {            
            if (Math.Round(employee.WeeklyActualFTE(dateTime), 1) >= 1)
                return true;
            else
                return Math.Round(employee.WeeklyActualFTE(dateTime), 1) >= employee.FteContract * quantifier;           
        }
    }
}
