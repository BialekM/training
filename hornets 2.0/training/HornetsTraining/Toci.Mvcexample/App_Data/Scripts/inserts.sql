insert into courses (course_main_name) values ('Bartek Zapart');

insert into courses (course_main_name) values ('Wojtek Sabat');
insert into courses (course_main_name) values ('Marcin Ga�a');
insert into courses (course_main_name) values ('Adrian Pankiewicz');
insert into courses (course_main_name) values ('Lukasz Cichon');
insert into courses (course_main_name) values ('�ukasz Popio�ek');
insert into courses (course_main_name) values ('S�awek Kowal');
insert into courses (course_main_name) values ('Michal Mazur');
insert into courses (course_main_name) values ('Bartosz Mackiewicz');
insert into courses (course_main_name) values ('Lukasz Sykutera');
insert into courses (course_main_name) values ('Ania Kolodziej');


select * from courses;

insert into account(login, password) values ('bartek', 'beatka');
insert into account(login, password) values ('marcin', 'marcin');
insert into account(login, password) values ('lukasz', 'ZDupy');
insert into account(login, password) values ('wojtek', 'zdphash');
insert into account(login, password) values ('adrian', 'z dupy');
insert into account(login, password) values ('slawek', 'toci');
insert into account(login, password) values ('jan', 'janek');
insert into account(login, password) values ('ania', 'ania');
insert into account(login, password) values ('bartek', 'beatka');
insert into account(login, password) values ('marcin', 'marcin');
insert into account(login, password) values ('lukasz', 'ZDupy');
insert into account(login, password) values ('wojtek', 'zdphash');
insert into account(login, password) values ('adrian', 'z dupy');
insert into account(login, password) values ('slawek', 'toci');
insert into account(login, password) values ('jan', 'janek');
insert into account(login, password) values ('ania', 'ania');


insert into technologypromotor (Account_idAccount, course_id_courses) values (1, 1);
insert into technologypromotor (Account_idAccount, course_id_courses) values (2, 2);
insert into technologypromotor (Account_idAccount, course_id_courses) values (3, 3);
insert into technologypromotor (Account_idAccount, course_id_courses) values (11, 11);
insert into technologypromotor (Account_idAccount, course_id_courses) values (4, 4);
insert into technologypromotor (Account_idAccount, course_id_courses) values (7, 7);
insert into technologypromotor (Account_idAccount, course_id_courses) values (9, 9);
insert into technologypromotor (Account_idAccount, course_id_courses) values (6, 6);
insert into  technologypromotor (Account_idAccount, course_id_courses) values (12, 12);
insert into technologypromotor (Account_idAccount, course_id_courses) values (13, 13);
insert into technologypromotor (Account_idAccount, course_id_courses) values (6, 6);
insert into technologypromotor (Account_idAccount, course_id_courses) values (14, 14);
insert into technologypromotor (Account_idAccount, course_id_courses) values (10, 10);


insert into course (technology_id_promotor, courses_idCourses, topic, agenda, start_date, end_date, level) values (1, 1, 'c#', 'dluga', '2016-08-08', '2016-12-12', 2);
insert into course (technology_id_promotor, courses_idCourses, topic, agenda, start_date, end_date, level) values (2, 2, 'php', 'dluga', '2016-08-08', '2016-12-12', 2);
