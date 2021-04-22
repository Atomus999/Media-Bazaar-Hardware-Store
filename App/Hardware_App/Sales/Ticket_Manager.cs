using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_App 
{
    public class Ticket_Manager 
    {
        private List<Ticket> tickets;

        public DatabaseHelperTicket dataHelperTicket { get; set; } = new DatabaseHelperTicket();
        public Ticket_Manager()
        {
            tickets = new List<Ticket>();

        }

        public void loadTickets(List<Product> products)
        {
            ClearTickets();
            tickets = dataHelperTicket.loadTickets(products);
        }
        public void ClearTickets()
        {
            tickets.Clear();
        }
        public List<Ticket> getAllTickets()
        {
            return tickets;
        }
        public Ticket returnTicketById(int id)
        {
            foreach(Ticket t in tickets)
            {
                if(t.Id == id)
                {
                    return t;
                }
            }
            return null;
        }
        
        public void AddTicket(Ticket ticket) 
        {
            try
            {
                tickets.Add(ticket);
                dataHelperTicket.AddTicket(ticket);

            }
            catch(Exception ex)
            {
                MessageBox.Show("error with Loading - " + ex.Message);
            }
            finally
            {
            }

        }

        public List<Ticket> ReturnAllTickets() //Return tickets
        {
            return tickets;
        }


        public List<DataTableModelTicket> GetActiveTicketsDataTable()
        {
            List<DataTableModelTicket> dataTableModelTickets = new List<DataTableModelTicket>();
            foreach (Ticket t in tickets)
            {
                if (t.IsActive)
                {
                    try
                    {
                        DataTableModelTicket tModel = new DataTableModelTicket(t.Id, t.Quantity, t.product.Barcode, t.CurrentState, t.TicketDate, t.product.Name);

                        dataTableModelTickets.Add(tModel);
                    }
                    catch { };
                }

            }
            return dataTableModelTickets;
        }

        public List<DataTableModelTicket> GetInactiveTicketsDataTable()
        {
           List<DataTableModelTicket> dataTableModelTickets = new List<DataTableModelTicket>();
         
                foreach (Ticket t in tickets)
                {
                    if (!t.IsActive)
                    {
                    try
                    {
                        DataTableModelTicket tModel = new DataTableModelTicket(t.Id, t.Quantity, t.product.Barcode, t.CurrentState, t.TicketDate, t.product.Name);
                        dataTableModelTickets.Add(tModel);
                    }
                    catch { }
                    }

                }
                return dataTableModelTickets;
            
        }

        public void UpdateTicket(Ticket t)
        {
            foreach(Ticket ticket in tickets)
            {
                if(ticket.Id == t.Id)
                {
                    ticket.Id = t.Id;
                    ticket.Quantity = t.Quantity;
                    ticket.product = t.product;
                    ticket.CurrentState = t.CurrentState;
                    ticket.TicketDate = t.TicketDate;
                    ticket.IsActive = t.IsActive;
                    dataHelperTicket.updateTicket(ticket);
                    break;
                }
            }
        }

    }
}
