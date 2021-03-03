<?php
const SERVER_NAME = "localhost";
const DB_NAME = "abc12";
const DB_USERNAME = "root";
const DB_PASSWORD = "";
class Database {
    
    private $connection;
    //ham khoi tao
    public function __construct(){
        try {
            //$connectionString = "mysql:host=".SERVER_NAME.";dbname=".DB_NAME;
            $connectionString = "mysql:host=".SERVER_NAME;
            $this->connection = new PDO($connectionString, DB_USERNAME, DB_PASSWORD);
            echo "<h1>Connect DB successfully</h1>";
        }catch(PDOException $exception) {
            echo "Error connect to DB: ".$exception->getMessage();
            $connectionString = NULL;
        }
        //
    }
    //ham tao table
    public function createDatabaseAndTables(){
        //Gui cau lenh SQL 
        $sql = "CREATE DATABASE abc12";
        $conn->exec($sql);
        $sql = "CREATE TABLE IF NOT EXISTS abc12users (".
            "USERNAME VARCHAR(200) NOT NULL UNIQUE,".
            "PASSWORD_HASH CHAR(100) NOT NULL,".
            "PHONE VARCHAR(10)
        );";
        $conn->exec($sql);
    }
}
?>