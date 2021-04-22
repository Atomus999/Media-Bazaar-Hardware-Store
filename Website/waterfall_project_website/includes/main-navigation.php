<header class="main-header">
    <button class="toggle-button">
        <span class="toggle-button_bar"></span>
        <span class="toggle-button_bar"></span>
        <span class="toggle-button_bar"></span>
    </button>
    <div class="main-header_brand">
        <img src="images/MediaBazaar.png" alt="Store Logo" />
    </div>
    <nav class="main-nav">
        <ul class="main-nav_items">
            <li class="main-nav_item main-nav_item--user">
                <p><?php echo "Hello, " . $empManager->GetEmployeeById($_SESSION["empId"])->GetFirstName();?></p>
            </li>
            <li class="main-nav_item">
                <a href="schedule.php">Schedule</a>
            </li>
            <li class="main-nav_item">
                <a href="account-overview.php">Account</a>
            </li>
            <li class="main-nav_item main-nav_item--cta">
                <a href="handlers/user-logout-handler.php"><i class="fas fa-sign-in-alt"></i>Log Out</a>
            </li>
        </ul>
    </nav>
</header>
<nav class="mobile-nav">
    <ul class="mobile-nav_items">
    <li class="mobile-nav_item main-nav_item--user">
                <p><?php echo "Hello, " . $empManager->GetEmployeeById($_SESSION["empId"])->GetFirstName();?></p>
            </li>
        <li class="mobile-nav_item">
            <a href="schedule.php">Schedule</a>
        </li>
        <li class="mobile-nav_item">
            <a href="account-overview.php">Account</a>
        </li>
        <li class="mobile-nav_item mobile-nav_item--cta">
            <a href="handlers/user-logout-handler.php">Log Out</a>
        </li>
    </ul>
</nav>