using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class DataTableModelTicket
    {
        private int id = -1;
        private int quantity;
        private string productBarcode;
        private state state;
        private DateTime ticketDate;
        private string productName;

        public DataTableModelTicket(int id, int quantity, string productBarcode, state state, DateTime ticketDate, string productName)
        {
            this.id = id;
            this.quantity = quantity;
            this.productBarcode = productBarcode;
            this.state = state;
            this.ticketDate = ticketDate;
            this.productName = productName;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string ProductName
        { 
            get 
            {
                return productName;
            }
            set 
            {
                productName = value;
            }
        }

        public string ProductBarcode
        {
            get { return productBarcode; }
            set { productBarcode = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public state CurrentState
        {
            get { return state; }
            set { state = value; }
        }
        public DateTime TicketDate
        {
            get { return ticketDate; }
            set { ticketDate = value; }
        }

    }

}
