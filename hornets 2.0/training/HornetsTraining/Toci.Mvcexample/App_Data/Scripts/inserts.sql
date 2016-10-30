USE [D:\GITREPOSITORY\WARRIORREP\HORNETS 2.0\TRAINING\HORNETSTRAINING\TOCI.MVCEXAMPLE\APP_DATA\TEAMLEASINGDATABASE.MDF]
GO
insert into courses (course_main_name) values ('Bartek Zapart');

insert into courses (course_main_name) values ('Wojtek Sabat');
insert into courses (course_main_name) values ('Marcin Ga³a');
insert into courses (course_main_name) values ('Adrian Pankiewicz');
insert into courses (course_main_name) values ('Lukasz Cichon');
insert into courses (course_main_name) values ('£ukasz Popio³ek');
insert into courses (course_main_name) values ('S³awek Kowal');
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
insert into technologypromotor (Account_idAccount, course_id_courses) values (14, 14);
insert into technologypromotor (Account_idAccount, course_id_courses) values (10, 10);


insert into course (technology_id_promotor, courses_idCourses, topic, agenda, start_date, end_date, level) values (1, 1, 'c#', 'dluga', '2016-08-08', '2016-12-12', 2);
insert into course (technology_id_promotor, courses_idCourses, topic, agenda, start_date, end_date, level) values (2, 2, 'php', 'dluga', '2016-08-08', '2016-12-12', 2);
insert into course (technology_id_promotor, courses_idCourses, topic, agenda, start_date, end_date, level) values (11, 11, 'c#', 'dluga', '2016-08-08', '2016-12-12', 2);
insert into course (technology_id_promotor, courses_idCourses, topic, agenda, start_date, end_date, level) values (6, 6, 'c#', 'dluga', '2016-08-08', '2016-12-12', 2);
insert into course (technology_id_promotor, courses_idCourses, topic, agenda, start_date, end_date, level) values (3, 3, 'c#', 'dluga', '2016-08-08', '2016-12-12', 2);
insert into course (technology_id_promotor, courses_idCourses, topic, agenda, start_date, end_date, level) values (9, 9, 'c#', 'dluga', '2016-08-08', '2016-12-12', 2);
insert into course (technology_id_promotor, courses_idCourses, topic, agenda, start_date, end_date, level) values (7, 7, 'AngularJS', 'Ciekawa', '2017-09-02', '2016-2-1', 1);
insert into course (technology_id_promotor, courses_idCourses, topic, agenda, start_date, end_date, level) values (10, 10, 'c#', 'dluga', '2016-08-08', '2016-12-12', 2);


---developers
insert into developer (Account_idAccount, experience_from, per_hour_cost, week_availability, isSuspendedForJobs) values (1, '2004-06-01', '100', '10', 0);
insert into developer (Account_idAccount, experience_from, per_hour_cost, week_availability, isSuspendedForJobs) values (12, '20014-09-21', '39', '10', 0);
insert into developer (Account_idAccount, experience_from, per_hour_cost, week_availability, isSuspendedForJobs) values (3, '2015-08-26', '20', '10', 0);
insert into developer (Account_idAccount, experience_from, per_hour_cost, week_availability, isSuspendedForJobs) values (10, '2015-08-01', '10', '10', 0);
insert into developer (Account_idAccount, experience_from, per_hour_cost, week_availability, isSuspendedForJobs) values (9, '2015-01-01', '1', '10', 0);
insert into developer (Account_idAccount, experience_from, per_hour_cost, week_availability, isSuspendedForJobs) values (7, '2016-09-01', '15', '2', 1);
insert into developer (Account_idAccount, experience_from, per_hour_cost, week_availability, isSuspendedForJobs) values (5, '2016-03', '1', '10', 0);

select * from technologies;

insert into technologies (tech_name, is_active) values ('c#', 1);
insert into technologies (tech_name, is_active) values ('php', 1);
insert into technologies (tech_name, is_active) values ('javascript', 1);

insert into technologies (tech_name, is_active) values ('c#', 1);
insert into technologies (tech_name, is_active) values ('java', 1);
insert into technologies (tech_name, is_active) values ('Unity3D/c#', 1);
insert into technologies (tech_name, is_active) values ('scala', 1);
insert into technologies (tech_name, is_active) values ('c/c++', 1);
insert into technologies (tech_name, is_active) values ('Microsoft assembler', 1);
insert into technologies (tech_name, is_active) values ('Python', 1)
insert into technologies (tech_name, is_active) values ('SAP ABAP', 1);
insert into technologies (tech_name, is_active) values ('AngularJS', 1);
insert into technologies (tech_name, is_active) values ('Backbone', 1);
insert into technologies (tech_name, is_active) values ('React', 1);
insert into technologies (tech_name, is_active) values ('Ember', 1);

insert into technologiesdeveloper (Technologies_idTechnologies, Developer_idDeveloper, experience_from, skill_level) values (1, 1, '2007-02-01', 9);
insert into technologiesdeveloper (Technologies_idTechnologies, Developer_idDeveloper, experience_from, skill_level) values (5, 8, '2012-07-01', 6);
insert into technologiesdeveloper (Technologies_idTechnologies, Developer_idDeveloper, experience_from, skill_level) values (1, 1, '2015-08-01', 3);
insert into technologiesdeveloper (Technologies_idTechnologies, Developer_idDeveloper, experience_from, skill_level) values (1, 1, '2015-05-04', 4);
insert into technologiesdeveloper (Technologies_idTechnologies, Developer_idDeveloper, experience_from, skill_level) values (1, 1, '2016-03-09', 2);