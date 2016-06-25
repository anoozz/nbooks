drop table if exists accounts;
create table accounts(
	id integer not null primary key,
	name varchar(45),
	description varchar(45),
	note varchar(45),
	balance double,
	inactive boolean,
	type smallint,
	tax_line_mapping smallint
);

drop table if exists bills;
create table bills(
	id integer not null primary key,
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
);

drop table if exists bills_accounts;
create table bills_accounts(
	id integer not null primary key,
	bill_id integer,
	account_id integer,
	amount double,
	amount_paid double,
	memo varchar(45),
	customer_id integer,
	billable boolean,
	class_id integer
);

drop table if exists bills_items;
create table bills_items(
	id integer not null primary key,
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
);

drop table if exists bills_payments;
create table bills_payments(
	id integer not null primary key,
	date datetime,
	payment_method_id integer,
	account_id integer
);

drop table if exists bills_payments_bills;
create table bills_payments_bills(
	id integer not null primary key,
	bill_payment_id integer,
	bill_id integer,
	amount_paid double
);

drop table if exists categories;
create table categories(
	id integer not null primary key,
	name varchar(45),
	description varchar(45),
	inactive boolean
);

drop table if exists classes;
create table classes(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
);

drop table if exists company;
create table company(
	id integer not null primary key,
	name varchar(45),
	ship_to_name varchar(45),
	ship_to_address varchar(255),
	address varchar(255),
	phone varchar(45),
	fax varchar(45),
	email varchar(45),
	website varchar(45),
	legal_name varchar(45),
	legal_address varchar(45),
	legal_address1 varchar(45),
	city varchar(45),
	state_id integer,
	zip varchar(45),
	legal_country_id integer,
	country_id integer,
	fiscal_year smallint,
	tax_year smallint,
	income_tax_form smallint,
	ein varchar(45),
	ssn varchar(45),
	payroll_contact varchar(45),
	payroll_contact_title varchar(45),
	payroll_contact_phone varchar(45)
);

drop table if exists config;
create table config(
	id integer not null primary key,
	data_version varchar(45)
);

drop table if exists converted_items;
create table converted_items(
	id integer not null primary key,
	from_item_id integer,
	to_item_id integer,
	quantity double,
	date datetime
);

drop table if exists countries;
create table countries(
	id integer not null primary key,
	short_name varchar(45),
	long_name varchar(45),
	inactive boolean
);

drop table if exists customer_messages;
create table customer_messages(
	id integer not null primary key,
	message mediumtext,
	inactive boolean
);

drop table if exists customer_types;
create table customer_types(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
);

drop table if exists customers;
create table customers(
	id integer not null primary key,
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
);

drop table if exists customers_discounted_items;
create table customers_discounted_items(
	id integer not null primary key,
	customer_id integer,
	item_id integer,
	discount double
);

drop table if exists deduction_types;
create table deduction_types(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
);

drop table if exists deductions;
create table deductions(
	id integer not null primary key,
	type integer,
	emp_id integer,
	amount double,
	pcode_id integer,
	date datetime
);

drop table if exists departments;
create table departments(
	id integer not null primary key,
	name varchar(45),
	description varchar(45),
	inactive boolean,
	branch_id integer
);

drop table if exists employee_types;
create table employee_types(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
);

drop table if exists employees;
create table employees(
	id integer not null primary key,
	last_name varchar(45),
	first_name varchar(45),
	middle_name varchar(45),
	street1 varchar(45),
	gender smallint,
	date_of_birth datetime,
	marital_status smallint,
	phone varchar(45),
	religion varchar(45),
	zip varchar(45),
	date_hired datetime,
	date_resigned datetime,
	school varchar(45),
	course varchar(255),
	contact varchar(45),
	branch_id integer,
	department_id integer,
	account_no varchar(45),
	stat_code varchar(45),
	shift_id integer,
	hdmf varchar(45),
	ss_no varchar(45),
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
	emp_id varchar(45),
	title varchar(45),
	print_on_check_as varchar(45),
	street2 varchar(45),
	city varchar(45),
	state_id integer,
	cellular varchar(45),
	email varchar(45)
);

drop table if exists ending_quantities;
create table ending_quantities(
	id integer not null primary key,
	date varchar(45)
);

drop table if exists ending_quantities_items;
create table ending_quantities_items(
	id integer not null primary key,
	ending_quantity_id integer,
	item_id integer,
	quantity double
);

drop table if exists invoices;
create table invoices(
	id integer not null primary key,
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
);

drop table if exists invoices_items;
create table invoices_items(
	invoice_id integer,
	item_id integer,
	quantity double,
	unit_price double,
	id integer not null primary key,
	sales_tax_code_id integer
);

drop table if exists item_receipts;
create table item_receipts(
	id integer not null primary key,
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
);

drop table if exists item_receipts_items;
create table item_receipts_items(
	id integer not null primary key,
	item_receipt_id integer,
	item_id integer,
	quantity double,
	unit_price double,
	discount double,
	ucs double,
	customer_id integer,
	billable boolean
);

