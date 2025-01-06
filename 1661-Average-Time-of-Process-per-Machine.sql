/* Write your PL/SQL query statement below */

select     a.machine_id,
           round(avg(b.timestamp-a.timestamp),3) as processing_time
from Activity A join Activity B
on A.machine_id = B.machine_id
and A.process_id = B.process_id
and a.activity_type = 'start'
and b. activity_type = 'end'
group by a.machine_id; 

