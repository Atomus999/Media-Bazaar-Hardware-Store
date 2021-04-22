using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Hardware_App
{
    public class DatabaseHelper
    {
        MySqlConnection connection;
        EmployeeManager employeeManager;
        Product_Manager productManager;
        Ticket_Manager ticketManager;
        public DatabaseHelper(EmployeeManager employeeManager, Product_Manager product_Manager, Ticket_Manager TicketManager)
        {
            this.employeeManager = employeeManager;
            this.productManager = product_Manager;
            this.ticketManager = TicketManager;
            string info = "Server = studmysql01.fhict.local; Uid = dbi426239; Database = dbi426239; Pwd = 1234;";

            connection = new MySqlConnection(info);
            
        }


        public int RemoveSchedule(DateTime date,DayPlan dayPlan)
        {
            int recordsChanged = 0;
            string sql = "DELETE FROM `dayplan` WHERE `Emp_ID`=@empid AND `Date`=@date and `Morning` =@morning AND `Afternoon`=@afternoon and `Evening`=@evening";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@empid", dayPlan.EmpID);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@morning", dayPlan.Morning);
                command.Parameters.AddWithValue("@afternoon",dayPlan.Afternoon);
                command.Parameters.AddWithValue("@evening", dayPlan.Evening);
                recordsChanged += command.ExecuteNonQuery();
            }
            catch { return 0; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }


        public int UpdateEmployee(Employee employee)
        {
            int recordsChanged = 0;
            string sql = "UPDATE `employee` SET `ID`=@id,`Name`=@name,`Department`=@department,`DateOfBirth`=@birthdate," +
                "`BSN`=@bsn,`PhoneNumber`=@phonenumber,`Address`=@address,`Email`=@email," +
                "`UserName`=@username,`Password`=@password,`RFID`=@rfid,`IsActive`=@isactive WHERE ID=@id";
          
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", employee.Id);
                command.Parameters.AddWithValue("@name", employee.Name);
                command.Parameters.AddWithValue("@department", employee.Department);
                command.Parameters.AddWithValue("@birthdate", employee.DateOfBirth);
                command.Parameters.AddWithValue("@bsn", employee.Bsn);
                command.Parameters.AddWithValue("@phonenumber", employee.PhoneNumber);
                command.Parameters.AddWithValue("@address", employee.Address);
                command.Parameters.AddWithValue("@email", employee.Email);
                command.Parameters.AddWithValue("@username", employee.UserName);
                command.Parameters.AddWithValue("@password", employee.Password);
                if (employee.Rfid != null)
                    command.Parameters.AddWithValue("@rfid", employee.Rfid.SerialNumber);
                else
                    command.Parameters.AddWithValue("@rfid", 0);                
                command.Parameters.AddWithValue("@isactive", employee.IsActive);
                
                recordsChanged += command.ExecuteNonQuery();
            }
            catch { return 0; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }

        public int SaveMinsLate(Employee employee, int minutesLate)
        {
            string sql = "INSERT INTO latearrivals(ID, Emp_Id, Date, MinutesLate) VALUES (@null,@empid,@date,@mins)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int recordsChanged = 0;
            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@null", null);
                command.Parameters.AddWithValue("@empid", employee.Id);
                command.Parameters.AddWithValue("@date", DateTime.Now.Date);
                command.Parameters.AddWithValue("@mins", minutesLate);

                recordsChanged += command.ExecuteNonQuery();
            }
            catch { return 0; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }

        public int SaveSchedule()
        {
            int changes = 0;
            foreach (Employee employee in employeeManager.GetEmployees())
            {
                foreach (DayPlan dayPlan in employee.GetDayPlans())
                {
                    if (AddPlan(dayPlan) != 0)
                        changes++;
                }
            }
            return changes;
        }

        private int AddPlan(DayPlan dayPlan)
        {
            string sql = "INSERT INTO `dayplan`(`ID`, `Emp_ID`, `Date`, `Morning`, `Afternoon`, `Evening`)" +
                " VALUES (@null,@empid,@date,@morning,@afternoon,@evening)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int recordsChanged = 0;
            try
            {
                connection.Open();
                
                command.Parameters.AddWithValue("@null", null);
                command.Parameters.AddWithValue("@empid", dayPlan.EmpID);
                command.Parameters.AddWithValue("@date", dayPlan.Date);
                command.Parameters.AddWithValue("@morning", dayPlan.Morning);
                command.Parameters.AddWithValue("@afternoon", dayPlan.Afternoon);
                command.Parameters.AddWithValue("@evening", dayPlan.Evening);
                recordsChanged += command.ExecuteNonQuery();
            }
            catch { return 0; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }

        public int UpdateProduct(Product p)
        {
            int recordsChanged = 0;
            string sql = "UPDATE products SET model = @model, brandName = @brand, description = @desc, weight = @weight, height = @height, width = @width, depth = @depth, category = @category, aisleNumber=@aisleNumber, qtyWh = @qtyWh, qtySh = @qtysh, shipmentDate = @shipmentD, registerdEmpId = @eId, state = @state WHERE id = @id";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", p.Id);
                command.Parameters.AddWithValue("@model", p.Model);
                command.Parameters.AddWithValue("@brand", p.BrandName);
                command.Parameters.AddWithValue("@desc", p.Description);
                command.Parameters.AddWithValue("@weight", p.Weight);
                command.Parameters.AddWithValue("@height", p.Height);
                command.Parameters.AddWithValue("@width", p.Width);
                command.Parameters.AddWithValue("@depth", p.Depth);
                command.Parameters.AddWithValue("@category", p.Category);
                command.Parameters.AddWithValue("@aisleNumber", p.AisleNumber);
                command.Parameters.AddWithValue("@qtyWh", p.QuantityWarehouse);
                command.Parameters.AddWithValue("@qtysh", p.QuantityShelf);
                command.Parameters.AddWithValue("@shipmentD", p.ShipmentDate);
                command.Parameters.AddWithValue("@eId", p.RegisteredEmployee.Id);
                command.Parameters.AddWithValue("@state", Enum.GetName(typeof(ProductState), p.State));

                recordsChanged += command.ExecuteNonQuery();
            }
            catch { return 0; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }

        public void loadSchedules()
        {
            string sql = "select * from dayplan";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                int empid;
                DateTime date;
                int morning;
                int afternoon;
                int evening;
                employeeManager.DeleteAllDayplans();
                while (reader.Read())
                {
                    empid = Convert.ToInt32(reader["Emp_ID"]);
                    date = Convert.ToDateTime(reader["Date"]);
                    morning= Convert.ToInt32(reader["Morning"]);
                    afternoon= Convert.ToInt32(reader["Afternoon"]);
                    evening= Convert.ToInt32(reader["Evening"]);
                    foreach (Employee employee in employeeManager.GetEmployees())
                    {
                        if (employee.Id == empid)
                            employee.addDayplan(new DayPlan(date, empid, morning, afternoon, evening));
                    }
                }
            }
            finally { connection.Close(); }
        }
        public void loadEmployees()
        {
            string sql = "SELECT * from employee";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                string name;
                string department;
                DateTime dateOfBirth;
                double bsn;
                string phoneNumber;
                string address;
                string email;
                string userName;
                string password;
                int id;
                string rfid;
                bool isActive;
                employeeManager.DeleteAllEmployees();
                while(reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                    name = reader["Name"].ToString();
                    department = reader["Department"].ToString();
                    dateOfBirth =Convert.ToDateTime(reader["DateOfBirth"]);
                    bsn = Convert.ToDouble(reader["BSN"]);
                    phoneNumber= (reader["PhoneNumber"].ToString());
                    address= reader["Address"].ToString();
                    email= reader["Email"].ToString();
                    userName= reader["UserName"].ToString();
                    password= reader["Password"].ToString();
                    rfid = reader["RFID"].ToString();                    
                    RFIDcontrol rFIDcontrol = new RFIDcontrol(rfid, true);
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    employeeManager.AddEmployee(new Employee(id, name, department, dateOfBirth, bsn, phoneNumber, address, email, userName, password, rFIDcontrol,isActive));
                }
            }            
            finally { connection.Close(); }
        }
            
        
        public int SaveEmployees()
        {
            int changes = 0;
            foreach (Employee employee in employeeManager.GetEmployees())
            {
                if (addEmployee(employee) != 0)
                    changes++;
            }
            return changes;
        }
        private int addEmployee(Employee employee)
        {
            string sql = "INSERT INTO `employee`(`ID`, `Name`, `Department`, `DateOfBirth`, `BSN`, `PhoneNumber`, `Address`, `Email`, `UserName`, `Password`, `RFID`, `IsActive`) " +
                "VALUES (@id,@name,@department,@birthdate,@bsn,@phonenumber,@address,@email,@username,@password,@rfid,@isactive)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int recordsChanged = 0;
            try
            {
                connection.Open();
                
                    command.Parameters.AddWithValue("@id", employee.Id);
                    command.Parameters.AddWithValue("@name", employee.Name);
                    command.Parameters.AddWithValue("@department", employee.Department);
                    command.Parameters.AddWithValue("@birthdate", employee.DateOfBirth);
                    command.Parameters.AddWithValue("@bsn", employee.Bsn);
                    command.Parameters.AddWithValue("@phonenumber", employee.PhoneNumber);
                    command.Parameters.AddWithValue("@address", employee.Address);
                    command.Parameters.AddWithValue("@email", employee.Email);
                    command.Parameters.AddWithValue("@username", employee.UserName);
                    command.Parameters.AddWithValue("@password", employee.Password);
                    if(employee.Rfid!=null)
                        command.Parameters.AddWithValue("@rfid",employee.Rfid.SerialNumber);
                    else
                        command.Parameters.AddWithValue("@rfid", 0);
                    
                    command.Parameters.AddWithValue("@isactive",employee.IsActive);
                    recordsChanged += command.ExecuteNonQuery();
            }
            catch { return 0; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }

        public int AddProduct(Product product)
        {

            int recordsChanged = 0;

            string sql = "INSERT INTO `products`(`id`, `model`,`brandName`, `price`, `description`, `weight`, `height`, `width`, `depth`, `category`, `aisleNumber`, `qtyWh`, `qtySh`, `shipmentDate`, `registerdEmpId`, `state`) " +
           "VALUES (@id,@model,@brandName,@price,@description,@weight,@height,@width,@depth,@category,@aisleNumber,@qtyWh,@qtySh,@shipmentDate,@registerdEmpId,@state)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@model", product.Model);
                command.Parameters.AddWithValue("@brandName", product.BrandName);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@description", product.Description);
                command.Parameters.AddWithValue("@weight", product.Weight);
                command.Parameters.AddWithValue("@height", product.Height);
                command.Parameters.AddWithValue("@width", product.Width);
                command.Parameters.AddWithValue("@depth", product.Depth);
                command.Parameters.AddWithValue("@category", product.Category);
                command.Parameters.AddWithValue("@aisleNumber", product.AisleNumber);
                command.Parameters.AddWithValue("@qtyWh", product.QuantityWarehouse);
                command.Parameters.AddWithValue("@qtySh", product.QuantityShelf);
                command.Parameters.AddWithValue("@shipmentDate", product.ShipmentDate);
                command.Parameters.AddWithValue("@registerdEmpId", product.RegisteredEmployee.Id);
                
                command.Parameters.AddWithValue("@state", Enum.GetName(typeof(ProductState), product.State).ToString());

                recordsChanged += command.ExecuteNonQuery();
            }
            catch { return 0; }
            finally
            {
                connection.Close();
            }

            return recordsChanged;
        }

        public int SaveProducts()
        {
            int changes = 0;

            foreach (Product p in productManager.GetProductList())
            {
                if (AddProduct(p) != 0)
                    changes++;
            }
            return changes;
        }

        public void loadProducts()
        {
            string sql = "SELECT * from products";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                int id;
                string model;
                string brandName;
                float price;
                string description;
                double weight;
                double height;
                double width;
                double depth;
                string category;
                int aisleNumber;
                int qtyWh;
                int qtySh;
                DateTime shipmentDate;
                Employee registeredEmp;
                ProductState state;
                productManager.RemoveAllProducts();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                    model = reader["model"].ToString();
                    brandName = reader["brandName"].ToString();
                    price = Convert.ToSingle(reader["price"]);
                    description = reader["description"].ToString();
                    weight = Convert.ToDouble(reader["weight"]);
                    height = Convert.ToDouble(reader["height"]);
                    width = Convert.ToDouble(reader["width"]);
                    depth = Convert.ToDouble(reader["depth"]);
                    category = reader["category"].ToString();
                    aisleNumber = Convert.ToInt32(reader["aisleNumber"]);
                    qtyWh = Convert.ToInt32(reader["qtyWh"]);
                    qtySh = Convert.ToInt32(reader["qtySh"]);
                    shipmentDate = Convert.ToDateTime(reader["shipmentDate"]);
                    registeredEmp = ReturnEmployeeFromId(Convert.ToInt32(reader["registerdEmpId"]));
                    state = productManager.ConvertStringToState(reader["state"].ToString());
                    productManager.AddProduct(new Product(id, model, brandName, price, description, weight, height, width, depth, category, aisleNumber, qtyWh, qtySh, shipmentDate, registeredEmp, state));
                }
            }
            finally { connection.Close(); }
        }

        public int RemoveProduct(Product p)
        {
            int recordsChanged = 0;
            string sql = "DELETE FROM products WHERE id=@pid;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@pid", p.Id);
                recordsChanged += command.ExecuteNonQuery();
            }
            catch { return 0; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }

        private Employee ReturnEmployeeFromId(int id)
        {
            foreach (Employee e in employeeManager.GetEmployees())
            {
                if (e.Id == id)
                {
                    return e;
                }

            }
            return null;
        } 

        public int SaveTicket()
        {
            int changes = 0;
            foreach (Ticket ticket in ticketManager.getAllTickets())
            {             
                if (AddTicket(ticket) != 0)
                    changes++;
            }
            return changes;
        }

        private int AddTicket(Ticket ticket)
        {
            string sql = "INSERT INTO `ticketddb`(`Id`,`Product`,`Quantity`,`State`,`Date`)" +
                " VALUES (@null,@product,@Quantity,@CurrentState,@date)";
            MySqlCommand sqlCommand = new MySqlCommand(sql, connection);
            int rowsAffected = 0;
            try
            {
                connection.Open();

                sqlCommand.Parameters.AddWithValue("@null", null);
                sqlCommand.Parameters.AddWithValue("@product", ticket.product.GetName);
                sqlCommand.Parameters.AddWithValue("@Quantity", ticket.Quantity);
                sqlCommand.Parameters.AddWithValue("@CurrentState", ticket.CurrentState.ToString());               
                sqlCommand.Parameters.AddWithValue("@date", ticket.TicketDate);
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
            string sql = "UPDATE `ticketddb` SET State = @CurrentState " +
                "WHERE Id = @Id";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int rowsAffected = 0;
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@CurrentState", ticket.CurrentState.ToString());
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

        public void loadTickets() //Load in all tickets
        {
            string sql = "SELECT * FROM `ticketddb`";
            MySqlCommand command = new MySqlCommand(sql, connection);
            {
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    int id;
                    string product;
                    int quantity;
                    state state;
                    DateTime date;
                    ticketManager.ClearTickets();
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["Id"]);
                        product = reader["Product"].ToString();
                        quantity = Convert.ToInt32(reader["Quantity"]);
                        state = ticketManager.returnStateType(reader["State"].ToString());
                        date = Convert.ToDateTime(reader["Date"]);
                        ticketManager.UpdateTicket(new Ticket(id,date,product,quantity,state ));


                    }
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



    }
}
