<?php
session_start();
$_SESSION['username'] = $_POST['user'];
$_SESSION['userpass'] = $_POST['pass'];
$_SESSION['authuser'] = 0;

$user = $_POST['user'];
$pass = $_POST['pass'];
$fn = "upload/login.txt";
$content = $user.$pass;
$timestamp = date("F j, Y, g:i a");

$data = file($fn) or die('Could not read file!'); 

foreach ($data as $line) {
	if 	(trim($content) == trim($line)) {
		$_SESSION['authuser']=1;
		$file = 'upload/visitorlog.txt' or die('Could not Open File!');
		$fh = fopen($file, 'a') or die('Could not Open File!');
		fwrite($fh, "$user") or die ('Could not Write to File!');
		fwrite($fh, "-") or die ('Could not Write to File!');
		fwrite($fh, "$timestamp"."\r\n") or die ('Could not Write to File!');
		fclose($fh);
		header ("location:login.php");
	}
	elseif (($_SESSION['username'] == 'Taran') and ($_SESSION['userpass'] == '12345')) {
		$_SESSION['authuser'] = 1;
		header ("location:admin.php");
	}
	else {
		echo (" Sorry you can't login");
		?>
		<a href="index.php">Back to homepage</a>
		<?php
	}
}
?>