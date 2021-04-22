<?php
class Spouse{
    private $empId;
    private $fistName;
    private $lastName;
    private $phoneNumber;

    public function __construct($empId, $fistName, $lastName, $phoneNumber)
    {
        $this->empId= $empId;
        $this->fistName= $fistName;
        $this->lastName= $lastName;
        $this->phoneNumber= $phoneNumber;
    }

    public function GetEmpId(){ return $this->empId; }
    public function GetFirstName(){ return $this->fistName; }
    public function GetLastName(){ return $this->lastName; }
    public function GetPhoneNumber(){ return $this->phoneNumber; }
}
?>