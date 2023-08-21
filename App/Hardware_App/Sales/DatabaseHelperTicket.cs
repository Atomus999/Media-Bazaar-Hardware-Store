using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class DatabaseHelperTicket
    {
        MySqlConnection connection;

        public DatabaseHelperTicket()
        {
            string info = "Server = localhost; Uid = root; Database = mediabazaar; Pwd = 1234;";
            connection = new MySqlConnection(info);
        }

        public void assignId()
        {
            string sql = "select count(*) as col1 from ticketddb";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                int startid = -1;


                while (reader.Read())
                {
                    startid = Convert.ToInt32(reader["col1"]);
                }
                Ticket.startIdHelper = startid + 1;
            }
            finally { connection.Close(); }
        }

        public int AddTicket(Ticket ticket)
        {
            string sql = "INSERT INTO `ticketddb`(`Id`,`Product`,`Quantity`,`State`,`Date`, `isActive`)" +
                " VALUES (@null,@product,@Quantity,@CurrentState,@date,@isActive)";
            MySqlCommand sqlCommand = new MySqlCommand(sql, connection);
            int rowsAffected = 0;
            try
            {
                connection.Open();

                sqlCommand.Parameters.AddWithValue("@null", ticket.Id);
                sqlCommand.Parameters.AddWithValue("@product", ticket.product.Barcode);
                sqlCommand.Parameters.AddWithValue("@Quantity", ticket.Quantity);
                sqlCommand.Parameters.AddWithValue("@CurrentState", ticket.CurrentState.ToString());
                sqlCommand.Parameters.AddWithValue("@date", ticket.TicketDate);
                sqlCommand.Parameters.AddWithValue("@isActive", ticket.IsActive);
                rowsAffected += sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }

            finally
            {
                connection.Close();
            }
            return rowsAffected;
        }

        public int updateTicket(Ticket ticket)
        {
            string sql = "UPDATE `ticketddb` SET State = @CurrentState, isActive=@isActive " +
                "WHERE Id = @Id";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int rowsAffected = 0;
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@CurrentState", ticket.CurrentState.ToString());
                command.Parameters.AddWithValue("@isActive", ticket.IsActive);
                command.Parameters.AddWithValue("@Id", ticket.Id);
                rowsAffected += command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                return 0;
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected;
        }

        public List<Ticket> loadTickets(List<Product> products) //Load in all tickets
        {
            string sql = "SELECT * FROM `ticketddb`";
            MySqlCommand command = new MySqlCommand(sql, connection);
            {
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    int id;
                    Product p = null;
                    string productBarcode;
                    int quantity;
                    state state;
                    DateTime date;
                    bool isActive;
                    List<Ticket> tickets = new List<Ticket>();
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["Id"]);
                        productBarcode = reader["Product"].ToString();
                        quantity = Convert.ToInt32(reader["Quantity"]);
                        state = returnStateType(reader["State"].ToString());
                        date = Convert.ToDateTime(reader["Date"]);
                        isActive = Convert.ToBoolean(reader["isActive"]);
                        foreach (Product product in products)
                        {
                            if (product.Barcode == productBarcode)
                            {
                                p = product;
                                break;
                            }

                        }
                        tickets.Add(new Ticket(id, date, p, quantity, state, isActive));
                    }
                    return tickets;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private state returnStateType(string curState) //need to switch from one state to another for accept and reject
        {
            switch (curState)
            {
                case "Arriving":
                    return state.Arriving;

                case "Accepted":
                    return state.Accepted;

                case "Rejected":
                    return state.Rejected;

                default:
                    return state.Pending;
            }

        }
    }
}
