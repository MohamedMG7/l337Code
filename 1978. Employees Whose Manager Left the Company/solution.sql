select employee_id from Employees e
where salary < 30000 and e.manager_id not in (select employee_id from Employees)
ORDER BY employee_id;