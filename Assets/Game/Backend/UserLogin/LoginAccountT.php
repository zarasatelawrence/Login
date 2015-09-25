<?php

/**
 * @author piidz
 * @copyright 2015
 */

//require_once 'Connect.php';

//PHP ONLY
$Hostname = "localhost";
$DBName = "piidzx10_TestUserDB";
$User = "piidzx10_piidz";
$PasswordP = "1234";

$mysql_link = mysqli_connect($Hostname, $User, $PasswordP, $DBName) or die("Can't connect to DataBase");
mysqli_select_db($mysql_link, $DBName) or die("Can't Connect to DataBase");
//connect();


$user = $_REQUEST["user"];
$password = $_REQUEST["password"];

if(!$user || !$password)
{
    echo "user or password is empty.";
}

else
{
    $SQL = "SELECT * FROM  `Accounts` WHERE user = '" . $user . "'";
    $result_id = mysqli_query($mysql_link, $SQL) or die("DATABASE ERROR");
    $total = mysqli_num_rows($result_id);
    
    if($total)
    {
        $datas = mysqli_fetch_array($result_id);
        $enc_password = md5($password);
        
        if(!strcmp($enc_password, $datas["password"]))
        {
            $SQL2 = "SELECT user FROM Accounts WHERE user = '" . $user . "'";
            $result_id2 = mysqli_query($mysql_link, $SQL2) or die("DATABASE ERROR!");
            while($row = mysqli_fetch_array($result_id2))
            {
                echo $row['user'];
                echo ":";
                echo"Success";
            }
        }
        
        else
        {
            echo "Wrong Password.";
        }
    }
    
     else
     {
        echo "User does not exist";
     }
}

mysqli_close($mysql_link);
?>