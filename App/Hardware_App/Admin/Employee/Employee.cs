using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hardware_App
{
    public class Employee
    {
        private string name;
        private string firstName;
        private string lastName;
        private string department;
        private DateTime dateOfBirth;
        private double bsn;
        private string phoneNumber;
        private string address;
        private string email;
        private string userName;
        private string password;
        private int id;
        private RFIDcontrol rfid;
        private List<DayPlan> dayPlans;
        private double fteContract;
        private List<FteReal> actualFtes;
        private Spouse spouse;

        public ScheduleDays ScheduleDays { get; set; } = new ScheduleDays();
        
        public int NumberOfDayOff { get; set; }
        
        public bool IsActive { get; set; }
        public Spouse SetSpouse
        {
            get { return this.spouse; }
            set { this.spouse = value; }
        }
        public List<FteReal> ActualFtes
        {
            get { return actualFtes; }
            set { actualFtes = value; }
        }
        public RFIDcontrol Rfid
        {
            get { return rfid; }
            set { rfid = value; }
        }
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
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public double Bsn
        {
            get { return bsn; }
            set { bsn = value; }
        }
        public double FteContract
        {
            get { return fteContract; }
            set { fteContract = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                try
                {
                    bool success = Regex.IsMatch(value, @"316[0-9]{4}[0-9]{4}$");
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
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Employee(int id, string firstname, string lastname, string department, DateTime dateofbirth, double bsn, string phonenumber,
            string address, string email, string username, string password,double fte)
        {
            this.id = id;
            this.firstName = firstname;
            this.lastName = lastname;
            this.department = department;
            this.dateOfBirth = dateofbirth;
            this.bsn = bsn;
            this.PhoneNumber = phonenumber;
            this.address = address;
            this.email = email;
            this.userName = username;
            this.password = password;
            this.rfid = null;
            dayPlans = new List<DayPlan>();
            this.IsActive = true;
            this.fteContract = fte;
            this.spouse = null;
            actualFtes = new List<FteReal>();
        }

        

        public Employee(int id, string firstname, string lastname, string department, DateTime dateofbirth, double bsn, string phonenumber,
            string address, string email, string username, string password, RFIDcontrol rfid,bool isActive,double contractFTE)
        {
            
            this.id = id;
            this.firstName = firstname;
            this.lastName = lastname;
            this.department = department;
            this.dateOfBirth = dateofbirth;
            this.bsn = bsn;
            this.phoneNumber = phonenumber;
            this.address = address;
            this.email = email;
            this.userName = username;
            this.password = password;
            this.rfid = rfid;
            dayPlans = new List<DayPlan>();
            this.IsActive = isActive;
            actualFtes = new List<FteReal>();
            this.spouse = null;
            this.fteContract = contractFTE;
        }

        public Employee(int id, string firstname, string lastname, string department, DateTime dateofbirth, double bsn, string phonenumber,
            string address, string email, string username, string password, RFIDcontrol rfid, bool isActive, double contractFTE, Spouse spouse)
        {

            this.id = id;
            this.firstName = firstname;
            this.lastName = lastname;
            this.department = department;
            this.dateOfBirth = dateofbirth;
            this.bsn = bsn;
            this.phoneNumber = phonenumber;
            this.address = address;
            this.email = email;
            this.userName = username;
            this.password = password;
            this.rfid = rfid;
            dayPlans = new List<DayPlan>();
            this.IsActive = isActive;
            actualFtes = new List<FteReal>();
            this.spouse = null;
            this.fteContract = contractFTE;
            this.spouse = spouse;
        }
       
        public bool DatesAreInTheSameWeek(DateTime date1, DateTime date2)
        {
            var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
            var d1 = date1.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date1));
            var d2 = date2.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date2));

            return d1 == d2;
        }

        public double WeeklyActualFTE(DateTime dateCalendar)
        {
            double counter = 0;
            foreach (FteReal fte in actualFtes)
            {
                if (DatesAreInTheSameWeek(dateCalendar, fte.Date))
                    counter += fte.ActualFte;
            }
            return counter;
        }

        public int WeeklyNumberOfShift(DateTime dateCalendar)
        {
            int counter = 0;
            foreach (FteReal fte in actualFtes)
            {
                if (DatesAreInTheSameWeek(dateCalendar, fte.Date))
                    counter ++;
            }
            return counter;
        }

        public int WeeklyDayOff(DateTime dateCalender, List<EmployeeAbsence> absences)
        {
            int counter = 0;
            foreach (EmployeeAbsence ab in absences)
            {
                if (DatesAreInTheSameWeek(dateCalender, ab.Date))
                {
                    if (ab.EmpId == this.id)
                    {
                        counter ++;
                    }
                }   
            }
            return counter;
        }

        public void addActualFte(FteReal fteReal)
        {
            actualFtes.Add(fteReal);
        }
        public void removeActualFte(int empid, DateTime dateTime)
        {
            for (int i = 0; i < actualFtes.Count; i++)
            {
                FteReal fte = actualFtes[i];
                if (fte.EmpId == empid && fte.Date == dateTime)
                {
                    actualFtes.Remove(fte);
                    break;
                }
            }
            
        }

        public void addDayplan(DayPlan dayplan)
        {
            dayPlans.Add(dayplan);
        }

        public void removeDayplan(DayPlan dayplan)
        {
            dayPlans.Remove(dayplan);
        }
        public void deteleDayPlans()
        {
            dayPlans.Clear();
        }

        public List<DayPlan> GetDayPlans()
        {
            return dayPlans;
        }

        public void GetNewRfid()
        {
            this.rfid = new RFIDcontrol("0", false);
        }

        public List<DayPlan> GetDayPlansByDate(DateTime date)
        {
            List<DayPlan> dayPlansByDate = new List<DayPlan>();

            foreach (DayPlan dayPlan in dayPlans)
            {
                if (dayPlan.Date == date)
                {
                    dayPlansByDate.Add(dayPlan);
                }
            }
            return dayPlansByDate;
        }

        
        public string EmployeeInformation()
        {
            return $"ID : {this.id}, Name : {this.firstName+ " " +this.lastName}, Username : {this.userName}";
        }
        public override string ToString()
        {
            if(IsActive)
            return $"ID : {this.id}, Name : {this.firstName + " " + this.lastName}, Username : {this.userName}";
            else
                return $"ID : {this.id}, Name : {this.firstName + " " + this.lastName}, Username : {this.userName}, Deactivated";
        }
    }
}
