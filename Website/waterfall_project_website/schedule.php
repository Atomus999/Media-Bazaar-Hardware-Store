<?php
include 'includes/class-autoloader.inc.php';
session_start();
if(isset($_SESSION["empId"])){
    $id = $_SESSION["empId"];
}
else{
    header("Location: index.php");
}

if(isset($_SESSION["userEditError"])){
    unset($_SESSION['userEditError']);
    unset($_SESSION['userEditError_Absence']);
}

$empManager = new EmployeeManager();
$inputDay=date("Y-m-d");
if(isset($_POST['btn-schedule-date'])) {
    $postDate = $_POST['date-picker-schedule'];
    $inputDay = $postDate;
  } 

$empDayPlans= $empManager->GetDayPlansForEmployeeById($id);
$weekDays= $empManager->GetDaysOfTheWeek($inputDay);


$page = isset($_GET['page']) ? $_GET['page'] : 1;
$absencePerPage= 5;
$startNr=($absencePerPage * $page) - $absencePerPage;
$totalAbsences = $empManager->GetAllAbsencesCount($id);
$total_pages=ceil( $totalAbsences / $absencePerPage );
$absencesByLimit= $empManager->GetAllAbsencesByLimit($id, $startNr, $absencePerPage);
$absenceVisible= "";
if($totalAbsences < 1){
    $absenceVisible= "hidden";
}
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <title>MediaBazaar-Schedule</title>
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
        <section class="schedule-content">
            <form action="" method="post" class="schedule-form">
            <b>Select day:</b>
                <input type="date" value="Y-m-d" name="date-picker-schedule" id="dp-schedule" />
                <input type="submit" value="Show schedule" name="btn-schedule-date" class="btn-submit-schedule-date" />
            </form>
            <div class="schedule-table">
                <div class="mo-wrapper day-wrapper">
                    <div class="mo-head day-head"><p>Monday<?php echo "<br>" . $weekDays[0]; ?></p></div>
                    <div class="mo-cell day-cell">
                    <?php 
                    foreach($empDayPlans as $dayPlan){
                        if($dayPlan->GetDate() == $weekDays[0]){
                            $empManager->GenerateHtmlForDayPlanShift($dayPlan);
                        }
                    }
                    ?>
                    </div>
                </div>
                <div class="tu-wrapper day-wrapper">
                    <div class="tu-head day-head"><p>Tuesday<?php echo "<br>" . $weekDays[1]; ?></p></div>
                    <div class="tu-cell day-cell">
                    <?php 
                    foreach($empDayPlans as $dayPlan){
                        if($dayPlan->GetDate() == $weekDays[1]){
                            $empManager->GenerateHtmlForDayPlanShift($dayPlan);
                        }
                    }
                    ?>
                    </div>
                </div>
                <div class="we-wrapper day-wrapper">
                    <div class="we-head day-head"><p>Wednesday<?php echo "<br>" . $weekDays[2]; ?></p></div>
                    <div class="we-cell day-cell">
                    <?php 
                    foreach($empDayPlans as $dayPlan){
                        if($dayPlan->GetDate() == $weekDays[2]){
                            $empManager->GenerateHtmlForDayPlanShift($dayPlan);
                        }
                    }
                    ?>
                    </div>
                </div>
                <div class="th-wrapper day-wrapper">
                    <div class="th-head day-head"><p>Thursday<?php echo "<br>" . $weekDays[3]; ?></p></div>
                    <div class="th-cell day-cell">
                    <?php 
                    foreach($empDayPlans as $dayPlan){
                        if($dayPlan->GetDate() == $weekDays[3]){
                            $empManager->GenerateHtmlForDayPlanShift($dayPlan);
                        }
                    }
                    ?>
                    </div>
                </div>
                <div class="fr-wrapper day-wrapper">
                    <div class="fr-head day-head"><p>Friday<?php echo "<br>" . $weekDays[4]; ?></p></div>
                    <div class="fr-cell day-cell">
                    <?php 
                    foreach($empDayPlans as $dayPlan){
                        if($dayPlan->GetDate() == $weekDays[4]){
                            $empManager->GenerateHtmlForDayPlanShift($dayPlan);
                        }
                    }
                    ?>
                    </div>
                </div>
                <div class="sa-wrapper day-wrapper">
                    <div class="sa-head day-head"><p>Saturday<?php echo "<br>" . $weekDays[5]; ?></p></div>
                    <div class="sa-cell day-cell">
                    <?php 
                    foreach($empDayPlans as $dayPlan){
                        if($dayPlan->GetDate() == $weekDays[5]){
                            $empManager->GenerateHtmlForDayPlanShift($dayPlan);
                        }
                    }
                    ?>
                    </div>
                </div>
                <div class="su-wrapper day-wrapper">
                    <div class="su-head day-head"><p>Sunday<?php echo "<br>" . $weekDays[6]; ?></p></div>
                    <div class="su-cell day-cell">
                    <?php 
                    foreach($empDayPlans as $dayPlan){
                        if($dayPlan->GetDate() == $weekDays[6]){
                            $empManager->GenerateHtmlForDayPlanShift($dayPlan);
                        }
                    }
                    ?>
                    </div>
                </div>
            </div>
            <a id="btn_nav_report_abs" href="report-abs.php">Report Absence</a>
            <div class="absence-overview-container<?php echo" ".$absenceVisible?>">
                <div class="absence-overview-title">
                    <p><i class="fas fa-user-clock"></i>Absence Overview</p>
                </div>
                <div class="abs-line"></div>
                <div class="absence-overview-list">
                    <?php 
                        foreach ($absencesByLimit as $absence) {
                            $empManager->GenerateHtmlForAbsence($absence);
                        }
                    ?>
                </div>
                <div class="absence-overview-list-controls">
                <?php
                    if($page>1){
                        // btn first page
                        echo "<a href='" . $_SERVER['PHP_SELF'] . "?page=1";
                        echo "' title='Go to the first page.' class='a-first-page-btn'>";
                        echo "<<";
                        echo "</a>";
                        
                        // btn previous page
                        $prev_page = $page - 1;
                        echo "<a href='" . $_SERVER['PHP_SELF'] . "?page={$prev_page}";
                        echo "' title='Previous page is {$prev_page}.' class='a-previous-page-btn'>";
                        echo "<";
                        echo "</a>";
                        
                    } 
                        
                    if($page<$total_pages){
                        // btn the next page
                        $next_page = $page + 1;
                        echo "<a href='" . $_SERVER['PHP_SELF'] . "?page={$next_page}";
                        echo "' title='Next page is {$next_page}.' class='a-next-page-btn push'>";
                            echo "> ";
                        echo "</a>";
                        
                        // btn the last page
                        echo "<a href='" . $_SERVER['PHP_SELF'] . "?page={$total_pages}";
                        echo "' title='Last page is {$total_pages}.' class='a-last-page-btn'>";
                        echo ">>";
                        echo "</a>";
                    }
                ?>
                </div>
            </div>
            <button onclick="topFunction()" id="goTop-btn" title="Go to top"><i class="fas fa-arrow-up"></i>Top</button>
        </section>
        <?php include 'includes/main-footer.php'; ?>
        <script src="js/shared.js"></script>
    </body>
</html>