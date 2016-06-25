drop table if exists attachments;
create table attachments(
	id integer not null primary key,
	emp_id integer,
	attachment mediumblob,
	attachment_type varchar(45),
	notes varchar(45)
) engine=innodb;

drop table if exists bank_transmittals;
create table bank_transmittals(
	id integer not null primary key,
	emp_id integer,
	account_no varchar(45),
	net_pay double
) engine=innodb;

drop table if exists brackets;
create table brackets(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
) engine=innodb;

drop table if exists branches;
create table branches(
	id integer not null primary key,
	name varchar(45),
	address varchar(45),
	inactive boolean
) engine=innodb;

drop table if exists contributions;
create table contributions(
	id integer not null primary key,
	emp_id integer,
	date datetime,
	cont_type integer,
	sss_premium_id integer,
	amount double
) engine=innodb;

drop table if exists deduction_types;
create table deduction_types(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
) engine=innodb;

drop table if exists departments;
create table departments(
	id integer not null primary key,
	name varchar(45),
	description varchar(45),
	inactive boolean,
	branch_id integer
) engine=innodb;

drop table if exists employees;
create table employees(
	id integer not null primary key,
	lname varchar(45),
	fname varchar(45),
	mname varchar(45),
	address varchar(45),
	sex smallint,
	bday datetime,
	marital_stat smallint,
	contact_no varchar(45),
	religion varchar(45),
	postal_code varchar(45),
	date_hired datetime,
	date_resigned datetime,
	school varchar(45),
	course varchar(45),
	contact_person varchar(45),
	br_code varchar(45),
	dept_id integer,
	account_no varchar(45),
	stat_code varchar(45),
	shift_id integer,
	hdmf varchar(45),
	sss varchar(45),
	tin varchar(45),
	philhealth varchar(45),
	bracket_id integer,
	ded_hdmf15th boolean,
	ded_sss15th boolean,
	ded_tax15th boolean,
	ded_philhealth15th boolean,
	ded_hdmf30th boolean,
	ded_sss30th boolean,
	ded_tax30th boolean,
	ded_philhealth30th boolean,
	atm varchar(45),
	seniority_pay double,
	pay_rate double,
	vl_allow double,
	sl_allow double,
	image mediumblob,
	inactive boolean,
	fingerprint_sig mediumblob,
	log_exemption boolean,
	salary double,
	monthly_rate double,
	daily_rate double,
	hourly_rate double,
	position_id integer,
	emp_id varchar(45)
) engine=innodb;