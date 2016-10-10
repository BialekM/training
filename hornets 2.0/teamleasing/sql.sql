drop table technologies;
drop table client;
drop table developer;
drop table account;

create table account
(
    accId serial primary key,
    accLogin text,
    accPassword text,
    accRole text,
    accName text,
    accSurname text,
    accLocation text
);

create table developer
(
	devId serial primary key,
	devAccountId integer references account(accId),
	devExperienceFrom date
	
);

create table client 
(
	
);

create table technologies 
(
	techId serial primary key,
	techName text
);