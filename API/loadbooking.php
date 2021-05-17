<?php
require 'db.php';

$userId = $_POST["UserID"];

if (!isset($userId)) {
    echo "Пустые или неверные данные";
    exit;
}

    
//echo check_user_exists($login);
load_booking($userId);
?>