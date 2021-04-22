<?php
class EmployeeDh{

    private $database;

    public function __construct(){
        $db = new Dbh();
        $this->database = $db;
    }
    
    public function GetEmployeeById($id){
        $sql="SELECT * FROM employee WHERE id=:id";
        $results=$this->database->connect()->prepare($sql);
        $results->execute(['id' => $id]);

        $obj = null;
        foreach ($results as $row) {
            $obj = new Employee($row ["ID"], $row ["FirstName"], $row ["LastName"], $row ["Department"], $row ["DateOfBirth"], $row ["BSN"], $row ["PhoneNumber"], $row ["Address"], $row ["Email"], $row ["UserName"], $row ["Password"], $row ["RFID"], $row ["IsActive"], $row ["ContractFTE"], $this->GetSpouseByEmployeeId($id));
        }
        return $obj;
    }

    private function GetSpouseByEmployeeId($empId){
        $sql="SELECT * FROM spouse WHERE Emp_ID=:id";
        $results=$this->database->connect()->prepare($sql);
        $results->execute(['id' => $empId]);

        $obj = null;
        foreach ($results as $row) {
            $obj = new Spouse($empId, $row["FirstName"], $row["LastName"], $row["PhoneNumber"]);
        }
        if($obj == null)
        $obj= new Spouse($empId, "", "", "");
        return $obj;
    }

    public function CheckIfSpouseExists($empId){
        $sql="SELECT * FROM spouse WHERE Emp_ID=:id";
        $results=$this->database->connect()->prepare($sql);
        $results->execute(['id' => $empId]);

        if($results->rowCount() == 1){
            return true;
        }
        else{
            return false;
        }
    }

    public function getEmployeeByUsername($username){
        $sql="SELECT * FROM employee WHERE UserName=:username";
        $results=$this->database->connect()->prepare($sql);
        $results->execute(['username' => $username]);

        $obj = null;
        foreach ($results as $row) {
            $obj = new Employee($row ["ID"], $row ["FirstName"], $row ["LastName"],$row ["Department"], $row ["DateOfBirth"], $row ["BSN"], $row ["PhoneNumber"], $row ["Address"], $row ["Email"], $row ["UserName"], $row ["Password"], $row ["RFID"], $row ["IsActive"], $row ["ContractFTE"], $this->GetSpouseByEmployeeId($row["ID"]));
        }
        return $obj;
    }

    public function ValidateLogIn($username,$password){
        $query = "
        SELECT * FROM employee WHERE UserName=:username AND Password=:password AND IsActive != 0
        ";
        $results = $this->database->connect()->prepare($query);
        $results->bindValue(":username",$username);
        $results->bindValue(":password",$password);
    //     $query = $con->prepare("
    // SELECT * FROM website_signup WHERE Email=:Email AND Password=:Password
    // ");

    // $query->bindParam(":Email",$email);
    // $query->bindParam(":Password",$password);

    $results->execute();

    // check rows

    if($results->rowCount() == 1){
        return true;
    }
    else{
        return false;
    }

    }
    public function GetDayPlansForEmployeeById($id){
        $sql="SELECT * FROM dayplan WHERE Emp_ID=:id";
        $results=$this->database->connect()->prepare($sql);
        $results->execute(['id' => $id]);

        $dayplans=[];
        foreach($results as $row){
        $obj = new DayPlan($row ["ID"],$row ["Emp_ID"],$row ["Date"],$row ["Morning"],$row ["Afternoon"],$row ["Evening"]);
        $dayplans[] = $obj;
        }

        return $dayplans;
    }

