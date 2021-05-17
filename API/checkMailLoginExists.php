<?php
require 'db.php';

$login = $_POST["Login"];
$email = $_POST["Email"];

    if (!isset($login) || !isset($email)) {
        echo "Пустые или неверные данные";
        exit;
    }
//echo check_user_exists($login);
echo check_email_and_login_exists($login, $email);
?>