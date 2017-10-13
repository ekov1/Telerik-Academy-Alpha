SELECT DISTINCT d.Name AS DepartmentName, AVG(SALARY) AS AverageSalary FROM Employees e
JOIN Departments d
ON 'Sales' = d.Name
GROUP BY d.Name