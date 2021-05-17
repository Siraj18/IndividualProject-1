<?php
require 'db.php';

$emailUser = $_POST["email"];
$messageUser = $_POST["Message"];
$userId = $_POST["UserID"];
$userInfo = $_POST["FIO"];
$userDevice = $_POST["Device"];
$userProces = $_POST["Proces"];


    if (!isset($emailUser) || !isset($messageUser) || !isset($userId) || !isset($userInfo) || !isset($userDevice) || !isset($userProces)) {
        echo "Пустые или неверные данные";
        exit;
    }
//echo check_user_exists($login);
send_report($userId, $messageUser, $userInfo, $emailUser, $userDevice, $userProces);
?>