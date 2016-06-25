//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;
using Core.Util;
using NBooks.Commands;
using NBooks.Core.Models;
using NBooks.Core.Util;
//using NBooks.Reports.Command;

namespace NBooks.Util
{
	public class DefaultMenu : IMenu
	{
		ToolStripMenuItem windowMenuItem = new BToolStripMenuItem(
			"Window",
			new ToolStripItem[] {
				new BToolStripMenuItem("Arrange Icons", new ArrangeIcons()),
				new BToolStripMenuItem("Close All", new CloseAllChildren()),
				new ToolStripSeparator(),
				new BToolStripMenuItem("Tile Horizontally", new TileHorizontally()),
				new BToolStripMenuItem("Tile Vertically", new TileVertically()),
				new BToolStripMenuItem("Cascade", new CascadeWindows()),
			}
		);
		ToolStripMenuItem previousOpenCompaniesMenuItem = new BToolStripMenuItem("Open Previous Company");
		
		public ToolStripMenuItem PreviousOpenCompaniesMenuItem {
			get { return previousOpenCompaniesMenuItem; }
		}
		
		public ToolStripMenuItem WindowMenuItem {
			get { return windowMenuItem; }
		}
		
		public DefaultMenu()
		{
		}
		
		public ToolStripItem[] CreateToolBarButtons()
		{
			return new ToolStripItem[] {
				new BToolStripButton("Home", new ShowHomePage(), ResourceUtility.GetImage("world")),
				new ToolStripSeparator(),
				new BToolStripButton("Company Information", new EditCompany(CompanySingleton.Instance), ResourceUtility.GetImage("house")),
				new BToolStripButton("Items", new ListItems(), ResourceUtility.GetImage("brick")),
				new BToolStripButton("Customers", new ListCustomers(), ResourceUtility.GetImage("user_orange")),
				new BToolStripButton("Vendors", new ListVendors(), ResourceUtility.GetImage("user_gray")),
				new BToolStripButton("Employees", new ListEmployees(), ResourceUtility.GetImage("user")),
			};
		}
		
