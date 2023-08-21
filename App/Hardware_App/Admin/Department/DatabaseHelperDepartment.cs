using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Hardware_App
{
    public class DatabaseHelperDepartment
    {

        MySqlConnection connection;


        public DatabaseHelperDepartment()
        {
            string info = "Server = localhost; Uid = root; Database = mediabazaar; Pwd = 1234;";
            connection = new MySqlConnection(info);
        }


        public int DeleteDayplanFromDateForward(DateTime dateTime)
        {
            string sql = "DELETE FROM `dayplan` WHERE `Date` >= @date";

            MySqlCommand command = new MySqlCommand(sql, connection);
            int recordsChanged = 0;
            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@date", dateTime);


                recordsChanged += command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }
        public int DeleteFteFromDateForward(DateTime dateTime)
        {
            string sql = "DELETE FROM `ftetracker` WHERE `Date` >= @date";

            MySqlCommand command = new MySqlCommand(sql, connection);
            int recordsChanged = 0;
            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@date", dateTime);


                recordsChanged += command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }


        public ShiftPerDept LoadDepartmentReqEmp(int depid)
        {
            string sql = "SELECT * from departmentreqemp where Dep_ID=@id";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", depid);
                MySqlDataReader reader = command.ExecuteReader();


                int ReqEmpMonMor;
                int ReqEmpMonAft;
                int ReqEmpMonEve;
                int ReqEmpTueMor;
                int ReqEmpTueAft;
                int ReqEmpTueEve;
                int ReqEmpWedMor;
                int ReqEmpWedAft;
                int ReqEmpWedEve;
                int ReqEmpThuMor;
                int ReqEmpThuAft;
                int ReqEmpThuEve;
                int ReqEmpFriMor;
                int ReqEmpFriAft;
                int ReqEmpFriEve;
                int ReqEmpSatMor;
                int ReqEmpSatAft;
                int ReqEmpSatEve;
                int ReqEmpSunMor;
                int ReqEmpSunAft;
                int ReqEmpSunEve;
                ShiftPerDept shiftPerDept = null;
                while (reader.Read())
                {
                    depid = Convert.ToInt32(reader["Dep_ID"]);
                    ReqEmpMonMor = Convert.ToInt32(reader["ReqEmpMonMor"]);
                    ReqEmpMonAft = Convert.ToInt32(reader["ReqEmpMonAft"]);
                    ReqEmpMonEve = Convert.ToInt32(reader["ReqEmpMonEve"]);
                    ReqEmpTueMor = Convert.ToInt32(reader["ReqEmpTueMor"]);
                    ReqEmpTueAft = Convert.ToInt32(reader["ReqEmpTueAft"]);
                    ReqEmpTueEve = Convert.ToInt32(reader["ReqEmpTueEve"]);
                    ReqEmpWedMor = Convert.ToInt32(reader["ReqEmpWedMor"]);
                    ReqEmpWedAft = Convert.ToInt32(reader["ReqEmpWedAft"]);
                    ReqEmpWedEve = Convert.ToInt32(reader["ReqEmpWedEve"]);
                    ReqEmpThuMor = Convert.ToInt32(reader["ReqEmpThuMor"]);
                    ReqEmpThuAft = Convert.ToInt32(reader["ReqEmpThuAft"]);
                    ReqEmpThuEve = Convert.ToInt32(reader["ReqEmpThuEve"]);
                    ReqEmpFriMor = Convert.ToInt32(reader["ReqEmpFriMor"]);
                    ReqEmpFriAft = Convert.ToInt32(reader["ReqEmpFriAft"]);
                    ReqEmpFriEve = Convert.ToInt32(reader["ReqEmpFriEve"]);
                    ReqEmpSatMor = Convert.ToInt32(reader["ReqEmpSatMor"]);
                    ReqEmpSatAft = Convert.ToInt32(reader["ReqEmpSatAft"]);
                    ReqEmpSatEve = Convert.ToInt32(reader["ReqEmpSatEve"]);
                    ReqEmpSunMor = Convert.ToInt32(reader["ReqEmpSunMor"]);
                    ReqEmpSunAft = Convert.ToInt32(reader["ReqEmpSunAft"]);
                    ReqEmpSunEve = Convert.ToInt32(reader["ReqEmpSunEve"]);

                    shiftPerDept = new ShiftPerDept(ReqEmpMonMor,
                                                  ReqEmpMonAft,
                                                  ReqEmpMonEve,
                                                  ReqEmpTueMor,
                                                  ReqEmpTueAft,
                                                  ReqEmpTueEve,
                                                  ReqEmpWedMor,
                                                  ReqEmpWedAft,
                                                  ReqEmpWedEve,
                                                  ReqEmpThuMor,
                                                  ReqEmpThuAft,
                                                  ReqEmpThuEve,
                                                  ReqEmpFriMor,
                                                  ReqEmpFriAft,
                                                  ReqEmpFriEve,
                                                  ReqEmpSatMor,
                                                  ReqEmpSatAft,
                                                  ReqEmpSatEve,
                                                  ReqEmpSunMor,
                                                  ReqEmpSunAft,
                                                  ReqEmpSunEve);

                }
                return shiftPerDept;
            }
            finally { connection.Close(); }
        }


        public List<Department> LoadDepartments()
        {
            string sql = "SELECT * from department";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                string name;
                int id;
                double fte;
                List<Department> departments = new List<Department>();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                    name = reader["Name"].ToString();
                    fte = Convert.ToDouble(reader["FTE"]);

                    departments.Add(new Department(id, name, fte));
                }
                return departments;
            }
            finally { connection.Close(); }
        }

        public int AddDepartment(Department department)
        {
            string sql = "INSERT INTO `department`(`Name`, `FTE`) VALUES (@name,@fte)";

            MySqlCommand command = new MySqlCommand(sql, connection);
            int recordsChanged = 0;
            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@name", department.Name);
                if (department.FTE != 0)
                {
                    command.Parameters.AddWithValue("@fte", department.FTE);
                }
                else
                {
                    command.Parameters.AddWithValue("@fte", 0);
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

        public int UpdateDepartment(Department department)
        {
            int recordsChanged = 0;
            string sql = "UPDATE `department` SET `ID`=@id,`Name`=@name,`FTE`=@fte WHERE ID=@id";

            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@id", department.Id);
                command.Parameters.AddWithValue("@name", department.Name);
                if (department.FTE != 0)
                {
                    command.Parameters.AddWithValue("@fte", department.FTE);
                }
                else
                {
                    command.Parameters.AddWithValue("@fte", 0);
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

        public int RemoveDepartment(Department department)
        {
            int recordsChanged = 0;
            string sql = "DELETE FROM `department` WHERE id=@pid;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@pid", department.Id);
                recordsChanged += command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }

    }
}
