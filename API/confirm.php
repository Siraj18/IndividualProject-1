<?php
require 'db.php';

$bookingNumber = $_POST["BookingNumber"];



    if (!isset($bookingNumber)) {
        echo "Пустые или неверные данные";
        exit;
    }
//echo check_user_exists($login);
echo confirm_book($bookingNumber);
?>