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
using System.Windows.Forms.DataVisualization.Charting;
using Hardware_App.Admin;
using MySql.Data;
using MySql.Data.MySqlClient;
using Phidget22;
using Phidget22.Events;
using Hardware_App.Admin.Schedule.ScheduleAlgorithm;

namespace Hardware_App
{
    public partial class ManageEmployee : Form
    {
        private ScheduleOverview scheduleOverview;
        private ManageInformation manageInformation;
        private RFID myRFIDReader;

        #region Design-Rounding

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );

        private List<Control> listBoxes = new List<Control>();
        private List<Panel> panels = new List<Panel>();
        private List<CustomTextbox> customTextboxes = new List<CustomTextbox>();
        private void AddListboxes()
        {
            listBoxes.Add(lbMorningSchedule);
            listBoxes.Add(lbAfternoonSchedule);
            listBoxes.Add(lbEveningSchedule);
            listBoxes.Add(lbAllEmployees2);
            listBoxes.Add(lbRFIDStatus);
        }

        private void AddPanels()
        {
            //search
            panels.Add(panelShadowSearch);
            panels.Add(panelSearch);
            //panels.Add(panelShadowSearch2);
            panels.Add(panelSearch2);
            //schedule
            panels.Add(panelShadowScheduleAuto);
            panels.Add(panelScheduleAuto);

            panels.Add(panelShadowScheduleCalendar);
            panels.Add(panelScheduleCalendar);

            panels.Add(panelShadowScheduleEmployee);
            panels.Add(panelScheduleEmployee);

            panels.Add(panelShadowShowSchedule);
            panels.Add(panelShowSchedule);
            //statistics
            panels.Add(panelShadowEmpStats);
            panels.Add(panelEmpStats);

            panels.Add(panelShadowDepStats);
            panels.Add(panelDepStats);

            panels.Add(panelShadowSpecProd);
            panels.Add(panelSpecProd);
            panels.Add(panelShadowGenProd);
            panels.Add(panelGenProd);
            panels.Add(panelShadowProdChart);
            panels.Add(panelProdChart);
            //attendance
            panels.Add(panelShadowAttendance);
            panels.Add(panelAttendance);
            //departments
            panels.Add(panelShadowDep);
            panels.Add(panelDep);
            panels.Add(panelShadowDepAddFte);
            panels.Add(panelDepAddFte);
            panels.Add(panelShadowDepFTE);
            panels.Add(panelDepFTE);
            //rfid
            panels.Add(panelShadowRfid);
            panels.Add(panelRfid);
        }

        private void AddTextBoxes()
        {
            customTextboxes.Add(tbSearch);
            customTextboxes.Add(tbSearch2);
            customTextboxes.Add(tbDepartmentName);
            customTextboxes.Add(tbFteRequired);
            customTextboxes.Add(tbRFIDSerial);
        }


