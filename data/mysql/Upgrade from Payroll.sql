create table accounts(
	id integer not null primary key auto_increment,
	name varchar(45),
	description varchar(45),
	note varchar(45),
	balance double,
	inactive boolean,
	type smallint,
	tax_line_mapping smallint
) engine=innodb;

drop table attachments;

drop table bank_transmittals;

create table bills(
	id integer not null primary key auto_increment,
	vendor_id integer,
	vendor_address varchar(45),
	terms_id integer,
	memo varchar(45),
	date datetime,
	ref_no varchar(45),
	amount double,
	due_date datetime,
	created_by integer,
	creation_date datetime,
	updated_by integer,
	update_date datetime
) engine=innodb;

create table bills_accounts(
	id integer not null primary key auto_increment,
	bill_id integer,
	account_id integer,
	amount double,
	amount_paid double,
	memo varchar(45),
	customer_id integer,
	billable boolean,
	class_id integer
) engine=innodb;

create table bills_items(
	id integer not null primary key auto_increment,
	bill_id integer,
	item_id integer,
	description varchar(45),
	quantity double,
	unit_id integer,
	cost double,
	amount double,
	customer_id integer,
	billable boolean,
	class_id integer
) engine=innodb;

create table bills_payments(
	id integer not null primary key auto_increment,
	date datetime,
	payment_method_id integer,
	account_id integer
) engine=innodb;

create table bills_payments_bills(
	id integer not null primary key auto_increment,
	bill_payment_id integer,
	bill_id integer,
	amount_paid double
) engine=innodb;

drop table brackets;

drop table branches;

create table categories(
	id integer not null primary key auto_increment,
	name varchar(45),
	description varchar(45),
	inactive boolean
) engine=innodb;

