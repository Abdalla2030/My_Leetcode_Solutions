/* Write your PL/SQL query statement below */
select  Department , Employee , Salary
from (select d.name Department , e.name Employee , Salary ,
      dense_rank() over (partition by d.id order by e.salary desc) rn
     from Employee e , Department d
     where e.departmentId  = d.id(+))
where rn <= 3; 
