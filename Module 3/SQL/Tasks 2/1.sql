SELECT FirstName + ' ' + LastName, Salary AS FullName FROM Employees
WHERE Salary = (SELECT MIN(SALARY) FROM Employees)