        private void RoundListBoxes(int nWidthEllipse, int nHeightEllipse)
        {
            this.AddListboxes();
            foreach (Control c in listBoxes)
            {
                c.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, nWidthEllipse, nHeightEllipse));
            }
        }

        private void RoundPanels(int nWidthEllipse, int nHeightEllipse)
        {
            this.AddPanels();
            foreach (Control c in panels)
            {
                c.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, nWidthEllipse, nHeightEllipse));
            }
        }

        private void RoundTextBoxes(int nWidthEllipse, int nHeightEllipse)
        {
            this.AddTextBoxes();
            foreach (Control c in customTextboxes)
            {
                c.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, nWidthEllipse, nHeightEllipse));
            }
        }


        #endregion



        public DepotStatisticsManager depotStatistics { get; set; }

        public ManageEmployee()
        {
            InitializeComponent();
            this.RoundPanels(20, 20);
            this.RoundListBoxes(15, 15);
            this.RoundTextBoxes(5, 5);
            manageInformation = new ManageInformation();
            manageInformation.ListboxUpdatedEvent += new ManageInformation.UpdateEmpListboxHandler(refreshAllEmpDataGridView);
            manageInformation.ListboxUpdatedEvent += new ManageInformation.UpdateEmpListboxHandler(refreshAllEmpListbox);

            EmployeeManager e = EmployeeManager.GetInstance();
            DepartmentManager d = DepartmentManager.GetInstance();

            updateDepartments();
            dgvEmployees.MultiSelect = false;
            dgvEmployees2.MultiSelect = false;
            dgvEmployees3.MultiSelect = false;
            dgvDepartments.MultiSelect = false;
            cbCategory.DataSource = Enum.GetValues(typeof(ProductCategory));

            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Tag += new RFIDTagEventHandler(this.ProcessThisTag);

                lbRFIDStatus.Items.Add($"Startup: so far so good. Today is {DateTime.Today.ToString("d")}");
            }
            catch (PhidgetException) { lbRFIDStatus.Items.Add("error at start-up."); }

            try
            {
                myRFIDReader.Open(); //if successfully, it will call the Attach-event.
            }
            catch (PhidgetException) { lbRFIDStatus.Items.Add("no RFID-reader opened???????????"); }
        }

        public loginForm reference { get; set; }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            manageInformation.TbEmpId.Clear();
            manageInformation.TbFirstName.Clear();
            manageInformation.TbBSN.Clear();
            manageInformation.TbPhoneNumber.Text = "316";
            manageInformation.TbAddress.Clear();
            manageInformation.TbEmail.Clear();
            manageInformation.TbUsername.Clear();
            manageInformation.TbPassword.Clear();

            manageInformation.UpdateDepartments();
            manageInformation.btnChange.Visible = false;
            manageInformation.btnCreate.Visible = true;
            manageInformation.lblAlert.Visible = false;
            manageInformation.btnSpouse.Visible = false;
            manageInformation.Show();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbDepartmentName.Text))
            {
                Department department = new Department(tbDepartmentName.Text);
                DepartmentManager.GetInstance().AddDepartment(department);

                updateDepartments();
                refreshAllEmpDataGridView();
            }
            else
            {
                MessageBox.Show("Insert text in the add window");
            }
        }
        public void updateDepartments()
        {
            lbDepartments.Items.Clear();
            foreach (Department department in DepartmentManager.GetInstance().Departments)
            {
                department.ShowFTE = true;
                lbDepartments.Items.Add(department);
                department.ShowFTE = false;
            }
        }
        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearch.Text))
            {
                foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
                {
                    if (Int32.TryParse(tbSearch.Text, out int value))
                    {
                        if (employee.Id == Convert.ToInt32(tbSearch.Text))
                        {
                            dgvEmployees.DataSource = EmployeeManager.GetInstance().GetEmployeesDatatableByID(Convert.ToInt32(tbSearch.Text));
                        }
                    }
                    else
                    {
                        if (employee.FirstName.ToLower() == tbSearch.Text || employee.LastName.ToLower() == tbSearch.Text)
                        {
                            dgvEmployees.DataSource = EmployeeManager.GetInstance().GetEmployeesDatatableByName(tbSearch.Text.ToLower());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please search by one of options(ID, NAME)");
            }
        }

        private void btnChangeEmpData_Click(object sender, EventArgs e)
        {
            manageInformation.UpdateDepartments();
            int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value.ToString());
            Employee emp = null;
            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
                if (id == employee.Id)
                {
                    manageInformation.btnChange.Visible = true;
                    manageInformation.btnCreate.Visible = false;
                    manageInformation.lblAlert.Visible = true;
                    manageInformation.btnSpouse.Visible = true;
                    manageInformation.TbEmpId.Text = employee.Id.ToString();
                    manageInformation.TbFirstName.Text = employee.FirstName;
                    manageInformation.TbLastName.Text = employee.LastName;
                    manageInformation.CbDepartment.SelectedIndex = manageInformation.CbDepartment.FindStringExact(employee.Department);
                    manageInformation.datetimeDateOfBirth.Value = employee.DateOfBirth;
                    manageInformation.TbBSN.Text = employee.Bsn.ToString();
                    manageInformation.TbPhoneNumber.Text = employee.PhoneNumber;
                    manageInformation.TbAddress.Text = employee.Address;
                    manageInformation.TbEmail.Text = employee.Email;
                    manageInformation.TbUsername.Text = employee.UserName;
                    manageInformation.TbPassword.Text = employee.Password;
                    manageInformation.TbContactFTE.Text = employee.FteContract.ToString();
                    manageInformation.ChkMonday.Checked = employee.ScheduleDays.Monday;
                    manageInformation.ChkTuesday.Checked = employee.ScheduleDays.Tuesday;
                    manageInformation.ChkWednesday.Checked = employee.ScheduleDays.Wednesday;
                    manageInformation.ChkThursday.Checked = employee.ScheduleDays.Thursday;
                    manageInformation.ChkFriday.Checked = employee.ScheduleDays.Friday;
                    manageInformation.ChkSaturday.Checked = employee.ScheduleDays.Saturday;
                    manageInformation.ChkSunday.Checked = employee.ScheduleDays.Sunday;
                    emp = employee;

                    if (employee.Rfid != null)
                    {
                        manageInformation.TbRFID.Text = employee.Rfid.ToString();
                    }
                    else
                    {
                        manageInformation.TbRFID.Clear();
                    }
                }
                manageInformation.Show();
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            refreshAllEmpListbox();
            refreshAllEmpDataGridView();
        }

        private void ResizeDataGridColumn(DataGridView dgv, int index, int width)
        {
            dgv.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns[index].Width = width;
        }

        public void refreshAllEmpDataGridView()
        {
            dgvEmployees.DataSource = null;
            dgvEmployees2.DataSource = null;
            dgvEmployees3.DataSource = null;
            dgvDepartments.DataSource = null;

            dgvEmployees.DataSource = EmployeeManager.GetInstance().GetEmployeesDatatable();
            dgvEmployees2.DataSource = EmployeeManager.GetInstance().GetEmployeesDatatable();
            dgvEmployees3.DataSource = EmployeeManager.GetInstance().GetEmployeesDatatable();
            dgvDepartments.DataSource = DepartmentManager.GetInstance().GetDepartmentsDatatable();
            this.ResizeDataGridColumn(dgvEmployees, 0, 25);
            this.ResizeDataGridColumn(dgvEmployees2, 0, 25);
            this.ResizeDataGridColumn(dgvEmployees3, 0, 25);
            this.ResizeDataGridColumn(dgvDepartments, 0, 25);

        }
        public void refreshAllEmpListbox()
        {
            lbAllEmployees.Items.Clear();
            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
                lbAllEmployees.Items.Add(employee);
            }
        }
        private void tbSearchEmployee2_Click(object sender, EventArgs e)
        {
            lbAllEmployees2.Items.Clear();

            if (!string.IsNullOrEmpty(tbSearch2.Text))
            {
                foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
                {
                    if (Int32.TryParse(tbSearch2.Text, out int value))
                    {
                        if (employee.Id == Convert.ToInt32(tbSearch2.Text))
                        {
                            if (employee.IsActive)
                                lbAllEmployees2.Items.Add(employee);
                            else
                                MessageBox.Show("Employee is deactivated");
                        }
                    }
                    else
                    {
                        if (employee.FirstName.ToLower() == tbSearch2.Text.ToLower() || employee.LastName.ToLower() == tbSearch2.Text.ToLower())
                        {
                            if (employee.IsActive)
                                lbAllEmployees2.Items.Add(employee);
                            else
                                MessageBox.Show("Employee is deactivated");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please search by one of options(ID, NAME)");
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
                        MessageBox.Show("Employee will not work on Sunday"); ok = false;
                    }
                    break;
                case DayOfWeek.Monday:
                    if (!employee.ScheduleDays.Monday)
                    {
                        MessageBox.Show("Employee will not work on Monday"); ok = false;
                    }
                    break;
                case DayOfWeek.Tuesday:
                    if (!employee.ScheduleDays.Tuesday)
                    {
                        MessageBox.Show("Employee will not work on Tuesday"); ok = false;
                    }
                    break;
                case DayOfWeek.Wednesday:
                    if (!employee.ScheduleDays.Wednesday)
                    {
                        MessageBox.Show("Employee will not work on Wednesday"); ok = false;
                    }
                    break;
                case DayOfWeek.Thursday:
                    if (!employee.ScheduleDays.Thursday)
                    {
                        MessageBox.Show("Employee will not work on Thursday"); ok = false;
                    }
                    break;
                case DayOfWeek.Friday:
                    if (!employee.ScheduleDays.Friday)
                    {
                        MessageBox.Show("Employee will not work on Friday"); ok = false;
                    }
                    break;
                case DayOfWeek.Saturday:
                    if (!employee.ScheduleDays.Saturday)
                    {
                        MessageBox.Show("Employee will not work on Saturday"); ok = false;
                    }
                    break;
                default:
                    break;
            }
            return ok;
        }
        private void AddMorning()
        {
            try
            {
                DateTime dateSelected = calendarSchedule.SelectionStart;
                bool ok = true;
                string selectedEmployee = lbAllEmployees2.SelectedItem.ToString();
                foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
                {

                    if (employee.EmployeeInformation() == selectedEmployee)
                    {
                        if (!checkWorkDay(dateSelected, employee))
                            MessageBox.Show("Employee does not wish to work that day");


                        if (employee.WeeklyActualFTE(dateSelected) >= employee.FteContract)
                        {
                            MessageBox.Show("Fte exceeds employee contract for this week");
                        }
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
                    }

                }


                DateTime bold = calendarSchedule.SelectionRange.Start;

                calendarSchedule.AddBoldedDate(bold);

            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Please choose employee");
            }
        }

        private void AddAfternoon()
        {
            try
            {
                DateTime dateSelected = calendarSchedule.SelectionStart;
                bool ok = true;
                string selectedEmployee = lbAllEmployees2.SelectedItem.ToString();
                foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
                {
                    if (employee.EmployeeInformation() == selectedEmployee)
                    {

                        if (!checkWorkDay(dateSelected, employee))
                            MessageBox.Show("Employee does not wish to work that day");
                        if (employee.WeeklyActualFTE(dateSelected) >= employee.FteContract)
                        {
                            MessageBox.Show("Fte exceeds employee contract for this week");
                        }
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
                    }
                }

                DateTime bold = calendarSchedule.SelectionRange.Start;

                calendarSchedule.AddBoldedDate(bold);

            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Please choose employee");
            }
        }

        private void AddEvening()
        {
            try
            {
                DateTime dateSelected = calendarSchedule.SelectionStart;
                bool ok = true;
                string selectedEmployee = lbAllEmployees2.SelectedItem.ToString();
                foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
                {
                    if (employee.EmployeeInformation() == selectedEmployee)
                    {


                        if (!checkWorkDay(dateSelected, employee))
                            MessageBox.Show("Employee does not wish to work that day");
                        if (employee.WeeklyActualFTE(dateSelected) >= employee.FteContract)
                        {
                            MessageBox.Show("Fte exceeds employee contract for this week");
                        }
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
                    }
                }

                DateTime bold = calendarSchedule.SelectionRange.Start;

                calendarSchedule.AddBoldedDate(bold);

            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Please choose employee");
            }
        }

        public void UpdateSchedules()
        {
            lbMorningSchedule.Items.Clear();
            lbAfternoonSchedule.Items.Clear();
            lbEveningSchedule.Items.Clear();

            DateTime dateSelected = calendarSchedule.SelectionStart;

            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
                foreach (DayPlan dayplan in employee.GetDayPlansByDate(dateSelected))
                {
                    if (dayplan.Morning != 0)
                    {
                        lbMorningSchedule.Items.Add(employee.FirstName + " " + employee.LastName);
                    }
                    else if (dayplan.Afternoon != 0)
                    {
                        lbAfternoonSchedule.Items.Add(employee.FirstName + " " + employee.LastName);
                    }
                    else if (dayplan.Evening != 0)
                    {
                        lbEveningSchedule.Items.Add(employee.FirstName + " " + employee.LastName);
                    }
                }
            }
        }

        private void btnCheckSchedule_Click(object sender, EventArgs e)
        {
            UpdateSchedules(); // button is obsolete after calendar click event
        }

        private void btnRemoveSchedule_Click(object sender, EventArgs e)
        {
            //resetShiftDays();
            DepartmentManager.GetInstance().resetShiftDays();
            DateTime dateSelected = calendarSchedule.SelectionStart;
            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
                List<DayPlan> plans = employee.GetDayPlansByDate(dateSelected);
                try
                {
                    if (lbMorningSchedule.SelectedItem.ToString() == employee.FirstName + " " + employee.LastName)
                    {
                        for (int i = 0; i < plans.Count; i++)
                        {
                            if (plans[i].Morning == 1)
                            {
                                employee.removeActualFte(employee.Id, dateSelected);
                                employee.removeDayplan(plans[i]);
                                EmployeeManager.GetInstance().dataHelperEmployee.RemoveSchedule(dateSelected, plans[i]);
                                EmployeeManager.GetInstance().dataHelperEmployee.RemoveFte(dateSelected, employee.Id);
                            }
                        }
                    }
                }
                catch (Exception ex) { throw ex; }
                try
                {
                    if (lbAfternoonSchedule.SelectedItem.ToString() == employee.FirstName + " " + employee.LastName)
                    {
                        for (int i = 0; i < plans.Count; i++)
                        {
                            if (plans[i].Afternoon == 1)
                            {
                                employee.removeActualFte(employee.Id, dateSelected);
                                employee.removeDayplan(plans[i]);
                                EmployeeManager.GetInstance().dataHelperEmployee.RemoveSchedule(dateSelected, plans[i]);
                                EmployeeManager.GetInstance().dataHelperEmployee.RemoveFte(dateSelected, employee.Id);
                            }
                        }
                    }
                }
                catch (Exception ex) { throw ex; }
                try
                {
                    if (lbEveningSchedule.SelectedItem.ToString() == employee.FirstName + " " + employee.LastName)
                    {
                        for (int i = 0; i < plans.Count; i++)
                        {
                            if (plans[i].Evening == 1)
                            {
                                employee.removeActualFte(employee.Id, dateSelected);
                                employee.removeDayplan(plans[i]);
                                EmployeeManager.GetInstance().dataHelperEmployee.RemoveSchedule(dateSelected, plans[i]);
                                EmployeeManager.GetInstance().dataHelperEmployee.RemoveFte(dateSelected, employee.Id);
                            }
                        }
                    }
                }
                catch (Exception ex) { throw ex; }
            }
            UpdateSchedules();
        }

        private void BtnLoadData_Click(object sender, EventArgs e)
        {
        }

        private void BtnSaveData_Click(object sender, EventArgs e)
        {
        }

        private void BtnLoadSchedule_Click(object sender, EventArgs e)
        {
        }

        private void BtnSaveSchedule_Click(object sender, EventArgs e)
        {
        }

        private void BtnShowByDate_Click(object sender, EventArgs e)
        {
            DepartmentManager.GetInstance().resetShiftDays();
            scheduleOverview = new ScheduleOverview(calendarSchedule.SelectionStart);
            scheduleOverview.ListEmployees();
            scheduleOverview.showEmpByDate(calendarSchedule.SelectionStart);
            scheduleOverview.Show();
        }

        private void ManageEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            reference.Show();
            reference.clearLogInWindows();
        }

        private void btnAssignSchedule_Click(object sender, EventArgs e)
        {
            if (rbtnMorning.Checked == true)
            {
                AddMorning();
            }
            else if (rbtnAfternoon.Checked == true)
            {
                AddAfternoon();
            }
            else if (rbtnEvening.Checked == true)
            {
                AddEvening();
            }

            UpdateSchedules();

        }

        private void BtnDeactivateEmployee_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value.ToString());

            Employee emp = null;

            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
                if (id == employee.Id)
                {
                    emp = employee;
                }
            }
            if (emp != null)
            {
                foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
                {
                    if (employee.ToString() == emp.ToString())
                    {
                        employee.IsActive = !employee.IsActive;
                        EmployeeManager.GetInstance().dataHelperEmployee.UpdateEmployee(employee);

                    }
                }
            }

            lbAllEmployees.Items.Clear();
            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
                lbAllEmployees.Items.Add(employee);
            }

            btnViewAll_Click(null, null);
        }

        private void CalendarSchedule_DateSelected(object sender, DateRangeEventArgs e)
        {
            UpdateSchedules();
        }

        private void ProcessThisTag(object sender, RFIDTagEventArgs e)
        {
            string name = null;

            tbRFIDSerial.Text = e.Tag.ToString();

            DateTime now = DateTime.Now;

            int nowHour = now.Hour;
            int nowMinute = now.Minute;
            bool morning = false;
            bool afternoon = false;
            bool evening = false;
            TimeSpan nowTime = new TimeSpan(nowHour, nowMinute, 0);
            TimeSpan endMorning = new TimeSpan(12, 30, 0);
            TimeSpan endEvening = new TimeSpan(21, 30, 0);

            int nowHou1r = endMorning.Hours;
            int qwecq = endMorning.Minutes;

            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
                if (employee.Rfid != null)
                {
                    if (employee.Rfid.ToString() == e.Tag.ToString())
                    {
                        int minsLate = 0;

                        name = employee.FirstName + " " + employee.LastName;
                        lbRFIDStatus.Items.Add($"Welcome, {name}, {now}");
                        MessageBox.Show($"{name} has arrived at work at {now}");

                        List<DayPlan> dayPlansToday = employee.GetDayPlansByDate(DateTime.Today);
                        DayPlan today = new DayPlan(DateTime.Today, employee.Id, 0, 0, 0);
                        foreach (DayPlan dayPlan in dayPlansToday)
                        {
                            if (dayPlan.Morning == 1)
                                today.Morning = 1;
                            if (dayPlan.Afternoon == 1)
                                today.Afternoon = 1;
                            if (dayPlan.Evening == 1)
                                today.Evening = 1;
                        }

                        if (today != null)
                        {
                            if (today.Morning == 1)
                            {
                                if (8 <= nowHour && nowTime <= endMorning)
                                {
                                    morning = true;
                                    minsLate = (nowHour - 8) * 60 + (nowMinute - 0);
                                    MessageBox.Show($"{name} is late for Morning schedule");
                                }
                                else
                                {
                                    MessageBox.Show($"{name} does not come for Monring schedule");
                                }
                            }
                            else if (today.Afternoon == 1)
                            {
                                if (endMorning < nowTime && nowHour < 17)
                                {
                                    afternoon = true;
                                    minsLate = (nowHour - 12) * 60 + (nowMinute - 30);
                                    MessageBox.Show($"{name} is late for Afternoon schedule");
                                }
                                else
                                {
                                    MessageBox.Show($"{name} does not come for Afternoon schedule");
                                }
                            }
                            else if (today.Evening == 1)
                            {
                                if (17 <= nowHour && nowTime <= endEvening)
                                {
                                    evening = true;
                                    minsLate = (nowHour - 17) * 60 + (nowMinute - 0);
                                    MessageBox.Show($"{name} is late for Evening schedule");
                                }
                                else
                                {
                                    MessageBox.Show($"{name} does not come for Evening schedule");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show($"{name} has no work today");
                        }
                        if (minsLate != 0)
                        {
                            foreach (DayPlan dayPlan in employee.GetDayPlans())
                            {
                                if (dayPlan.Morning == 1 && morning)
                                {
                                    dayPlan.MinsLate = minsLate;
                                }
                                else if (dayPlan.Afternoon == 1 && afternoon)
                                {
                                    dayPlan.MinsLate = minsLate;
                                }
                                else if (dayPlan.Evening == 1 && evening)
                                {
                                    dayPlan.MinsLate = minsLate;
                                }
                            }
                            EmployeeManager.GetInstance().dataHelperEmployee.SaveMinsLate(employee, minsLate);
                        }

                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                myRFIDReader.Close();
                lbRFIDStatus.Items.Add("closed");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("rfid not found");
            }
        }

        private void btnAssignRFID_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvEmployees2.CurrentRow.Cells[0].Value.ToString());

            Employee emp = null;

            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
                if (id == employee.Id)
                {
                    emp = employee;
                }
            }
            if (emp != null)
            {
                RFIDcontrol rfid = EmployeeManager.GetInstance().GetRFIDcontrolBySerial(tbRFIDSerial.Text);

                try
                {
                    if (!rfid.IsAssigned)
                    {
                        if (emp.Rfid != null)
                        {
                            emp.Rfid.IsAssigned = false; // previous rfid gets available again
                        }
                        emp.Rfid = rfid; // get new rfid number
                        rfid.IsAssigned = true; // make it unavailable
                        EmployeeManager.GetInstance().dataHelperEmployee.UpdateEmployee(emp);
                        MessageBox.Show($"{tbRFIDSerial.Text} is assigned to {emp.FirstName + " " + emp.LastName}");
                    }
                    else
                    {
                        MessageBox.Show("This RFID is already assigned");

                    }
                }

                catch (System.NullReferenceException ex)
                {
                    MessageBox.Show("This RFID is not assigned to list");
                }
            }
            refreshAllEmpDataGridView();
        }

        private void tabControlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            double avgMorning = 0;
            double avgAfternoon = 0;
            double avgEvening = 0;


            double totalNumber = EmployeeManager.GetInstance().GetEmployees().Count;

            lbAllEmployees3.Items.Clear();
            lbAllEmployees4.Items.Clear();
            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
                lbAllEmployees3.Items.Add(employee);
                lbAllEmployees4.Items.Add(employee);


                foreach (DayPlan dayPlan in employee.GetDayPlans())
                {
                    if (dayPlan.Morning == 1)
                    {
                        avgMorning++;
                    }
                    if (dayPlan.Afternoon == 1)
                    {
                        avgAfternoon++;
                    }
                    if (dayPlan.Evening == 1)
                    {
                        avgEvening++;
                    }
                }
            }

            avgMorning /= totalNumber;
            avgAfternoon /= totalNumber;
            avgEvening /= totalNumber;

            lblTotalNumberEmployee.Text = totalNumber.ToString();
            lblAverageShift.Text = $"Morning : {Math.Round(avgMorning, 2)}, Afternoon : {Math.Round(avgAfternoon, 2)}, Evening : {Math.Round(avgEvening, 2)}";

            cbSelectDept.Items.Clear();

            foreach (Department department in DepartmentManager.GetInstance().GetAllDepartments())
            {
                cbSelectDept.Items.Add(department);
            }
            lbNumberOfProducts.Text = Convert.ToString(depotStatistics.numberOfProducts());
            lbUnavailableProducts.Text = Convert.ToString(depotStatistics.numberOfUnavailableProducts());

            refreshAllEmpDataGridView();
            refreshPieChart();

        }


        public void WeeklyStatistics(string departmentName)
        {
            string message = "";

            doughnutWeekly1.Series.Clear();
            doughnutWeekly1.Titles.Clear();
            try
            {
                foreach (Department department in DepartmentManager.GetInstance().GetAllDepartments())
                {
                    if (department.Name == departmentName)
                    {
                        double countFte = department.calculateWeeklyFte(calendarDepartment.SelectionStart, EmployeeManager.GetInstance().GetEmployees());
                        message += $"{department.Name} from {department.FTE} required FTE" +
                            $" has {countFte} FTE completed \n";
                        doughnutWeekly1.Series.Add(department.Name);
                        doughnutWeekly1.Titles.Add(department.Name);
                        doughnutWeekly1.Series[department.Name].Points.AddXY("Required", department.FTE);
                        doughnutWeekly1.Series[department.Name].Points.AddXY("Completed", countFte);
                        doughnutWeekly1.Series[department.Name].ChartType = SeriesChartType.Doughnut;
                        doughnutWeekly1.Series[department.Name].IsValueShownAsLabel = true;

                    }
                }
            }
            catch
            {
                throw new Exception("Error retrieving the statistic data");
            }
            lblWeeklyDepartmentStatistics.Text = message;
        }

        private void btnUploadSerialNumber_Click(object sender, EventArgs e)
        {
            bool isExisted = true;
            if (EmployeeManager.GetInstance().GetRFIDcontrols().Count == 0)
            {
                EmployeeManager.GetInstance().AddRFID(new RFIDcontrol(tbRFIDSerial.Text, false));
                MessageBox.Show($"{tbRFIDSerial.Text} is uploaded");
            }
            else
            {
                foreach (RFIDcontrol rFIDcontrol in EmployeeManager.GetInstance().GetRFIDcontrols())
                {
                    if (rFIDcontrol.ToString() == tbRFIDSerial.Text)
                    {
                        MessageBox.Show("This serial number is already existed!");
                        isExisted = true;
                        break;
                    }
                    else
                    {
                        isExisted = false;
                    }
                }

                if (!isExisted)
                {
                    EmployeeManager.GetInstance().AddRFID(new RFIDcontrol(tbRFIDSerial.Text, false));
                    MessageBox.Show($"{tbRFIDSerial.Text} is uploaded");
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                myRFIDReader.Open();
            }
            catch (PhidgetException)
            {
                lbRFIDStatus.Items.Add("no RFID-reader opened???????????");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Rfid is not connected");
            }
        }

        private void lbAllEmployees3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee selectedEmployee = null;
            int totalLateMinutes = 0;
            int nowMonth = DateTime.Today.Month;

            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
                if (employee.ToString() == lbAllEmployees3.SelectedItem.ToString())
                {
                    selectedEmployee = employee;
                }
            }

            foreach (DayPlan dayplan in selectedEmployee.GetDayPlans())
            {
                if (nowMonth == dayplan.GetMonth())
                {
                    totalLateMinutes += dayplan.MinsLate;
                }
            }
            lblLateDescription.Text = $"{selectedEmployee} is late {totalLateMinutes / 3} mins in this month";
        }

        private void lbAllEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEmployee = lbAllEmployees.SelectedItem.ToString();
            if (selectedEmployee != null)
            {
                foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
                {
                    if (employee.ToString() == selectedEmployee)
                    {
                        if (employee.IsActive)
                        {
                            btnDeactivateEmployee.Text = "Deactivate Employee";
                        }
                        else
                        {
                            btnDeactivateEmployee.Text = "Activate Employee";
                        }
                    }
                }
            }
        }

        private void BtnAddReqFte_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvDepartments.CurrentRow.Cells[0].Value.ToString());

            Department dep = null;

            foreach (Department department1 in DepartmentManager.GetInstance().GetAllDepartments())
            {
                if (id == department1.Id)
                {
                    dep = department1;
                }
            }
            if (dep != null)
            {
                if (!string.IsNullOrEmpty(tbFteRequired.Text))
                {
                    dep.FTE = Convert.ToDouble(tbFteRequired.Text);
                }
                else
                {
                    MessageBox.Show("Insert FTE");
                }
            }
            refreshAllEmpDataGridView();
            DepartmentManager.GetInstance().dataHelperDepartment.UpdateDepartment(dep);

        }



        private void BtnCheckFte_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvDepartments.CurrentRow.Cells[0].Value.ToString());

            Department dep = null;

            foreach (Department department1 in DepartmentManager.GetInstance().GetAllDepartments())
            {
                if (id == department1.Id)
                {
                    dep = department1;
                }
            }
            if (dep != null)
            {
                double countFte = dep.calculateWeeklyFte(calendarDepartment.SelectionStart, EmployeeManager.GetInstance().GetEmployees());
                MessageBox.Show($"Department {dep.Name} from {dep.FTE} required FTE" +
                    $" has {countFte} FTE completed");
            }

        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
            }
        }

        private void refreshPieChart()
        {
            int undertime = 0;
            int exacttime = 0;
            int overtime = 0;
            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {

                if (Math.Round(employee.WeeklyActualFTE(DateTime.Now), 1) < Math.Round(employee.FteContract, 1))
                    undertime++;
                else if (Math.Round(employee.WeeklyActualFTE(DateTime.Now), 1) == Math.Round(employee.FteContract, 1))
                    exacttime++;
                else if (Math.Round(employee.WeeklyActualFTE(DateTime.Now), 1) > Math.Round(employee.FteContract, 1))
                    overtime++;
                else
                    MessageBox.Show("error weeklyfte compared with contract");
            }
            chartPie.Series["Number of shifts"].Points.Clear();
            chartPie.Series["Number of shifts"].IsValueShownAsLabel = true;
            chartPie.Series["Number of shifts"].Points.AddXY("Undertime", undertime);
            chartPie.Series["Number of shifts"].Points.AddXY("Exact hours", exacttime);
            chartPie.Series["Number of shifts"].Points.AddXY("Overtime", overtime);
        }
        private void refreshBarChart()
        {
            barChartProducts.Series.Clear();
            Series series = barChartProducts.Series.Add("Products");
            barChartProducts.Series["Products"].IsVisibleInLegend = false;
            barChartProducts.ChartAreas[0].AxisY.Title = "Product Quantity";
            Random rnd = new Random();
            foreach (Product product in depotStatistics.selectedCategoryProducts(cbCategory.SelectedItem.ToString()))
            {
                series.Points.AddXY(product.Name, product.QuantityWarehouse);
            }
            foreach (var p in barChartProducts.Series["Products"].Points)
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                p.Color = randomColor;
            }
        }

        private void updateStatisticLabels()
        {

            lbStatisticsProductTurnover.Text = "";
            lbUnavailablePS.Text = "";
            lbProductQuantity.Text = "";
        }

        private void dgvEmployees3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeManager.GetInstance().loadMinsLate();
            Employee emp = null;
            int id = Convert.ToInt32(dgvEmployees3.CurrentRow.Cells[0].Value.ToString());
            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
                if (id == employee.Id)
                {
                    emp = employee;
                }
            }
            if (emp != null)
            {
                int totalLateMinutes = 0;
                int nowMonth = DateTime.Today.Month;

                foreach (DayPlan dayplan in emp.GetDayPlans())
                {
                    if (nowMonth == dayplan.GetMonth())
                    {
                        totalLateMinutes += dayplan.MinsLate;
                    }
                }
                lblLateDescription.Text = $"{emp.FirstName + " " + emp.LastName} is late {totalLateMinutes} mins in this month";
            }
        }

        private void CbSelectDept_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbAllEmployees2.Items.Clear();

            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
                if (employee.Department == cbSelectDept.SelectedItem.ToString())
                    lbAllEmployees2.Items.Add(employee);
            }


        }

        private void btnRejectEmpAbs_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeAbsence abs;
                abs = EmployeeManager.GetInstance().returnEmployeeAbsenceById(Convert.ToInt32(dataGridViewEmpAbs.CurrentRow.Cells[0].Value.ToString()));
                if (abs.TicketStatus == "Pending")
                {
                    abs.TicketStatus = "Rejected";
                    EmployeeManager.GetInstance().UpdateEmployeeAbsence(abs);
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Please choose a ticket");
            }
            finally
            {
                UpdateEmpAbsDataGridView();
            }
        }

        private void btnAcceptEmpAbs_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeAbsence abs;
                abs = EmployeeManager.GetInstance().returnEmployeeAbsenceById(Convert.ToInt32(dataGridViewEmpAbs.CurrentRow.Cells[0].Value.ToString()));
                if (abs.TicketStatus == "Pending")
                {
                    abs.TicketStatus = "Accepted";
                    EmployeeManager.GetInstance().UpdateEmployeeAbsence(abs);
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Please choose a ticket");
            }
            finally
            {
                UpdateEmpAbsDataGridView();
            }
        }

        public void UpdateEmpAbsDataGridView()
        {
            dataGridViewEmpAbs.DataSource = null;
            dataGridViewEmpAbs.DataSource = EmployeeManager.GetInstance().GetEmployeeAbsences();
            this.ResizeDataGridColumn(dataGridViewEmpAbs, 0, 25);
        }

        private void btnRefreshEmpAbsDataGridView_Click(object sender, EventArgs e)
        {
            EmployeeManager.GetInstance().loadAbsences();
            UpdateEmpAbsDataGridView();
        }


        private void btnChangeDepartmentName_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvDepartments.CurrentRow.Cells[0].Value.ToString());

            Department dep = null;

            foreach (Department department1 in DepartmentManager.GetInstance().GetAllDepartments())
            {
                if (id == department1.Id)
                {
                    dep = department1;
                }
            }
            if (dep != null)
            {
                dep.Name = tbDepartmentName.Text;
            }
            DepartmentManager.GetInstance().dataHelperDepartment.UpdateDepartment(dep);
            refreshAllEmpDataGridView();
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvDepartments.CurrentRow.Cells[0].Value.ToString());

            Department dep = null;

            foreach (Department department1 in DepartmentManager.GetInstance().GetAllDepartments())
            {
                if (id == department1.Id)
                {
                    dep = department1;
                }
            }
            if (dep != null)
            {
                for (int i = DepartmentManager.GetInstance().GetAllDepartments().Count - 1; i >= 0; i--)
                {
                    if (DepartmentManager.GetInstance().GetAllDepartments()[i].Id == id)
                    {
                        DepartmentManager.GetInstance().dataHelperDepartment.RemoveDepartment(DepartmentManager.GetInstance().GetAllDepartments()[i]);
                        DepartmentManager.GetInstance().GetAllDepartments().Remove(DepartmentManager.GetInstance().GetAllDepartments()[i]);
                    }
                }
            }
            refreshAllEmpDataGridView();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                cbCategoryProducts.DataSource = null;
                cbCategoryProducts.ValueMember = "Id";
                cbCategoryProducts.DisplayMember = "Name";
                cbCategoryProducts.DataSource = depotStatistics.selectedCategoryProducts(cbCategory.SelectedItem.ToString());
                refreshBarChart();
            }
            catch { }

        }

        private Product passedProduct() //selected 
        {

            Product productHere = null;
            if (Convert.ToInt32(cbCategory.SelectedValue) != null)
            {

                if (cbCategoryProducts.SelectedValue != null)
                {
                    productHere = Product_Manager.GetInstance().GetProductById(Convert.ToInt32(cbCategoryProducts.SelectedValue));

                    return productHere;
                }
            }
            return productHere;


        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) // If the tab index is changed it will update combobox
        {

            cbStatisticDepartment.DataSource = null;

            cbStatisticDepartment.ValueMember = "Id";
            cbStatisticDepartment.DisplayMember = "Name";
            cbStatisticDepartment.DataSource = DepartmentManager.GetInstance().Departments;
        }



        private void cbStatisticDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string description = "";
                string departmentName = cbStatisticDepartment.SelectedItem.ToString();
                if (departmentName != null)
                {
                    foreach (Department dep in DepartmentManager.GetInstance().Departments)
                    {
                        if (cbStatisticDepartment.SelectedItem.ToString() == dep.Name.ToString())
                            description += $"Number of employees in {dep.Name} : {dep.trackEmployees(EmployeeManager.GetInstance().GetEmployees())}  ";

                    }
                    WeeklyStatistics(departmentName);
                }

                lblNumberOfEmployeesPerDepartments.Text = description;
            }
            catch (Exception ex) { throw ex; }
            refreshAllEmpDataGridView();
        }

        private void cbCategoryProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {

                Product product = passedProduct();


                lbProductQuantity.Text = product.QuantityWarehouse.ToString();
                lbUnavailablePS.Text = product.QuantityShelf.ToString();
                lbStatisticsProductTurnover.Text = $"{depotStatistics.calculateTurnover(product)} € ";

            }
            catch (System.NullReferenceException)
            {
                updateStatisticLabels();
                MessageBox.Show("There is no products");
            }

        }
        #region navigation buttons events
        private void btnNavManageEmp_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = tabControlAdmin.TabPages[0];
        }

        private void btnNavSchedule_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = tabControlAdmin.TabPages[1];
        }

        private void btnNavStatistics_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = tabControlAdmin.TabPages[2];
        }

        private void btnNavAttendance_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = tabControlAdmin.TabPages[3];
        }

        private void btnNavDepartments_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = tabControlAdmin.TabPages[4];
        }

        private void btnNavRfid_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = tabControlAdmin.TabPages[5];
        }

        private void btnNavLateCheck_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = tabControlAdmin.TabPages[6];
        }

        private void btnNavEmpAbsence_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = tabControlAdmin.TabPages[7];
        }
        #endregion



        private void BtnAutoNormalSchedule_Click(object sender, EventArgs e)
        {

            try
            {
                double fteConstraint = Convert.ToDouble(cbWorktime.SelectedItem.ToString());
                bool respectDesiredDays;
                if (chkRespectDays.Checked)
                    respectDesiredDays = true;
                else
                    respectDesiredDays = false;
                BaseScheduling baseScheduling = new BaseScheduling(new List<IConstraintStrategy>() { new FteConstraint(fteConstraint), new WorkdayConstraint(respectDesiredDays) });
                baseScheduling.AssignEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAutoDeassign_Click(object sender, EventArgs e)
        {
            BaseScheduling baseScheduling = new BaseScheduling();
            baseScheduling.DeassignEmployees();
        }

        private void WeeklyReportButton_Click_1(object sender, EventArgs e)
        {
            EmployeeManager.GetInstance().fileManagerEmployee.SaveEmployeeData(EmployeeManager.GetInstance().GetEmployees(), EmployeeManager.GetInstance().GetEmployeeAbsences());
        }
    }
}

