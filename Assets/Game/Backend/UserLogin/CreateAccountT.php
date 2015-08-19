<?php
$user = $_REQUEST["user"];
$password = $_REQUEST["password"];

//PHP ONLY
$Hostname = "localhost";
$DBName = "piidzx10_TestUserDB";
$User = "piidzx10_piidz";
$PasswordP = "1234";

$mysql_link = mysqli_connect($Hostname, $User, $PasswordP, $DBName) or die("Can't connect to DataBase");
mysqli_select_db($mysql_link, $DBName) or die("Can't Connect to DataBase");

if (!$user || !$password)
{
	echo "Empty!";
}

else
{
	$SQL = "SELECT * FROM Accounts WHERE user = '" . $user . "'";
	$Result = mysqli_query($mysql_link, $SQL) or die("DATABASE ERROR");
	$Total = mysqli_num_rows($Result);
	
	if($Total == 0)
	{
		$insert = "INSERT INTO `Accounts`(`user`, `password`) VALUES ('" . $user . "', MD5('" . $password . "'))";
		$SQL1 = mysqli_query($mysql_link, $insert) or die("DATABASE ERROR");
		echo "Success";
	}
	
	else
	{
		echo "AlreadyUsed";
	}
}

mysqli_close($mysql_link);
?>