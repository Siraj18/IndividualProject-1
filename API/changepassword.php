
<?php
require 'db.php';

$login = $_GET["Login"];
$ind = $_GET["Ind"];
$o_pass = $_POST["o_pass"];

if (!isset($login) || !isset($ind)) {
    echo "Пустые или неверные данные";
    exit;
}
echo $newPass;
$flag = "no";
$create_date = link_find($ind); // Получаем время создания ссылки в секундах
$cur_date = date("U") - $create_date; // Получаем разницу
if ($cur_date > 43200) { // Если больше 12 часов
    echo "Ссылка недействительна";
}
else {
    echo "Смена пароля";
    $flag = "yes";
}


if(isset($_POST['submit']) && $flag == "yes") {
    // Смена пароля


    $oldPass = htmlspecialchars($_POST['o_pass']);
    $oldPass = strip_tags($oldPass);

    $newPass = htmlspecialchars($_POST['n_pass']);
    $newPass = strip_tags($newPass);


    if ($oldPass != $newPass) {
        $opass =  find_password($login);
        if ($opass == $oldPass) {
            update_password($login, $newPass);
        }
        else {
            echo "Старый пароль неверный";
        }
    }
    else {
        echo "Пароли одинаковые";
    }

}
?>

<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title></title>
</head>
<body>
<div>
<div>
 <h1>Смена пароля</h1>
<form action="" method="post" name="registerform">

<p><label>Пароль:<br>
<input name="o_pass" size="30" type="password"></label></p>
<p><label>Новый пароль:<br>
<input name="n_pass" size="30" type="password"></label></p>
<p><input name="submit" type="submit" value="Смена пароля"></p>
 </form>
</div>
</div>

</body>
</html>

