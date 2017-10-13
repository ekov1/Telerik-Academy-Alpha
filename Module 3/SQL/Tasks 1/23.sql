SELECT e.FirstName, m.FirstName FROM Employees e
RIGHT OUTER JOIN Employees m
ON m.ManagerID = e.EmployeeID