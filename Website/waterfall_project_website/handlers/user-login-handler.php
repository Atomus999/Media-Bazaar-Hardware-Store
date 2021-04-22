<?php
include '../includes/class-autoloader.inc.php';
$empManager = new EmployeeManager();
/*Will change on login imp*/
session_start();
// $_SESSION["empId"] = POST["login-submit-btn"];
 
//header("Location: ../schedule.php");

if(isset($_POST["loginButton"])){
    
    $isValid = $empManager->ValidateLogIn($_POST["Username"],$_POST["Password"]);

    if($isValid){
        $employee = $empManager->getEmployeeByUsername($_POST["Username"]);
        $_SESSION["empId"] = $employee->GetId();
        $_SESSION["logInError"] = false;
        header("Location: ../schedule.php");
    }
    else{
        $_SESSION["logInError"] = true;
        header("Location: ../index.php");
    }
}
?>
