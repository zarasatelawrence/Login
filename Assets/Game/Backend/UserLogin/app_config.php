<?php

/**
 * @author piidz
 * @copyright 2015
 */

define('DATABASE_USERNAME', 'piidzx10_piidz');
define('DATABASE_PASSWORD', '1234');
define('DATABASE_ADDRESS', 'localhost');
define('DATABASE_DB', 'piidzx10_TestUserDB');

function connect()
{
    mysql_connect(DATABASE_ADDRESS, DATABASE_USERNAME, DATABASE_PASSWORD) or
        die('Error: '. mysql_error());
    mysql_select_db(DATABASE_DB) or
        die('Error: '. mysql_error());
}

?>