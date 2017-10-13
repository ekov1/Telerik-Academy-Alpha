SELECT e.FirstName + ' ' + e.LastName AS FullName, e.Salary, d.Name AS DepartmentName
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE Salary = (SELECT MIN(Salary) FROM Employees k
				WHERE k.DepartmentID = e.DepartmentID)
ORDER BY Salary ASC