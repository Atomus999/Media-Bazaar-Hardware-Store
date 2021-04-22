<?php
class EmployeeManager{

    private $employeeDh;

    public function __construct(){
        $this->employeeDh = new EmployeeDh();
    }

    /*Employee management section*/

    public function GetEmployeeById($id){
        if($id <= 0){
            return false;
        }

        return $this->employeeDh->GetEmployeeById($id);
    }

    public function getEmployeeByUsername($username){
        return $this->employeeDh->getEmployeeByUsername($username);
    }

    public function ValidateLogIn($username,$password){
        $inputUsername = $this->sanitizeString($username);
        $inputPassword = $this->sanitizeString($password);
        if($username == "" || $password == "")
    {
        return false; // echo update ,p>
    }
    else{
       
        return  $this->employeeDh->ValidateLogIn($inputUsername,$inputPassword);
    }
    }

    private function sanitizeString ($string){

        $string = strip_tags($string);

        $string = str_replace(" ","",$string);

    return $string;
}

   

    public function GenerateHtmlForGetEmployeeById($employee){
        $spouse = $employee->GetSpouse();
        echo 
        "
        <p id=\"uo-text-id\" class=\"uo-text\">" . $employee->GetId() . "</p>
        <p id=\"uo-text-name\" class=\"uo-text\">" . $employee->GetFirstName() . " " . $employee->GetLastName().  "</p>
        <p id=\"uo-text-department\" class=\"uo-text\">" . $employee->GetDepartment() . "</p>
        <p id=\"uo-text-dob\" class=\"uo-text\">" . $employee->GetDateOfBirth() . "</p>
        <p id=\"uo-text-bsn\" class=\"uo-text\">". $employee->GetBsn() . "</p>
        <p id=\"uo-text-userName\" class=\"uo-text\">" . $employee->GetUserName() . "</p>
        <p id=\"uo-text-phoneNr\" class=\"uo-text\">" . $employee->GetPhoneNumber() . "</p>
        <p id=\"uo-text-address\" class=\"uo-text\">" . $employee->GetAddress() . "</p>
        <p id=\"uo-text-email\" class=\"uo-text\">" . $employee->GetEmail() . "</p>
        <p id=\"uo-text-rfid\" class=\"uo-text\">" . $employee->GetRfid(). "</p>
        <p id=\"uo-text-fte\" class=\"uo-text\">" . $employee->GetContractFte(). "</p>
        <p id=\"uo-text-spouseName\" class=\"uo-text\">" . $spouse->GetFirstName(). " ". $spouse->GetLastName() . "</p>
        <p id=\"uo-text-spousePhoneNr\" class=\"uo-text\">" . $spouse->GetPhoneNumber(). "</p>";
    }

    public function UpdateEmployee($employee){
        if($employee->GetPhoneNumber() != "" || $employee->GetUserName() != "" || $employee->GetPassword() != "" || $employee->GetAddress() != "" || $employee->GetEmail() != "" ){
            $this->employeeDh->UpdateEmployee($employee);
        }
        else{
            return false;
        }
    }

    /*Schedule section*/

    public function GetDayPlansForEmployeeById($id){
        if($id <= 0){
            return false;
        }

        return $this->employeeDh->GetDayPlansForEmployeeById($id);
    }

    public function GenerateHtmlForDayPlanShift($dayPlan){
        if($dayPlan->GetMorning() != 0){
            echo "
            <span class=\"morning-shift\">
                            <p>
                                Morning<br />
                                08:00AM-12:30PM
                            </p>
                        </span>
            ";
        }

        if($dayPlan->GetAfternoon() !=0){
            echo "
            <span class=\"afternoon-shift\">
                            <p>
                                Afternoon<br />
                                12:30PM-17:00PM
                            </p>
                        </span>
            ";
        }

        if($dayPlan->GetEvening() !=0){
            echo"
            <span class=\"evening-shift\">
                            <p>
                                Evening<br />
                                17:00PM-21:30PM
                            </p>
                        </span>
            ";
        }

    }

