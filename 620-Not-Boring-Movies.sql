/* Write your PL/SQL query statement below */

select id, movie, description, rating
from Cinema 
where mod(id,2)=1 and description <> 'boring'
order by rating desc;