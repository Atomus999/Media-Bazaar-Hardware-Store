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
    public partial class SpouseInformation : Form
    {
        ManageInformation manageInformation;

        public CustomTextbox TbEmpId { get; set; }
        public CustomTextbox TbFirstName { get; set; }
        public CustomTextbox TbLastName { get; set; }
        public CustomTextbox TbPhoneNumber { get; set; }
        public XanderUI.XUIButton BtnAddSpouse { get; set; }
        public XanderUI.XUIButton BtnChangeSpouseData { get; set; }


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
            customTextboxes.Add(tbEmpId);
            customTextboxes.Add(tbFirstName);
            customTextboxes.Add(tbLastName);
            customTextboxes.Add(tbPhoneNumber);
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

        #endregion
        public SpouseInformation(ManageInformation manageInformation)
        {
            InitializeComponent();
            TbEmpId = tbEmpId;
            TbFirstName = tbFirstName;
            TbLastName = tbLastName;
            TbPhoneNumber = tbPhoneNumber;
            BtnAddSpouse = btnAddSpouse;
            BtnChangeSpouseData = btnChangeSpouseData;
            this.RoundTextBoxes(5, 5);
            TbEmpId.ReadOnly = true;
            this.manageInformation = manageInformation;
        }

        private void btnAddSpouse_Click(object sender, EventArgs e)
        {
            try
            { 
                int empid = Convert.ToInt32(tbEmpId.Text);
                string firstName = tbFirstName.Text;
                string lastName = tbLastName.Text;
                string phoneNumber = tbPhoneNumber.Text;
                Spouse spouse = new Spouse(empid, firstName, lastName, phoneNumber);
                EmployeeManager.GetInstance().dataHelperSpouse.AddSpouse(spouse);
                foreach (Employee emp in EmployeeManager.GetInstance().GetEmployees())
                {
                    if(empid == emp.Id)
                    {
                        emp.SetSpouse = spouse;
                        EmployeeManager.GetInstance().dataHelperEmployee.UpdateEmployee(emp);
                    }
                }
            }
            catch (PhoneNumberException ex) { MessageBox.Show("Wrong Phone number format"); }
            catch (Exception ex) { MessageBox.Show("Please write valid information"); }
        }

        private void SpouseInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnChangeSpouseData_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach (Spouse spo in EmployeeManager.GetInstance().GetSpouses())
            {
                if (spo.FirstName == tbFirstName.Text && spo.LastName == tbLastName.Text)
                {
                    if (string.IsNullOrEmpty(tbPhoneNumber.Text))
                    {
                        message += "Phonenumber has not been changed\r\n";
                    }
                    else
                    {
                        string oldPhoneNumber = spo.PhoneNumber;
                        spo.PhoneNumber = tbPhoneNumber.Text;
                        if (oldPhoneNumber != spo.PhoneNumber)
                        {
                            message += $"Phonenumber has been changed to {spo.PhoneNumber}\r\n";
                        }
                        else
                        {
                            message += "Phonenumber has not been changed(Format incorrect)\r\n";
                        }

                    }
                    EmployeeManager.GetInstance().dataHelperSpouse.UpdateSpouse(spo);
                }

            }
            MessageBox.Show(message);
        }
    }
}
