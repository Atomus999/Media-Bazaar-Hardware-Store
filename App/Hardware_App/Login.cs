using Hardware_App.Admin;
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
    public partial class loginForm : Form
    {
        ManageEmployee manageEmployee;
        Depotworker depotworker;
        SalesRepresentative salesRepresentative;
        ChooseRole chooseRole;

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

        private void AddTextBoxes()
        {
            customTextboxes.Add(tbUsername);
            customTextboxes.Add(tbPassword);
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

        public loginForm()
        {
            InitializeComponent();
            this.RoundTextBoxes(5, 5);
            tbUsername.TextColor = Color.FromArgb(31, 31, 31);
            tbPassword.TextColor = Color.FromArgb(31, 31, 31);
            manageEmployee = new ManageEmployee();
            depotworker = new Depotworker(manageEmployee);
            salesRepresentative = new SalesRepresentative(depotworker);
            chooseRole = new ChooseRole(manageEmployee,depotworker,salesRepresentative);
            EmployeeManager.GetInstance().loadSpouses();
            EmployeeManager.GetInstance().loadEmployees();
            Product_Manager.GetInstance().loadProducts(EmployeeManager.GetInstance().GetEmployees());
            depotworker.Ticket_Manager.loadTickets(Product_Manager.GetInstance().GetProductList());
            EmployeeManager.GetInstance().loadAbsences();
            EmployeeManager.GetInstance().loadFtes();
            EmployeeManager.GetInstance().loadSchedules();
            EmployeeManager.GetInstance().loadWorkingDays();
            EmployeeManager.GetInstance().loadMinsLate();

            depotworker.Ticket_Manager.dataHelperTicket.assignId();
            Product_Manager.GetInstance().dataHelperProduct.assignId();
            DepartmentManager.GetInstance().LoadDepartments();
            DepartmentManager.GetInstance().LoadDepReqEmp();
            timerDatabase.Start();
            manageEmployee.UpdateSchedules();
            manageEmployee.refreshAllEmpListbox();
            depotworker.UpdateProductList();
            manageEmployee.refreshAllEmpDataGridView();
            manageEmployee.UpdateEmpAbsDataGridView();
            salesRepresentative.updateCombobox();
            depotworker.UpdateTicketRequestsDepo();
            salesRepresentative.UpdateSalesActiveTicketDataGridView();
            salesRepresentative.UpdateSalesInactiveTicketDataGridView();
            foreach (Employee emp in EmployeeManager.GetInstance().GetEmployees())
            {
                EmployeeManager.GetInstance().AddRFID(emp.Rfid);
            }

            //Statistics//
            
            manageEmployee.depotStatistics = new DepotStatisticsManager();
            manageEmployee.depotStatistics.ticketManager = depotworker.Ticket_Manager;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int userExists = 0;
            
            foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            {
                if (tbUsername.Text == employee.UserName)
                {
                    userExists = 1;
                    if (tbPassword.Text == employee.Password)
                    {
                        if (employee.IsActive)
                        {
                            switch (employee.Department)
                            {
                                case "Administration":
                                    manageEmployee.Show();
                                    break;
                                case "Depot worker":
                                    depotworker.Show();
                                    break;
                                case "Sales representative":
                                    salesRepresentative.Show();
                                    break;
                                case "Special":
                                    chooseRole.Show();
                                    break;
                                default:
                                    break;
                            }
                            manageEmployee.reference = this;
                            depotworker.reference = this;
                            salesRepresentative.reference = this;
                            this.Hide();
                        }
                        else
                            MessageBox.Show("employee is deactivated");
                    }
                    else
                        MessageBox.Show("wrong password");
                }
            }
            if (userExists == 0)
                MessageBox.Show("Username doesn't exist");
        }

        private void timerDatabase_Tick(object sender, EventArgs e)
        {
            EmployeeManager.GetInstance().loadEmployees();
            EmployeeManager.GetInstance().loadFtes();
            EmployeeManager.GetInstance().loadMinsLate();
            EmployeeManager.GetInstance().loadSchedules();
            EmployeeManager.GetInstance().loadWorkingDays();
            EmployeeManager.GetInstance().loadAbsences();
            DepartmentManager.GetInstance().LoadDepartments();
            DepartmentManager.GetInstance().LoadDepReqEmp();

            Product_Manager.GetInstance().loadProducts(EmployeeManager.GetInstance().GetEmployees());
            depotworker.Ticket_Manager.loadTickets(Product_Manager.GetInstance().GetProductList());

        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerDatabase.Stop();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '●';
            }
        }
        public void clearLogInWindows()
        {
            tbUsername.Clear();
            tbPassword.Clear();
        }
    }
}
