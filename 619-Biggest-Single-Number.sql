/* Write your PL/SQL query statement below */

select max(hd.num) num 
from (select num , count(*) cnt
from MyNumbers 
group by num ) hd

where cnt = 1;
