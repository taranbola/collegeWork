<?php
$user = $_POST['user'];
$pass = $_POST['pass'];
$fn = "upload/login.txt";
$content = $user.$pass;


$data = file($fn) or die('Could not read file!'); 

foreach ($data as $line) {
if 	(trim($content) ==trim($line)) 
	{
	echo (" Success – Match Found! ");
	}
else 
	echo (" Sorry No Match Found! ");
	}
header ("location:loggedin.php");
?>
