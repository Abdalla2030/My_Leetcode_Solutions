/* Write your PL/SQL query statement below */

select Project.project_id, round(avg(experience_years),2) as  average_years
from Project left join Employee
on  Project.employee_id = Employee. employee_id
group by Project.project_id

