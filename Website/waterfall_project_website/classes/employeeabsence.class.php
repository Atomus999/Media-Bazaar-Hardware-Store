<?php
class EmployeeAbsence{
    private $empId;
    private $date;
    private $absenceReason;
    private $absenceDescription;
    private $ticketStatus;
    private $absenceTime;

    function __construct($empId, $date, $absenceReason, $absenceDescription, $ticketStatus, $absenceTime){
        $this->empId = $empId;
        $this->date = $date;
        $this->absenceReason = $absenceReason;
        $this->absenceDescription = $absenceDescription;
        $this->ticketStatus = $ticketStatus;
        $this->absenceTime = $absenceTime;
    }

    public function GetEmpId(){ return $this->empId;}
    public function GetDate(){ return $this->date;}
    public function GetAbsenceReason(){ return $this->absenceReason;}
    public function GetAbsenceDescription(){ return $this->absenceDescription;}
    public function GetTicketStatus(){ return $this->ticketStatus;}
    public function GetAbsenceTime(){ return $this->absenceTime;}
}
?>