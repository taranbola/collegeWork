<?php 
$userInput = $_POST["WelcomeMessage"];
$file = 'upload/welcome.txt' or die('Could not Open File!');
$fh = fopen($file, 'w') or die('Could not Open File!');
fwrite($fh, "$userInput") or die ('Could not Write to File!');
fclose($fh);
header("Location: index.php");
?>
