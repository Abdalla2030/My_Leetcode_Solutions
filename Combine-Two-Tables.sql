/* Write your PL/SQL query statement below */

select firstName,lastName,city,state 
from Person , Address 
where Person.personId  = Address.personId(+);
