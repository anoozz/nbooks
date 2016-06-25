drop table if exists vendors;
create table vendors(
	id integer not null primary key,
	name varchar(45),
	address varchar(45),
	phone varchar(45),
	inactive boolean,
	balance double,
	contact varchar(45)
);