using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App.Admin.Schedule.ScheduleAlgorithm
{
    public interface IConstraintStrategy
    {
        bool CheckConstraint(Employee employee, DateTime dateTime);
       
    }
}
