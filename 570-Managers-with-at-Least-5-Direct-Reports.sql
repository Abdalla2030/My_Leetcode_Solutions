/* Write your PL/SQL query statement below */

With result as (
    select name,
    (select count(*) from Employee e2 where e1.id = e2.managerId) as countt
    from Employee e1
)

select name
from result
where countt >= 5 ; 