create table classes(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

alter table company
	change column id id integer not null auto_increment,
	change column name name varchar(45),
	add ship_to_name varchar(45) after name,
	add ship_to_address varchar(255) after ship_to_name,
	change column address address varchar(255),
	change column phone phone varchar(45),
	change column fax fax varchar(45),
	drop prepared_by,
	drop checked_by,
	drop noted_by,
	drop approved_by,
	drop account_no,
	add email varchar(45),
	add website varchar(45),
	add legal_name varchar(45),
	add legal_address varchar(45),
	add legal_address1 varchar(45),
	add city varchar(45),
	add state_id integer,
	add zip varchar(45),
	add legal_country_id integer,
	add country_id integer,
	add fiscal_year smallint,
	add tax_year smallint,
	add income_tax_form smallint,
	add ein varchar(45),
	add ssn varchar(45),
	add payroll_contact varchar(45),
	add payroll_contact_title varchar(45),
	add payroll_contact_phone varchar(45);

drop table if exists config;
create table config(
	id integer not null primary key auto_increment,
	data_version varchar(45)
) engine=innodb;
	
drop table contributions;

create table converted_items(
	id integer not null primary key auto_increment,
	from_item_id integer,
	to_item_id integer,
	quantity double,
	date datetime
) engine=innodb;

create table countries(
	id integer not null primary key auto_increment,
	short_name varchar(45),
	long_name varchar(45),
	inactive boolean
) engine=innodb;
insert into countries(short_name, long_name, inactive) values('US', 'United States', 0);
insert into countries(short_name, long_name, inactive) values('CA', 'Canada', 0);
insert into countries(short_name, long_name, inactive) values('PH', 'Philippines', 0);
insert into countries(short_name, long_name, inactive) values('Other', 'Other', 0);

create table customers(
	id integer not null primary key auto_increment,
	name varchar(45),
	address varchar(45),
	phone varchar(45),
	trade_assistance varchar(45),
	classification varchar(45),
	type_of_deal varchar(45),
	balance double,
	inactive boolean,
	company_name varchar(45),
	balance_as_of datetime,
	title varchar(45),
	first_name varchar(45),
	last_name varchar(45),
	middle_name varchar(45),
	ship_to_address varchar(45),
	contact varchar(45),
	fax varchar(45),
	alt_phone varchar(45),
	alt_contact varchar(45),
	email varchar(45),
	cc varchar(45),
	customer_type_id integer,
	terms_id integer,
	sales_rep_id integer,
	send_method smallint,
	sales_tax_code_id integer,
	tax_item_id integer,
	resale_number varchar(45),
	price_level_id integer,
	account_no varchar(45),
	credit_limit double,
	payment_method_id integer,
	credit_card_no varchar(45),
	cc_expiry_month varchar(45),
	cc_expiry_year varchar(45),
	name_on_card varchar(45),
	cc_address varchar(45),
	cc_zip_code varchar(45),
	job_status smallint,
	start_date datetime,
	projected_end datetime,
	end_date datetime,
	job_description varchar(45),
	job_type_id integer,
	notes mediumtext
) engine=innodb;

create table customer_messages(
	id integer not null primary key auto_increment,
	message mediumtext,
	inactive boolean
) engine=innodb;

create table customer_types(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

create table customers_discounted_items(
	id integer not null primary key auto_increment,
	customer_id integer,
	item_id integer,
	discount double
) engine=innodb;

alter table deduction_types
	change column id id integer not null auto_increment,
	change column name name varchar(45),
	change column inactive inactive boolean;
	
alter table departments
	change column id id integer not null auto_increment,
	change column name name varchar(45),
	change column description description varchar(45),
	change column inactive inactive boolean,
	change column branch_id branch_id integer;

alter table employees
	change column id id integer not null auto_increment,
	change column lname last_name varchar(45),
	change column fname first_name varchar(45),
	change column mname middle_name varchar(45),
	change column address street1 varchar(45),
	change column sex gender smallint,
	change column bday date_of_birth datetime,
	change column marital_stat marital_status smallint,
	change column contact_no phone varchar(45),
	change column religion religion varchar(45),
	change column postal_code zip varchar(45),
	change column date_hired date_hired datetime,
	change column school school varchar(45),
	change column course course varchar(255),
	change column contact_person contact varchar(45),
	change column br_code branch_id integer,
	change column dept_id department_id integer,
	change column account_no account_no varchar(45),
	change column stat_code stat_code varchar(45),
	change column shift_id shift_id integer,
	change column hdmf hdmf varchar(45),
	change column sss ss_no varchar(45),
	change column tin tin varchar(45),
	change column philhealth philhealth varchar(45),
	change column bracket_id bracket_id integer,
	change column ded_hdmf15th ded_hdmf15th boolean,
	change column ded_sss15th ded_sss15th boolean,
	change column ded_tax15th ded_tax15th boolean,
	change column ded_philhealth15th ded_philhealth15th boolean,
	change column ded_hdmf30th ded_hdmf30th boolean,
	change column ded_sss30th ded_sss30th boolean,
	change column ded_tax30th ded_tax30th boolean,
	change column ded_philhealth30th ded_philhealth30th boolean,
	change column atm atm varchar(45),
	change column seniority_pay seniority_pay double,
	change column pay_rate pay_rate double,
	change column vl_allow vl_allow double,
	change column sl_allow sl_allow double,
	change column inactive inactive boolean,
	change column log_exemption log_exemption boolean,
	change column salary salary double,
	change column monthly_rate monthly_rate double,
	change column daily_rate daily_rate double,
	change column hourly_rate hourly_rate double,
	change column position_id position_id integer,
	change column emp_id emp_id varchar(45),
	add column title varchar(45),
	add column print_on_check_as varchar(45),
	add column street2 varchar(45),
	add column city varchar(45),
	add column state_id integer,
	add column cellular varchar(45),
	add column email varchar(45);

drop table employee_nos;

alter table employment_statuses
	rename to employee_types,
	change column id id integer not null auto_increment,
	change column name name varchar(45),
	change column inactive inactive boolean;
	
create table ending_quantities(
	id integer not null primary key auto_increment,
	date varchar(45)
) engine=innodb;

create table ending_quantities_items(
	id integer not null primary key auto_increment,
	ending_quantity_id integer,
	item_id integer,
	quantity double
) engine=innodb;

drop table holidays;

create table invoices(
	id integer not null primary key auto_increment,
	date datetime,
	customer_id integer,
	ref_no varchar(45),
	bill_to_address varchar(45),
	ship_to_address varchar(45),
	po_no varchar(45),
	terms_id integer,
	sales_rep_id integer,
	shipping_date datetime,
	shipping_method_id integer,
	fob varchar(45),
	customer_message_id integer,
	tax_item_id integer,
	sales_tax_code_id integer,
	memo varchar(45),
	created_by integer,
	creation_date datetime,
	updated_by integer,
	update_date datetime,
	status smallint,
	account_id integer
) engine=innodb;

create table invoices_items(
	invoice_id integer,
	item_id integer,
	quantity double,
	unit_price double,
	id integer not null primary key auto_increment,
	sales_tax_code_id integer
) engine=innodb;

create table items(
	id integer not null primary key auto_increment,
	name varchar(45),
	sales_description varchar(45),
	on_hand double,
	unit_measure varchar(45),
	sales_price double,
	reorder_point double,
	overstock_level double,
	part_number varchar(45),
	beginning_qty double,
	tolarge_packing double,
	inactive boolean,
	ucs double,
	preferred_vendor_id integer,
	vendor_discount double,
	purchase_description varchar(45),
	cost double,
	type smallint,
	unit_id integer,
	income_account_id integer,
	cogs_account_id integer,
	sales_tax_code_id integer,
	asset_account_id integer,
	total_value double,
	value_as_of datetime
) engine=innodb;

create table item_receipts(
	id integer not null primary key auto_increment,
	date datetime,
	vendor_id integer,
	prepared_by varchar(45),
	approved_by varchar(45),
	reference_no varchar(45),
	memo mediumtext,
	status smallint,
	created_by integer,
	creation_date datetime,
	updated_by integer,
	update_date datetime
) engine=innodb;

create table item_receipts_items(
	id integer not null primary key auto_increment,
	item_receipt_id integer,
	item_id integer,
	quantity double,
	unit_price double,
	discount double,
	ucs double,
	customer_id integer,
	billable boolean
) engine=innodb;

drop table if exists item_receipts_returned_items;
create table item_receipts_returned_items(
	id integer not null primary key auto_increment,
	item_receipt_id integer,
	item_id integer,
	quantity double,
	unit_price double
) engine=innodb;

create table job_types(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

drop table leaves;

drop table leave_setup;

drop table loans;

alter table loan_types
	change column id id integer not null auto_increment,
	change column name name varchar(45),
	change column inactive inactive boolean;

create table modules(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

create table modules_commands(
	id integer not null primary key auto_increment,
	module_id integer,
	name varchar(45),
	command varchar(45)
) engine=innodb;

alter table other_deductions
  rename to deductions,
  change column id id integer not null auto_increment,
  change column type type integer,
  change column emp_id emp_id integer,
  change column amount amount double,
  change column pcode_id pcode_id integer,
  change column date date datetime;

drop table other_deductions_temp;

create table other_names(
	id integer not null primary key auto_increment,
	name varchar(45),
	company_name varchar(45),
	title varchar(45),
	first_name varchar(45),
	middle_name varchar(45),
	last_name varchar(45),
	address varchar(45),
	contact varchar(45),
	phone varchar(45),
	fax varchar(45),
	alt_phone varchar(45),
	alt_contact varchar(45),
	email varchar(45),
	account_no varchar(45),
	inactive boolean
) engine=innodb;
  
drop table overtimes;

alter table pagibig_premiums
	change column id id integer not null auto_increment,
	change column code code varchar(45),
	change column inactive inactive boolean,
	change column description description varchar(45);

create table payments(
	id integer not null primary key auto_increment,
	customer_id integer,
	amount double,
	payment_method_id integer,
	memo varchar(45),
	date datetime,
	check_no varchar(45)
) engine=innodb;

create table payments_invoices(
	id integer not null primary key auto_increment,
	payment_id integer,
	invoice_id integer,
	amount_paid double
) engine=innodb;

create table payment_methods(
	id integer not null primary key auto_increment,
	name varchar(45),
	type smallint,
	inactive boolean
) engine=innodb;

alter table payroll_codes
	change column id id integer not null auto_increment,
	change column date_from date_from datetime,
	change column date_to date_to datetime,
	change column days_consume days_consume double,
	change column year year integer,
	change column loan_sss loan_sss boolean,
	change column loan_pagibig loan_pagibig boolean,
	change column loan_philhealth loan_philhealth boolean,
	change column close_semi close_semi boolean,
	change column inactive inactive boolean,
	change column code code varchar(45),
	change column ot_regular_rate ot_regular_rate double,
	change column ot_sunday_rate ot_sunday_rate double,
	change column ot_legal_rate ot_legal_rate double,
	change column ot_special_rate ot_special_rate double,
	change column ot_legal_sunday_rate ot_legal_sunday_rate double;

create table payroll_schedules(
	id integer not null primary key auto_increment,
	name varchar(45),
	pay_frequency smallint,
	next_check_date datetime,
	next_day_period datetime,
	inactive boolean
) engine=innodb;

alter table payslips
	change column id id integer not null auto_increment,
	change column emp_id emp_id integer,
	change column pcode_id pcode_id integer,
	change column regular_hours regular_hours double,
	change column undertime_hours undertime_hours double,
	change column absent_hours absent_hours double,
	change column regular_pay regular_pay double,
	change column other_income other_income double,
	change column tax_withheld tax_withheld double,
	change column sss_medical sss_medical double,
	change column sss_premium sss_premium double,
	change column sss_salary sss_salary double,
	change column sss_education sss_education double,
	change column sss_cal sss_cal double,
	change column other_deduction other_deduction double,
	change column pagibig_loan pagibig_loan double,
	change column pagibig_health pagibig_health double,
	change column pagibig_premium pagibig_premium double,
	change column gross_pay gross_pay double,
	change column deduction deduction double,
	change column net_pay net_pay double,
	change column hours_worked hours_worked double,
	change column pay pay double,
	change column sss_employer_contrib sss_employer_contrib double;

drop table payslips_temp;

create table periods(
	id integer not null primary key auto_increment,
	name varchar(45),
	date_from datetime,
	date_to datetime,
	inactive boolean
) engine=innodb;

create table periods_categories(
	id integer not null primary key auto_increment,
	period_id integer,
	category_id integer,
	target_value double
) engine=innodb;

alter table philhealth_premiums
	change column id id integer not null auto_increment,
	change column code code varchar(45),
	change column range_from range_from double,
	change column range_to range_to double,
	change column ps ps double,
	change column es es double,
	change column contribution contribution double,
	change column inactive inactive boolean;

create table physical_counts(
	id integer not null primary key auto_increment,
	date datetime,
	prepared_by varchar(45),
	approved_by varchar(45),
	remarks mediumtext
) engine=innodb;

create table physical_counts_items(
	id integer not null primary key auto_increment,
	physical_count_id integer,
	item_id integer,
	original_qty double,
	adjusted_qty double
) engine=innodb;

alter table positions
	change column id id integer not null auto_increment,
	change column name name varchar(45),
	change column inactive inactive boolean;

create table price_levels(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

create table price_levels_items(
	id integer not null primary key auto_increment,
	price_level_id integer,
	item_id integer,
	custom_price double
) engine=innodb;

create table purchase_orders(
	id integer not null primary key auto_increment,
	date datetime,
	vendor_id integer,
	prepared_by varchar(45),
	approved_by varchar(45),
	reference_no varchar(45),
	created_by integer,
	creation_date datetime,
	updated_by integer,
	update_date datetime,
	po_no varchar(45),
	ship_to_address varchar(45),
	vendor_address varchar(45),
	vendor_message varchar(45),
	memo varchar(45),
	status smallint
) engine=innodb;

create table purchase_orders_items(
	purchase_order_id integer,
	item_id integer,
	rate double,
	quantity double,
	amount double,
	id integer not null primary key auto_increment,
	description varchar(45),
	unit_id integer,
	quantity_received double
) engine=innodb;

create table routes(
	id integer not null primary key auto_increment,
	code varchar(45),
	inactive boolean,
	description varchar(45)
) engine=innodb;

create table sales_infos(
	id integer not null primary key auto_increment,
	date datetime,
	route_id integer,
	sales_rep_id integer,
	prepared_by varchar(45),
	received_by varchar(45),
	customer_id integer,
	status smallint,
	created_by integer,
	creation_date datetime,
	updated_by integer,
	update_date datetime
) engine=innodb;

create table sales_infos_details(
	id integer not null primary key auto_increment,
	sales_info_id integer,
	check_no varchar(45),
	description varchar(45),
	amount double,
	type varchar(45)
) engine=innodb;

create table sales_orders(
	id integer not null primary key auto_increment,
	date datetime,
	customer_id integer
) engine=innodb;

create table sales_orders_items(
	id integer not null primary key auto_increment,
	sales_order_id integer,
	item_id integer,
	quantity double,
	unit_price double
) engine=innodb;

create table sales_reps(
	id integer not null primary key auto_increment,
	name varchar(45),
	address varchar(45),
	phone varchar(45),
	inactive boolean
) engine=innodb;

create table sales_tax_codes(
	id integer not null primary key auto_increment,
	code varchar(45),
	description varchar(45),
	taxable boolean,
	inactive boolean
) engine=innodb;

alter table shifts
	change column id id integer not null auto_increment,
	change column notes notes varchar(45),
	change column inactive inactive boolean,
	change column regular_hours regular_hours double,
	change column grace_period grace_period double;
	
alter table shift_times
	change column id id integer not null auto_increment,
	change column shift_id shift_id integer,
	change column time_in time_in integer,
	change column time_out time_out integer;

create table shipping_methods(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

alter table sss_premiums
	change column id id integer not null auto_increment,
	change column code code varchar(45),
	change column inactive inactive boolean;

create table states(
	id integer not null primary key auto_increment,
	short_name varchar(45),
	long_name varchar(45),
	country_id integer
) engine=innodb;
insert into states(country_id, short_name) values(1, 'AL');
insert into states(country_id, short_name) values(1, 'AK');
insert into states(country_id, short_name) values(1, 'AZ');
insert into states(country_id, short_name) values(1, 'AR');
insert into states(country_id, short_name) values(1, 'CA');
insert into states(country_id, short_name) values(1, 'CO');
insert into states(country_id, short_name) values(1, 'CT');
insert into states(country_id, short_name) values(1, 'DE');
insert into states(country_id, short_name) values(1, 'FL');
insert into states(country_id, short_name) values(1, 'GA');
insert into states(country_id, short_name) values(1, 'HI');
insert into states(country_id, short_name) values(1, 'ID');
insert into states(country_id, short_name) values(1, 'IL');
insert into states(country_id, short_name) values(1, 'IN');
insert into states(country_id, short_name) values(1, 'IA');
insert into states(country_id, short_name) values(1, 'KS');
insert into states(country_id, short_name) values(1, 'KY');
insert into states(country_id, short_name) values(1, 'LA');
insert into states(country_id, short_name) values(1, 'ME');
insert into states(country_id, short_name) values(1, 'MD');
insert into states(country_id, short_name) values(1, 'MA');
insert into states(country_id, short_name) values(1, 'MI');
insert into states(country_id, short_name) values(1, 'MN');
insert into states(country_id, short_name) values(1, 'MS');
insert into states(country_id, short_name) values(1, 'MO');
insert into states(country_id, short_name) values(1, 'MT');
insert into states(country_id, short_name) values(1, 'NE');
insert into states(country_id, short_name) values(1, 'NV');
insert into states(country_id, short_name) values(1, 'NH');
insert into states(country_id, short_name) values(1, 'NJ');
insert into states(country_id, short_name) values(1, 'NM');
insert into states(country_id, short_name) values(1, 'NY');
insert into states(country_id, short_name) values(1, 'NC');
insert into states(country_id, short_name) values(1, 'ND');
insert into states(country_id, short_name) values(1, 'OH');
insert into states(country_id, short_name) values(1, 'OK');
insert into states(country_id, short_name) values(1, 'OR');
insert into states(country_id, short_name) values(1, 'PA');
insert into states(country_id, short_name) values(1, 'RI');
insert into states(country_id, short_name) values(1, 'SC');
insert into states(country_id, short_name) values(1, 'SD');
insert into states(country_id, short_name) values(1, 'TN');
insert into states(country_id, short_name) values(1, 'TX');
insert into states(country_id, short_name) values(1, 'UT');
insert into states(country_id, short_name) values(1, 'VT');
insert into states(country_id, short_name) values(1, 'VA');
insert into states(country_id, short_name) values(1, 'WA');
insert into states(country_id, short_name) values(1, 'WV');
insert into states(country_id, short_name) values(1, 'WI');
insert into states(country_id, short_name) values(1, 'WY');

create table sub_categories(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

alter table tax_codes
	change column id id integer not null auto_increment,
	change column code code varchar(45),
	change column description description varchar(45),
	change column inactive inactive boolean,
	change column personal_exemption personal_exemption double;
	
alter table tax_salary_ranges
	change column id id integer not null auto_increment,
	change column tax_code_id tax_code_id integer;

create table terms(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

alter table time_sheets
	rename to timesheets,
	change column id id integer not null auto_increment,
	change column emp_id employee_id integer,
	change column date date datetime,
	change column in_out in_out boolean;

drop table if exists time_sheets_temp;

create table to_dos(	
	id integer not null primary key auto_increment,
	note mediumtext,
	remind_on datetime,
	done boolean,
	inactive boolean
) engine=innodb;

drop table travel_orders;

create table truck_loads(
	id integer not null primary key auto_increment,
	date datetime,
	route_id integer,
	sales_rep_id integer,
	truck_no varchar(45),
	prepared_by varchar(45),
	approved_by varchar(45),
	released_by varchar(45),
	recorded_by varchar(45),
	status smallint,
	remarks mediumtext,
	customer_id integer,
	created_by integer,
	creation_date datetime,
	updated_by integer,
	update_date datetime
) engine=innodb;

create table truck_loads_items(
	truck_load_id integer,
	item_id integer,
	quantity double,
	unit_price double,
	amount double,
	id integer not null primary key auto_increment,
	discount double
) engine=innodb;

create table truck_returns(
	id integer not null primary key auto_increment,
	date datetime,
	route_id integer,
	sales_rep_id integer,
	truck_no varchar(45),
	prepared_by varchar(45),
	approved_by varchar(45),
	released_by varchar(45),
	recorded_by varchar(45),
	status smallint,
	remarks mediumtext,
	customer_id integer,
	created_by integer,
	creation_date datetime,
	updated_by integer,
	update_date datetime
) engine=innodb;

create table truck_returns_items(
	truck_return_id integer,
	item_id integer,
	unit_price double,
	quantity double,
	amount double,
	id integer not null primary key auto_increment,
	discount double
) engine=innodb;

create table units(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean,
	set_name varchar(45),
	abbreviation varchar(45),
	description varchar(45)
) engine=innodb;

alter table users
	drop admin,
	change column id id integer not null auto_increment,
	change column name name varchar(45),
	change column password password varchar(45) character set latin1 collate latin1_general_cs,
	add challenge_question smallint after password,
	add answer varchar(45) after challenge_question,
	change column inactive inactive boolean;

create table users_modules(
	id integer not null primary key auto_increment,
	user_id integer,
	module_id integer
) engine=innodb;

create table users_modules_commands(
	id integer not null primary key auto_increment,
	module_id integer,
	command_id integer
) engine=innodb;

create table vehicle_mileages(
	id integer not null primary key auto_increment,
	vehicle_id integer,
	start_date datetime,
	end_date datetime,
	odometer_start double,
	odometer_end double,
	notes mediumtext
) engine=innodb;

create table vehicles(
	id integer not null primary key auto_increment,
	name varchar(45),
	description varchar(45),
	inactive boolean
) engine=innodb;

create table vendors(
	id integer not null primary key auto_increment,
	name varchar(45),
	address varchar(45),
	phone varchar(45),
	inactive boolean,
	balance double,
	contact varchar(45)
) engine=innodb;

create table vendor_types(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

create table vendors_discounted_items(
	id integer not null primary key auto_increment,
	vendor_id integer,
	item_id integer,
	discount double
) engine=innodb;

drop table violations;

create table workers_comps(
	id integer not null primary key auto_increment,
	code varchar(45),
	description varchar(45),
	rate double,
	effectivity_date datetime,
	inactive boolean
) engine=innodb;

drop function if exists get_emp_no;