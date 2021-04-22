using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class DataTableModelProduct
    {
        private int id;
        private string name;
        private int qtyWh;
        private ProductState state;
        private string barcode;

        public DataTableModelProduct(int id, string name, int qtyWh, ProductState state, string barcode)
        {
            this.id = id;
            this.name = name;
            this.qtyWh = qtyWh;
            this.state = state;
            this.barcode = barcode;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int QuantityWarehouse { get { return qtyWh; } set { qtyWh = value; } }
        public ProductState State { get { return state; } set { state = value; } }
        public string Barcode { get { return barcode; } set { barcode = value; } }

    }
}
