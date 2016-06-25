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
	change column Id id integer not null auto_increment,
	change column Name name varchar(45),
	change column ShipToName ship_to_name varchar(45),
	change column ShipToAddress ship_to_address varchar(255),
	change column Address address varchar(255),
	change column Phone phone varchar(45),
	change column Fax fax varchar(45),
	change column Email email varchar(45),
	change column Website website varchar(45),
	change column LegalName legal_name varchar(45),
	change column LegalAddress legal_address varchar(45),
	change column LegalAddress1 legal_address1 varchar(45),
	change column City city varchar(45),
	change column State state_id integer,
	change column Zip zip varchar(45),
	change column LegalCountry legal_country_id integer,
	change column Country country_id integer,
	change column FiscalYear fiscal_year smallint,
	change column TaxYear tax_year smallint,
	change column IncomeTaxForm income_tax_form smallint,
	change column EIN ein varchar(45),
	change column SSN ssn varchar(45),
	change column PayrollContact payroll_contact varchar(45),
	change column PayrollTitle payroll_contact_title varchar(45),
	change column PayrollPhone payroll_contact_phone varchar(45);

create table config(
	id integer not null primary key auto_increment,
	data_version varchar(45)
) engine=innodb;
	
alter table converted_items
	change column Id id integer not null auto_increment,
	change column ItemFromId from_item_id integer,
	change column ItemToId to_item_id integer,
	change column Quantity quantity double,
	change column Date date datetime;
	
create table countries(
	id integer not null primary key auto_increment,
	short_name varchar(45),
	long_name varchar(45),
	inactive boolean
) engine=innodb;
insert into countries(short_name, long_name, inactive) values('US', 'United States', 0);
insert into countries(short_name, long_name, inactive) values('CA', 'Canada', 0);
insert into countries(short_name, long_name, inactive) values('Other', 'Other', 0);
insert into countries(short_name, long_name, inactive) values('PH', 'Philippines', 0);
	
alter table customers
	change column Id id integer not null auto_increment,
	change column Name name varchar(45),
	change column Address address varchar(45),
	change column Phone phone varchar(45),
	change column TradeAssistance trade_assistance varchar(45),
	change column Classification classification varchar(45),
	change column TypeOfDeal type_of_deal varchar(45),
	change column Balance balance double,
	add column inactive boolean,
	add column company_name varchar(45),
	add column balance_as_of datetime,
	add column title varchar(45),
	add column first_name varchar(45),
	add column last_name varchar(45),
	add column middle_name varchar(45),
	add column ship_to_address varchar(45),
	add column contact varchar(45),
	add column fax varchar(45),
	add column alt_phone varchar(45),
	add column alt_contact varchar(45),
	add column email varchar(45),
	add column cc varchar(45),
	add column customer_type_id integer,
	add column terms_id integer,
	add column sales_rep_id integer,
	add column send_method smallint,
	add column sales_tax_code_id integer,
	add column tax_item_id integer,
	add column resale_number varchar(45),
	add column price_level_id integer,
	add column account_no varchar(45),
	add column credit_limit double,
	add column payment_method_id integer,
	add column credit_card_no varchar(45),
	add column cc_expiry_month varchar(45),
	add column cc_expiry_year varchar(45),
	add column name_on_card varchar(45),
	add column cc_address varchar(45),
	add column cc_zip_code varchar(45),
	add column job_status smallint,
	add column start_date datetime,
	add column projected_end datetime,
	add column end_date datetime,
	add column job_description varchar(45),
	add column job_type_id integer,
	add column notes mediumtext;
	
update customers set inactive = 0;
	
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
	
alter table customer_disc_items
  rename to customers_discounted_items,
	change column Id id integer not null auto_increment,
	change column CustomerId customer_id integer,
	change column ItemId item_id integer,
	change column Discount discount double;
	
create table deductions(
	id integer not null primary key auto_increment,
	type integer,
	emp_id integer,
	amount double,
	pcode_id integer,
	date datetime
) engine=innodb;
	
