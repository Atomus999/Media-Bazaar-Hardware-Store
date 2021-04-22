using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class EmployeeAbsence
    {
        private int id;
        private int empId;
        private DateTime date;
        private string absenceReason;
        private string absenceDescription;
        private string ticketStatus;
        private string absenceTime;

        public int Id { get { return this.id; } set { id = value; } }
        public int EmpId { get { return this.empId; } set { empId = value; } }
        public string EmployeeName { get; set; }
        public DateTime Date { get { return this.date; } set { date = value; } }
        public string AbsenceReason { get { return this.absenceReason; } set { absenceReason = value; } }
        public string AbsenceDescription { get { return this.absenceDescription; } set { absenceDescription = value; } }
        public string TicketStatus { get { return this.ticketStatus; } set { ticketStatus = value; } }
        public string AbsenceTime { get { return this.absenceTime; } set { absenceTime = value; } }

        public EmployeeAbsence(int id, int empId, DateTime date, string absenceReason, string absenceDescription, string ticketStatus)
        {
            this.id = id;
            this.empId = empId;
            this.date = date;
            this.absenceReason = absenceReason;
            this.absenceDescription = absenceDescription;
            this.ticketStatus = ticketStatus;
        }

        public override string ToString()
        {
            return $"Id {id} EmpId {empId} Date {date} AbsenceReason{absenceReason} AbsenceDescription {absenceDescription} TicketStatus {ticketStatus}";
        }

    }
}
