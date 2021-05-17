<?php
require 'db.php';

$name = $_POST["Name"];
$author = $_POST["Author"];
$publisher = $_POST["Publisher"];
$count = $_POST["Count"];


    if (!isset($name) || !isset($author) || !isset($publisher) || !isset($count)) {
        echo "Пустые или неверные данные";
        exit;
    }
//echo check_user_exists($login);
echo book_add($name, $author, $publisher, $count);
?>