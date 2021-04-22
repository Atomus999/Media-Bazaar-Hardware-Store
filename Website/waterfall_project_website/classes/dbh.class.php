<?php
class Dbh{
    private $host = "studmysql01.fhict.local";
    private $user = "dbi426239";
    private $pwd = "1234";
    private $dbName = "dbi426239";

    public function connect(){
        $dsn = 'mysql:host=' . $this->host . ';dbname=' . $this->dbName;
        $pdo = new PDO($dsn, $this->user, $this->pwd);
       // $pdo->setAttribute(PDO::ATTR_DEFAULT_FETCH_MODE, PDO::FETCH_ASSOC);
       $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        return $pdo;
    }
}
?>