/* Write your PL/SQL query statement below */
/*
select e.employee_id , e.department_id
from Employee e , (select employee_id , count(department_id) cnt
                 from Employee 
                 group by employee_id) hd
where (e.employee_id = hd.employee_id
and e.primary_flag = 'Y')
or  hd.cnt = 1;
*/

select e.employee_id , e.department_id
from (select employee_id , count(department_id) cnt
                     from Employee 
                     group by employee_id ) hd , Employee e
where (e.employee_id = hd.employee_id and cnt = 1)
or (e.employee_id = hd.employee_id and e.primary_flag = 'Y') ;