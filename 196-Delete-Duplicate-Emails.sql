select * from person p1
where p1.id  in (select min(id)
                from person
                where email = p1.email);
