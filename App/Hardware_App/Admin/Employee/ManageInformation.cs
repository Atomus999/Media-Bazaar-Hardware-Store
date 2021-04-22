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
    public partial class ManageInformation : Form
    {

        public delegate void UpdateEmpListboxHandler();
        public event UpdateEmpListboxHandler ListboxUpdatedEvent;

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

        private List<CustomTextbox> customTextboxes = new List<CustomTextbox>();
        private List<Panel> panels = new List<Panel>();

        private void AddPanels()
        {
            panels.Add(panelShadowEmpGen);
            panels.Add(panelEmpGen);
            panels.Add(panelShadowEmpLoginInfo);
            panels.Add(panelEmpLoginInfo);
            panels.Add(panelShadowWorkDays);
            panels.Add(panelWorkDays);
        }
        private void AddTextBoxes()
        {
            customTextboxes.Add(tbEmpId);
            customTextboxes.Add(tbFirstName);
            customTextboxes.Add(tbLastName);
            customTextboxes.Add(tbPhoneNumber);
            customTextboxes.Add(tbBSN);
            customTextboxes.Add(tbEmail);
            customTextboxes.Add(tbAddress);
            customTextboxes.Add(tbContractFte);
            customTextboxes.Add(tbUsername);
            customTextboxes.Add(tbPassword);
            customTextboxes.Add(tbRFID);
        }

        private void RoundTextBoxes(int nWidthEllipse, int nHeightEllipse)
        {
            this.AddTextBoxes();
            foreach (Control c in customTextboxes)
            {
                c.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, nWidthEllipse, nHeightEllipse));
                ((CustomTextbox)c).TextColor = Color.FromArgb(31, 31, 31);
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

        #endregion
        public CustomTextbox TbEmpId { get; set; }
        public CustomTextbox TbFirstName { get; set; }
        public CustomTextbox TbLastName { get; set; }
        public ComboBox CbDepartment { get; set; }
        public CustomTextbox TbPhoneNumber { get; set; }
        public CustomTextbox TbBSN { get; set; }
        public CustomTextbox TbEmail { get; set; }
        public CustomTextbox TbAddress { get; set; }
        public CustomTextbox TbContactFTE { get; set; }
        public CustomTextbox TbUsername { get; set; }
        public CustomTextbox TbPassword { get; set; }
        public CustomTextbox TbRFID { get; set; }
        public XanderUI.XUICheckBox ChkMonday { get; set; }
        public XanderUI.XUICheckBox ChkTuesday { get; set; }
        public XanderUI.XUICheckBox ChkWednesday { get; set; }
        public XanderUI.XUICheckBox ChkThursday { get; set; }
        public XanderUI.XUICheckBox ChkFriday { get; set; }
        public XanderUI.XUICheckBox ChkSaturday { get; set; }
        public XanderUI.XUICheckBox ChkSunday { get; set; }


        private void CallListboxUpdateEvent()
        {
            if (ListboxUpdatedEvent != null)
                ListboxUpdatedEvent();
        }

        private SpouseInformation spouseInformation;

        public XanderUI.XUIButton btnCreate { get { return btnAddEmployee; } }
        public XanderUI.XUIButton btnChange { get { return btnChangeEmpData; } }
        public XanderUI.XUIButton btnSpouse { get { return btnAddSpouse; } }

        public ManageInformation()
        {
            InitializeComponent();
            TbEmpId = tbEmpId;
            TbFirstName = tbFirstName;
            TbLastName = tbLastName;
            CbDepartment = cbDepartment;
            TbPhoneNumber = tbPhoneNumber;
            TbBSN = tbBSN;
            TbEmail = tbEmail;
            TbAddress = tbAddress;
            TbContactFTE = tbContractFte;
            TbUsername = tbUsername;
            TbPassword = tbPassword;
            TbRFID = tbRFID;
            ChkMonday = chkMonday;
            ChkTuesday = chkTuesday;
            ChkWednesday = chkWednesday;
            ChkThursday = chkThursday;
            ChkFriday = chkFriday;
            ChkSaturday = chkSaturday;
            ChkSunday = chkSunday;
            this.RoundTextBoxes(5, 5);
            this.RoundPanels(20, 20);
            spouseInformation = new SpouseInformation(this);
        }

        private void setWorkingDays(Employee employee)
        {
            if (chkMonday.Checked)
                employee.ScheduleDays.Monday = true;
            else
                employee.ScheduleDays.Monday = false;

            if (chkTuesday.Checked)
                employee.ScheduleDays.Tuesday = true;
            else
                employee.ScheduleDays.Tuesday = false;

            if (chkWednesday.Checked)
                employee.ScheduleDays.Wednesday = true;
            else
                employee.ScheduleDays.Wednesday = false;

            if (chkThursday.Checked)
                employee.ScheduleDays.Thursday = true;
            else
                employee.ScheduleDays.Thursday = false;

            if (chkFriday.Checked)
                employee.ScheduleDays.Friday = true;
            else
                employee.ScheduleDays.Friday = false;

            if (chkSaturday.Checked)
                employee.ScheduleDays.Saturday = true;
            else
                employee.ScheduleDays.Saturday = false;

            if (chkSunday.Checked)
                employee.ScheduleDays.Sunday = true;
            else
                employee.ScheduleDays.Sunday = false;
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = true;
                int id = Convert.ToInt32(tbEmpId.Text);
                foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
                {
                    if(employee.Id == id)
                    {
                        MessageBox.Show("This ID already exists");
                        ok = false;
                    }
                }
                if (ok)
                {
                    string firstName = tbFirstName.Text;
                    string lastName = tbLastName.Text;
                    string department = cbDepartment.SelectedItem.ToString();
                    DateTime dateOfBirth = datetimeDateOfBirth.Value;
                    double bsn = Convert.ToDouble(tbBSN.Text);
                    string phoneNumber = tbPhoneNumber.Text;
                    string address = tbAddress.Text;
                    string email = tbEmail.Text;
                    string userName = tbUsername.Text;
                    string password = tbPassword.Text;
                    double fte = Convert.ToDouble(tbContractFte.Text);                    
                    Employee emp = new Employee(id, firstName, lastName, department, dateOfBirth, bsn, phoneNumber,
                        address, email, userName, password, fte);
                    setWorkingDays(emp);
                    EmployeeManager.GetInstance().AddEmployee(emp);
                    EmployeeManager.GetInstance().dataHelperEmployee.saveWorkingDay(emp);
                }
            }
            catch (PhoneNumberException ex) { MessageBox.Show("Wrong Phone number format"); }
            catch (Exception ex) { MessageBox.Show("Please write valid information"); }

            CallListboxUpdateEvent();
        }
        
        public void UpdateDepartments()
        {
            cbDepartment.Items.Clear();
          
            foreach(Department department in DepartmentManager.GetInstance().Departments)
            {
                cbDepartment.Items.Add(department);
            }
        }

        private void refreshBoxes(Employee employee)
        {
            tbEmpId.Text = employee.Id.ToString();
            tbFirstName.Text = employee.FirstName;
            tbLastName.Text = employee.LastName;
            cbDepartment.SelectedItem = employee.Department;
            cbDepartment.SelectedIndex = cbDepartment.FindStringExact(employee.Department);
            datetimeDateOfBirth.Value = employee.DateOfBirth;
            tbBSN.Text = employee.Bsn.ToString();
            tbPhoneNumber.Text = employee.PhoneNumber;
            tbAddress.Text = employee.Address;
            tbEmail.Text = employee.Email;
            tbUsername.Text = employee.UserName;
            tbPassword.Text = employee.Password;
            tbContractFte.Text = employee.FteContract.ToString();
            chkMonday.Checked = employee.ScheduleDays.Monday;
            chkTuesday.Checked = employee.ScheduleDays.Tuesday;
            chkWednesday.Checked = employee.ScheduleDays.Wednesday;
            chkThursday.Checked = employee.ScheduleDays.Thursday;
            chkFriday.Checked = employee.ScheduleDays.Friday;
            chkSaturday.Checked = employee.ScheduleDays.Saturday;
            chkSunday.Checked = employee.ScheduleDays.Sunday;
        }

        private void btnChangeEmpData_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach(Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
                if (employee.FirstName == tbFirstName.Text && employee.LastName == tbLastName.Text && employee.UserName == tbUsername.Text && employee.Password == tbPassword.Text)
                {
                    if (string.IsNullOrEmpty(cbDepartment.SelectedItem.ToString()))
                    {
                        message += "Department has not been changed\r\n";
                    }
                    else
                    {
                        employee.Department = cbDepartment.SelectedItem.ToString();
                        message += $"Department has been changed to {cbDepartment.SelectedItem.ToString()}\r\n";
                    }

                    if (string.IsNullOrEmpty(tbContractFte.Text))
                    {
                        message += "Working FTE has not been changed\r\n";
                    }
                    else
                    {
                        employee.FteContract = Convert.ToDouble(tbContractFte.Text);
                        message += $"FTE has been changed to {Convert.ToDouble(tbContractFte.Text)}\r\n";
                    }
                    if (string.IsNullOrEmpty(tbPhoneNumber.Text))
                    {
                        message += "Phonenumber has not been changed\r\n";
                    }
                    else
                    {
                        string oldPhoneNumber = employee.PhoneNumber;
                        employee.PhoneNumber = tbPhoneNumber.Text;
                        if(oldPhoneNumber != employee.PhoneNumber)
                        {
                            message += $"Phonenumber has been changed to {employee.PhoneNumber}\r\n";
                        }
                        else
                        {
                            message += "Phonenumber has not been changed(Format incorrect)\r\n";
                        }
                        
                    }

                    if (string.IsNullOrEmpty(tbAddress.Text))
                    {
                        message += "Address has not been changed\r\n";
                    }
                    else
                    {
                        employee.Address = tbAddress.Text;
                        message += $"Address has been changed to {tbAddress.Text}\r\n";
                    }
                    
                    setWorkingDays(employee);
                    EmployeeManager.GetInstance().dataHelperEmployee.UpdateEmployee(employee);
                    EmployeeManager.GetInstance().dataHelperEmployee.UpdateWorkingDays(employee);
                    refreshBoxes(employee);
                }
                
            }
            MessageBox.Show(message);
            
        }

        private void ManageInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnAddSpouse_Click(object sender, EventArgs e)
        {
            bool hasSpouse = false;
            Employee employee = null;
            foreach (Employee emp in EmployeeManager.GetInstance().GetEmployees())
            {
                if (!string.IsNullOrEmpty(tbEmpId.Text))
                {
                    if (emp.Id == Convert.ToInt32(tbEmpId.Text))
                    {
                        if (emp.SetSpouse != null)
                        {
                            employee = emp;
                            hasSpouse = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please write employee information first!");
                }
            }

            if (hasSpouse)
            {
                foreach (Spouse spo in EmployeeManager.GetInstance().GetSpouses())
                {
                    if (employee.Id == spo.EmpID)
                    {
                        spouseInformation.TbEmpId.Text = employee.Id.ToString();
                        spouseInformation.TbFirstName.Text = spo.FirstName;
                        spouseInformation.TbLastName.Text = spo.LastName;
                        spouseInformation.TbPhoneNumber.Text = spo.PhoneNumber;
                        spouseInformation.BtnAddSpouse.Visible = false;
                        spouseInformation.BtnChangeSpouseData.Visible = true;
                        spouseInformation.lblAlert.Visible = true;
                        spouseInformation.Show();
                    }
                }
            }
            else
            {
                spouseInformation.TbEmpId.Text = tbEmpId.Text;
                spouseInformation.TbFirstName.Clear();
                spouseInformation.TbLastName.Clear();
                spouseInformation.TbPhoneNumber.Clear();
                spouseInformation.BtnAddSpouse.Visible = true;
                spouseInformation.BtnChangeSpouseData.Visible = false;
                spouseInformation.lblAlert.Visible = false;
                spouseInformation.Show();
            }
            
        }
    }
}
