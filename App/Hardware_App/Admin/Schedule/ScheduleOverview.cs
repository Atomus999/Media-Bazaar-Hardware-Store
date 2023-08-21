using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_App
{
    public partial class ScheduleOverview : Form
    {
        int counter = 0;
        private DateTime date;
        public ScheduleOverview(DateTime dateTime)
        {
            InitializeComponent();
            lbEmployees.DrawMode = DrawMode.OwnerDrawVariable;
            lbEmployees.DrawItem += new DrawItemEventHandler(lbEmployees_draw);

            lbDay1.DrawMode = DrawMode.OwnerDrawVariable;
            lbDay1.DrawItem += new DrawItemEventHandler(lbDay1_draw);
            lbDay2.DrawMode = DrawMode.OwnerDrawVariable;
            lbDay2.DrawItem += new DrawItemEventHandler(lbDay2_draw);
            lbDay3.DrawMode = DrawMode.OwnerDrawVariable;
            lbDay3.DrawItem += new DrawItemEventHandler(lbDay3_draw);
            lbDay4.DrawMode = DrawMode.OwnerDrawVariable;
            lbDay4.DrawItem += new DrawItemEventHandler(lbDay4_draw);
            lbDay5.DrawMode = DrawMode.OwnerDrawVariable;
            lbDay5.DrawItem += new DrawItemEventHandler(lbDay5_draw);
            lbDay6.DrawMode = DrawMode.OwnerDrawVariable;
            lbDay6.DrawItem += new DrawItemEventHandler(lbDay6_draw);
            lbDay7.DrawMode = DrawMode.OwnerDrawVariable;
            lbDay7.DrawItem += new DrawItemEventHandler(lbDay7_draw);
            cbDepartments.DataSource = DepartmentManager.GetInstance().Departments;
            this.date = dateTime;
            setIndexes(dateTime);
            lblError.Text = "";
            lblError2.Text = "";
        }

        private void lbDay1_draw(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                Brush myBrush = Brushes.Black;
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                 e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {
                Console.WriteLine("draw not possible 1");

            }
        }
        private void lbDay2_draw(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                Brush myBrush = Brushes.Black;
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                 e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {
                Console.WriteLine("draw not possible 2");
            }
        }
        private void lbDay3_draw(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                Brush myBrush = Brushes.Black;
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                 e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {
                Console.WriteLine("draw not possible 3");
            }
        }
        private void lbDay4_draw(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                Brush myBrush = Brushes.Black;
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                 e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {
                Console.WriteLine("draw not possible 4");
            }
        }
        private void lbDay5_draw(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                Brush myBrush = Brushes.Black;
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                 e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {
                Console.WriteLine("draw not possible 5");
            }
        }
        private void lbDay6_draw(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                Brush myBrush = Brushes.Black;
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                 e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {
                Console.WriteLine("draw not possible 6");
            }
        }
        private void lbDay7_draw(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                Brush myBrush = Brushes.Black;
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                 e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {
                Console.WriteLine("draw not possible 7");
            }
        }
        public void setIndexes(DateTime dateTime)
        {
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    setDays(date, -6);
                    counter = -6;
                    trim();
                    break;
                case DayOfWeek.Monday:
                    setDays(date, 0);
                    counter = 0;
                    trim();
                    break;
                case DayOfWeek.Tuesday:
                    setDays(date, -1);
                    counter = -1;
                    trim();
                    break;
                case DayOfWeek.Wednesday:
                    setDays(date, -2);
                    counter = -2;
                    trim();
                    break;
                case DayOfWeek.Thursday:
                    setDays(date, -3);
                    counter = -3;
                    trim();
                    break;
                case DayOfWeek.Friday:
                    setDays(date, -4);
                    counter = -4;
                    trim();
                    break;
                case DayOfWeek.Saturday:
                    setDays(date, -5);
                    counter = -5;
                    trim();
                    break;
                default:
                    break;
            }
        }
        private void lbEmployees_draw(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                Brush myBrush = Brushes.White;

                string lbItem = ((ListBox)sender).Items[e.Index].ToString();
                lbItem = lbItem.Remove(lbItem.Length - 11);
                lbItem = lbItem.Trim();
                foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
                {
                    if (lbItem == employee.FirstName + " " + employee.LastName)
                    {
                        if (employee.WeeklyActualFTE(date) > employee.FteContract)
                            myBrush = Brushes.Red;
                        else
                            myBrush = Brushes.Black;
                    }
                    e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                 e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

                    e.DrawFocusRectangle();

                }
            }
            catch
            {
                Console.WriteLine("draw not possible employee");
            }
        }
        public void setDays(DateTime dateTime, int j)
        {
            lblDay1.Text = dateTime.AddDays(j).ToString();
            lblDay2.Text = dateTime.AddDays(j + 1).ToString();
            lblDay3.Text = dateTime.AddDays(j + 2).ToString();
            lblDay4.Text = dateTime.AddDays(j + 3).ToString();
            lblDay5.Text = dateTime.AddDays(j + 4).ToString();
            lblDay6.Text = dateTime.AddDays(j + 5).ToString();
            lblDay7.Text = dateTime.AddDays(j + 6).ToString();

        }
        public void trim()
        {
            lblDay1.Text = lblDay1.Text.Remove(10);
            lblDay2.Text = lblDay2.Text.Remove(10);
            lblDay3.Text = lblDay3.Text.Remove(10);
            lblDay4.Text = lblDay4.Text.Remove(10);
            lblDay5.Text = lblDay5.Text.Remove(10);
            lblDay6.Text = lblDay6.Text.Remove(10);
            lblDay7.Text = lblDay7.Text.Remove(10);
        }


        public void ListEmployees()
        {
            lbEmployees.Items.Clear();
            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
                if (employee.IsActive)
                    if (employee.Department == cbDepartments.SelectedItem.ToString())
                    {
                        string text = employee.FirstName + " " + employee.LastName + "        " + employee.WeeklyActualFTE(date) + "/" + employee.FteContract + " FTE";
                        //string text = employee.Name;
                        lbEmployees.Items.Add(text);
                    }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            //UpdateShiftPerDepPerDay();
            RefreshUi();
        }

        private void RefreshUi()
        {
            DepartmentManager.GetInstance().resetShiftDays();
            ListEmployees();
            showEmpByDate(date);
        }

        public void showEmpByDate(DateTime dateTime)
        {
            lbDay1.Items.Clear();
            lbDay2.Items.Clear();
            lbDay3.Items.Clear();
            lbDay4.Items.Clear();
            lbDay5.Items.Clear();
            lbDay6.Items.Clear();
            lbDay7.Items.Clear();

            for (int i = 0; i < 7; i++)
            {
                ListBox listBox;
                switch (i)
                {
                    case 0:
                        listBox = lbDay1;
                        break;
                    case 1:
                        listBox = lbDay2;
                        break;
                    case 2:
                        listBox = lbDay3;
                        break;
                    case 3:
                        listBox = lbDay4;
                        break;
                    case 4:
                        listBox = lbDay5;
                        break;
                    case 5:
                        listBox = lbDay6;
                        break;
                    case 6:
                        listBox = lbDay7;
                        break;
                    default:
                        listBox = lbEmployees;
                        break;
                }
                foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
                {
                    if (!employee.IsActive)
                        continue;

                    bool checker = true;
                    if (!checkWorkDay(date.AddDays(i + counter), employee))
                        checker = false;
                    List<DayPlan> dayPlans = employee.GetDayPlansByDate(dateTime.AddDays(i + counter));
                    int morning = 0;
                    int afternoon = 0;
                    int evening = 0;

                    foreach (DayPlan plan in dayPlans)
                    {
                        if (plan.Morning != 0)
                            morning = 1;
                        if (plan.Afternoon != 0)
                            afternoon = 1;
                        if (plan.Evening != 0)
                            evening = 1;
                    }

                    if (employee.Department == cbDepartments.SelectedItem.ToString())
                    {
                        addToListbox2(morning, afternoon, evening, listBox, checker);
                        CalculateShifts(morning, afternoon, evening, dateTime.AddDays(i + counter), employee.Department);
                    }

                }
            }
            UpdateShiftPerDepPerDay();
        }

        private void CalculateShifts(int morning, int afternoon, int evening, DateTime dateTime, string dep)
        {
            foreach (Department department in DepartmentManager.GetInstance().Departments)
            {
                if (dep == department.Name)
                {
                    switch (dateTime.DayOfWeek)
                    {
                        case DayOfWeek.Sunday:
                            if (morning == 1)
                                department.ShiftPerDept.FilledEmployees.Sunday.Morning++;
                            if (afternoon == 1)
                                department.ShiftPerDept.FilledEmployees.Sunday.Afternoon++;
                            if (evening == 1)
                                department.ShiftPerDept.FilledEmployees.Sunday.Evening++;
                            break;
                        case DayOfWeek.Monday:
                            if (morning == 1)
                                department.ShiftPerDept.FilledEmployees.Monday.Morning++;
                            if (afternoon == 1)
                                department.ShiftPerDept.FilledEmployees.Monday.Afternoon++;
                            if (evening == 1)
                                department.ShiftPerDept.FilledEmployees.Monday.Evening++;
                            break;
                        case DayOfWeek.Tuesday:
                            if (morning == 1)
                                department.ShiftPerDept.FilledEmployees.Tuesday.Morning++;
                            if (afternoon == 1)
                                department.ShiftPerDept.FilledEmployees.Tuesday.Afternoon++;
                            if (evening == 1)
                                department.ShiftPerDept.FilledEmployees.Tuesday.Evening++;
                            break;
                        case DayOfWeek.Wednesday:
                            if (morning == 1)
                                department.ShiftPerDept.FilledEmployees.Wednesday.Morning++;
                            if (afternoon == 1)
                                department.ShiftPerDept.FilledEmployees.Wednesday.Afternoon++;
                            if (evening == 1)
                                department.ShiftPerDept.FilledEmployees.Wednesday.Evening++;
                            break;
                        case DayOfWeek.Thursday:
                            if (morning == 1)
                                department.ShiftPerDept.FilledEmployees.Thursday.Morning++;
                            if (afternoon == 1)
                                department.ShiftPerDept.FilledEmployees.Thursday.Afternoon++;
                            if (evening == 1)
                                department.ShiftPerDept.FilledEmployees.Thursday.Evening++;
                            break;
                        case DayOfWeek.Friday:
                            if (morning == 1)
                                department.ShiftPerDept.FilledEmployees.Friday.Morning++;
                            if (afternoon == 1)
                                department.ShiftPerDept.FilledEmployees.Friday.Afternoon++;
                            if (evening == 1)
                                department.ShiftPerDept.FilledEmployees.Friday.Evening++;
                            break;
                        case DayOfWeek.Saturday:
                            if (morning == 1)
                                department.ShiftPerDept.FilledEmployees.Saturday.Morning++;
                            if (afternoon == 1)
                                department.ShiftPerDept.FilledEmployees.Saturday.Afternoon++;
                            if (evening == 1)
                                department.ShiftPerDept.FilledEmployees.Saturday.Evening++;
                            break;
                        default:
                            break;
                    }
                }
            }
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
        public void addToListbox2(int morning, int afternoon, int evening, ListBox listBox, bool checker)
        {
            if (morning != 0 && afternoon != 0)
                listBox.Items.Add("M,A,0");
            else if (afternoon != 0 && evening != 0)
                listBox.Items.Add("0,A,E");
            else if (morning != 0)
                listBox.Items.Add("M,0,0");
            else if (afternoon != 0)
                listBox.Items.Add("0,A,0");
            else if (evening != 0)
                listBox.Items.Add("0,0,E");
            else
            {
                if (checker)
                    listBox.Items.Add("0,0,0");
                else
                    listBox.Items.Add("N/A");
            }
        }


        public void UpdateShiftPerDepPerDay()
        {
            foreach (Department department in DepartmentManager.GetInstance().Departments)
            {
                if (department.Name == cbDepartments.SelectedItem.ToString())
                {

                    lblMonShft.Text = $"{department.ShiftPerDept.RequiredEmployees.Monday.Morning},{department.ShiftPerDept.RequiredEmployees.Monday.Afternoon},{department.ShiftPerDept.RequiredEmployees.Monday.Evening}";
                    lblMonShftFill.Text = $"{department.ShiftPerDept.FilledEmployees.Monday.Morning},{department.ShiftPerDept.FilledEmployees.Monday.Afternoon},{department.ShiftPerDept.FilledEmployees.Monday.Evening}";

                    lblTueShft.Text = $"{department.ShiftPerDept.RequiredEmployees.Tuesday.Morning},{department.ShiftPerDept.RequiredEmployees.Tuesday.Afternoon},{department.ShiftPerDept.RequiredEmployees.Tuesday.Evening}";
                    lblTueShftFill.Text = $"{department.ShiftPerDept.FilledEmployees.Tuesday.Morning},{department.ShiftPerDept.FilledEmployees.Tuesday.Afternoon},{department.ShiftPerDept.FilledEmployees.Tuesday.Evening}";

                    lblWedShft.Text = $"{department.ShiftPerDept.RequiredEmployees.Wednesday.Morning},{department.ShiftPerDept.RequiredEmployees.Wednesday.Afternoon},{department.ShiftPerDept.RequiredEmployees.Wednesday.Evening}";
                    lblWedShftFill.Text = $"{department.ShiftPerDept.FilledEmployees.Wednesday.Morning},{department.ShiftPerDept.FilledEmployees.Wednesday.Afternoon},{department.ShiftPerDept.FilledEmployees.Wednesday.Evening}";

                    lblThuShft.Text = $"{department.ShiftPerDept.RequiredEmployees.Thursday.Morning},{department.ShiftPerDept.RequiredEmployees.Thursday.Afternoon},{department.ShiftPerDept.RequiredEmployees.Thursday.Evening}";
                    lblThuShftFill.Text = $"{department.ShiftPerDept.FilledEmployees.Thursday.Morning},{department.ShiftPerDept.FilledEmployees.Thursday.Afternoon},{department.ShiftPerDept.FilledEmployees.Thursday.Evening}";

                    lblFriShft.Text = $"{department.ShiftPerDept.RequiredEmployees.Friday.Morning},{department.ShiftPerDept.RequiredEmployees.Friday.Afternoon},{department.ShiftPerDept.RequiredEmployees.Friday.Evening}";
                    lblFriShftFill.Text = $"{department.ShiftPerDept.FilledEmployees.Friday.Morning},{department.ShiftPerDept.FilledEmployees.Friday.Afternoon},{department.ShiftPerDept.FilledEmployees.Friday.Evening}";

                    lblSatShft.Text = $"{department.ShiftPerDept.RequiredEmployees.Saturday.Morning},{department.ShiftPerDept.RequiredEmployees.Saturday.Afternoon},{department.ShiftPerDept.RequiredEmployees.Saturday.Evening}";
                    lblSatShftFill.Text = $"{department.ShiftPerDept.FilledEmployees.Saturday.Morning},{department.ShiftPerDept.FilledEmployees.Saturday.Afternoon},{department.ShiftPerDept.FilledEmployees.Saturday.Evening}";

                    lblSunShft.Text = $"{department.ShiftPerDept.RequiredEmployees.Sunday.Morning},{department.ShiftPerDept.RequiredEmployees.Sunday.Afternoon},{department.ShiftPerDept.RequiredEmployees.Sunday.Evening}";
                    lblSunShftFill.Text = $"{department.ShiftPerDept.FilledEmployees.Sunday.Morning},{department.ShiftPerDept.FilledEmployees.Sunday.Afternoon},{department.ShiftPerDept.FilledEmployees.Sunday.Evening}";
                    if (!string.Equals(lblMonShft.Text, lblMonShftFill.Text))
                        lblMonShftFill.ForeColor = Color.Red;
                    else
                        lblMonShftFill.ForeColor = Color.Black;

                    if (!string.Equals(lblTueShft.Text, lblTueShftFill.Text))
                        lblTueShftFill.ForeColor = Color.Red;
                    else
                        lblTueShftFill.ForeColor = Color.Black;

                    if (!string.Equals(lblWedShft.Text, lblWedShftFill.Text))
                        lblWedShftFill.ForeColor = Color.Red;
                    else
                        lblWedShftFill.ForeColor = Color.Black;

                    if (!string.Equals(lblThuShft.Text, lblThuShftFill.Text))
                        lblThuShftFill.ForeColor = Color.Red;
                    else
                        lblThuShftFill.ForeColor = Color.Black;

                    if (!string.Equals(lblFriShft.Text, lblFriShftFill.Text))
                        lblFriShftFill.ForeColor = Color.Red;
                    else
                        lblFriShftFill.ForeColor = Color.Black;

                    if (!string.Equals(lblSatShft.Text, lblSatShftFill.Text))
                        lblSatShftFill.ForeColor = Color.Red;
                    else
                        lblSatShftFill.ForeColor = Color.Black;

                    if (!string.Equals(lblSunShft.Text, lblSunShftFill.Text))
                        lblSunShftFill.ForeColor = Color.Red;
                    else
                        lblSunShftFill.ForeColor = Color.Black;

                }
            }
        }
        private void CbDepartments_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DepartmentManager.GetInstance().resetShiftDays();
            ListEmployees();
            showEmpByDate(date);
        }

        private void AddSchedule(DateTime dateSelected, Employee employeeSelected, string shift)
        {
            lblError.Text = "";
            lblError2.Text = "";
            try
            {
                bool ok = true;

                foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
                {
                    if (employee == employeeSelected)
                    {
                        if (!checkWorkDay(dateSelected, employee))
                        {
                            lblError.Text = "Employee does not wish to work that day";
                            lblError.ForeColor = Color.Red;
                        }
                        if (employee.WeeklyActualFTE(dateSelected) >= employee.FteContract)
                        {
                            lblError2.Text = "Fte exceeds employee contract for this week";
                            lblError2.ForeColor = Color.Red;
                        }
                        switch (shift)
                        {
                            case "Evening":
                                foreach (DayPlan dayPlan in employee.GetDayPlansByDate(dateSelected))
                                {
                                    if (dayPlan.Evening == 1 || dayPlan.Morning == 1)
                                        ok = false;
                                }
                                if (ok)
                                {
                                    DayPlan temp = new DayPlan(dateSelected, employee.Id, 0, 0, 1);
                                    employee.addDayplan(temp);
                                    EmployeeManager.GetInstance().dataHelperEmployee.AddPlan(temp);

                                    FteReal tempfte = new FteReal(employee.Id, dateSelected, 0.1);
                                    employee.ActualFtes.Add(tempfte);
                                    EmployeeManager.GetInstance().dataHelperEmployee.AddFTE(tempfte);
                                }
                                else
                                    MessageBox.Show("Employee already scheduled in the evening or morning");
                                break;
                            case "Morning":
                                foreach (DayPlan dayPlan in employee.GetDayPlansByDate(dateSelected))
                                {
                                    if (dayPlan.Morning == 1 || dayPlan.Evening == 1)
                                        ok = false;
                                }
                                if (ok)
                                {
                                    DayPlan temp = new DayPlan(dateSelected, employee.Id, 1, 0, 0);
                                    employee.addDayplan(temp);
                                    EmployeeManager.GetInstance().dataHelperEmployee.AddPlan(temp);

                                    FteReal tempfte = new FteReal(employee.Id, dateSelected, 0.1);
                                    employee.ActualFtes.Add(tempfte);
                                    EmployeeManager.GetInstance().dataHelperEmployee.AddFTE(tempfte);
                                }
                                else
                                    MessageBox.Show("Employee already scheduled in the morning or evening");
                                break;
                            case "Afternoon":
                                foreach (DayPlan dayPlan in employee.GetDayPlansByDate(dateSelected))
                                {
                                    if (dayPlan.Afternoon == 1)
                                        ok = false;
                                }
                                if (ok)
                                {
                                    DayPlan temp = new DayPlan(dateSelected, employee.Id, 0, 1, 0);
                                    employee.addDayplan(temp);
                                    EmployeeManager.GetInstance().dataHelperEmployee.AddPlan(temp);

                                    FteReal tempfte = new FteReal(employee.Id, dateSelected, 0.1);
                                    employee.ActualFtes.Add(tempfte);
                                    EmployeeManager.GetInstance().dataHelperEmployee.AddFTE(tempfte);
                                }
                                else
                                    MessageBox.Show("Employee already scheduled in the afternoon");
                                break;

                        }

                    }
                }
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Please choose employee");
            }
        }

        private string returnShift()
        {
            if (rbtnMorning.Checked == true)
            {
                return "Morning";
            }
            else if (rbtnAfternoon.Checked == true)
            {
                return "Afternoon";
            }
            else if (rbtnEvening.Checked == true)
            {
                return "Evening";
            }
            else
                return "unassigned";
        }

        private Employee returnSelectedEmployee()
        {
            try
            {
                string tempEmpName = lbEmployees.SelectedItem.ToString();
                string[] name = tempEmpName.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
                {
                    if (employee.FirstName == name[0] && employee.LastName == name[1])
                        return employee;
                }
            }
            catch { MessageBox.Show("Please select employee"); }
            return null;
        }

        private void BtnScheduleDay1_Click(object sender, EventArgs e)
        {
            AssignEmployeeToSchedule(lblDay1.Text);
        }

        private void AssignEmployeeToSchedule(string day)
        {
            Employee selectedEmployee = returnSelectedEmployee();
            DateTime selectedDate = Convert.ToDateTime(day);
            string shift = returnShift();
            AddSchedule(selectedDate, selectedEmployee, shift);
            RefreshUi();
        }

        private void BtnScheduleDay2_Click(object sender, EventArgs e)
        {
            AssignEmployeeToSchedule(lblDay2.Text);
        }

        private void BtnScheduleDay3_Click(object sender, EventArgs e)
        {
            AssignEmployeeToSchedule(lblDay3.Text);
        }

        private void BtnScheduleDay4_Click(object sender, EventArgs e)
        {
            AssignEmployeeToSchedule(lblDay4.Text);

        }

        private void BtnScheduleDay5_Click(object sender, EventArgs e)
        {
            AssignEmployeeToSchedule(lblDay5.Text);
        }

        private void BtnScheduleDay6_Click(object sender, EventArgs e)
        {
            AssignEmployeeToSchedule(lblDay6.Text);
        }

        private void BtnScheduleDay7_Click(object sender, EventArgs e)
        {
            AssignEmployeeToSchedule(lblDay7.Text);
        }
    }
}
