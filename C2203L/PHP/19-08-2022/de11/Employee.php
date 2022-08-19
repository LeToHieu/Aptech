<?php
//echo "This is point class";
class Employee {
    private $employeeNo;
    private $employeeName;
    private $post;
    private $salary;
    public function __construct(
        $employeeNo,
        $employeeName = "",
        $post = "",
        $salary = 0
    ) {
        $this->employeeNo = $employeeNo;
        $this->employeeName = $employeeName;
        $this->post = $post;
        $this->salary = $salary;
    }       
}
?>