<?php
include '../includes/class-autoloader.inc.php';
session_start();
if(isset($_SESSION["empId"])){
    $id = $_SESSION["empId"];
}
else{
    header("Location: index.php");
}

if (!function_exists('CheckDate')) {
    function CheckDate($date){
        if (false === strtotime($date)) { 
            return false;
        } 
        list($year, $month, $day) = explode('-', $date); 
        return checkdate($month, $day, $year);
    }
}

$empManager = new EmployeeManager();
$loggedEmp= $empManager->GetEmployeeById($id);
if(isset($_POST["absence-submit-btn"]) && $_POST["absence-submit-btn"] == "Submit"){
    $inputSwitchMorning = "";
    $inputSwitchAfternoon = "";
    $inputSwitchEvening = "";
    $inputAbsenceTime = "";
    $inputDate = $_POST["absence-date-input"];
    $inputReason = $_POST["select-abs-reason"];
    $inputDescription = $_POST["absence-input-description"];
    if(isset($_POST["morning_shift_switch"])){
        $inputSwitchMorning = $_POST["morning_shift_switch"];
    }
    if(isset($_POST["afternoon_shift_switch"])){
        $inputSwitchAfternoon = $_POST["afternoon_shift_switch"];
    }
    if(isset($_POST["evening_shift_switch"])){
        $inputSwitchEvening = $_POST["evening_shift_switch"];
    }

    if($inputSwitchMorning == "" && $inputSwitchAfternoon == "" && $inputSwitchEvening == ""){
        $inputAbsenceTime= "AllDay";
    }
    elseif($inputSwitchMorning != "" && $inputSwitchAfternoon != ""){
        $inputAbsenceTime = $inputSwitchMorning . "," . $inputSwitchAfternoon;
    }
    elseif($inputSwitchAfternoon != "" && $inputSwitchEvening !=""){
        $inputAbsenceTime = $inputSwitchAfternoon . "," . $inputSwitchEvening;
    }
    elseif($inputSwitchMorning != "" && $inputSwitchAfternoon == "" && $inputSwitchEvening == ""){
        $inputAbsenceTime = $inputSwitchMorning;
    }
    elseif($inputSwitchMorning == "" && $inputSwitchAfternoon != "" && $inputSwitchEvening == ""){
        $inputAbsenceTime = $inputSwitchAfternoon;
    }
    elseif($inputSwitchMorning == "" && $inputSwitchAfternoon == "" && $inputSwitchEvening != ""){
        $inputAbsenceTime = $inputSwitchEvening;
    }

    if(empty($inputDate) || empty($inputReason) || empty($inputDescription)){
        $_SESSION["userEditError"] = true;
        header("Location: ../report-abs.php");
    } 
    else{
        if(strlen($inputReason) < 50 || strlen($inputDescription) < 200 || CheckDate($inputDate)){
            if($empManager->CheckAbsenceDate($loggedEmp->GetId() ,$inputDate) || $inputDate < date("Y-m-d")){
                $_SESSION["userEditError"] = true;
                $_SESSION["userEditError_Absence"] = true;
                header("Location: ../report-abs.php");
            }
            else{
                $absence = new EmployeeAbsence($loggedEmp->GetId(), $inputDate, $inputReason, $inputDescription, "Pending", $inputAbsenceTime);
                $empManager->CreateAbsence($absence);
                $_SESSION["userEditError"] = false;
                $_SESSION["userEditError_Absence"] = false;
                header("Location: ../schedule.php");
            }
        }
        else{
            $_SESSION["userEditError"] = true;
            header("Location: ../report-abs.php");
           // echo "fail at lenghth";
        }
    }
    
}
else{
    header("Location: ../schedule.php");
    //echo "fail at submit";
}
?>