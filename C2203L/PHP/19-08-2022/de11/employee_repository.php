<?php
require './Employee.php';
require './db_connection.php';        
function findAllEmployees() {
    $result = [];
    try{
        $statement=$connection->prepare('
          SELECT * FROM employee
        ');
        $statement->execute();
        $all_employees=$statement->fetchAll();
        //convert 
        foreach($all_employees as $employee) {
            $employeeObject = new Employee($employee['empno'],
                                $employee['ename'],
                                $employee['post'],
                                $employee['salary']);
            array_push($result, $employeeObject);
        }
    }catch(PDOException $e){
        echo $e->getMessage();
    } finally {
        return $result;
    }

}

?>