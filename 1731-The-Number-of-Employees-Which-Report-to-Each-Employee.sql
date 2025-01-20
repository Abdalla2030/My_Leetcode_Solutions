/* Write your PL/SQL query statement below */

select e2.employee_id , e2.name , count(e1.reports_to) reports_count, round(avg(e1.age))average_age
from Employees e1 , Employees e2
where e1.reports_to = e2.employee_id
group by e2.employee_id , e2.name
order by e2.employee_id ;