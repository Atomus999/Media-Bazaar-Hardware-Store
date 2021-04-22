using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace Hardware_App
{
    [Serializable]
    public class FileManagerEmployee
    {
        private string fileName = "../../" + $"({DateTime.Today.ToString("yyyy/M/d")})" + " Data.csv";
        public FileManagerEmployee()
        {

        }

        public void SaveEmployeeData(List<Employee> employees, List<EmployeeAbsence> employeeAbsences)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                sw.WriteLine("#ID , Name, Department, Assigned FTE, Number of shifts, Number of day off, Actual worked shifts");

                foreach (Employee emp in employees)
                {
                    int id = emp.Id;
                    string name = emp.FirstName + "" + emp.LastName;
                    string department = emp.Department;
                    double assignedFTE = emp.WeeklyActualFTE(DateTime.Now);
                    int numberOfShifts = emp.WeeklyNumberOfShift(DateTime.Now);
                    int numberOfDayOff = emp.WeeklyDayOff(DateTime.Now, employeeAbsences);
                    int actualWorkedShifts = numberOfShifts - numberOfDayOff;

                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", id, name, department, assignedFTE, numberOfShifts, numberOfDayOff, actualWorkedShifts);
                }
            }
            catch (IOException ex)
            { throw new InvalidOperationException("Error writing file"); }
            finally
            { if (sw != null) { sw.Close(); } }
        }
    }
}
