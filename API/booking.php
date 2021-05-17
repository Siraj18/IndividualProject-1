<?php
require 'db.php';

$bookId = $_POST["BookID"];
$bookingNumber = $_POST["BookingNumber"];
$userId = $_POST["UserID"];
$userInfo = $_POST["FIO"];


    if (!isset($bookId) || !isset($bookingNumber) || !isset($userId) || !isset($userInfo)) {
        echo "Пустые или неверные данные";
        exit;
    }
//echo check_user_exists($login);
echo booking_book($bookId, $bookingNumber, $userId,$userInfo);
?>