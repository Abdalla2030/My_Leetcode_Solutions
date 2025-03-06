select round(sum(case when hd2.min_date + 1 = hd1.event_date then 1 else 0 end)
/
count(distinct hd2.player_id), 2) as fraction
from activity hd1 , (select player_id, min(event_date) min_date
                     from activity 
                     group by player_id ) hd2
where hd1.player_id = hd2.player_id;