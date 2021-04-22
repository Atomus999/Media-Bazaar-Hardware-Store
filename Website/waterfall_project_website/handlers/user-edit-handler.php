<?php
include '../includes/class-autoloader.inc.php';
session_start();
if(isset($_SESSION["empId"])){
    $id = $_SESSION["empId"];
}
else{
    header("Location: index.php");
}

$empManager = new EmployeeManager();
$loggedEmp= $empManager->GetEmployeeById($id);

if(isset($_POST["employee-update-btn"]) && $_POST["employee-update-btn"] == "Submit"){

    if($_POST["input-edit-spouseFirstName"] != "" && $_POST["input-edit-spouseLastName"] != "" && $_POST["input-edit-spousePhoneNr"] != ""){

        if($loggedEmp->GetSpouse()->GetFirstName() == "" && $loggedEmp->GetSpouse()->GetLastName() == "" && $loggedEmp->GetSpouse()->GetPhoneNumber() == ""){

            $spouse = new Spouse($loggedEmp->GetId(), $_POST["input-edit-spouseFirstName"], $_POST["input-edit-spouseLastName"], $_POST["input-edit-spousePhoneNr"]);
            $empManager->CreateSpouse($spouse);
            $employeeObj = new Employee($loggedEmp->GetId(), $loggedEmp->GetFirstName(), $loggedEmp->GetLastName(), $loggedEmp->GetDepartment(), $loggedEmp->GetDateOfBirth(), $loggedEmp->GetBsn(), $_POST["input-edit-phone"], $_POST["input-edit-address"],$_POST["input-edit-email"] , $_POST["input-edit-username"], $_POST["input-edit-password"], $loggedEmp->GetRfid(), $loggedEmp->GetIsActive(), $loggedEmp->GetContractFte(), $spouse);
            $empManager->UpdateEmployee($employeeObj);
            header("Location: ../account-overview.php");
            
            
        }
        else{
            $spouse = new Spouse($loggedEmp->GetId(), $_POST["input-edit-spouseFirstName"], $_POST["input-edit-spouseLastName"], $_POST["input-edit-spousePhoneNr"]);
            $empManager->UpdateSpouse($spouse);
            $employeeObj = new Employee($loggedEmp->GetId(), $loggedEmp->GetFirstName(), $loggedEmp->GetLastName(), $loggedEmp->GetDepartment(), $loggedEmp->GetDateOfBirth(), $loggedEmp->GetBsn(), $_POST["input-edit-phone"], $_POST["input-edit-address"],$_POST["input-edit-email"] , $_POST["input-edit-username"], $_POST["input-edit-password"], $loggedEmp->GetRfid(), $loggedEmp->GetIsActive(), $loggedEmp->GetContractFte(), $spouse);
            $empManager->UpdateEmployee($employeeObj);
            header("Location: ../account-overview.php");
        }
    }
    else{
        if($empManager->CheckIfSpouseExists($loggedEmp->GetId())){
            $empManager->RemoveSpouse($loggedEmp->GetId());
            $spouse = new Spouse($loggedEmp->GetId(),"", "", "");
            $employeeObj = new Employee($loggedEmp->GetId(), $loggedEmp->GetFirstName(), $loggedEmp->GetLastName(), $loggedEmp->GetDepartment(), $loggedEmp->GetDateOfBirth(), $loggedEmp->GetBsn(), $_POST["input-edit-phone"], $_POST["input-edit-address"],$_POST["input-edit-email"] , $_POST["input-edit-username"], $_POST["input-edit-password"], $loggedEmp->GetRfid(), $loggedEmp->GetIsActive(), $loggedEmp->GetContractFte(), $spouse);
            $empManager->UpdateEmployee($employeeObj);
            header("Location: ../account-overview.php");
        }
        else{
            $spouse = new Spouse($loggedEmp->GetId(),"", "", "");
            $employeeObj = new Employee($loggedEmp->GetId(), $loggedEmp->GetFirstName(), $loggedEmp->GetLastName(), $loggedEmp->GetDepartment(), $loggedEmp->GetDateOfBirth(), $loggedEmp->GetBsn(), $_POST["input-edit-phone"], $_POST["input-edit-address"],$_POST["input-edit-email"] , $_POST["input-edit-username"], $_POST["input-edit-password"], $loggedEmp->GetRfid(), $loggedEmp->GetIsActive(), $loggedEmp->GetContractFte(), $spouse);
            $empManager->UpdateEmployee($employeeObj);
            header("Location: ../account-overview.php");
        }
        
    }
    
}
?>