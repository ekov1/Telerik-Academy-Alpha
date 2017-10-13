SELECT COUNT(*) AS [Number of people in Sales] FROM Employees e
	JOIN Departments d ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'