		public ToolStripItem[] CreateMenuItems()
		{
			return new ToolStripItem[] {
				new BToolStripMenuItem(
					"File",
					new ToolStripItem[] {
//						new BToolStripMenuItem("New Company", new AddCompany()),
//						previousOpenCompaniesMenuItem,
//						new ToolStripSeparator(),
						new BToolStripMenuItem("Exit", new ExitCommand()),
					}
				),
				new BToolStripMenuItem(
					"Edit",
					new ToolStripItem[] {
						new BToolStripMenuItem("Use Calculator...", new UseCalculator()),
					}
				),
				new BToolStripMenuItem(
					"View",
					new ToolStripItem[] {
						new BToolStripMenuItem("Open Window List"),
						new ToolStripSeparator(),
						new BToolStripMenuItem("Icon Bar"),
					}
				),
				new BToolStripMenuItem(
					"Lists",
					new ToolStripItem[] {
						new BToolStripMenuItem("Chart of Accounts", new ListAccounts()),
						new BToolStripMenuItem("Item List", new ListItems()),
						new BToolStripMenuItem("Unit List", new ListUnits()),
						new BToolStripMenuItem("Price Level List", new ListPriceLevels()),
						new BToolStripMenuItem("Sales Tax Code List", new ListSalesTaxCodes()),
						new BToolStripMenuItem("Category List", new ListCategories()),
						new BToolStripMenuItem("Period List", new ListPeriods()),
						new BToolStripMenuItem("Workers Comp List", new ListWorkersComps()),
						new ToolStripSeparator(),
						new BToolStripMenuItem("Other Names List", new ListOtherNames()),
						new BToolStripMenuItem(
							"Customer && Vendor Profile List",
							new ToolStripItem[] {
								new BToolStripMenuItem("Sales Rep List", new ListSalesReps()),
								new BToolStripMenuItem("Customer Type List", new ListCustomerTypes()),
								new BToolStripMenuItem("Vendor Type List", new ListVendorTypes()),
								new BToolStripMenuItem("Job Type List", new ListJobTypes()),
								new BToolStripMenuItem("Route List", new ListRoutes()),
								new BToolStripMenuItem("Terms List", new ListTerms()),
								new BToolStripMenuItem("Customer Messages List", new ListCustomerMessages()),
								new BToolStripMenuItem("Payment Method List", new ListPaymentMethods()),
								new BToolStripMenuItem("Vehicle List", new ListVehicles()),
								new BToolStripMenuItem("Shipping Method List", new ListShippingMethods()),
							}
						)
					}
				),
				new BToolStripMenuItem(
					"Company",
					new ToolStripItem[] {
						new BToolStripMenuItem("Home Page", new ShowHomePage()),
						new ToolStripSeparator(),
						new BToolStripMenuItem("Company Information...", new EditCompany(CompanySingleton.Instance)),
						new BToolStripMenuItem("Setup Users...", new ListUsers()),
						new BToolStripMenuItem("Change Password...", new ChangePassword()),
						new BToolStripMenuItem("To Do List", new ListToDos()),
						new BToolStripMenuItem("Chart of Accounts", new ListAccounts()),
						new ToolStripSeparator(),
						new BToolStripMenuItem("Enter Vehicle Trip", new AddVehicleTrip()),
						new ToolStripSeparator(),
						new BToolStripMenuItem("Vehicle Trip List", new ListVehicleTrips()),
					}
				),
				new BToolStripMenuItem(
					"Customers",
					new ToolStripItem[] {
//						new BToolStripMenuItem("Customer Center", new ShowCustomerCenter()),
//						new ToolStripSeparator(),
						new BToolStripMenuItem("Create Invoices", new AddInvoice()),
						new BToolStripMenuItem("Enter Sales Receipts", new AddSalesReceipt()),
						new ToolStripSeparator(),
						new BToolStripMenuItem("Receive Payments", new AddPayment()),
						new ToolStripSeparator(),
						new BToolStripMenuItem("Enter Truck Loads", new AddTruckLoad()),
						new BToolStripMenuItem("Enter Truck Returns", new AddTruckReturn()),
						new BToolStripMenuItem("Create Sales Information", new AddSalesInfo()),
						new ToolStripSeparator(),
						new BToolStripMenuItem("Invoices List", new ListInvoices()),
						new BToolStripMenuItem("Truck Load List", new ListTruckLoads()),
						new BToolStripMenuItem("Truck Return List", new ListTruckReturns()),
						new BToolStripMenuItem("Sales Info List", new ListSalesInfos()),
						new ToolStripSeparator(),
						new BToolStripMenuItem("Customer List", new ListCustomers()),
						new BToolStripMenuItem("Item List", new ListItems()),
					}
				),
				new BToolStripMenuItem(
					"Vendors",
					new ToolStripItem[] {
						new BToolStripMenuItem("Enter Bills", new AddBill()),
						new BToolStripMenuItem("Pay Bills", new AddBillPayment()),
						new ToolStripSeparator(),
						new BToolStripMenuItem("Sales Tax Code List", new ListSalesTaxCodes()),
						new ToolStripSeparator(),
						new BToolStripMenuItem("Create Purchase Orders", new AddPurchaseOrder()),
						new BToolStripMenuItem("Receive Items", new AddItemReceipt()),
						new ToolStripSeparator(),
						new BToolStripMenuItem("Purchase Order List", new ListPurchaseOrders()),
						new BToolStripMenuItem("Bill List", new ListBills()),
						new BToolStripMenuItem("Item Receipt List", new ListItemReceipts()),
						new ToolStripSeparator(),
						new BToolStripMenuItem(
							"Inventory Acitivies",
							new ToolStripItem[] {
								new BToolStripMenuItem("New Item", new AddItem())
							}
						),
						new ToolStripSeparator(),
						new BToolStripMenuItem("Vendor List", new ListVendors()),
						new BToolStripMenuItem("Item List", new ListItems()),
					}
				),
				new BToolStripMenuItem(
					"Employees",
					new ToolStripItem[] {
//						new BToolStripMenuItem("Deduction Type List", new ListDeductionTypes()),
//						new BToolStripMenuItem("Shift List", new ListShifts()),
//						new BToolStripMenuItem("Position List", new ListPositions()),
//						new BToolStripMenuItem("Tax Code List", new ListTaxCodes()),
//						new BToolStripMenuItem("Payroll Code List", new ListPayrollCodes()),
//						new BToolStripMenuItem(
//							"Premiums",
//							new ToolStripItem[] {
//								new BToolStripMenuItem("Pag-IBIG Premium List", new ListPagIbigPremiums()),
//								new BToolStripMenuItem("PhilHealth Premium List", new ListPhilHealthPremiums()),
//								new BToolStripMenuItem("SSS Premium List", new ListSSPremiums()),
//							}
//						),
//						new ToolStripSeparator(),
//						new BToolStripMenuItem(
//							"Workers Compensation",
//							new ToolStripItem[] {
//								new BToolStripMenuItem("Workers Comp List", new ListWorkersComps())
//							}
//						),
//						new BToolStripMenuItem("Loan Type List", new ListLoanTypes()),
//						new BToolStripMenuItem("Employee Type List", new ListEmployeeTypes()),
//						new BToolStripMenuItem("Department List", new ListDepartments()),
						new BToolStripMenuItem("Employee List", new ListEmployees())
					}
				),
				new BToolStripMenuItem(
					"Banking",
					new ToolStripItem[] {
						new BToolStripMenuItem("Write Checks", new AddCheck()),
					}
				),
//				new BToolStripMenuItem(
//					"Reports",
//					new ToolStripItem[] {
//						new BToolStripMenuItem(
//							"Customers && Receivables",
//							new ToolStripItem[] {
//								new BToolStripMenuItem("A/R Aging Summary", new ViewARAgingSummaryReport()),
//								new BToolStripMenuItem("A/R Aging Detail", new ViewARAgingDetailReport()),
//								new BToolStripMenuItem("Customer Balance Summary", new ViewCustomerBalanceSummaryReport()),
//								new BToolStripMenuItem("Customer Balance Detail", new ViewCustomerBalanceDetailReport()),
//								new BToolStripMenuItem("Open Invoices", new ViewOpenInvoices()),
//								new BToolStripMenuItem("Collections Report"),
//								new BToolStripMenuItem("Accounts Receivable Graph"),
//								new BToolStripMenuItem("Unbilled Costs by Jobs"),
//								new BToolStripMenuItem("Transaction List by Customer"),
//								new ToolStripSeparator(),
//								new BToolStripMenuItem("Customer Phone List", new ViewCustomerPhoneListReport()),
//								new BToolStripMenuItem("Customer Contact List", new ViewCustomerContactListReport()),
//								new BToolStripMenuItem("Item Price List", new ViewItemPriceListReport())
//							}
//						),
//						new BToolStripMenuItem(
//							"Vendors && Payables",
//							new ToolStripItem[] {
//								new BToolStripMenuItem("A/P Aging Summary", new ViewAPAgingSummaryReport()),
//								new BToolStripMenuItem("A/P Aging Detail", new ViewARAgingDetailReport()),
//								new BToolStripMenuItem("Vendor Balance Summary", new ViewVendorBalanceSummaryReport()),
//								new BToolStripMenuItem("Vendor Balance Detail", new ViewVendorBalanceDetailReport()),
//								new BToolStripMenuItem("Unpaid Bills Detail"),
//								new BToolStripMenuItem("Accounts Payable Graph"),
//								new BToolStripMenuItem("Transaction List by Vendor"),
//								new ToolStripSeparator(),
//								new BToolStripMenuItem("Sales Tax Liability"),
//								new BToolStripMenuItem("Sales Tax Revenue Summary"),
//								new ToolStripSeparator(),
//								new BToolStripMenuItem("Vendor Phone List", new ViewVendorPhoneListReport()),
//								new BToolStripMenuItem("Vendor Contact List", new ViewVendorContactListReport()),
//							}
//						),
//						new BToolStripMenuItem(
//							"Sales"
//						),
//						new BToolStripMenuItem(
//							"Employees && Payroll",
//							new ToolStripItem[] {
//								new BToolStripMenuItem("Summarize Payroll Data in Excel"),
//								new BToolStripMenuItem("More Payroll Reports in Excel"),
//								new BToolStripMenuItem("Payroll Summary"),
//								new BToolStripMenuItem("Payroll Item Detail"),
//								new BToolStripMenuItem("Payroll Detail Review"),
//								new BToolStripMenuItem("Employee Earnings Summary"),
//								new BToolStripMenuItem("Employee State Taxes Detail"),
//								new BToolStripMenuItem("Payroll Transactions by Payee"),
//								new BToolStripMenuItem("Payroll Transaction Detail"),
//								new BToolStripMenuItem("Payroll Liability Balances"),
//								new ToolStripSeparator(),
//								new BToolStripMenuItem("Employee Contact List", new ViewEmployeeContactListReport()),
//								new BToolStripMenuItem("Employee Withholding"),
//								new ToolStripSeparator(),
//								new BToolStripMenuItem("Payroll Item Listing", new ViewPayrollItemListReport()),
//								new BToolStripMenuItem("Paid Time Off List"),
//							}
//						),
//						new BToolStripMenuItem(
//							"Accountant && Taxes",
//							new ToolStripItem[] {
//								new BToolStripMenuItem("Trial Balance", new ViewTrialBalanceReport()),
//								new BToolStripMenuItem("General Ledger", new ViewGeneralLedgerReport()),
//								new BToolStripMenuItem("Journal", new ViewJournalReport()),
//								new ToolStripSeparator(),
//								new BToolStripMenuItem("Audit Trail"),
//								new BToolStripMenuItem("Customer Credit Card Audit Trail"),
//								new BToolStripMenuItem("Voided/Deleted Transactions Summary"),
//								new BToolStripMenuItem("Voided/Deleted Transactions Detail"),
//								new ToolStripSeparator(),
//								new BToolStripMenuItem("Transaction List by Date"),
//								new BToolStripMenuItem("Account Listing", new ViewAccountListReport()),
//								new BToolStripMenuItem("Fixed Asset Listing"),
//								new ToolStripSeparator(),
//								new BToolStripMenuItem("Income Tax Preparation"),
//								new BToolStripMenuItem("Income Tax Summary"),
//								new BToolStripMenuItem("Income Tax Detail"),
//							}
//						),
//						new BToolStripMenuItem(
//							"List",
//							new ToolStripItem[] {
//								new BToolStripMenuItem("Account Listing", new ViewAccountListReport()),
//								new BToolStripMenuItem("Item Price List", new ViewItemPriceListReport()),
//								new BToolStripMenuItem("Item Listing", new ViewItemListReport()),
//								new BToolStripMenuItem("Payroll Item Listing", new ViewPayrollItemListReport()),
//								new ToolStripSeparator(),
//								new BToolStripMenuItem("Customer Phone List", new ViewCustomerPhoneListReport()),
//								new BToolStripMenuItem("Customer Contact List", new ViewCustomerContactListReport()),
//								new BToolStripMenuItem("Vendor Phone List", new ViewVendorPhoneListReport()),
//								new BToolStripMenuItem("Vendor Contact List", new ViewVendorContactListReport()),
//								new BToolStripMenuItem("Employee Contact List", new ViewEmployeeContactListReport()),
//								new BToolStripMenuItem("Other Names Contact List", new ViewOtherNameContactListReport()),
//								new BToolStripMenuItem("Other Names Phone List", new ViewOtherNamePhoneListReport()),
//								new ToolStripSeparator(),
//								new BToolStripMenuItem("Terms Listing", new ViewTermsListReport()),
//								new BToolStripMenuItem("To Do Notes", new ViewToDoListReport()),
//							}
//						),
//					}
//				),
				windowMenuItem,
				new BToolStripMenuItem(
					"Help",
					new ToolStripItem[] {
						new BToolStripMenuItem("User Community", new GoToUserCommunity()),
						new BToolStripMenuItem("Support Services", new GoToSupportServices()),
						new ToolStripSeparator(),
						new BToolStripMenuItem("About NBooks...", new ShowAbout()),
					}
				),
			};
		}
	}
}