create table deduction_types(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

create table departments(
	id integer not null primary key auto_increment,
	name varchar(45),
	description varchar(45),
	inactive boolean,
	branch_id integer
) engine=innodb;

create table employee_types(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

create table employees(
	id integer not null primary key auto_increment,
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
) engine=innodb;
	
alter table ending_quantities
	change column Id id integer not null auto_increment,
	change column Date date varchar(45);
	
alter table ending_qty_items
	rename to ending_quantities_items,
	change column Id id integer not null auto_increment,
	change column EQId ending_quantity_id integer,
	change column ItemId item_id integer,
	change column Qty quantity double;
	
alter table invoices
	change column Id id integer not null auto_increment,
	change column Date date datetime,
	change column CustomerId customer_id integer,
	add column ref_no varchar(45),
	add column bill_to_address varchar(45),
	add column ship_to_address varchar(45),
	add column po_no varchar(45),
	add column terms_id integer,
	add column sales_rep_id integer,
	add column shipping_date datetime,
	add column shipping_method_id integer,
	add column fob varchar(45),
	add column customer_message_id integer,
	add column tax_item_id integer,
	add column sales_tax_code_id integer,
	add column memo varchar(45),
	add column created_by integer,
	add column creation_date datetime,
	add column updated_by integer,
	add column update_date datetime,
	add column status smallint,
	add column account_id integer;
	
alter table invoice_items
	rename to invoices_items,
	change column InvoiceId invoice_id integer,
	change column ItemId item_id integer,
	change column Quantity quantity double,
	change column UnitPrice unit_price double,
	change column Id id integer not null auto_increment,
	add column sales_tax_code_id integer;
	
alter table items
	change column Id id integer not null auto_increment,
	change column Name name varchar(45),
	change column Description sales_description varchar(45),
	change column QtyOnHand on_hand double,
	change column UnitMeasure unit_measure varchar(45),
	change column UnitPrice sales_price double,
	change column ReOrderingLevel reorder_point double,
	change column OverStockLevel overstock_level double,
	change column Code part_number varchar(45),
	change column BeginningQty beginning_qty double,
	change column ToLargePacking tolarge_packing double,
	change column Inactive inactive boolean,
	change column UCS ucs double,
	change column PreferredVendorId preferred_vendor_id integer,
	change column VendorDiscount vendor_discount double,
	add column purchase_description varchar(45),
	add column cost double,
	add column type smallint,
	add column unit_id integer,
	add column income_account_id integer,
	add column cogs_account_id integer,
	add column sales_tax_code_id integer,
	add column asset_account_id integer,
	add column total_value double,
	add column value_as_of datetime;
	
update items set type = 1, purchase_description = sales_description, name = part_number, cost = sales_price;
	
alter table item_receipts
	change column Id id integer not null auto_increment,
	change column Date date datetime,
	change column VendorId vendor_id integer,
	change column PreparedBy prepared_by varchar(45),
	change column ApprovedBy approved_by varchar(45),
	change column ReferenceNo reference_no varchar(45),
	change column Remarks memo mediumtext,
	change column Status status smallint,
	add column created_by integer,
	add column creation_date datetime,
	add column updated_by integer,
	add column update_date datetime;
	
alter table item_receipt_items
	rename to item_receipts_items,
	change column Id id integer not null auto_increment,
	change column IRId item_receipt_id integer,
	change column ItemId item_id integer,
	change column Quantity quantity double,
	change column UnitPrice unit_price double,
	change column Discount discount double,
	change column UCS ucs double,
	add column customer_id integer,
	add column billable boolean;
  
drop trigger if exists item_receipt_items_before_ins_tr;
create trigger item_receipts_items_before_ins_tr before insert on item_receipts_items for each row
begin
  update items set on_hand = on_hand + new.quantity
  where items.id = new.item_id;
end;

create table job_types(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

create table loan_types(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;
	
alter table modules
	change column Id id integer not null auto_increment,
	change column Name name varchar(45),
	change column Inactive inactive boolean;
	
alter table module_commands
	rename to modules_commands,
	change column Id id integer not null auto_increment,
	change column ModuleId module_id integer,
	change column Name name varchar(45),
	change column Command command varchar(45);
	
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

create table pagibig_premiums(
	id integer not null primary key auto_increment,
	code varchar(45),
	range_from double,
	range_to double,
	ps double,
	es double,
	contribution double,
	inactive boolean,
	description varchar(45)
) engine=innodb;

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

create table payroll_codes(
	id integer not null primary key auto_increment,
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
) engine=innodb;

create table payroll_schedules(
	id integer not null primary key auto_increment,
	name varchar(45),
	pay_frequency smallint,
	next_check_date datetime,
	next_day_period datetime,
	inactive boolean
) engine=innodb;

create table payslips(
	id integer not null primary key auto_increment,
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
) engine=innodb;

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

create table philhealth_premiums(
	id integer not null primary key auto_increment,
	code varchar(45),
	range_from double,
	range_to double,
	ps double,
	es double,
	contribution double,
	inactive boolean
) engine=innodb;
	
alter table physical_counts
	change column Id id integer not null auto_increment,
	change column Date date datetime,
	change column PreparedBy prepared_by varchar(45),
	change column ApprovedBy approved_by varchar(45),
	change column Remarks remarks mediumtext;
	
alter table physical_count_items
	rename to physical_counts_items,
	change column Id id integer not null auto_increment,
	change column PCId physical_count_id integer,
	change column ItemId item_id integer,
	change column OriginalQty original_qty double,
	change column AdjustedQty adjusted_qty double;
  
drop trigger if exists physical_count_items_before_ins_tr;
create trigger physical_counts_items_before_ins_tr before insert on physical_counts_items for each row
begin
  update items set on_hand = new.adjusted_qty
  where items.id = new.item_id;
end;

create table positions(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

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
	
alter table purchase_orders
	change column Id id integer not null auto_increment,
	change column Date date datetime,
	change column VendorId vendor_id integer,
	change column PreparedBy prepared_by varchar(45),
	change column ApprovedBy approved_by varchar(45),
	change column ReferenceNo reference_no varchar(45),
	add column created_by integer,
	add column creation_date datetime,
	add column updated_by integer,
	add column update_date datetime,
	add column po_no varchar(45),
	add column ship_to_address varchar(45),
	add column vendor_address varchar(45),
	add column vendor_message varchar(45),
	add column memo varchar(45),
	add column status smallint;
	
alter table purchase_order_items
	rename to purchase_orders_items,
	change column POId purchase_order_id integer,
	change column ItemId item_id integer,
	change column UnitPrice rate double,
	change column Quantity quantity double,
	change column Amount amount double,
	change column Id id integer not null auto_increment,
	add column description varchar(45),
	add column unit_id integer,
	add column quantity_received double;
	
alter table routes
	change column Id id integer not null auto_increment,
	change column Code code varchar(45),
	change column Inactive inactive boolean,
	change column Description description varchar(45);
	
alter table sales_infos
	change column Id id integer not null auto_increment,
	change column Date date datetime,
	change column RouteId route_id integer,
	change column SalesmanId sales_rep_id integer,
	change column PreparedBy prepared_by varchar(45),
	change column ReceivedBy received_by varchar(45),
	change column CustomerId customer_id integer,
	change column Status status smallint,
	add column created_by integer,
	add column creation_date datetime,
	add column updated_by integer,
	add column update_date datetime;
	
alter table sales_info_details
	rename to sales_infos_details,
	change column Id id integer not null auto_increment,
	change column SIId sales_info_id integer,
	change column CheckNo check_no varchar(45),
	change column Description description varchar(45),
	change column Amount amount double,
	change column Type type varchar(45);
	
alter table sales_orders
	change column Id id integer not null auto_increment,
	change column Date date datetime,
	change column CustomerId customer_id integer;
	
alter table sales_order_items
  rename to sales_orders_items,
	change column Id id integer not null auto_increment,
	change column SOId sales_order_id integer,
	change column ItemId item_id integer,
	change column Quantity quantity double,
	change column UnitPrice unit_price double;
	
alter table salesmen
	rename to sales_reps,
	change column Id id integer not null auto_increment,
	change column Name name varchar(45),
	change column Address address varchar(45),
	change column Phone phone varchar(45),
	change column Inactive inactive boolean;
	
create table sales_tax_codes(
	id integer not null primary key auto_increment,
	code varchar(45),
	description varchar(45),
	taxable boolean,
	inactive boolean
) engine=innodb;

create table shifts(
	id integer not null primary key auto_increment,
	notes varchar(45),
	inactive boolean,
	regular_hours double,
	grace_period double
) engine=innodb;

create table shift_times(
	id integer not null primary key auto_increment,
	shift_id integer,
	time_in integer,
	time_out integer
) engine=innodb;

create table shipping_methods(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

create table sss_premiums(
	id integer not null primary key auto_increment,
	code varchar(45),
	range_from double,
	range_to double,
	er double,
	ec double,
	ee double,
	contribution double,
	inactive boolean
) engine=innodb;

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
insert into states(country_id, short_name) values(2, 'AB');
insert into states(country_id, short_name) values(2, 'BC');
insert into states(country_id, short_name) values(2, 'MB');
insert into states(country_id, short_name) values(2, 'NB');
insert into states(country_id, short_name) values(2, 'NL');
insert into states(country_id, short_name) values(2, 'NT');
insert into states(country_id, short_name) values(2, 'NS');
insert into states(country_id, short_name) values(2, 'NU');
insert into states(country_id, short_name) values(2, 'ON');
insert into states(country_id, short_name) values(2, 'PE');
insert into states(country_id, short_name) values(2, 'QC');
insert into states(country_id, short_name) values(2, 'SK');
insert into states(country_id, short_name) values(2, 'YT');

create table sub_categories(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

create table tax_codes(
	id integer not null primary key auto_increment,
	code varchar(45),
	description varchar(45),
	inactive boolean,
	personal_exemption double
) engine=innodb;

create table tax_salary_ranges(
	id integer not null primary key auto_increment,
	tax_code_id integer,
	monthly_from double,
	monthly_to double,
	monthly_tax double,
	semimonthly_from double,
	semimonthly_to double,
	semimonthly_tax double,
	percent_over double
) engine=innodb;

create table terms(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;

create table timesheets(
	id integer not null primary key auto_increment,
	employee_id integer,
	date datetime,
	in_out boolean
) engine=innodb;
  
alter table todos
	rename to to_dos,
	change column Id id integer not null auto_increment,
	change column Note note mediumtext,
	change column RemindOn remind_on datetime,
	change column Done done boolean,
	change column Inactive inactive boolean;
  
alter table truck_loads
	change column Id id integer not null auto_increment,
	change column Date date datetime,
	change column RouteId route_id integer,
	change column SalesmanId sales_rep_id integer,
	change column TruckNo truck_no varchar(45),
	change column PreparedBy prepared_by varchar(45),
	change column ApprovedBy approved_by varchar(45),
	change column ReleasedBy released_by varchar(45),
	change column RecordedBy recorded_by varchar(45),
	change column Status status smallint,
	change column Remarks remarks mediumtext,
	change column CustomerId customer_id integer,
	add column created_by integer,
	add column creation_date datetime,
	add column updated_by integer,
	add column update_date datetime;
  
alter table truck_load_items
	rename to truck_loads_items,
	change column TLId truck_load_id integer,
	change column ItemId item_id integer,
	change column Quantity quantity double,
	change column UnitPrice unit_price double,
	change column Amount amount double,
	change column Id id integer not null auto_increment,
	change column Discount discount double;
  
alter table truck_returns
	change column Id id integer not null auto_increment,
	change column Date date datetime,
	change column RouteId route_id integer,
	change column SalesmanId sales_rep_id integer,
	change column TruckNo truck_no varchar(45),
	change column PreparedBy prepared_by varchar(45),
	change column ApprovedBy approved_by varchar(45),
	change column ReleasedBy released_by varchar(45),
	change column RecordedBy recorded_by varchar(45),
	change column Status status smallint,
	change column Remarks remarks mediumtext,
	change column CustomerId customer_id integer,
	add column created_by integer,
	add column creation_date datetime,
	add column updated_by integer,
	add column update_date datetime;
  
alter table truck_return_items
	rename to truck_returns_items,
	change column TRId truck_return_id integer,
	change column ItemId item_id integer,
	change column UnitPrice unit_price double,
	change column Quantity quantity double,
	change column Amount amount double,
	change column Id id integer not null auto_increment,
	change column Discount discount double;
  
alter table units
	change column Id id integer not null auto_increment,
	change column Name name varchar(45),
	change column Inactive inactive boolean,
	add column set_name varchar(45),
	add column abbreviation varchar(45),
	add column description varchar(45);
  
alter table users
	change column Id id integer not null auto_increment,
	change column Name name varchar(45),
	change column Password password varchar(45) character set latin1 collate latin1_general_cs,
	change column ChallengeQuestion challenge_question smallint,
	change column Answer answer varchar(45),
	add column inactive boolean;
update users set inactive = 0;
  
alter table user_modules
	rename to users_modules,
	change column Id id integer not null auto_increment,
	change column UserId user_id integer,
	change column ModuleId module_id integer;
  
alter table user_module_commands
	rename to users_modules_commands,
	change column Id id integer not null auto_increment,
	change column ModuleId module_id integer,
	change column CommandId command_id integer;



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
  
alter table vendors
	change column Id id integer not null auto_increment,
	change column Name name varchar(45),
	change column Address address varchar(45),
	change column Phone phone varchar(45),
	add column inactive boolean,
	add column balance double,
	add column contact varchar(45);

update vendors set inactive = 0;
  
create table vendor_types(
	id integer not null primary key auto_increment,
	name varchar(45),
	inactive boolean
) engine=innodb;
  
alter table vendor_disc_items
	rename to vendors_discounted_items,
	change column Id id integer not null auto_increment,
	change column VendorId vendor_id integer,
	change column ItemId item_id integer,
	change column Discount discount double;
  
alter table vendor_returned_items
	rename to item_receipts_returned_items,
	change column Id id integer not null auto_increment,
	change column IRId item_receipt_id integer,
	change column ItemId item_id integer,
	change column Quantity quantity double,
	change column UnitPrice unit_price double;
  
create table workers_comps(
	id integer not null primary key auto_increment,
	code varchar(45),
	description varchar(45),
	rate double,
	effectivity_date datetime,
	inactive boolean
) engine=innodb;

-- drop procedure if exists update_items_from_truck_loads;
-- drop procedure if exists update_items_from_truck_returns;
-- drop procedure if exists update_truck_load_items;

-- drop function if exists get_actual_cash;
-- drop function if exists get_actual_cash2;
-- drop function if exists get_bottlepacks;
-- drop function if exists get_bottlepacks2;
-- drop function if exists get_check;
-- drop function if exists get_check2;
-- drop function if exists get_customer;
-- drop function if exists get_customer_discounts;
-- drop function if exists get_discount;
-- drop function if exists get_discounted_items;
-- drop function if exists get_empties;
-- drop function if exists get_empties2;
-- drop function if exists get_ending_qty;
-- drop function if exists get_expenses;
-- drop function if exists get_expenses_with_customer;
-- drop function if exists get_fullcasebox;
-- drop function if exists get_fullcasebox2;
-- drop function if exists get_fullcasebox3;
-- drop function if exists get_fullcases;
-- drop function if exists get_item_discounts;
-- drop function if exists get_item_price;
-- drop function if exists get_item_qty_truck_loads;
-- drop function if exists get_item_qty_truck_returns;
-- drop function if exists get_item_sold_amount;
-- drop function if exists get_item_truck_loads;
-- drop function if exists get_item_truck_loads2;
-- drop function if exists get_item_truck_returns;
-- drop function if exists get_item_truck_returns2;
-- drop function if exists get_loaded_item;
-- drop function if exists get_mtcases;
-- drop function if exists get_net_cash;
-- drop function if exists get_net_cash_with_customer;
-- drop function if exists get_received_item;
-- drop function if exists get_returned_item;
-- drop function if exists get_return_item;
-- drop function if exists get_route;
-- drop function if exists get_route_actual_cash_onhand;
-- drop function if exists get_route_info;
-- drop function if exists get_salesman;
-- drop function if exists get_salesman_actual_cash_onhand;
-- drop function if exists get_salesman_info;
-- drop function if exists get_sales_info_detail;
-- drop function if exists get_sales_info_detail2;
-- drop function if exists get_sales_info_detail3;
-- drop function if exists get_sales_info_detail4;
-- drop function if exists get_soldqtybycode;
-- drop function if exists get_sold_discounted_items;
-- drop function if exists get_sold_qty;
-- drop function if exists get_sold_qty_from_customer;
-- drop function if exists get_sold_qty_from_salesman;
-- drop function if exists get_sold_undiscounted_items;
-- drop function if exists get_tdi;
-- drop function if exists get_total_discounts;
-- drop function if exists get_truck_load_amount;
-- drop function if exists get_truck_load_amount2;
-- drop function if exists get_truck_load_fulls;
-- drop function if exists get_truck_load_fulls2;
-- drop function if exists get_truck_return_amount;
-- drop function if exists get_truck_return_amount2;
-- drop function if exists get_truck_return_fulls;
-- drop function if exists get_truck_return_fulls2;

-- drop trigger if exists item_receipt_items_before_del_tr;
-- drop trigger if exists item_receipt_items_before_upd_tr;
-- drop trigger if exists item_receipts_items_before_ins_tr;
-- drop trigger if exists physical_counts_items_before_ins_tr;
-- drop trigger if exists truck_load_items_before_del_tr;
-- drop trigger if exists truck_load_items_before_ins_tr;
-- drop trigger if exists truck_load_items_before_upd_tr;
-- drop trigger if exists truck_return_items_before_del_tr;
-- drop trigger if exists truck_return_items_before_ins_tr;
-- drop trigger if exists truck_return_items_before_upd_tr;
-- drop trigger if exists vendor_returned_items_before_del_tr;
-- drop trigger if exists vendor_returned_items_before_ins_tr;
-- drop trigger if exists vendor_returned_items_before_upd_tr;