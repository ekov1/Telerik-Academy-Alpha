SELECT (e.firstName + ' ' + e.LastName) AS [Employee Name], 
ISNULL((m.FirstName + ' ' + m.LastName), '(no manager)') AS [Manager]
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID