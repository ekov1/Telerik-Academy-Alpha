SELECT 
d.Name AS DepartmentName,
COUNT(*) AS EmployeesCountDepartment
FROM Employees e
LEFT OUTER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

SELECT 
t.Name AS TownName,
COUNT(*) AS EmployeesCountTowns
FROM Employees e
LEFT OUTER JOIN Addresses a
ON e.AddressID = a.AddressID
LEFT OUTER JOIN Towns t
on a.TownID = t.TownID
GROUP BY t.Name