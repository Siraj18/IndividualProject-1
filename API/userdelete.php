<?php
require 'db.php';

$login = $_POST["Login"];



    if (!isset($login)) {
        echo "Пустые или неверные данные";
        exit;
    }
//echo check_user_exists($login);
echo delete_user($login);
?>