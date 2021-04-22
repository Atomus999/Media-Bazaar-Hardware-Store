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
    public partial class InspectProduct : Form
    {
        Depotworker depotworker;
        public InspectProduct()
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

        private List<CustomTextbox> customTextboxes = new List<CustomTextbox>();

        private void AddTextBoxes()
        {
            customTextboxes.Add(tbInspectId);
            customTextboxes.Add(tbInspectModel);
            customTextboxes.Add(tbInspectBrand);
            customTextboxes.Add(tbInspectPrice);
            customTextboxes.Add(tbInspectQtyWh);
            customTextboxes.Add(tbInspectQtyShelf);
            customTextboxes.Add(tbInspectWidth);
            customTextboxes.Add(tbInspectWeight);
            customTextboxes.Add(tbInspectAisleNr);
            customTextboxes.Add(tbInspectBarcode);
            customTextboxes.Add(tbInspectName);
            customTextboxes.Add(tbInspectREmp);
            customTextboxes.Add(tbInspectDepth);
            customTextboxes.Add(tbInspectCategory);
            customTextboxes.Add(tbInspectState);
            customTextboxes.Add(tbInspectHeight);
            customTextboxes.Add(tbInspectShipmentDate);
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

        public InspectProduct(Depotworker dw, Product p)
        {
            InitializeComponent();
            depotworker = dw;
            DisplayProductDetails(p);
            this.RoundTextBoxes(5, 5);
        }

        public void DisplayProductDetails(Product p)
        {
            tbInspectId.Text = p.Id.ToString();
            tbInspectModel.Text = p.Model.ToString();
            tbInspectBrand.Text = p.BrandName.ToString();
            tbInspectPrice.Text = p.Price.ToString();
            tbInspectDescription.Text = p.Description.ToString();
            tbInspectWeight.Text = p.Weight.ToString();
            tbInspectHeight.Text = p.Height.ToString();
            tbInspectWidth.Text = p.Width.ToString();
            tbInspectDepth.Text = p.Depth.ToString();
            tbInspectQtyWh.Text = p.QuantityWarehouse.ToString();
            tbInspectCategory.Text = p.Category.ToString();
            tbInspectAisleNr.Text = p.AisleNumber.ToString();
            tbInspectShipmentDate.Text = p.ShipmentDate.ToString();
            tbInspectREmp.Text = p.RegisteredEmployee.FirstName + p.RegisteredEmployee.LastName;
            tbInspectState.Text = Enum.GetName(typeof(ProductState), p.State);
            tbInspectName.Text = p.Name.ToString();
            tbInspectBarcode.Text = p.Barcode.ToString();
            tbInspectQtyShelf.Text = p.QuantityShelf.ToString();
        }

    }
}