drop table if exists item_receipts_returned_items;
create table item_receipts_returned_items(
	id integer not null primary key,
	item_receipt_id integer,
	item_id integer,
	quantity double,
	unit_price double
);

drop table if exists items;
create table items(
	id integer not null primary key,
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
);

drop table if exists job_types;
create table job_types(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
);

drop table if exists loan_types;
create table loan_types(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
);

drop table if exists modules;
create table modules(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
);

drop table if exists modules_commands;
create table modules_commands(
	id integer not null primary key,
	module_id integer,
	name varchar(45),
	command varchar(45)
);

drop table if exists other_names;
create table other_names(
	id integer not null primary key,
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
);

drop table if exists pagibig_premiums;
create table pagibig_premiums(
	id integer not null primary key,
	code varchar(45),
	range_from double,
	range_to double,
	ps double,
	es double,
	contribution double,
	inactive boolean,
	description varchar(45)
);

drop table if exists payment_methods;
create table payment_methods(
	id integer not null primary key,
	name varchar(45),
	type smallint,
	inactive boolean
);

drop table if exists payments;
create table payments(
	id integer not null primary key,
	customer_id integer,
	amount double,
	payment_method_id integer,
	memo varchar(45),
	date datetime,
	check_no varchar(45)
);

drop table if exists payments_invoices;
create table payments_invoices(
	id integer not null primary key,
	payment_id integer,
	invoice_id integer,
	amount_paid double
);

drop table if exists payroll_codes;
create table payroll_codes(
	id integer not null primary key,
	date_from datetime,
	date_to datetime,
	days_consume double,
	year integer,
	loan_sss boolean,
	loan_pagibig boolean,
	loan_philhealth boolean,
	close_semi boolean,
	inactive boolean,
	code varchar(45),
	ot_regular_rate double,
	ot_sunday_rate double,
	ot_legal_rate double,
	ot_special_rate double,
	ot_legal_sunday_rate double
);

drop table if exists payroll_items;
create table payroll_items(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
);

drop table if exists payroll_schedules;
create table payroll_schedules(
	id integer not null primary key,
	name varchar(45),
	pay_frequency smallint,
	next_check_date datetime,
	next_day_period datetime,
	inactive boolean
);

drop table if exists payslips;
create table payslips(
	id integer not null primary key,
	emp_id integer,
	pcode_id integer,
	regular_hours double,
	undertime_hours double,
	absent_hours double,
	regular_pay double,
	other_income double,
	tax_withheld double,
	sss_medical double,
	sss_premium double,
	sss_salary double,
	sss_education double,
	sss_cal double,
	other_deduction double,
	pagibig_loan double,
	pagibig_health double,
	pagibig_premium double,
	gross_pay double,
	deduction double,
	net_pay double,
	hours_worked double,
	pay double,
	sss_employer_contrib double
);

drop table if exists periods;
create table periods(
	id integer not null primary key,
	name varchar(45),
	date_from datetime,
	date_to datetime,
	inactive boolean
);

drop table if exists periods_categories;
create table periods_categories(
	id integer not null primary key,
	period_id integer,
	category_id integer,
	target_value double
);

drop table if exists philhealth_premiums;
create table philhealth_premiums(
	id integer not null primary key,
	code varchar(45),
	range_from double,
	range_to double,
	ps double,
	es double,
	contribution double,
	inactive boolean
);

drop table if exists physical_counts;
create table physical_counts(
	id integer not null primary key,
	date datetime,
	prepared_by varchar(45),
	approved_by varchar(45),
	remarks mediumtext
);

drop table if exists physical_counts_items;
create table physical_counts_items(
	id integer not null primary key,
	physical_count_id integer,
	item_id integer,
	original_qty double,
	adjusted_qty double
);

drop table if exists positions;
create table positions(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
);

drop table if exists price_levels;
create table price_levels(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
);

drop table if exists price_levels_items;
create table price_levels_items(
	id integer not null primary key,
	price_level_id integer,
	item_id integer,
	custom_price double
);

drop table if exists purchase_orders;
create table purchase_orders(
	id integer not null primary key,
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
);

drop table if exists purchase_orders_items;
create table purchase_orders_items(
	purchase_order_id integer,
	item_id integer,
	rate double,
	quantity double,
	amount double,
	id integer not null primary key,
	description varchar(45),
	unit_id integer,
	quantity_received double
);

drop table if exists routes;
create table routes(
	id integer not null primary key,
	code varchar(45),
	inactive boolean,
	description varchar(45)
);

drop table if exists sales_infos;
create table sales_infos(
	id integer not null primary key,
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
);

drop table if exists sales_infos_details;
create table sales_infos_details(
	id integer not null primary key,
	sales_info_id integer,
	check_no varchar(45),
	description varchar(45),
	amount double,
	type varchar(45)
);

drop table if exists sales_orders;
create table sales_orders(
	id integer not null primary key,
	date datetime,
	customer_id integer
);

drop table if exists sales_orders_items;
create table sales_orders_items(
	id integer not null primary key,
	sales_order_id integer,
	item_id integer,
	quantity double,
	unit_price double
);

drop table if exists sales_receipts;
create table sales_receipts(
	id integer not null primary key,
	date datetime,
	customer_id integer
);

