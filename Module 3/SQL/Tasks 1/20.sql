SELECT e.FirstName, m.FirstName FROM Employees e
JOIN Employees m
ON e.ManagerID = m.EmployeeID