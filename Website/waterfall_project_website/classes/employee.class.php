<?php
class Employee{

    private $id;
    private $firstName;
    private $lastName;
    private $department;
    private $dateOfBirth;
    private $bsn;
    private $phoneNumber;
    private $address;
    private $email;
    private $userName;
    private $password;
    private $rfid;
    private $isActive;
    private $contractFte;
    private $spouse;

    function __construct($id, $firstName, $lastName, $department, $dateOfBirth, $bsn, $phoneNumber, $address, $email, $userName, $password, $rfid, $isActive, $contractFte, $spouse) {
        $this->id = $id;
        $this->firstName = $firstName;
        $this->lastName = $lastName;
        $this->department = $department;
        $this->dateOfBirth = $dateOfBirth;
        $this->bsn = $bsn;
        $this->phoneNumber = $phoneNumber;
        $this->address = $address;
        $this->email = $email;
        $this->userName = $userName;
        $this->password = $password;
        $this->rfid = $rfid;
        $this->isActive = $isActive;
        $this->contractFte = $contractFte;
        $this->spouse = $spouse;
    }

    public function GetId() { return $this->id; }
    public function GetFirstName() { return $this->firstName; }
    public function GetLastName() { return $this->lastName; }
    public function GetDepartment() { return $this->department; }
    public function GetDateOfBirth() {return $this->dateOfBirth; }
    public function GetBsn() { return $this->bsn; }
    public function GetPhoneNumber() { return $this->phoneNumber; }
    public function GetAddress() { return $this->address; }
    public function GetEmail() { return $this->email; }
    public function GetUserName() { return $this->userName; }
    public function GetPassword() { return $this->password; }
    public function GetRfid() { return $this->rfid; }
    public function GetIsActive() { return $this->isActive; }
    public function GetContractFte() { return $this->contractFte; }
    public function GetSpouse(){ return $this->spouse; }
}
?>