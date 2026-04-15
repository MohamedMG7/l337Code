select project_id, ROUND(Avg(experience_years),2) AS average_years from Project p
join employee e on e.employee_id = p.employee_id
GROUP BY project_id ;