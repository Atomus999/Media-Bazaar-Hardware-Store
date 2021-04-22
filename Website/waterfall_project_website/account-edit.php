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
$spouse = $loggedEmp->GetSpouse();
$spouseVisibility = "";
if($spouse->GetFirstName() =="" && $spouse->GetLastName() =="" && $spouse->GetPhoneNumber() ==""){
    $spouseVisibility = "hidden";
}
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <title>MediaBazaar-Account-Edit-Page</title>
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
    <section class="account-edit-content">
        <div class="user-edit-card-wrapper">
            <div class="user-card-header">
                <i class="fas fa-user-edit"></i>
            </div>
            <div class="user-card-body">
                <form id="user_edit_info_form" action="handlers/user-edit-handler.php" method="post" class="user-edit-info-form">
                    <div class="user-edit-text-input-wrap">
                        <p class="edit-username user-edit-label"><b>Username:</b></p>
                        <input class="user-edit-text-input" type="text" name="input-edit-username" placeholder="" value="<?php echo $loggedEmp->GetUserName();?>" required />
                    </div>
                    <div class="edit-password user-edit-text-input-wrap">
                        <p class="user-edit-label"><b>Password:</b></p>
                        <div class="password-input-wrap">
                            <input id="ue-password-input" class="user-edit-text-input active" type="password" name="input-edit-password" placeholder="" value="<?php echo $loggedEmp->GetPassword();?>" required />
                            <div class="show-password-btn">
                                <i id="icon-password" class="fa fa-eye-slash"></i>
                            </div>
                        </div>
                    </div>
                    <div class="edit-phone user-edit-text-input-wrap">
                        <p class="user-edit-label"><b>Phone Nr:</b></p>
                        <input class="user-edit-text-input" type="text" name="input-edit-phone" placeholder="" pattern="316[0-9]{4}[0-9]{4}$" title="Phone number required format is 316-xxxx-xxxx" value="<?php echo $loggedEmp->GetPhoneNumber();?>" required />
                    </div>
                    <div class="edit-address user-edit-text-input-wrap">
                        <p class="user-edit-label"><b>Address:</b></p>
                        <input class="user-edit-text-input" type="text" name="input-edit-address" placeholder="" value="<?php echo $loggedEmp->GetAddress();?>" required />
                    </div>
                    <div class="edit-email user-edit-text-input-wrap">
                        <p class="user-edit-label"><b>Email:</b></p>
                        <input class="user-edit-text-input" type="email" name="input-edit-email" placeholder="" value="<?php echo $loggedEmp->GetEmail();?>" required />
                    </div>
                    <div class="spouse-btn-container">
                        <div id="spouse_btn" class="spouse-btn"></div>
                    </div>
                    <div class="edit-spouseFirstName user-edit-text-input-wrap <?php echo $spouseVisibility; ?>">
                        <p class="user-edit-label"><b>Spouse First Name:</b></p>
                        <input id="user_edit_spouseFirstName" class="user-edit-text-input" type="text" name="input-edit-spouseFirstName" placeholder="" value="<?php echo $spouse->GetFirstName();?>"/>
                    </div>
                    <div class="edit-spouseLastName user-edit-text-input-wrap <?php echo $spouseVisibility; ?>">
                        <p class="user-edit-label"><b>Spouse Last Name:</b></p>
                        <input id="user_edit_spouseLastName" class="user-edit-text-input" type="text" name="input-edit-spouseLastName" placeholder="" value="<?php echo $spouse->GetLastName();?>"/>
                    </div>
                    <div class="edit-spousePhoneNr user-edit-text-input-wrap <?php echo $spouseVisibility; ?>">
                        <p class="user-edit-label"><b>Spouse Phone Nr:</b></p>
                        <input id="user_edit_spousePhoneNr" class="user-edit-text-input" type="text" name="input-edit-spousePhoneNr" placeholder="" value="<?php echo $spouse->GetPhoneNumber();?>"/>
                    </div>
                    <div class="user-edit-form-btn-wrapper">
                        <a href="account-overview.php" class="user-edit-btn-cancel">Cancel</a>
                        <input type="submit" name="employee-update-btn" value="Submit" class="user-edit-submit-btn" />
                    </div>
                </form>
            </div>
        </div>
    </section>
    <?php include 'includes/main-footer.php'; ?>
    <script src="js/shared.js"></script>
    <script src="js/edit-user-spouse.js"></script>
</body>
</html>