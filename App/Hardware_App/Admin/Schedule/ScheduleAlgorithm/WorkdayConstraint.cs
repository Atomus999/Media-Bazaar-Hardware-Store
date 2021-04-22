using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App.Admin.Schedule.ScheduleAlgorithm
{
    class WorkdayConstraint : IConstraintStrategy
    {
        private bool respectWorkday;

        public WorkdayConstraint(bool respectWorkday)
        {
            this.respectWorkday = respectWorkday;
        }

        public bool CheckConstraint(Employee employee, DateTime dateTime)
        {
            if (respectWorkday)
                return !EmployeeManager.GetInstance().checkWorkDay(dateTime, employee);
            else
                return false;
        }

    }
}