    public function UpdateEmployee($employee){
        $spouseFirstName=$employee->GetSpouse()->GetFirstName();
        $spouseLastName =$employee->GetSpouse()->GetLastName();
        $spouseFullName = "";
        if($spouseFirstName != "" && $spouseLastName != ""){
            $spouseFullName= $employee->GetSpouse()->GetFirstName() . " " . $employee->GetSpouse()->GetLastName();
        }
        $sql="UPDATE `employee` SET `ID`=:id, `FirstName`=:emp_Firstname, `LastName`=:emp_Lastname, `Department`=:department, `DateOfBirth`=:dateOfBirth, `BSN`=:bsn, `PhoneNumber`=:phoneNumber, `Address`=:emp_address, `Email`=:email, `UserName`=:userName, `Password`=:emp_password, `RFID`=:rfid, `IsActive`=:isActive, `ContractFTE`=:contractFte, `Spouse`=:spouseName WHERE `ID`=:id";
        $results=$this->database->connect()->prepare($sql);
        $results->bindValue(':id', $employee->GetId());
        $results->bindValue(':emp_Firstname', $employee->GetFirstName());
        $results->bindValue(':emp_Lastname', $employee->GetLastName());
        $results->bindValue(':department', $employee->GetDepartment());
        $results->bindValue(':bsn', $employee->GetBsn());
        $results->bindValue(':dateOfBirth', $employee->GetDateOfBirth());
        $results->bindValue(':phoneNumber', $employee->GetPhoneNumber());
        $results->bindValue(':emp_address', $employee->GetAddress());
        $results->bindValue(':email', $employee->GetEmail());
        $results->bindValue(':userName', $employee->GetUserName());
        $results->bindValue(':emp_password', $employee->GetPassword());
        $results->bindValue(':rfid', $employee->GetRfid());
        $results->bindValue(':isActive', $employee->GetIsActive());
        $results->bindValue(':contractFte', $employee->GetContractFte());
        $results->bindValue(':spouseName', $spouseFullName);
        $results->execute();
    }

    public function GetAllAbsencesCount($empId){
    $sql = "SELECT COUNT(*) FROM employeeabsence WHERE Emp_Id={$empId}";
        $results = $this->database->connect()->query($sql)->fetchColumn();
        return $results;
    }

    public function GetAllAbsencesByLimit($empId, $startNr,$nrPerPage){
        $sql = "SELECT * FROM employeeabsence WHERE Emp_Id={$empId} ORDER BY `ID` DESC LIMIT {$startNr}, {$nrPerPage} ";
        $results = $this->database->connect()->query($sql);

        $absences=[];
        foreach($results as $row){
        $obj = new EmployeeAbsence($row ["Emp_Id"],$row ["Date"],$row ["AbsenceReason"],$row ["AbsenceDescription"],$row ["TicketStatus"], $row["AbsenceTime"]);
        $absences[] = $obj;
        }

        return $absences;
    }

    public function CheckAbsenceDate($empId, $date){
        $sql = "SELECT * FROM employeeabsence WHERE `Date`=:absDate AND Emp_Id=:absEmpId";
        $results = $this->database->connect()->prepare($sql);
        $results->bindValue(':absDate', $date);
        $results->bindValue(':absEmpId', $empId);
        $results->execute();

        if($results->rowCount() == 1){
            return true;
        }
        else{
            return false;
        }
    }

    public function CreateAbsence($absence){
        $sql = "INSERT INTO employeeabsence (Emp_Id, `Date`, AbsenceReason, AbsenceDescription, TicketStatus, AbsenceTime) VALUES (?, ?, ?, ?, ?, ?)";
        $stmt=$this->database->connect()->prepare($sql);
        $stmt->execute([$absence->GetEmpId(), $absence->GetDate(), $absence->GetAbsenceReason(), $absence->GetAbsenceDescription(), $absence->GetTicketStatus(), $absence->GetAbsenceTime()]);
    }

    public function CreateSpouse($spouse){
        $sql = "INSERT INTO spouse (Emp_ID, `FirstName`, LastName, PhoneNumber) VALUES (?, ?, ?, ?)";
        $stmt=$this->database->connect()->prepare($sql);
        $stmt->execute([$spouse->GetEmpId(), $spouse->GetFirstName(), $spouse->GetLastName(), $spouse->GetPhoneNumber()]);
    }

    public function UpdateSpouse($spouse){
        $sql="UPDATE spouse SET FirstName=:firstName, LastName=:lastName, PhoneNumber=:phoneNumber WHERE Emp_ID=:empId";
        $results=$this->database->connect()->prepare($sql);
        $results->bindValue(':empId', $spouse->GetEmpId());
        $results->bindValue(':firstName', $spouse->GetFirstName());
        $results->bindValue(':lastName', $spouse->GetLastName());
        $results->bindValue(':phoneNumber', $spouse->GetPhoneNumber());
        $results->execute();
    }

    public function RemoveSpouse($empId){
            $sql="DELETE FROM spouse WHERE Emp_ID=:id";
            $result= $this->database->connect()->prepare($sql);
            $result->bindValue(":id", $empId);
            $result->execute();
    }

}
?>