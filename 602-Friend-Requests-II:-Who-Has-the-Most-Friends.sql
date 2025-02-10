/* Write your PL/SQL query statement below */
select *
from    (select id , count(id) num
        from(select requester_id id
        from RequestAccepted

        union all
    
        select accepter_id id
        from RequestAccepted)
        group by id
        order by num desc)
where rownum = 1 ;



