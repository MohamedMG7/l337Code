SELECT 
    m.employee_id,
    m.name,
    COUNT(*) AS reports_count,
    Round(Avg(e.age)) As average_age
FROM Employees e
JOIN Employees m 
    ON e.reports_to = m.employee_id
GROUP BY e.reports_to, m.name
Order BY employee_id;