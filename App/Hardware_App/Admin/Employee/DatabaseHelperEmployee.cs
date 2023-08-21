using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Hardware_App
{
    public class DatabaseHelperEmployee
    {
        MySqlConnection connection;


        public DatabaseHelperEmployee()
        {
            string info = "Server = localhost; Uid = root; Database = mediabazaar; Pwd = 1234;";
            connection = new MySqlConnection(info);
        }


        public int UpdateWorkingDays(Employee employee)
        {
            int recordsChanged = 0;
            string sql = "UPDATE `employeedays` SET `Monday`=@monday," +
                "`Tuesday`=@tuesday,`Wednesday`=@wednesday,`Thursday`=@thursday,`Friday`=@friday," +
                "`Saturday`=@saturday,`Sunday`=@sunday WHERE Emp_Id=@empid";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@monday", employee.ScheduleDays.Monday);
                command.Parameters.AddWithValue("@tuesday", employee.ScheduleDays.Tuesday);
                command.Parameters.AddWithValue("@wednesday", employee.ScheduleDays.Wednesday);
                command.Parameters.AddWithValue("@thursday", employee.ScheduleDays.Thursday);
                command.Parameters.AddWithValue("@friday", employee.ScheduleDays.Friday);
                command.Parameters.AddWithValue("@saturday", employee.ScheduleDays.Saturday);
                command.Parameters.AddWithValue("@sunday", employee.ScheduleDays.Sunday);
                command.Parameters.AddWithValue("@empid", employee.Id);

                recordsChanged += command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }
        public void loadWorkingDays(List<Employee> employees)
        {
            string sql = "SELECT * from employeedays";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                int empid;
                bool monday;
                bool tuesd;
                bool wednesd;
                bool thursd;
                bool frid;
                bool saturd;
                bool sund;

                while (reader.Read())
                {
                    empid = Convert.ToInt32(reader["Emp_Id"]);
                    monday = Convert.ToBoolean(reader["Monday"]);
                    tuesd = Convert.ToBoolean(reader["Tuesday"]);
                    wednesd = Convert.ToBoolean(reader["Wednesday"]);
                    thursd = Convert.ToBoolean(reader["Thursday"]);
                    frid = Convert.ToBoolean(reader["Friday"]);
                    saturd = Convert.ToBoolean(reader["Saturday"]);
                    sund = Convert.ToBoolean(reader["Sunday"]);

                    foreach (Employee employee in employees)
                    {
                        if (employee.Id == empid)
                        {
                            employee.ScheduleDays.Monday = monday;
                            employee.ScheduleDays.Tuesday = tuesd;
                            employee.ScheduleDays.Wednesday = wednesd;
                            employee.ScheduleDays.Thursday = thursd;
                            employee.ScheduleDays.Friday = frid;
                            employee.ScheduleDays.Saturday = saturd;
                            employee.ScheduleDays.Sunday = sund;
                        }
                    }
                }
            }
            finally { connection.Close(); }
        }
        public int saveWorkingDay(Employee employee)
        {
            string sql = "INSERT INTO `employeedays`(`ID`, `Emp_Id`, `Monday`, `Tuesday`, `Wednesday`, `Thursday`, `Friday`, `Saturday`, `Sunday`) VALUES " +
                "(@null,@empid,@monday,@tuesday,@wednesday,@thursday,@friday,@saturday,@sunday)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int recordsChanged = 0;
            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@null", null);
                command.Parameters.AddWithValue("@empid", employee.Id);
                command.Parameters.AddWithValue("@monday", employee.ScheduleDays.Monday);
                command.Parameters.AddWithValue("@tuesday", employee.ScheduleDays.Tuesday);
                command.Parameters.AddWithValue("@wednesday", employee.ScheduleDays.Wednesday);
                command.Parameters.AddWithValue("@thursday", employee.ScheduleDays.Thursday);
                command.Parameters.AddWithValue("@friday", employee.ScheduleDays.Friday);
                command.Parameters.AddWithValue("@saturday", employee.ScheduleDays.Saturday);
                command.Parameters.AddWithValue("@sunday", employee.ScheduleDays.Sunday);
                recordsChanged += command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }
        public void loadFtes(List<Employee> employees)
        {
            string sql = "select * from ftetracker";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                int empid;
                DateTime date;
                double actualFte;


                while (reader.Read())
                {
                    empid = Convert.ToInt32(reader["Emp_ID"]);
                    date = Convert.ToDateTime(reader["Date"]);
                    actualFte = Convert.ToDouble(reader["ActualFTE"]);

                    foreach (Employee employee in employees)
                    {
                        if (employee.Id == empid)
                            employee.addActualFte(new FteReal(empid, date, actualFte));
                    }
                }
            }
            finally { connection.Close(); }
        }

        public int AddFTE(FteReal fte)
        {
            string sql = "INSERT INTO `ftetracker`(`ID`, `Emp_Id`, `Date`, `ActualFTE`)" +
                " VALUES (@null,@empid,@date,@actualfte)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int recordsChanged = 0;
            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@null", null);
                command.Parameters.AddWithValue("@empid", fte.EmpId);
                command.Parameters.AddWithValue("@date", fte.Date);
                command.Parameters.AddWithValue("@actualfte", fte.ActualFte);

                recordsChanged += command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
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
            catch (Exception ex) { throw ex; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }

        public void loadMinsLate(List<Employee> employees)
        {
            string sql = "select * from latearrivals";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                int empid;
                DateTime date;
                int minsLate;

                while (reader.Read())
                {
                    empid = Convert.ToInt32(reader["Emp_ID"]);
                    date = Convert.ToDateTime(reader["Date"]);
                    minsLate = Convert.ToInt32(reader["MinutesLate"]);

                    foreach (Employee employee in employees)
                    {
                        if (employee.Id == empid)
                        {
                            try
                            {
                                employee.GetDayPlansByDate(date)[0].MinsLate = minsLate;
                            }
                            catch { }
                        }
                    }
                }
            }
            finally { connection.Close(); }
        }

        public int RemoveFte(DateTime date, int id)
        {
            int recordsChanged = 0;
            string sql = "DELETE FROM `ftetracker` WHERE `Emp_ID`=@empid AND `Date`=@date limit 1";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@empid", id);
                command.Parameters.AddWithValue("@date", date);

                recordsChanged += command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }
        public int RemoveSchedule(DateTime date, DayPlan dayPlan)
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
                command.Parameters.AddWithValue("@afternoon", dayPlan.Afternoon);
                command.Parameters.AddWithValue("@evening", dayPlan.Evening);
                recordsChanged += command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }
        public void loadSchedules(List<Employee> employees)
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
                List<DayPlan> dayPlans = new List<DayPlan>();
                while (reader.Read())
                {
                    empid = Convert.ToInt32(reader["Emp_ID"]);
                    date = Convert.ToDateTime(reader["Date"]);
                    morning = Convert.ToInt32(reader["Morning"]);
                    afternoon = Convert.ToInt32(reader["Afternoon"]);
                    evening = Convert.ToInt32(reader["Evening"]);
                    dayPlans.Add(new DayPlan(date, empid, morning, afternoon, evening));
                    foreach (Employee employee in employees)
                    {
                        if (employee.Id == empid)
                            employee.addDayplan(new DayPlan(date, empid, morning, afternoon, evening));
                    }
                }

            }
            finally { connection.Close(); }
        }

        public int AddPlan(DayPlan dayPlan)
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
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }

        public int UpdateEmployee(Employee employee)
        {
            int recordsChanged = 0;
            string sql = "UPDATE `employee` SET `ID`=@id,`FirstName`=@firstName,`LastName`=@lastName,`Department`=@department,`DateOfBirth`=@birthdate," +
                "`BSN`=@bsn,`PhoneNumber`=@phonenumber,`Address`=@address,`Email`=@email," +
                "`UserName`=@username,`Password`=@password,`RFID`=@rfid,`IsActive`=@isactive,`ContractFTE`=@contractFTE, `Spouse`=@spouse WHERE ID=@id";

            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", employee.Id);
                command.Parameters.AddWithValue("@firstName", employee.FirstName);
                command.Parameters.AddWithValue("@lastName", employee.LastName);
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
                command.Parameters.AddWithValue("@contractFTE", employee.FteContract);

                if (employee.SetSpouse != null)
                {
                    command.Parameters.AddWithValue("@spouse", employee.SetSpouse.ToString());
                }
                else
                {
                    command.Parameters.AddWithValue("@spouse", 0);
                }

                recordsChanged += command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }

        public List<Employee> loadEmployees(List<Spouse> spouses)
        {
            string sql = "SELECT * from employee";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                string firstName;
                string lastName;
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
                double fteContract;
                List<Employee> employees = new List<Employee>();
                string spouse;
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                    firstName = reader["FirstName"].ToString();
                    lastName = reader["LastName"].ToString();
                    department = reader["Department"].ToString();
                    dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    bsn = Convert.ToDouble(reader["BSN"]);
                    phoneNumber = (reader["PhoneNumber"].ToString());
                    address = reader["Address"].ToString();
                    email = reader["Email"].ToString();
                    userName = reader["UserName"].ToString();
                    password = reader["Password"].ToString();
                    rfid = reader["RFID"].ToString();
                    RFIDcontrol rFIDcontrol = new RFIDcontrol(rfid, true);
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    fteContract = Convert.ToDouble(reader["ContractFTE"]);
                    spouse = reader["Spouse"].ToString();
                    if (spouse == "")
                    {
                        employees.Add(new Employee(id, firstName, lastName, department, dateOfBirth, bsn, phoneNumber, address, email, userName, password, rFIDcontrol, isActive, fteContract));
                    }
                    else
                    {
                        foreach (Spouse spo in spouses)
                        {
                            if (id == spo.EmpID)
                                employees.Add(new Employee(id, firstName, lastName, department, dateOfBirth, bsn, phoneNumber, address, email, userName, password, rFIDcontrol, isActive, fteContract, spo));
                        }
                    }

                }
                return employees;
            }
            finally { connection.Close(); }
        }

        public int addEmployee(Employee employee)
        {
            string sql = "INSERT INTO `employee`(`ID`, `FirstName`, `LastName`, `Department`, `DateOfBirth`, `BSN`, `PhoneNumber`, `Address`, `Email`, `UserName`, `Password`, `RFID`, `IsActive`,`ContractFTE`,`Spouse`) " +
                "VALUES (@id,@firstName,@lastName,@department,@birthdate,@bsn,@phonenumber,@address,@email,@username,@password,@rfid,@isactive,@contractFTE,@spouse)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int recordsChanged = 0;
            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@id", employee.Id);
                command.Parameters.AddWithValue("@firstName", employee.FirstName);
                command.Parameters.AddWithValue("@lastName", employee.LastName);
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
                command.Parameters.AddWithValue("@contractFTE", employee.FteContract);
                if (employee.SetSpouse != null)
                {
                    command.Parameters.AddWithValue("@spouse", employee.SetSpouse.FirstName + employee.SetSpouse.LastName);
                }
                else
                {
                    command.Parameters.AddWithValue("@spouse", 0);
                }
                recordsChanged += command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }

        public List<EmployeeAbsence> loadAbsences(List<Employee> employees)
        {
            string sql = "SELECT * from employeeabsence";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                int id;
                int empId;
                DateTime date;
                string absenceReason;
                string absenceDescription;
                string ticketStatus;
                string EmployeeName = "";
                string absenceTime = "";
                List<EmployeeAbsence> absences = new List<EmployeeAbsence>();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                    empId = Convert.ToInt32(reader["Emp_Id"]);
                    date = Convert.ToDateTime(reader["Date"]);
                    absenceReason = reader["AbsenceReason"].ToString();
                    absenceDescription = reader["AbsenceDescription"].ToString();
                    ticketStatus = reader["TicketStatus"].ToString();
                    absenceTime = reader["AbsenceTime"].ToString();
                    foreach (Employee employee in employees)
                    {
                        if (empId == employee.Id)
                        {
                            EmployeeName = employee.FirstName + " " + employee.LastName;
                        }
                    }
                    EmployeeAbsence employeeAbsence = new EmployeeAbsence(id, empId, date, absenceReason, absenceDescription, ticketStatus);
                    employeeAbsence.EmployeeName = EmployeeName;
                    employeeAbsence.AbsenceTime = absenceTime;
                    absences.Add(employeeAbsence);
                }
                return absences;
            }
            finally { connection.Close(); }
        }

        public int updateAbsences(EmployeeAbsence absence)
        {
            string sql = "UPDATE `employeeabsence` SET TicketStatus = @CurrentState WHERE ID = @Id";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int rowsAffected = 0;
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@CurrentState", absence.TicketStatus);
                command.Parameters.AddWithValue("@Id", absence.Id);
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
    }
}