    public function GetDaysOfTheWeek($inputDay){
        if($inputDay == ""){
            $inputDay= date('Y-m-d');
        }
        $dayNumber= date('N', strtotime($inputDay));

        $daysWeekAfter= [];
        $daysWeekBefore= [];

        //retrive days of the week after the selected day
        for($i = $dayNumber; $i <= 7;$i++){
            $nextDay= strtotime('+' . $i - $dayNumber . ' day', strtotime($inputDay));
            array_push($daysWeekAfter, date('Y-m-d', $nextDay));
        }

        //retrive before selected day
        for($dayNumber; $dayNumber > 1; $dayNumber--){
            $previousDay= strtotime('-' . ($dayNumber - 1) . ' day', strtotime($inputDay));
            array_push($daysWeekBefore, date('Y-m-d', $previousDay));
        }

        //return merged days before and after in array
        return array_merge($daysWeekBefore, $daysWeekAfter);
    }
    /*Absences */
    public function GetAllAbsencesByLimit($empId, $startNr,$nrPerPage)
    {
        return $this->employeeDh->GetAllAbsencesByLimit($empId, $startNr,$nrPerPage);
    }

    public function GetAllAbsencesCount($empId)
    {
        return $this->employeeDh->GetAllAbsencesCount($empId);
    }

    public function CreateAbsence($absence){
        $this->employeeDh->CreateAbsence($absence);
    }

    public function CheckAbsenceDate($empId, $date){
        return $this->employeeDh->CheckAbsenceDate($empId, $date);
    }

    public function GenerateHtmlForAbsence($absence)
    {
        $timeIcon = "";
        if(false !== strpos($absence->GetAbsenceTime(), "Morning") || false !==strpos($absence->GetAbsenceTime(), "Afternoon")){
            $timeIcon = "sun";
        }
        elseif($absence->GetAbsenceTime() == "Evening"){
             $timeIcon="moon";
        }
        if($absence->GetTicketStatus() == "Rejected"){
            echo "
            <button class=\"absence-container-btn absence-denied\">
                        <p class=\"absence-date\">Date: " . $absence->GetDate() . "</p>
                        <p class=\"absence-reason\">Reason: " . $absence->GetAbsenceReason() . "</p>
                        <p class=\"absence-time\"><i class=\"fas fa-" . $timeIcon . "\"></i> " . $absence->GetAbsenceTime() . "</p>
                        <p class=\"absence-status\">Denied<i class=\"fas fa-thumbs-down\"></i></p>
                    </button>
            ";
        }
        if($absence->GetTicketStatus() == "Accepted"){
            echo"
            <button class=\"absence-container-btn absence-approved\">
                        <p class=\"absence-date\">Date: " . $absence->GetDate() . "</p>
                        <p class=\"absence-reason\">Reason: " . $absence->GetAbsenceReason() . "</p>
                        <p class=\"absence-time\"><i class=\"fas fa-" . $timeIcon . "\"></i> " . $absence->GetAbsenceTime() . "</p>
                        <p class=\"absence-status\">Approved<i class=\"fas fa-thumbs-up\"></i></p>
                    </button>
            ";
        }
        if($absence->GetTicketStatus() == "Pending"){
            echo"
            <button class=\"absence-container-btn absence-pending\">
                        <p class=\"absence-date\">Date: " . $absence->GetDate() . "</p>
                        <p class=\"absence-reason\">Reason: " . $absence->GetAbsenceReason() . "</p>
                        <p class=\"absence-time\"><i class=\"fas fa-" . $timeIcon . "\"></i> " . $absence->GetAbsenceTime() . "</p>
                        <p class=\"absence-status\">Pending<i class=\"fas fa-hourglass-half\"></i></p>
                    </button>
            ";
        }
    }

    /*Spouce section*/
    public function CreateSpouse($spouse){
        $this->employeeDh->CreateSpouse($spouse);
    }

    public function UpdateSpouse($spouse){
        $this->employeeDh->UpdateSpouse($spouse);
    }

    public function RemoveSpouse($empId){
        $this->employeeDh->RemoveSpouse($empId);
    }

    public function CheckIfSpouseExists($empId){
        return $this->employeeDh->CheckIfSpouseExists($empId);
    }
}
?>