<?php
require_once "SendMailSmtpClass.php"; // подключаем класс
require 'db.php';

$login = $_POST["Login"];
if (!isset($login)) {
    echo "Пустые или неверные данные";
    exit;
}

$ind = rand(0,10000);

link_add($ind, $login);
$opass =  find_password($login);
$mtext = "Старый пароль:" . $opass . "\n"; 

$m_text = "http://project181.std-978.ist.mospolytech.ru/dbtest/changepassword.php/?Login=". $login . "&Ind=" . $ind;

$f_text = $mtext . $m_text;


$mailSMTP = new SendMailSmtpClass('axmed.ramazanov.12@mail.ru', 'blackdi182001', 'ssl://smtp.mail.ru', 465, "UTF-8");
// $mailSMTP = new SendMailSmtpClass('логин', 'пароль', 'хост', 'порт', 'кодировка письма');
 
// от кого
$from = array(
    "Смена пароля", // Имя отправителя
    "axmed.ramazanov.12@mail.ru" // почта отправителя
);
// кому
$to = get_email($login);;
 
// отправляем письмо
$result =  $mailSMTP->send($to, 'Тема письма', $f_text, $from); 
// $result =  $mailSMTP->send('Кому письмо', 'Тема письма', 'Текст письма', 'Отправитель письма');
 
if($result === true){
    echo "Done";
}else{
    echo "Error: " . $result;
}
?>