<?php
$target = "upload/";
$target = $target.$_FILES['uploaded']["name"];

if(move_uploaded_file($_FILES['uploaded']['tmp_name'],$target))
{
echo "The file '$target' has been uploaded";
}
else{
echo "Sorry, there was a problem uploading your file.";
}
header('Refresh: 1; URL=http://bola_t.dcstudentweb.internal/index.php');
?>