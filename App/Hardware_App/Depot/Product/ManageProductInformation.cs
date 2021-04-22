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
    public partial class ManageProductInformation : Form
    {
        Depotworker depotworker;
        ManageEmployee manageEmployee;
        public ManageProductInformation()
        {
            InitializeComponent();
        }

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
        private List<CustomTextbox> customTextboxes = new List<CustomTextbox>();
        private void AddListboxes()
        {
            listBoxes.Add(lbRegEmployees);
        }

        private void AddTextBoxes()
        {
            customTextboxes.Add(tbProductId);
            customTextboxes.Add(tbName);
            customTextboxes.Add(tbModel);
            customTextboxes.Add(tbBrand);
            customTextboxes.Add(tbPrice);
            customTextboxes.Add(tbWidth);
            customTextboxes.Add(tbHeight);
            customTextboxes.Add(tbWeight);
            customTextboxes.Add(tbDepth);
            customTextboxes.Add(tbProductQtyShelf);
            customTextboxes.Add(tbBarcode);
        }


        private void RoundListBoxes(int nWidthEllipse, int nHeightEllipse)
        {
            this.AddListboxes();
            foreach (Control c in listBoxes)
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

        public ManageProductInformation(Depotworker dp, ManageEmployee manageEmployee)
        {
            InitializeComponent();
            this.depotworker = dp;
            this.manageEmployee = manageEmployee;
            UpdateEmployeeList();
            numAisle.Maximum = Int32.MaxValue;
            numericWhQty.Maximum = Int32.MaxValue;
            cbCategory.DataSource = Enum.GetValues(typeof(ProductCategory));
            cbCategory.SelectedIndex = 0;
            this.RoundListBoxes(10, 10);
            this.RoundTextBoxes(5, 5);
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string model = tbModel.Text;
                string brandName = tbBrand.Text;
                float price = float.Parse(tbPrice.Text);
                string description = tbDescription.Text;
                double weight = Convert.ToDouble(tbWeight.Text);
                double height = Convert.ToDouble(tbHeight.Text);
                double width = Convert.ToDouble(tbWeight.Text);
                double depth = Convert.ToDouble(tbDepth.Text);
                string category = cbCategory.SelectedItem.ToString();
                int aisleNumber = Convert.ToInt32(numAisle.Value);
                int qtyWh = Convert.ToInt32(numericWhQty.Value);
                DateTime shipmentDate = datetimeShipmentDate.Value;
                ProductState state = ProductState.AVAILABLE;
                string selectedEmployee = lbRegEmployees.SelectedItem.ToString();
                string name = tbName.Text;
                string barcode = tbBarcode.Text;
                if(string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(brandName) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(brandName) || string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Input can not be empty");
                }
                else
                {
                        foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
                        {
                            if (employee.EmployeeInformation() == selectedEmployee)
                            {
                            Product_Manager.GetInstance().dataHelperProduct.assignId();
                            Product_Manager.GetInstance().AddProduct(new Product(model, brandName, price, description, weight, height, width, depth, category, aisleNumber, qtyWh, 0, shipmentDate, employee, state, name, barcode));
                                depotworker.UpdateProductList();
                                depotworker.salesReference.updateCombobox();
                                this.Close();
                            }
                        }
                
                }
                
            }
            catch (BarcodeException)
            {
                MessageBox.Show("Barcode must contain 13 digits");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input\r\n"+"error: "+ex.Message);
            }
            depotworker.salesReference.updateCombobox();
        }

        public void UpdateEmployeeList()
        {
            lbRegEmployees.Items.Clear();
            List<Employee> depoWorkes = EmployeeManager.GetInstance().GetEmployeesByDepartment("Depot worker");
            foreach (Employee employee in depoWorkes)
            {
                if(employee.IsActive == true)
                {
                    lbRegEmployees.Items.Add(employee);
                }
                
            }
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbProductId.Text);
                string model = tbModel.Text;
                string brandName = tbBrand.Text;
                float price = float.Parse(tbPrice.Text);
                string description = tbDescription.Text;
                double weight = Convert.ToDouble(tbWeight.Text);
                double height = Convert.ToDouble(tbHeight.Text);
                double width = Convert.ToDouble(tbWeight.Text);
                double depth = Convert.ToDouble(tbDepth.Text);
                string category = cbCategory.SelectedItem.ToString();
                int aisleNumber = Convert.ToInt32(numAisle.Value);
                int qtyWh = Convert.ToInt32(numericWhQty.Value);
                int qtySh = Convert.ToInt32(tbProductQtyShelf.Text);
                DateTime shipmentDate = datetimeShipmentDate.Value;
                ProductState state;
                string selectedEmployee = lbRegEmployees.SelectedItem.ToString();
                string name = tbName.Text.ToString();
                string barcode = tbBarcode.Text.ToString();

                if (string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(brandName) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(brandName) || string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Input can not be empty");
                }
                else
                {
                    foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
                    {
                        if (employee.EmployeeInformation() == selectedEmployee)
                        {
                            if (checkbMakePAvailable.Checked)
                            {
                                state = ProductState.AVAILABLE;
                                Product_Manager.GetInstance().UpdateProduct(id, model, brandName, price, description, weight, height, width, depth, category, aisleNumber, qtyWh, qtySh, shipmentDate, employee, state, name, barcode);
                                depotworker.UpdateProductList();
                                depotworker.salesReference.updateCombobox();
                                depotworker.Show();
                                this.Close();
                            }
                            else
                            {
                                state = ProductState.UNAVAILABLE;
                                Product_Manager.GetInstance().UpdateProduct(id, model, brandName, price, description, weight, height, width, depth, category, aisleNumber, qtyWh, qtySh, shipmentDate, employee, state, name, barcode);
                                depotworker.UpdateProductList();
                                depotworker.salesReference.updateCombobox();
                                depotworker.Show();
                                this.Close();
                            }

                        }
                    }
                }

            }
            catch (BarcodeException)
            {
                MessageBox.Show("Barcode must contain 13 digits");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input \r \n" + "Error: " + ex.Message);
            }
        }

        private void ManageProductInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            depotworker.Show();
        }

        public void UpdateFields(int id, string model, string brandName, string price, string description, string weight, string height, string width, string depth, int aisleNumber, int qtyWh, int qtySh, DateTime shipmentDate, ProductState state, string name, string barcode)
        {
            tbModel.Text = model;
            tbBrand.Text = brandName;
            tbPrice.Text = price;
            tbDescription.Text = description;
            tbWeight.Text = weight;
            tbHeight.Text = height;
            tbWidth.Text = width;
            tbDepth.Text = depth;
            numAisle.Value = aisleNumber;
            numericWhQty.Value = qtyWh;
            datetimeShipmentDate.Value = shipmentDate;
            tbName.Text = name;
            tbBarcode.Text = barcode;
            tbProductQtyShelf.Visible = true;
            tbProductQtyShelf.Text = qtySh.ToString();
            tbProductQtyShelf.Location = numericShelfQty.Location;
            tbProductQtyShelf.ReadOnly = true;
            numericShelfQty.Visible = false;
            tbProductId.Visible = true;
            tbProductId.Text = id.ToString();
            tbProductId.ReadOnly = true;
            btnCreateProduct.Visible = false;
            labelid.Visible = true;
            if (state == ProductState.UNAVAILABLE)
            {
                checkbMakePAvailable.Visible = true;
                checkbMakePAvailable.Checked = false;
            }
            else 
            {
                checkbMakePAvailable.Checked = true;
                checkbMakePAvailable.Visible = false;
            } 
        }
    }
}
