/* Write your PL/SQL query statement below */

select s.product_id , first_year , quantity , price 
from (select product_id , min(year) first_year
     from Sales
     group by product_id) hd , Sales s
where s.product_id = hd.product_id
       and s.year  = hd.first_year ;

