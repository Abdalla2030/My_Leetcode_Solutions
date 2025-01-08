/* Write your PL/SQL query statement below */

select P.product_id , nvl(round(sum(U.units*P.price)/sum(U.units),2),0)as average_price
from UnitsSold U right join Prices P
on  U.product_id = P.product_id 
and U.purchase_date between P.start_date AND P.end_date
group by P.product_id ;