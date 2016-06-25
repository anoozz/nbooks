drop table if exists company;
create table company(
	Id integer not null primary key auto_increment,
	Name varchar(45),
	ShipToName varchar(45),
	ShipToAddress varchar(45),
	Address varchar(45),
	Phone varchar(45),
	Fax varchar(45),
	Email varchar(45),
	Website varchar(45),
	LegalName varchar(45),
	LegalAddress varchar(45),
	LegalAddress1 varchar(45),
	City varchar(45),
	State integer,
	Zip varchar(45),
	LegalCountry integer,
	Country integer,
	FiscalYear integer,
	TaxYear integer,
	IncomeTaxForm integer,
	EIN varchar(45),
	SSN varchar(45),
	PayrollContact varchar(45),
	PayrollTitle varchar(45),
	PayrollPhone varchar(45)
) engine=innodb;
insert into company(Name) values('Sample Company');

drop table if exists converted_items;
create table converted_items(
	Id integer not null primary key auto_increment,
	ItemFromId integer,
	ItemToId integer,
	Quantity double,
	Date datetime
) engine=innodb;

drop table if exists customers;
create table customers(
	Id integer not null primary key auto_increment,
	Name varchar(45),
	Address varchar(45),
	Phone varchar(45),
	TradeAssistance varchar(45),
	Classification varchar(45),
	TypeOfDeal varchar(45),
	Balance double
) engine=innodb;

drop table if exists customer_disc_items;
create table customer_disc_items(
	Id integer not null primary key auto_increment,
	CustomerId integer,
	ItemId integer,
	Discount double
) engine=innodb;

drop table if exists ending_qty_items;
create table ending_qty_items(
	Id integer not null primary key auto_increment,
	EQId integer,
	ItemId integer,
	Qty double
) engine=innodb;

drop table if exists ending_quantities;
create table ending_quantities(
	Id integer not null primary key auto_increment,
	Date varchar(45)
) engine=innodb;

drop table if exists invoices;
create table invoices(
	Id integer not null primary key auto_increment,
	Date datetime,
	CustomerId integer
) engine=innodb;

drop table if exists invoice_items;
create table invoice_items(
	InvoiceId integer,
	ItemId integer,
	Quantity double,
	UnitPrice double,
	Id integer not null primary key auto_increment
) engine=innodb;

drop table if exists items;
create table items(
	Id integer not null primary key auto_increment,
	Name varchar(45),
	Description varchar(45),
	QtyOnHand double,
	UnitMeasure varchar(45),
	UnitPrice double,
	ReOrderingLevel double,
	OverStockLevel double,
	Code varchar(45),
	BeginningQty double,
	ToLargePacking double,
	Inactive boolean,
	UCS double,
	PreferredVendorId integer,
	VendorDiscount double
) engine=innodb;

drop table if exists item_receipts;
create table item_receipts(
	Id integer not null primary key auto_increment,
	Date datetime,
	VendorId integer,
	PreparedBy varchar(45),
	ApprovedBy varchar(45),
	ReferenceNo varchar(45),
	Remarks varchar(45),
	Status varchar(45)
) engine=innodb;

drop table if exists item_receipt_items;
create table item_receipt_items(
	Id integer not null primary key auto_increment,
	IRId integer,
	ItemId integer,
	Quantity double,
	UnitPrice double,
	Discount double,
	UCS double
) engine=innodb;

drop table if exists modules;
create table modules(
	Id integer not null primary key,
	Name varchar(45),
	Inactive boolean
) engine=innodb;

drop table if exists module_commands;
create table module_commands(
	Id integer not null primary key auto_increment,
	ModuleId integer,
	Name varchar(45),
	Command varchar(255)
) engine=innodb;

drop table if exists physical_counts;
create table physical_counts(
	Id integer not null primary key auto_increment,
	Date datetime,
	PreparedBy varchar(45),
	ApprovedBy varchar(45),
	Remarks varchar(45)
) engine=innodb;

drop table if exists physical_count_items;
create table physical_count_items(
	Id integer not null primary key auto_increment,
	PCId integer,
	ItemId integer,
	OriginalQty double,
	AdjustedQty double
) engine=innodb;

drop table if exists purchase_orders;
create table purchase_orders(
	Id integer not null primary key auto_increment,
	Date datetime,
	VendorId integer,
	PreparedBy varchar(45),
	ApprovedBy varchar(45),
	ReferenceNo varchar(45)
) engine=innodb;

