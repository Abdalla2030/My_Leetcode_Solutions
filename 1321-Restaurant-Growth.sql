/* Write your PL/SQL query statement below */

select distinct to_char(visited_on,'yyyy-mm-dd') visited_on,
                (select sum(amount) from Customer  
                   where visited_on between c.visited_on-6 and  c.visited_on
                   ) amount ,
                   (select round(sum(amount)/7,2)
                    from Customer
                    where visited_on between c.visited_on-6 and  c.visited_on)  average_amount   
from Customer c 
where visited_on in (
                    select c2.visited_on
                    from Customer c1, Customer c2
                    where c2.visited_on >= c1.visited_on+6
                    )
order by  visited_on;




