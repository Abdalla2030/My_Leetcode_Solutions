/* Write your PL/SQL query statement below */

select stu.student_id , stu.student_name , sub.subject_name,
(select count(subject_name) from Examinations  where  student_id = stu.student_id and subject_name = sub.subject_name) as attended_exams
from Students stu cross join Subjects sub
order by stu.student_id ,  sub.subject_name ; 








