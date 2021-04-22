using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hardware_App
{
    public class Spouse
    {
        private int empID;
        private string firstName;
        private string lastName;
        private string phoneNumber;

        public int EmpID
        {
            get { return this.empID; }
            set { this.empID = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                try
                {
                    bool success = Regex.IsMatch(value, @"316-[0-9]{4}-[0-9]{4}$");
                    if (success)
                    {
                        this.phoneNumber = value;
                    }
                }
                catch (PhoneNumberException ex)
                {

                }
            }
        }

        public Spouse(int empid, string firstname, string lastname, string phonenumber)
        {
            this.empID = empid;
            this.firstName = firstname;
            this.lastName = lastname;
            this.phoneNumber = phonenumber;
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName}";
        }
    }
}
