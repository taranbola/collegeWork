<?php
session_start();
if ($_SESSION['authuser'] != 1){
	echo "Login to actually enter";
	?> <a href="index.php">Back to homepage</a>
	<?php
	exit();
	}
?>
<!DOCTYPE HTML> 
<html>
<head>
<meta charset="utf-8">
<title>Features</title>
<link rel="stylesheet" type="text/css" href="CSS/stylesheetCOMP.css"/>
</head>
<body>
<div id="wrapper">
		<div id="header">
        	<div id="logo"><img src="images/logo.jpg" alt=""/>
            </div>
            
			<div id="nav">
            	<ul>
					<li><a href="index.php">Home</a></li>
					<li><a href="previews.php">Previews</a></li>
					<li><a href="hardware.php">Hardware</a></li>
					<li><a href="videos.php">Latest Videos</a></li>
					<li><a href="features.php" id="focus">Features</a></li>
					<li><a href="forums.php">Forums</a></li>
					<li><a href="competitions.php">Competition</a></li>
            	</ul>
			</div>
            
		</div>
        
		<div id="left">		
		</div>
        
		       </div>
             
			
	
		<div id="footer" ><p>Top Games: Tomb Raider: Underworld | Metal Gear Solid 4 | Grand Theft Auto IV </p><p>Grand Theft Auto IV | Call of Duty 4: Modern Warfare | LittleBigPlanet</p>
        </div>
</div>
</body>
</html>