drop table if exists sales_receipts_items;
create table sales_receipts_items(
	id integer not null primary key,
	sales_receipt_id integer,
	item_id integer,
	quantity double,
	unit_price double
);

drop table if exists sales_receipts;
create table sales_receipts(
	id integer not null primary key,
	date datetime,
	account_id integer,
	vehicle_trip_id integer,
	customer_id integer,
	notes mediumtext
);

drop table if exists sales_receipts_items;
create table sales_receipts_items(
	id integer not null primary key,
	sales_receipt_id integer,
	item_id integer,
	quantity double,
	rate double
);

drop table if exists sales_reps;
create table sales_reps(
	id integer not null primary key,
	name varchar(45),
	address varchar(45),
	phone varchar(45),
	inactive boolean
);

drop table if exists sales_tax_codes;
create table sales_tax_codes(
	id integer not null primary key,
	code varchar(45),
	description varchar(45),
	taxable boolean,
	inactive boolean
);

drop table if exists shift_times;
create table shift_times(
	id integer not null primary key,
	shift_id integer,
	time_in integer,
	time_out integer
);

drop table if exists shifts;
create table shifts(
	id integer not null primary key,
	notes varchar(45),
	inactive boolean,
	regular_hours double,
	grace_period double
);

drop table if exists shipping_methods;
create table shipping_methods(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
);

drop table if exists sss_premiums;
create table sss_premiums(
	id integer not null primary key,
	code varchar(45),
	range_from double,
	range_to double,
	er double,
	ec double,
	ee double,
	contribution double,
	inactive boolean
);

drop table if exists states;
create table states(
	id integer not null primary key,
	short_name varchar(45),
	long_name varchar(45),
	country_id integer
);

drop table if exists sub_categories;
create table sub_categories(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
);

drop table if exists tax_codes;
create table tax_codes(
	id integer not null primary key,
	code varchar(45),
	description varchar(45),
	inactive boolean,
	personal_exemption double
);

drop table if exists tax_salary_ranges;
create table tax_salary_ranges(
	id integer not null primary key,
	tax_code_id integer,
	monthly_from double,
	monthly_to double,
	monthly_tax double,
	semimonthly_from double,
	semimonthly_to double,
	semimonthly_tax double,
	percent_over double
);

drop table if exists terms;
create table terms(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
);

drop table if exists timesheets;
create table timesheets(
	id integer not null primary key,
	employee_id integer,
	date datetime,
	in_out boolean
);

drop table if exists to_dos;
create table to_dos(	
	id integer not null primary key,
	note mediumtext,
	remind_on datetime,
	done boolean,
	inactive boolean
);

drop table if exists truck_loads;
create table truck_loads(
	id integer not null primary key,
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
);

drop table if exists truck_loads_items;
create table truck_loads_items(
	truck_load_id integer,
	item_id integer,
	quantity double,
	unit_price double,
	amount double,
	id integer not null primary key,
	discount double
);

drop table if exists truck_returns;
create table truck_returns(
	id integer not null primary key,
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
);

drop table if exists truck_returns_items;
create table truck_returns_items(
	truck_return_id integer,
	item_id integer,
	unit_price double,
	quantity double,
	amount double,
	id integer not null primary key,
	discount double
);

drop table if exists units;
create table units(
	id integer not null primary key,
	name varchar(45),
	inactive boolean,
	set_name varchar(45),
	abbreviation varchar(45),
	description varchar(45)
);

drop table if exists users;
create table users(
	id integer not null primary key,
	name varchar(45),
	password varchar(45),
	challenge_question smallint,
	answer varchar(45),
	inactive boolean
);
insert into users(name, password, inactive) values('admin', 'root', 0);

drop table if exists users_modules;
create table users_modules(
	id integer not null primary key,
	user_id integer,
	module_id integer
);

drop table if exists users_modules_commands;
create table users_modules_commands(
	id integer not null primary key,
	module_id integer,
	command_id integer
);

drop table if exists vehicle_mileages;
create table vehicle_mileages(
	id integer not null primary key,
	vehicle_id integer,
	start_date datetime,
	end_date datetime,
	odometer_start double,
	odometer_end double,
	notes mediumtext
);

drop table if exists vehicle_trips;
create table vehicle_trips(
	id integer not null primary key,
	vehicle_id integer,
	start_date datetime,
	end_date datetime,
	odometer_start double,
	odometer_end double,
	notes mediumtext,
	inactive boolean
);

drop table if exists vehicles;
create table vehicles(
	id integer not null primary key,
	name varchar(45),
	description varchar(45),
	inactive boolean
);

drop table if exists vendor_types;
create table vendor_types(
	id integer not null primary key,
	name varchar(45),
	inactive boolean
);

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

drop table if exists vendors_discounted_items;
create table vendors_discounted_items(
	id integer not null primary key,
	vendor_id integer,
	item_id integer,
	discount double
);

drop table if exists workers_comps;
create table workers_comps(
	id integer not null primary key,
	code varchar(45),
	description varchar(45),
	rate double,
	effectivity_date datetime,
	inactive boolean
);