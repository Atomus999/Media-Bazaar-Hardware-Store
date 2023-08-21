using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App.Admin.Schedule.ScheduleAlgorithm
{
    public class BaseScheduling
    {

        List<IConstraintStrategy> allConstraints = new List<IConstraintStrategy>() { new FteConstraint(5), new WorkdayConstraint(true) };
        private EmployeeManager employeeManager = EmployeeManager.GetInstance();
        private DepartmentManager departmentManager = DepartmentManager.GetInstance();

        public BaseScheduling(List<IConstraintStrategy> fteStrategy)
        {
            this.allConstraints = fteStrategy;
        }
        public BaseScheduling() { }

        private int ChooseShift(int j, Department department)
        {
            int lowest = -1;
            int fillShiftMorning = department.ShiftPerDept.FilledEmployees.AllDays[j].Morning;
            int fillShiftAfternoon = department.ShiftPerDept.FilledEmployees.AllDays[j].Afternoon;
            int fillShiftEvening = department.ShiftPerDept.FilledEmployees.AllDays[j].Evening;

            int reqShiftMorning = department.ShiftPerDept.RequiredEmployees.AllDays[j].Morning;
            int reqShiftAfternoon = department.ShiftPerDept.RequiredEmployees.AllDays[j].Afternoon;
            int reqShiftEvening = department.ShiftPerDept.RequiredEmployees.AllDays[j].Evening;


            if (fillShiftMorning < reqShiftMorning)
                lowest = 0;
            else if (fillShiftAfternoon < reqShiftAfternoon)
                lowest = 1;
            else if (fillShiftEvening < reqShiftEvening)
                lowest = 2;

            return lowest;
        }

        public void AssignEmployees()
        {
            int numberOfDaysToAutoSchedule = 21;


            int count = GetCountIndexBasedOnDay(DateTime.Now);
            for (int i = count; i < numberOfDaysToAutoSchedule + count; i++)
            {
                DateTime date = DateTime.Now.Date.AddDays(i - count);

                int j = i % 7;

                if (j == 0)
                    departmentManager.resetShiftDays();

                foreach (Department department in departmentManager.Departments)
                {


                    foreach (Employee employee in employeeManager.GetEmployees())
                    {
                        for (int two = 0; two < 2; two++)
                        {
                            int k = ChooseShift(j, department);
                            if (k == -1)
                                break;
                            int reqShift = department.ShiftPerDept.RequiredEmployees.AllDays[j].GetShift(k);
                            int fillShift = department.ShiftPerDept.FilledEmployees.AllDays[j].GetShift(k);
                            if (reqShift <= fillShift)
                                break;

                            if (!employee.IsActive)
                                continue;

                            if (employee.Department == department.Name)
                            {

                                bool Ok = true;
                                foreach (IConstraintStrategy constraint in allConstraints)
                                {
                                    if (constraint.CheckConstraint(employee, date))
                                        Ok = false;
                                }
                                if (!Ok)
                                    continue;

                                if (k == 0)
                                {
                                    if (VerifyDayPlanMorning(employee, date))
                                    {
                                        AddMorning(employee, date);
                                        department.ShiftPerDept.FilledEmployees.AllDays[j].Morning++;
                                        continue;
                                    }
                                }
                                else if (k == 1)
                                {
                                    if (VerifyDayPlanAfternoon(employee, date))
                                    {
                                        AddAfternoon(employee, date);
                                        department.ShiftPerDept.FilledEmployees.AllDays[j].Afternoon++;
                                        continue;
                                    }
                                }
                                else if (k == 2)
                                {
                                    if (VerifyDayPlanEvening(employee, date))
                                    {
                                        AddEvening(employee, date);
                                        department.ShiftPerDept.FilledEmployees.AllDays[j].Evening++;
                                        continue;
                                    }
                                }


                            }
                        }
                    }

                }
            }
        }

        public virtual void DeassignEmployees()
        {
            departmentManager.resetShiftDays();
            int numberOfDaysToAutoSchedule = 21;

            departmentManager.dataHelperDepartment.DeleteFteFromDateForward(DateTime.Now.AddDays(-1));

            departmentManager.dataHelperDepartment.DeleteDayplanFromDateForward(DateTime.Now.AddDays(-1));

            for (int i = 0; i < numberOfDaysToAutoSchedule; i++)
            {
                DateTime date = DateTime.Now.AddDays(i);

                foreach (Employee employee in employeeManager.GetEmployees())
                {
                    employee.GetDayPlans().Clear();
                    employee.ActualFtes.Clear();
                }
            }
        }

        private int GetCountIndexBasedOnDay(DateTime dateTime)
        {
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Sunday:

                    return 6;

                    break;
                case DayOfWeek.Monday:
                    return 0;
                    break;
                case DayOfWeek.Tuesday:
                    return 1;

                    break;
                case DayOfWeek.Wednesday:
                    return 2;
                    break;
                case DayOfWeek.Thursday:
                    return 3;
                    break;
                case DayOfWeek.Friday:
                    return 4;
                    break;
                case DayOfWeek.Saturday:
                    return 5;
                    break;
                default:
                    return -1;
                    break;
            }
        }
        private bool VerifyDayPlanMorning(Employee employee, DateTime date)
        {
            bool ok = true;
            foreach (DayPlan dayPlan in employee.GetDayPlansByDate(date))
            {
                if (dayPlan.Morning == 1 || dayPlan.Evening == 1)
                    ok = false;
            }
            return ok;
        }

        private void AddEvening(Employee employee, DateTime date)
        {
            DayPlan temp = new DayPlan(date, employee.Id, 0, 0, 1);
            employee.addDayplan(temp);

            EmployeeManager.GetInstance().dataHelperEmployee.AddPlan(temp);

            FteReal tempfte = new FteReal(employee.Id, date, 0.1);
            employee.ActualFtes.Add(tempfte);

            EmployeeManager.GetInstance().dataHelperEmployee.AddFTE(tempfte);
        }
        private void AddAfternoon(Employee employee, DateTime date)
        {
            DayPlan temp = new DayPlan(date, employee.Id, 0, 1, 0);
            employee.addDayplan(temp);

            EmployeeManager.GetInstance().dataHelperEmployee.AddPlan(temp);

            FteReal tempfte = new FteReal(employee.Id, date, 0.1);
            employee.ActualFtes.Add(tempfte);

            EmployeeManager.GetInstance().dataHelperEmployee.AddFTE(tempfte);
        }
        private void AddMorning(Employee employee, DateTime date)
        {
            DayPlan temp = new DayPlan(date, employee.Id, 1, 0, 0);
            employee.addDayplan(temp);

            EmployeeManager.GetInstance().dataHelperEmployee.AddPlan(temp);

            FteReal tempfte = new FteReal(employee.Id, date, 0.1);
            employee.ActualFtes.Add(tempfte);

            EmployeeManager.GetInstance().dataHelperEmployee.AddFTE(tempfte);
        }
        private bool VerifyDayPlanAfternoon(Employee employee, DateTime date)
        {
            bool ok = true;
            foreach (DayPlan dayPlan in employee.GetDayPlansByDate(date))
            {
                if (dayPlan.Afternoon == 1)
                    ok = false;
            }
            return ok;
        }
        private bool VerifyDayPlanEvening(Employee employee, DateTime date)
        {
            bool ok = true;
            foreach (DayPlan dayPlan in employee.GetDayPlansByDate(date))
            {
                if (dayPlan.Evening == 1 || dayPlan.Morning == 1)
                    ok = false;
            }
            return ok;
        }
    }
}
