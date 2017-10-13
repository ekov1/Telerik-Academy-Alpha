SELECT DISTINCT d.Name AS DepartmentName, AVG(SALARY) AS AverageSalary FROM Employees e
JOIN Departments d
ON '1' = d.DepartmentID
GROUP BY d.Name