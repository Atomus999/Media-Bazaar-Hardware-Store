<?php
include 'includes/class-autoloader.inc.php';
session_start();
if(isset($_SESSION["empId"])){
    $id = $_SESSION["empId"];
}
else{
    header("Location: index.php");
}

$empManager = new EmployeeManager();
$loggedEmp= $empManager->GetEmployeeById($id);
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <title>MediaBazaar-Account-Page</title>
        <meta charset="UTF-8" />
        <meta http-equiv="X-UA-Compatible" content="ie=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <link rel="shortcut icon" type="image/x-icon" href="images/sh_icon.ico" />
        <link rel="stylesheet" href="main.css" />
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.12.1/css/all.css" crossorigin="anonymous" />
        <link href="https://fonts.googleapis.com/css2?family=Bangers&display=swap" rel="stylesheet" />
        <link href="https://fonts.googleapis.com/css2?family=Kanit:wght@300&display=swap" rel="stylesheet" />
    </head>
    <body>
        <div class="backdrop"></div>
        <?php include 'includes/main-navigation.php'; ?>
        <section class="account-view-content">
            <div class="user-card-wrapper">
                <div class="user-card-header">
                    <i class="fas fa-user-cog"></i>
                </div>
                <div class="user-card-body">
                    <div class="user-overview-body-wrap">
                            <p id="uo-label-id" class="uo-label"><b>Id:</b></p>
                            <p id="uo-label-name" class="uo-label"><b>Name:</b></p>
                            <p id="uo-label-department" class="uo-label"><b>Department:</b></p>
                            <p id="uo-label-dob" class="uo-label"><b>DateOfBirth:</b></p>
                            <p id="uo-label-bsn" class="uo-label"><b>BSN:</b></p>
                            <p id="uo-label-userName" class="uo-label"><b>Username:</b></p>
                            <p id="uo-label-phoneNr" class="uo-label"><b>PhoneNr:</b></p>
                            <p id="uo-label-address" class="uo-label"><b>Address:</b></p>
                            <p id="uo-label-email" class="uo-label"><b>Email:</b></p>
                            <p id="uo-label-rfid" class="uo-label"><b>Rfid:</b></p>
                            <p id="uo-label-fte" class="uo-label"><b>FTE:</b></p>
                            <p id="uo-label-spouseName" class="uo-label"><b>Spouse Name:</b></p>
                            <p id="uo-label-spousePhoneNr" class="uo-label"><b>Spouse PhoneNr:</b></p>

                            <?php
                            $empManager->GenerateHtmlForGetEmployeeById($loggedEmp);
                            ?>
                            <!-- <p id="uo-text-id">23</p>
                            <p id="uo-text-name">John doe</p>
                            <p id="uo-text-department">Depot Worker</p>
                            <p id="uo-text-dob">27/05/1999</p>
                            <p id="uo-text-bsn">050505050505050</p>
                            <p id="uo-text-userName">iamGrooot</p>
                            <p id="uo-text-phoneNr">8585858585858585></p>
                            <p id="uo-text-address">bla bla bla bla bla bla bla</p>
                            <p id="uo-text-email">grjgjrrgj@gmail.com</p>
                            <p id="uo-text-rfid">0505059595959595</p>
                            <p id="uo-text-fte">0.5</p> -->
                    </div>
                    <a href="account-edit.php" class="user-edit-btn"><i class="fas fa-user-edit"></i>Edit info</a>
                </div>
            </div>
        </section>
        <?php include 'includes/main-footer.php'; ?>
        <script src="js/shared.js"></script>
    </body>
</html>