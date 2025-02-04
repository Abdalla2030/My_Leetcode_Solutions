/* Write your PL/SQL query statement below */

select p.product_name , sum(o.unit) unit
from Orders o, Products p
where o.product_id = p.product_id
and to_char(o.order_date,'yyyy-mm') = '2020-02'
group by p.product_name
having sum(o.unit) >= 100 ;
