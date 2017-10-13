SELECT FirstName + ' ' + LastName AS FullName, Salary FROM Employees
WHERE Salary <= (SELECT MIN(Salary * 1.1) FROM Employees)