SELECT e.FirstName, e.HireDate, d.Name FROM Employees e
RIGHT JOIN Departments d 
ON e.DepartmentID = d.DepartmentID
WHERE HireDate BETWEEN '1995-01-01 00:00:00' AND '2005-12-31 23:59:59' AND d.Name = 'Sales' or d.Name = 'Finance'