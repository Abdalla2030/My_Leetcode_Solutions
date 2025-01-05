/* Write your PL/SQL query statement below */

select unique_id , name     
from EmployeeUNI right join Employees 
on Employees.id = EmployeeUNI.id
order by unique_id nulls first ;  

