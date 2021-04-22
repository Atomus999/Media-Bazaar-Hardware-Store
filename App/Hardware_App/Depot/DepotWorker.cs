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
    public partial class Depotworker : Form
    {
        ManageEmployee manageEmployee;
        Ticket_Manager ticket_Manager;

        public Ticket_Manager Ticket_Manager
        {
            get { return this.ticket_Manager; }
            set { this.ticket_Manager = value; }
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

        private List<Panel> panels = new List<Panel>();
        private List<CustomTextbox> customTextboxes = new List<CustomTextbox>();

        private void AddPanels()
        {
            //search
            panels.Add(panelShadowSearch);
            panels.Add(panelSearch);
        }

        private void AddTextBoxes()
        {
            customTextboxes.Add(tbSearchProduct);
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

        public Depotworker()
        {
            InitializeComponent();
        }
        public Depotworker(ManageEmployee manageEmployee)
        {
            InitializeComponent();
            this.manageEmployee = manageEmployee;
            Product_Manager productManager = Product_Manager.GetInstance();
            ticket_Manager = new Ticket_Manager();
            this.RoundPanels(15, 15);
            this.RoundTextBoxes(5, 5);
        }
        public loginForm reference { get; set; }

        public SalesRepresentative salesReference { get; set; }
        private void Depotworker_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            reference.Show();
            reference.clearLogInWindows();
        }

        private void ResizeDataGridColumn(DataGridView dgv, int index, int width)
        {
            dgv.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns[index].Width = width;
        }

        public void UpdateProductList()
        {
            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = Product_Manager.GetInstance().GetProductsDataTable();
            this.ResizeDataGridColumn(dataGridViewProducts, 0, 25);
        }

        public void UpdateTicketRequestsDepo()
        {
            dataGridViewDepoTicketReq.DataSource = null;
            dataGridViewDepoTicketReq.DataSource = ticket_Manager.GetActiveTicketsDataTable();
            this.ResizeDataGridColumn(dataGridViewDepoTicketReq, 0, 25);
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            ManageProductInformation manageProduct = new ManageProductInformation(this, manageEmployee);
            foreach (Control c in manageProduct.Controls)
            {
                if (c.Name == "btnModifyProduct")
                {
                    c.Visible = false;
                }
                if (c.Name == "checkbMakePAvailable")
                {
                    c.Visible = false;
                }
                if (c.Name == "numericShelfQty")
                {
                    c.Visible = false;
                }
                if (c.Name == "labelQtyShelf")
                {
                    c.Visible = false;
                }

            }
            manageProduct.Show();
        }

        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            try
            {
                int selecteProductId = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[0].Value.ToString());
                Product product = Product_Manager.GetInstance().GetProductById(selecteProductId);
                if (product.State != ProductState.UNAVAILABLE)
                {
                    MessageBox.Show("The product state must be unavailable before permanently removing");
                }
                else
                {
                    var confirmResult = MessageBox.Show("The following action will permanently remove the product\r\n Would you like to proceed?", "Remove confirmation", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {

                        try
                        {
                            Product_Manager.GetInstance().RemoveProductById(selecteProductId);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Removing product failed\r\n" + ex.Message);
                        }
                        finally
                        {
                            UpdateProductList();
                            salesReference.updateCombobox();
                        }

                    }
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Select a product from the list");
            }

        }

        private void btnDeactivateStock_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedProductId = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[0].Value.ToString());
                Product p = Product_Manager.GetInstance().GetProductById(selectedProductId);
                Product_Manager.GetInstance().DeactivateProduct(p);
                p.State = ProductState.UNAVAILABLE;
                UpdateProductList();
                salesReference.updateCombobox();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Select a product from the list");
            }
        }

        private void btnSortProduct_Click(object sender, EventArgs e)
        {
            int cbProductIndex = cbSortProd.SelectedIndex;
            Product_Manager.GetInstance().SortProductsBy((ProductSortBy)cbProductIndex);
            UpdateProductList();

        }

        private void btnViewAllProducts_Click(object sender, EventArgs e)
        {
            UpdateProductList();
        }

        private void btnInspectProduct_Click(object sender, EventArgs e)
        {            
            try
            {
                Product selectedProduct = Product_Manager.GetInstance().GetProductById(Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[0].Value.ToString()));
                InspectProduct ip = new InspectProduct(this, selectedProduct);
                ip.Show();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Select a product from the list");
            }
        }

        private void btnRejectTicket_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket;
                ticket = ticket_Manager.returnTicketById(Convert.ToInt32(dataGridViewDepoTicketReq.CurrentRow.Cells[0].Value.ToString()));
                if (ticket.CurrentState == state.Pending)
                {
                    ticket.CurrentState = state.Rejected;
                    ticket_Manager.UpdateTicket(ticket);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error - " + ex.Message.ToString());
            }
            finally
            {
                UpdateTicketRequestsDepo();
                UpdateProductList();
                salesReference.UpdateSalesActiveTicketDataGridView();
                salesReference.UpdateSalesInactiveTicketDataGridView();
            }
        }

        private void btnAcceptTicket_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket;
                ticket = ticket_Manager.returnTicketById(Convert.ToInt32(dataGridViewDepoTicketReq.CurrentRow.Cells[0].Value.ToString()));
                if (ticket.CurrentState == state.Pending)
                {
                    ticket.CurrentState = state.Arriving;
                    int removeQuantity = 0;

                    foreach (Product product in Product_Manager.GetInstance().GetProductList())
                    {
                        if (product == ticket.product)
                        {
                            removeQuantity = ticket.Quantity;
                            product.QuantityWarehouse -= removeQuantity;
                            ticket_Manager.UpdateTicket(ticket);
                            Product_Manager.GetInstance().UpdateProduct(product.Id, product.Model, product.BrandName, product.Price, product.Description, product.Weight, product.Height, product.Width, product.Depth, product.Category, product.AisleNumber, product.QuantityWarehouse, product.QuantityShelf, product.ShipmentDate, product.RegisteredEmployee, product.State, product.Name, product.Barcode);
                        }

                    }
                }
                else
                    MessageBox.Show("No pending ticket to accept");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                UpdateTicketRequestsDepo();
                UpdateProductList();
                salesReference.UpdateSalesActiveTicketDataGridView();
                salesReference.UpdateSalesInactiveTicketDataGridView();
            }
            
        }

        private void btnChangeProductData_Click(object sender, EventArgs e)
        {
            try
            {
                Product selectedProduct = Product_Manager.GetInstance().GetProductById(Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[0].Value.ToString()));
                ManageProductInformation manageProduct = new ManageProductInformation(this, manageEmployee);
                manageProduct.UpdateFields(selectedProduct.Id, selectedProduct.Model, selectedProduct.BrandName, selectedProduct.Price.ToString(), selectedProduct.Description, selectedProduct.Weight.ToString(), selectedProduct.Height.ToString(), selectedProduct.Width.ToString(), selectedProduct.Depth.ToString(), selectedProduct.AisleNumber, selectedProduct.QuantityWarehouse, selectedProduct.QuantityShelf, selectedProduct.ShipmentDate, selectedProduct.State, selectedProduct.Name, selectedProduct.Barcode);
                
                manageProduct.Show();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Select a product from the list");
            }

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSearchProduct.Text))
            {
                if (Int32.TryParse(tbSearchProduct.Text, out _))
                {
                    int id = Convert.ToInt32(tbSearchProduct.Text);
                    if(id >= 0)
                    {
                        List<DataTableModelProduct> dtp = Product_Manager.GetInstance().GetProductsDataTableById(id);
                        if(dtp.Count != 0)
                        {
                            dataGridViewProducts.DataSource = null;
                            dataGridViewProducts.DataSource = dtp;
                        }
                        else
                        {
                            MessageBox.Show("No products with the entered id were found");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid id");
                    }
                }
                else
                {
                    List<DataTableModelProduct> dtp = Product_Manager.GetInstance().GetProductsDataTableByName(tbSearchProduct.Text);
                    if (dtp.Count != 0)
                    {
                        dataGridViewProducts.DataSource = null;
                        dataGridViewProducts.DataSource = dtp;
                    }
                    else
                    {
                        MessageBox.Show("No products with the entered name were found");
                    } 
                }
            }
            else
            {
                MessageBox.Show("Please enter the id or name of the product");
            }
        }

        private void btnNavProdRequests_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }

        private void btnNavManageProducts_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }
    }
}
