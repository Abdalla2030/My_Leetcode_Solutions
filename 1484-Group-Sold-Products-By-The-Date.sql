/* Write your PL/SQL query statement below */

select to_char(hd.sell_date,'yyyy-mm-dd') sell_date,
       count(distinct hd.product) num_sold ,
      (listagg (hd.product, ',') within group (order by hd.sell_date))products                               
from (select distinct sell_date , product
      from Activities) hd
group by hd.sell_date;

