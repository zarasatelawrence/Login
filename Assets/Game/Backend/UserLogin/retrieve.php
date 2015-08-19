<?php

/**
 * @author piidz
 * @copyright 2015
 */
    require_once 'app_config.php';
    connect();
    //$item = $_GET['item'];
    
    $query = "SELECT * FROM Accounts";
    $result = mysql_query($query);
    while($item = mysql_fetch_array($result))
    {
        echo $item['user'];
        echo ' - ';
        echo $item['password'];
        echo '</br>';
    }
    
    //echo $item;
?>