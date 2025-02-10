/* Write your PL/SQL query statement below */

select person_name
from (select *
      from (select person_name, sum(weight) over (order by turn) total
            from Queue)
            where total <= 1000
            order by total desc)
where rownum = 1 ; 

