using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class EmployeeManager
    {
        private List<Employee> allEmployees;
        private List<Spouse> spouses;
        private List<RFIDcontrol> rFIDcontrols;
        private List<EmployeeAbsence> employeeAbsences;

        private static EmployeeManager instance;
        public static EmployeeManager GetInstance()
        {
            if (instance == null)
                instance = new EmployeeManager();
            return instance;
        }

        public DatabaseHelperEmployee dataHelperEmployee { get; set; } = new DatabaseHelperEmployee();
        public DatabaseHelperSpouse dataHelperSpouse { get; set; } = new DatabaseHelperSpouse();

        public FileManagerEmployee fileManagerEmployee { get; set; } = new FileManagerEmployee();
        public EmployeeManager employeeManager { get; set; }
        public EmployeeManager()
        {
            allEmployees = new List<Employee>();
            spouses = new List<Spouse>();
            rFIDcontrols = new List<RFIDcontrol>();
            employeeAbsences = new List<EmployeeAbsence>();
        }

        public bool checkWorkDay(DateTime date, Employee employee)
        {
            bool ok = true;
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    if (!employee.ScheduleDays.Sunday)
                    {
                        ok = false;
                    }
                    break;
                case DayOfWeek.Monday:
                    if (!employee.ScheduleDays.Monday)
                    {
                        ok = false;
                    }
                    break;
                case DayOfWeek.Tuesday:
                    if (!employee.ScheduleDays.Tuesday)
                    {
                        ok = false;
                    }
                    break;
                case DayOfWeek.Wednesday:
                    if (!employee.ScheduleDays.Wednesday)
                    {
                        ok = false;
                    }
                    break;
                case DayOfWeek.Thursday:
                    if (!employee.ScheduleDays.Thursday)
                    {
                        ok = false;
                    }
                    break;
                case DayOfWeek.Friday:
                    if (!employee.ScheduleDays.Friday)
                    {
                        ok = false;
                    }
                    break;
                case DayOfWeek.Saturday:
                    if (!employee.ScheduleDays.Saturday)
                    {
                        ok = false;
                    }
                    break;
                default:
                    break;
            }
            return ok;
        }
        public void loadAbsences()
        {
            employeeAbsences.Clear();
            employeeAbsences= dataHelperEmployee.loadAbsences(allEmployees);
        }
        public List<Spouse> GetSpouses()
        {
            return this.spouses;
        }
        public void loadSpouses()
        {
            spouses = dataHelperSpouse.LoadSpouses();
        }
        public void loadWorkingDays()
        {
            dataHelperEmployee.loadWorkingDays(allEmployees);
        }
        public void loadFtes()
        {
            dataHelperEmployee.loadFtes(allEmployees);
        }
        public void loadMinsLate()
        {
            dataHelperEmployee.loadMinsLate(allEmployees);
        }

        public void loadSchedules()
        {
            DeleteAllDayplans();
            dataHelperEmployee.loadSchedules(allEmployees);
        }
        public void loadEmployees()
        {
            DeleteAllEmployees();
            allEmployees = dataHelperEmployee.loadEmployees(this.spouses);
        }
        public List<Employee> GetEmployees()
        {
            return allEmployees;
        }

        public Employee GetEmployeeByRFID(RFIDcontrol RFID)
        {
            Employee emp = null;
            foreach (Employee employee in this.allEmployees)
            {
                if(employee.Rfid == RFID)
                {
                    emp = employee;
                }
            }

            return emp;
        }
        public void AddEmployee(Employee employee)
        {
            allEmployees.Add(employee);
            dataHelperEmployee.addEmployee(employee);
            
        }
        public void DeleteAllEmployees()
        {
            allEmployees.Clear();
        }
        public void DeleteAllDayplans()
        {
            foreach (Employee employee in allEmployees)
            {
                employee.deteleDayPlans();
            }
        }

        public void AddRFID(RFIDcontrol rfid)
        {
             this.rFIDcontrols.Add(rfid);        
        }

        public RFIDcontrol GetRFIDcontrolBySerial(string serial)
        {
            RFIDcontrol rfid = null;
            foreach (RFIDcontrol rFIDcontrol in this.rFIDcontrols)
            {
                if(rFIDcontrol.SerialNumber == serial)
                {
                    rfid = rFIDcontrol;
                }
            }
            return rfid;
        }

        public List<RFIDcontrol> GetRFIDcontrols()
        {
            return this.rFIDcontrols;
        }

        public List<Employee> GetEmployeesByDepartment(string dep)
        {
            List<Employee> resultList = new List<Employee>();
            foreach (Employee employee in allEmployees)
            {
                if (employee.Department == dep)
                {
                    resultList.Add(employee);
                }
            }
            return resultList;
        }

        public List<DatatableEmployee> GetEmployeesDatatable()
        {
            List<DatatableEmployee> EmployeeDatatable = new List<DatatableEmployee>();

            foreach (Employee employee in this.allEmployees)
            {
                DatatableEmployee employeeForDataGridView = new DatatableEmployee(employee.Id, employee.FirstName, employee.LastName, employee.Department, employee.Address, employee.IsActive, employee.FteContract, employee.Rfid);
                EmployeeDatatable.Add(employeeForDataGridView);
            }

            return EmployeeDatatable;
        }

        public List<DatatableEmployee> GetEmployeesDatatableByID(int id)
        {
            List<DatatableEmployee> EmployeeDatatable = new List<DatatableEmployee>();

            foreach (Employee employee in this.allEmployees)
            {
                if(employee.Id == id)
                {
                    DatatableEmployee employeeForDataGridView = new DatatableEmployee(employee.Id, employee.FirstName, employee.LastName, employee.Department, employee.Address, employee.IsActive, employee.FteContract, employee.Rfid);
                    EmployeeDatatable.Add(employeeForDataGridView);
                }
            }
            return EmployeeDatatable;
        }

        public List<DatatableEmployee> GetEmployeesDatatableByName(string name)
        {
            List<DatatableEmployee> EmployeeDatatable = new List<DatatableEmployee>();

            foreach (Employee employee in this.allEmployees)
            {
                if (employee.FirstName.ToLower() == name || employee.LastName.ToLower() == name)
                {
                    DatatableEmployee employeeForDataGridView = new DatatableEmployee(employee.Id, employee.FirstName, employee.LastName, employee.Department, employee.Address, employee.IsActive, employee.FteContract, employee.Rfid);
                    EmployeeDatatable.Add(employeeForDataGridView);
                }
            }
            return EmployeeDatatable;
        }

        public void UpdateEmployeeAbsence(EmployeeAbsence absence)
        {
            dataHelperEmployee.updateAbsences(absence);
        }

        public List<EmployeeAbsence> GetEmployeeAbsences()
        {
            return employeeAbsences;
        }

        public EmployeeAbsence returnEmployeeAbsenceById(int id)
        {
            foreach (EmployeeAbsence abs in employeeAbsences)
            {
                if (abs.Id == id)
                {
                    return abs;
                }
            }
            return null;
        }
    }
}
