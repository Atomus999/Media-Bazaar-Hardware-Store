<?php
class DayPlan{

    private $id;
    private $empId;
    private $date;
    private $morning;
    private $afternoon;
    private $evening;

    function __construct($id, $empId, $date, $morning, $afternoon, $evening) {
        $this->id = $id;
        $this->empId = $empId;
        $this->date = $date;
        $this->morning = $morning;
        $this->afternoon = $afternoon;
        $this->evening = $evening;
    }

    public function GetId() { return $this->id; }
    public function GetEmployeeId() { return $this->empId; }
    public function GetDate() { return $this->date; }
    public function GetMorning() { return $this->morning; }
    public function GetAfternoon() { return $this->afternoon; }
    public function GetEvening() { return $this->evening; }

}
?>