drop table if exists purchase_order_items;
create table purchase_order_items(
	POId integer,
	ItemId integer,
	UnitPrice double,
	Quantity double,
	Amount double,
	Id integer not null primary key auto_increment
) engine=innodb;

drop table if exists routes;
create table routes(
	Id integer not null primary key auto_increment,
	Code varchar(45),
	Inactive boolean,
	Description varchar(45)
) engine=innodb;

drop table if exists salesmen;
create table salesmen(
	Id integer not null primary key auto_increment,
	Name varchar(45),
	Address varchar(45),
	Phone varchar(45),
	Inactive boolean
) engine=innodb;

drop table if exists sales_infos;
create table sales_infos(
	Id integer not null primary key auto_increment,
	Date datetime,
	RouteId integer,
	SalesmanId integer,
	PreparedBy varchar(45),
	ReceivedBy varchar(45),
	CustomerId integer,
	Status varchar(45)
) engine=innodb;

drop table if exists sales_info_details;
create table sales_info_details(
	Id integer not null primary key auto_increment,
	SIId varchar(45),
	CheckNo varchar(45),
	Description varchar(45),
	Amount double,
	Type varchar(45)
) engine=innodb;

drop table if exists sales_orders;
create table sales_orders(
	Id integer not null primary key auto_increment,
	Date datetime,
	CustomerId integer
) engine=innodb;

drop table if exists sales_order_items;
create table sales_order_items(
	Id integer not null primary key auto_increment,
	SOId integer,
	ItemId integer,
	Quantity double,
	UnitPrice double
) engine=innodb;

drop table if exists todos;
create table todos(
	Id integer not null primary key auto_increment,
	Note varchar(500),
	RemindOn datetime,
	Done boolean,
	Inactive boolean
) engine=innodb;

drop table if exists truck_loads;
create table truck_loads(
	Id integer not null primary key auto_increment,
	Date datetime,
	RouteId integer,
	SalesmanId integer,
	TruckNo varchar(45),
	PreparedBy varchar(45),
	ApprovedBy varchar(45),
	ReleasedBy varchar(45),
	RecordedBy varchar(45),
	Status varchar(45),
	Remarks varchar(45),
	CustomerId integer
) engine=innodb;

drop table if exists truck_load_items;
create table truck_load_items(
	TLId integer,
	ItemId integer,
	Quantity double,
	UnitPrice double,
	Amount double,
	Id integer not null primary key auto_increment,
	Discount double
) engine=innodb;

drop table if exists truck_returns;
create table truck_returns(
	Id integer not null primary key auto_increment,
	Date datetime,
	RouteId integer,
	SalesmanId integer,
	TruckNo varchar(45),
	PreparedBy varchar(45),
	ApprovedBy varchar(45),
	ReleasedBy varchar(45),
	RecordedBy varchar(45),
	Status varchar(45),
	Remarks varchar(45),
	CustomerId integer
) engine=innodb;

drop table if exists truck_return_items;
create table truck_return_items(
	TRId integer,
	ItemId integer,
	Quantity double,
	UnitPrice double,
	Amount double,
	Id integer not null primary key auto_increment,
	Discount double
) engine=innodb;

drop table if exists units;
create table units(
	Id integer not null primary key auto_increment,
	Name varchar(45),
	Inactive boolean
) engine=innodb;

drop table if exists users;
create table users(
	Id integer not null primary key auto_increment,
	Name varchar(45),
	Password varchar(45),
	ChallengeQuestion varchar(45),
	Answer varchar(45)
) engine=innodb;
insert into users(Name, Password) values('admin', 'root');

drop table if exists user_modules;
create table user_modules(
	Id integer not null primary key auto_increment,
	UserId integer,
	ModuleId integer
) engine=innodb;

drop table if exists user_module_commands;
create table user_module_commands(
	Id integer not null primary key auto_increment,
	ModuleId integer,
	CommandId integer
) engine=innodb;

drop table if exists vendors;
create table vendors(
	Id integer not null primary key auto_increment,
	Name varchar(45),
	Address varchar(45),
	Phone varchar(45)
) engine=innodb;

drop table if exists vendor_disc_items;
create table vendor_disc_items(
	Id integer not null primary key auto_increment,
	VendorId integer,
	ItemId integer,
	Discount double
) engine=innodb;

drop table if exists vendor_returned_items;
create table vendor_returned_items(
	Id integer not null primary key auto_increment,
	IRId integer,
	ItemId integer,
	Quantity double,
	UnitPrice double
) engine=innodb;