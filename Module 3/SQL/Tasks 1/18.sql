SELECT Employees.FirstName, Addresses.AddressText
FROM Employees INNER JOIN Addresses
ON Employees.EmployeeID = Addresses.AddressID