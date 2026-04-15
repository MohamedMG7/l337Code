select contest_id, ROUND(Count(user_id) / (select Count(*) from users) * 100,2) AS percentage from Register r
GROUP BY contest_id
ORDER BY percentage DESC, contest_id ASC;