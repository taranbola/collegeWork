<?php
session_start();
if ($_SESSION['authuser'] != 1) {
    echo "Login to actually enter";
?>
   <a href="index.php">Back to homepage</a>
    <?php
    exit();
}
?>
<html>
<head>
<title>Admin</title>
</head>
<body>
<p>Welcome to the admin page.</P>
<form enctype="multipart/form-data" action="upload.php" method="post">
    <p>Please choose a text file, make sure it is called welcome.txt:</p>
    <input name="uploaded" type="file" /><br/>
    <input type="submit" value="Upload" />
</form>
<form action="processscript.php" method="POST">
    <p>Change the welcome message:</p>
    <input type="text" name="WelcomeMessage">
    <input type="submit" value ="confirm">
</form>
<?php
echo "<h3>Visitor Log</h3>";
$counter     = 0;
$file_handle = fopen("upload/visitorlog.txt", "r");
while (!feof($file_handle)) {
    $line_of_text = fgets($file_handle);
    print $line_of_text . "<BR>";
    $counter++;
}
$counter = $counter - 1;
echo "Number of visitors is ", $counter;
fclose($file_handle);
?>
<?php
// define custom handler
error_reporting(0);
set_error_handler('myHandler');

// custom handler code
function myHandler($code, $msg, $file, $line)
{
    // print error page
    echo "<html><head></head><body>";
    echo "<h3>Errors</h3>";
    $ecounter    = 0;
    $file_handle = fopen("upload/errors.txt", "r");
    while (!feof($file_handle)) {
        $line_of_text = fgets($file_handle);
        print $line_of_text . "<BR>";
        $ecounter++;
    }
    $ecounter = $ecounter - 1;
    echo "Number of Errors is ", $ecounter;
    echo "</body></html>";
    
    // log error to file, with context
    $logData = date("d-M-Y h:i:s", mktime()) . ", $code, $msg, $line, $file\n";
    $fn      = "upload/errors.txt";
    $fp = fopen($fn, "a") or die("Error opening file in write mode!");
    fputs($fp, $logData);
    fclose($fp) or die("Error closing file!");
    // halt execution of script
    die();
}
// generate a warning
echo is_float();
?>
</body>
</html>