/* Write your PL/SQL query statement below */

select(round(sum(ins1.tiv_2016),2)) tiv_2016
from Insurance ins1
where ins1.tiv_2015 in (select tiv_2015 
                        from Insurance ins2
                        where ins1.pid !=ins2.pid)
and (ins1.lat , ins1.lon) not in (select ins3.lat , ins3.lon
                               from Insurance ins3
                               where ins1.pid != ins3.pid) ;