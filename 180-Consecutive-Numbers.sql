/* Write your PL/SQL query statement below */

select distinct l1.num ConsecutiveNums
from Logs l1, Logs l2, Logs l3
where l1.num = l2.num and l2.num = l3.num
and l1.id = l2.id+1 and l2.id+1 = l3.id+2 ;