
DELIMITER //

CREATE PROCEDURE GetEmployeeCountByDepartment(IN deptID INT)
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM employees
    WHERE DepartmentID = deptID;
END //

DELIMITER ;

CALL GetEmployeeCountByDepartment(1);

