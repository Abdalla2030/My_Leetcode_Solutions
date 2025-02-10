/* Write your PL/SQL query statement below */

select name results      
from(select MovieRating.user_id , name, count(*)
     from MovieRating , Users 
     where MovieRating.user_id = Users.user_id
     group by MovieRating.user_id,name
     order by count(*) desc,name)
where rownum = 1

union all

select title results
from (select MovieRating.movie_id ,title, avg(rating)
      from MovieRating , Movies 
      where MovieRating.movie_id = Movies.movie_id    
      and to_char(created_at,'mm-yyyy') = '02-2020'
      group by MovieRating.movie_id,title
      order by avg(rating) desc, title)
where rownum = 1
  