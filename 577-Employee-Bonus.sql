/* Write your PL/SQL query statement below */

select name, bonus
from Employee E
left join Bonus B
    on E.empId = B.empId
where bonus < 1000 or bonus is null
order by bonus nulls last;

