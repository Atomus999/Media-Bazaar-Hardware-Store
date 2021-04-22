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
    public partial class SalesRepresentative : Form
    {
        Depotworker depotworker;

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

        private void AddPanels()
        {
            panels.Add(panelShadowRequestProduct);
            panels.Add(panelRequestProduct);
            panels.Add(panelShadowRequestsControls);
            panels.Add(panelRequestsControls);
            panels.Add(panelShadowTicketLog);
            panels.Add(panelTicketLog);
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


        public SalesRepresentative(Depotworker depotworker)
        {
            InitializeComponent();
            this.depotworker = depotworker;
            depotworker.salesReference = this;
            this.RoundPanels(15, 15);
        }
        public loginForm reference { get; set; }

        private void SalesRepresentative_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            reference.Show();
            reference.clearLogInWindows();

        }

        private void btnSubmitTicket_Click(object sender, EventArgs e) //Add a ticket
        {
            int quantity;
            Product product = null;

            try
            {
                quantity = Convert.ToInt32(numQuantity.Value);

                foreach (Product pd in Product_Manager.GetInstance().GetProductList())
                {
                    if (pd.Barcode == cbProductBarcode.SelectedItem.ToString() || pd.Barcode == cbProductBarcode.Text)
                    {
                        product = pd;
                    }
                }

                if (product != null && product.QuantityWarehouse >= quantity)
                {
                    Ticket t = new Ticket(DateTime.Now, product, quantity, state.Pending, true);
                    depotworker.Ticket_Manager.AddTicket(t);
                }
                else
                {
                    MessageBox.Show("quantity not enough in depot");
                } 
                    
            }
            catch (Exception ex) //Exception in case of nothing entered
            {
                MessageBox.Show("Please select product");
            }
            finally //update the listBox
            {
                UpdateSalesActiveTicketDataGridView();
                depotworker.UpdateTicketRequestsDepo();
            }
        }

        private void btnConfirmDelivery_Click(object sender, EventArgs e) //Confirm delivery
        {
            try
            {
                Ticket t = depotworker.Ticket_Manager.returnTicketById(Convert.ToInt32(dataGridViewSalesTicketReq.CurrentRow.Cells[0].Value.ToString()));
                if (t.CurrentState == state.Arriving)
                {
                    t.CurrentState = state.Accepted;
                    t.IsActive = false;
                    depotworker.Ticket_Manager.UpdateTicket(t);
                }
                else
                    MessageBox.Show("can not accept delivery");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Please select a ticket");
            }
            finally
            {
                UpdateSalesActiveTicketDataGridView();
                UpdateSalesInactiveTicketDataGridView();
                depotworker.UpdateTicketRequestsDepo();
                depotworker.UpdateProductList();
            }
            
        }

        

        public void updateCombobox()
        {
            cbProductBarcode.Items.Clear();
            foreach (Product product in Product_Manager.GetInstance().GetProductList())
            {
                if(product.State == ProductState.AVAILABLE)
                {
                    cbProductBarcode.Items.Add(product.Barcode);
                }
                
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket;
                ticket = depotworker.Ticket_Manager.returnTicketById(Convert.ToInt32(dataGridViewSalesTicketReq.CurrentRow.Cells[0].Value.ToString()));
                if (ticket.CurrentState != state.Accepted && ticket.CurrentState != state.Rejected)
                {
                    ticket.CurrentState = state.Rejected;
                    ticket.IsActive = false;
                    int removeQuantity = 0;

                    foreach (Product product in Product_Manager.GetInstance().GetProductList())
                    {
                        if (product == ticket.product)
                        {
                            removeQuantity = ticket.Quantity;
                            product.QuantityWarehouse += removeQuantity;
                            Product_Manager.GetInstance().UpdateProduct(product.Id,product.Model, product.BrandName, product.Price, product.Description, product.Weight, product.Height, product.Width, product.Depth, product.Category, product.AisleNumber, product.QuantityWarehouse, product.QuantityShelf, product.ShipmentDate, product.RegisteredEmployee, product.State, product.Name, product.Barcode);
                            depotworker.Ticket_Manager.UpdateTicket(ticket);
                        }

                    }


                }
                else
                    MessageBox.Show("Can not reject already finished ticket");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a ticket");
            }
            finally
            {
                UpdateSalesActiveTicketDataGridView();
                UpdateSalesInactiveTicketDataGridView();
                depotworker.UpdateTicketRequestsDepo();
                depotworker.UpdateProductList();
            }
            
        }

        private void btnUpdateRequests_Click(object sender, EventArgs e)
        {
            UpdateSalesActiveTicketDataGridView();
        }

        private void ResizeDataGridColumn(DataGridView dgv, int index, int width)
        {
            dgv.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns[index].Width = width;
        }

        public void UpdateSalesActiveTicketDataGridView()
        {
            dataGridViewSalesTicketReq.DataSource = null;
            dataGridViewSalesTicketReq.DataSource = depotworker.Ticket_Manager.GetActiveTicketsDataTable();
            this.ResizeDataGridColumn(dataGridViewSalesTicketReq, 0, 25);
        }

        public void UpdateSalesInactiveTicketDataGridView()
        {
            dataGridViewSalesPastTicketReq.DataSource = null;
            dataGridViewSalesPastTicketReq.DataSource = depotworker.Ticket_Manager.GetInactiveTicketsDataTable();
            this.ResizeDataGridColumn(dataGridViewSalesPastTicketReq, 0, 25);
        }

        private void BtnViewPastTickets_Click(object sender, EventArgs e)
        {
            UpdateSalesInactiveTicketDataGridView();
        }

        private void BtnClearTickets_Click(object sender, EventArgs e)
        {
            foreach(Ticket t in depotworker.Ticket_Manager.ReturnAllTickets())
            {
                if(t.CurrentState == state.Accepted || t.CurrentState == state.Rejected)
                {
                    t.IsActive = false;
                }
            }
            UpdateSalesActiveTicketDataGridView();
            UpdateSalesInactiveTicketDataGridView();

        }
        private void bt_generateBarcode_Click(object sender, EventArgs e)
        {
            BarcodeGenerator barcode = new BarcodeGenerator();
            barcode.CreateADocument();
            MessageBox.Show("Generated pdf");
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
