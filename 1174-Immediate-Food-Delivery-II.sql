/* Write your PL/SQL query statement below */

select 
    Round(count(case
                when order_date = customer_pref_delivery_date then 1 end)/count(distinct customer_id)*100,2) as immediate_percentage 
from Delivery d1
where order_date = (select min(order_date)
                    from Delivery d2
                    where d2.customer_id =  d1.customer_id);

