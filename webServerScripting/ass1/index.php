<!DOCTYPE HTML> 
<html>
<head>
<meta charset="utf-8">
<title>Games Online Home</title>
<link rel="stylesheet" type="text/css" href="CSS/stylesheetCOMP.css">

</head>
<body>
<div id="wrapper">
		<div id="header">
        	<div id="logo"><img src="images/logo.jpg">
            </div>
            
			<div id="nav">
            	<ul>
					<li><a href="index.php" id="focus">Home</a></li>
					<li><a href="previews.php">Previews</a></li>
					<li><a href="hardware.php">Hardware</a></li>
					<li><a href="videos.php">Latest Videos</a></li>
					<li><a href="features.php">Features</a></li>
					<li><a href="forums.php">Forums</a></li>
					<li><a href="competitions.php">Competition</a></li>
            	</ul>
			</div>
            
		</div>
        
		<div id="left">		
		</div>
        
		<div id="right">
             <div id="login">
				<form name="form1" method="post" action="confirmation.php">
		      				<br />
						<label for="user">Username</label>
			     			<br />
			      				<input type="text" name="user">
		       				<br />
			     		<label for="pass">Password</label>
                    		<br />
			      				<input type="password" name="pass">
                    		<br />
                            <br />
			      				<input type="submit" value="Log in">
	   			</form>
				<a href="signup.php">Sign Up here</a>
        	<!---/div-->
            <!---div-->
			<p>
			<?php 
			$welcome = 'upload/welcome.txt' or die('Could not detect file!'); 
			$fopen = fopen($welcome,'r') or die('Could not open file!'); 
			$data = fread($fopen, filesize($welcome)) or die('Could not read file!'); 
			fclose($fopen);
			echo $data;
			?> 
			</p>
			</div>	
       </div>
             
			
	
		<div id="footer"><p>Top Games: Tomb Raider: Underworld | Metal Gear Solid 4 | Grand Theft Auto IV </p><p>Grand Theft Auto IV | Call of Duty 4: Modern Warfare | LittleBigPlanet <br/>
		<?php 
		echo $_SERVER['HTTP_USER_AGENT'];
		$browser = get_browser();
		print_r($browser);
		?> 
		</br>
		The screen resolution is 
		<script type="text/javascript">
		document.write(screen.width+' x '+screen.height);
		</script>
		</p>
        </div>
</div>
</body>
</html>


