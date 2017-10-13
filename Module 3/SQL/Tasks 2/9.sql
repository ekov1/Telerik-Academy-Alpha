SELECT d.Name, AVG(e.Salary) FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name