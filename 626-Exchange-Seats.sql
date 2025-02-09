/* Write your PL/SQL query statement below */
select 
    case
        when id = (select max(id) from Seat) and MOD(id, 2) != 0 then id
        when MOD(id, 2) = 0 then id - 1
        when MOD(id, 2) != 0 then id + 1
    end id,
    student
from Seat
order by id;
