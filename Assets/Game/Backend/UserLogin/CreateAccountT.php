<?php
$email = $_REQUEST["email"];
$password = $_REQUEST["password"];

//PHP ONLY
$Hostname = "";
$DBName = "";
$User = "";
$PasswordP = "";

mysql_connect($Hostname, $User, $PasswordP) or die("Can't connect to DataBase");
mysql_select_db($DBName) or die("Can't Connect to DataBase");

if (!$email || !$PasswordP)
{
	echo "Empty!";
}

else
{
	$SQL = "SELECT * FROM Accounts WHERE email = '" . $email . "'";
	$Result = @mysql_query($SQL) or die("DATABASE ERROR");
	$Total = mysql_num_rows($Result);
	
	if($Total == 0)
	{
		$insert = "INSERT INTO 'Accounts' ('email', 'password') VALUES('" . $email . "', MD5('" . $password . "'))";
		$SQL1 = mysql_query($insert);
		echo "Success";
	}
	
	else
	{
		echo "AlreadyUsed";
	}
}

mysql_close();
?>