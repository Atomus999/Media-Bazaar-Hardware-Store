using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class Ticket
    {
        private Product _product;
        public static int startIdHelper=0;
        private int quantity;
        private int id;
        private bool isActive;

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

        public Product product
        {
            get { return _product; }
            set { _product = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public state CurrentState;
        public DateTime TicketDate { get; set; }
        public bool IsActive {get{ return this.isActive; } set{ isActive = value; } }
        
        public Ticket(Product product , int quantity) //Need to remove the ticket quantity from depo storage
        {            
            TicketDate = DateTime.Now; // tickets creation time
            this.product = product; 
            this.Quantity = quantity;
            CurrentState = state.Pending;// makes the object with a pre state.
        }
        public Ticket(int id, DateTime time, Product _product, int Quantity, state State, bool isActive)
        {
            Id = id;
            
            TicketDate = time;
            this.Quantity = Quantity;
            CurrentState = State;
            this._product = _product;
            this.isActive = isActive;
        }

        public Ticket(DateTime time, Product _product, int Quantity, state State, bool isActive)
        {
            id = startIdHelper;
            startIdHelper++;
            TicketDate = time;
            this.Quantity = Quantity;
            CurrentState = State;
            this._product = _product;
            this.isActive = isActive;
        }

        public override string ToString()
        {
            if(Id!=-1)
                return $"Id:{Id} Product:{product.Barcode} quantity {Quantity} , current state of the ticket `{CurrentState} , ({TicketDate}) ";
            else
                return $"Product:{product.Barcode} quantity {Quantity} , current state of the ticket `{CurrentState} , ({TicketDate}) ";
        }

    }
}
