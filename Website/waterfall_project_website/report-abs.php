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
        <title>MediaBazaar-Absence-Page</title>
        <meta charset="UTF-8" />
        <meta http-equiv="X-UA-Compatible" content="ie=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <link rel="shortcut icon" type="image/x-icon" href="images/sh_icon.ico" />
        <link rel="stylesheet" href="main.css" />
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.12.1/css/all.css" crossorigin="anonymous" />
        <link href="https://fonts.googleapis.com/css2?family=Bangers&display=swap" rel="stylesheet" />
        <link href="https://fonts.googleapis.com/css2?family=Kanit:wght@300&display=swap" rel="stylesheet" />
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" crossorigin="anonymous">
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-CuOF+2SnTUfTwSZjCXf01h7uYhfOBuxIhGKPbfEJ3+FqH/s6cIFN9bGr1HmAg4fQ" crossorigin="anonymous">
    </head>
    <body>
        <div class="backdrop"></div>
        <?php include 'includes/main-navigation.php'; ?>
        <section class="absence-report-content" id="abs_report_content">
            <form action="handlers/user-absence-handler.php" method="post" class="absence-form">
                <div class="absence-date-input-wrap">
                    <label for="absence-date-input">Date</label>
                    <input type="date" value="Y-m-d" name="absence-date-input" id="abs_date_input">
                </div>
                <div class="absence-reason-wrapper">
                    <label for="select-absence-reason">Reason</label>
                    <div class="absence-reason-input-container">
                        <select id="select-absence-reason" name="select-abs-reason">
                            <option value="Sick">Sick</option>
                            <option value="DayOff">DayOff</option>
                            <option value="Family and Medical Leave">Family and Medical Leave</option>
                        </select>
                    </div>
                </div>
                <div class="absence-shift-label-wrapper">
                    <label for="">Leave unchecked for a full day</label>
                </div>
                <div class="absence-shift-wrapper">
                    <div class="form-check form-switch">
                        <input class="form-check-input" type="checkbox" id="abs_morning_switch" name="morning_shift_switch" value="Morning" />
                        <label class="form-check-label" for="abs_morning_switch">Morning</label>
                    </div>
                    <div class="form-check form-switch">
                        <input class="form-check-input" type="checkbox" id="abs_afternoon_switch" name="afternoon_shift_switch" value="Afternoon" />
                        <label class="form-check-label" for="abs_afternoon_switch">Afternoon</label>
                    </div>
                    <div class="form-check form-switch">
                        <input class="form-check-input" type="checkbox" id="abs_evening_switch" name="evening_shift_switch" value="Evening" />
                        <label class="form-check-label" for="abs_evening_switch">Evening</label>
                    </div>
                </div>
                <div class="absence-description-wrapper">
                    <label for="absence-input-description">Description</label>
                    <textarea rows="10" cols="40" name="absence-input-description" id="abs_description_input"></textarea>
                </div>
                <div class="absence-mainArea-btns-wrapper">
                    <a id="btn_absence_form_cancel" href="schedule.php" class="absence-submit-btn">Cancel</a>
                    <input id="btn_absence_form_submit" type="submit" name="absence-submit-btn" value="Submit" class="absence-submit-btn" />
                </div>
                <div class="absence-form-error-wrap">
                    <?php 

                        $error_message = "Invalid Input";
                        if(isset($_SESSION["userEditError"])){
                            if(isset($_SESSION["userEditError_Absence"])){
                                if($_SESSION["userEditError"] == true && $_SESSION["userEditError_Absence"] == true){
                                    $error_message .= "(Please select another date)";
                                }
                            }
                            
                            echo "
                            <div class=\"absence-form-error\">
                                <p><i class=\"fas fa-exclamation-triangle\"></i>{$error_message}</p>
                            </div>
                            ";
                        }
                        
                    ?>
                </div>
                
            </form>
        </section>
        <?php include 'includes/main-footer.php'; ?>
        <script src="js/shared.js"></script>
        <script src="js/absence-switch.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-alpha3/dist/js/bootstrap.bundle.min.js" integrity="sha384-popRpmFF9JQgExhfw5tZT4I9/CI5e2QcuUZPOVXb1m7qUmeR2b50u+YFEYe1wgzy" crossorigin="anonymous"></script>
    </body>
</html>