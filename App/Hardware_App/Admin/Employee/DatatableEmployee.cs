using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class DatatableEmployee
    {
        private string firstName;
        private string lastName;
        private string department;
        private string address;
        private int id;
        private RFIDcontrol rfid;
        private double fteContract;
        public int Id
        {
            get { return id; }
            set { id = value; }
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
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public double FteContract
        {
            get { return fteContract; }
            set { fteContract = value; }
        }
        public RFIDcontrol Rfid
        {
            get { return rfid; }
            set { rfid = value; }
        }
        public bool IsActive { get; set; }
        public DatatableEmployee(int id, string firstname, string lastname, string department, string address, bool isActive, double contractFTE, RFIDcontrol rfid)
        {
            this.id = id;
            this.firstName = firstname;
            this.lastName = lastname;
            this.department = department;
            this.address = address;
            this.IsActive = isActive;
            this.fteContract = contractFTE;
            this.rfid = rfid;
        }
    }
}
