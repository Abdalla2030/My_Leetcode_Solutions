/* Write your PL/SQL query statement below */

select to_char(activity_date,'yyyy-mm-dd') day , (count(distinct user_id)) active_users
from Activity 
where activity_date between '2019-06-28' and '2019-07-27'
group by to_char(activity_date,'yyyy-mm-dd');

