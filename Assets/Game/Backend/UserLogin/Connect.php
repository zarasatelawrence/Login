<?php

/**
 * @author piidz
 * @copyright 2015
 */

define('DATABASE_USERNAME', 'piidzx10_piidz');
define('DATABASE_PASSWORD', '1234');
define('DATABASE_ADDRESS', 'localhost');
define('DATABASE_DB', 'piidzx10_TestUserDB');

$connection = "";

function connect()
{
    $connection = mysqli_connect(DATABASE_ADDRESS, DATABASE_USERNAME, DATABASE_PASSWORD, DATABASE_DB) or 
        die("Can't connect to DataBase");
    
    mysqli_select_db($connection, $DBName) or 
        die("Can't Connect to DataBase");
}

function getConnection()
{
    return $connection;
}

?>