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
    public class DatabaseHelperSpouse
    {
        MySqlConnection connection;


        public DatabaseHelperSpouse()
        {
            string info = "Server = studmysql01.fhict.local; Uid = dbi426239; Database = dbi426239; Pwd = 1234;";
            connection = new MySqlConnection(info);
        }

        public List<Spouse> LoadSpouses()
        {
            string sql = "SELECT * from spouse";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                int empId;
                string firstName;
                string lastName;
                string phoneNumber;

                List<Spouse> spouses = new List<Spouse>();
                while (reader.Read())
                {
                    empId = Convert.ToInt32(reader["Emp_ID"]);
                    firstName = reader["FirstName"].ToString();
                    lastName = reader["LastName"].ToString();
                    phoneNumber = (reader["PhoneNumber"].ToString());

                    spouses.Add(new Spouse(empId, firstName, lastName, phoneNumber));

                }
                return spouses;
            }
            finally { connection.Close(); }
        }

        public int AddSpouse(Spouse spouse)
        {
            string sql = "INSERT INTO `spouse`(`Emp_ID`, `FirstName`, `LastName`, `PhoneNumber`)" +
                " VALUES (@id,@firstName,@lastName,@phonenumber)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int recordsChanged = 0;
            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@id", spouse.EmpID);
                command.Parameters.AddWithValue("@firstName", spouse.FirstName);
                command.Parameters.AddWithValue("@lastName", spouse.LastName);
                command.Parameters.AddWithValue("@phonenumber", spouse.PhoneNumber);
                recordsChanged += command.ExecuteNonQuery();
            }
            catch { return 0; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }

        public int UpdateSpouse(Spouse spouse)
        {
            int recordsChanged = 0;
            string sql = "UPDATE `spouse` SET `Emp_ID`=@id,`FirstName`=@firstName,`LastName`=@lastName,`PhoneNumber`=@phonenumber WHERE Emp_ID=@id";

            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", spouse.EmpID);
                command.Parameters.AddWithValue("@firstName", spouse.FirstName);
                command.Parameters.AddWithValue("@lastName", spouse.LastName);
                command.Parameters.AddWithValue("@phonenumber", spouse.PhoneNumber);
                recordsChanged += command.ExecuteNonQuery();
            }
            catch { return 0; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }
    }
}
