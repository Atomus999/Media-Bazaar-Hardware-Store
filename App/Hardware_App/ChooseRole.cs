using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_App
{
    public partial class ChooseRole : Form
    {
        ManageEmployee manageEmployee;
        Depotworker depotworker;
        SalesRepresentative salesRepresentative;
        public ChooseRole(ManageEmployee manageEmployee,Depotworker depotworker, SalesRepresentative salesRepresentative)
        {
            InitializeComponent();
            this.manageEmployee = manageEmployee;
            this.depotworker = depotworker;
            this.salesRepresentative = salesRepresentative;
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            manageEmployee.Show();
        }

        private void BtnSalesRep_Click(object sender, EventArgs e)
        {
            salesRepresentative.Show();
        }

        private void BtnDepotWorker_Click(object sender, EventArgs e)
        {
            depotworker.Show();
        }

        private void ChooseRole_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
