<?php
require 'db.php';

$login = $_POST["Login"];
$pass = $_POST["Pass"];
$firstName = $_POST["FirstName"];
$lastName = $_POST["LastName"];
$age = $_POST["Age"];
$userType = $_POST["UserType"];

    if (!isset($login) || !isset($pass) || !isset($firstName) || !isset($lastName) || !isset($age) || !isset($userType)) {
        echo "Пустые или неверные данные";
        exit;
    }
//echo check_user_exists($login);
echo register_user($login, $pass, $firstName, $lastName, $age, $userType);
?>