CREATE DATABASE EmployeeManagement;
USE EmployeeManagement;
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);


CREATE TABLE Employees (
    EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);
INSERT INTO Employees
(FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES
('John','Doe',1,5000.00,'2020-01-15'),
('Jane','Smith',2,6000.00,'2019-03-22'),
('Michael','Johnson',3,7000.00,'2018-07-30'),
('Emily','Davis',4,5500.00,'2021-11-05');

DELIMITER //

CREATE PROCEDURE sp_InsertEmployee(
    IN p_FirstName VARCHAR(50),
    IN p_LastName VARCHAR(50),
    IN p_DepartmentID INT,
    IN p_Salary DECIMAL(10,2),
    IN p_JoinDate DATE
)
BEGIN
    INSERT INTO Employees
    (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES
    (p_FirstName, p_LastName, p_DepartmentID, p_Salary, p_JoinDate);
END //

DELIMITER ;

CALL sp_InsertEmployee(
'Robert',
'Brown',
3,
7500,
'2024-06-15'
);
SELECT * FROM Employees;