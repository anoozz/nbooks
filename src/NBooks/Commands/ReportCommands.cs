//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Commands
{
	public class ViewStockStatusReport : AbstractCommand
	{
		public override void Run()
		{
//			using (UnitParameterForm f = new UnitParameterForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					if (f.AllUnits) {
//						WorkbenchSingleton.AddChild(new ReportForm(new StockStatusReport(), SessionFacade.FindAllItemsDS()), "Stock Status Report");
//					} else {
//						WorkbenchSingleton.AddChild(new ReportForm(new StockStatusReport(), SessionFacade.FindItemsByUnitMeasureDS(f.UnitMeasure)), "Stock Status Report");
//					}
//				}
//			}
		}
	}
	
	public class ViewCustomerDiscountReport : AbstractCommand
	{
		public override void Run()
		{
//			using (DateRangeForm f = new DateRangeForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(
//						new ReportForm(
//							new CustomerDiscountReport(),
//							SessionFacade.FindCustomerDiscountsDS(f.DateFrom, f.DateTo)
//						),
//						"Customer Discount Report"
//					);
//				}
//			}
		}
	}
	
	public class ViewVendorDiscountReport : AbstractCommand
	{
		public override void Run()
		{
//			using (DateRangeForm f = new DateRangeForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(
//						new ReportForm(
//							new VendorDiscountReport(),
//							SessionFacade.FindVendorDiscountsDS(f.DateFrom, f.DateTo)
//						),
//						"Vendor Discount Report"
//					);
//				}
//			}
		}
	}
	
	public class ViewEndOfDayReadingReport : AbstractCommand
	{
		public override void Run()
		{
//			using (DateForm f = new DateForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(
//						new ReportForm(
//							new EndOfDayReport(),
//							SessionFacade.FindCustomersEndOfDayReadingDS(f.Date)
//						),
//						"End of Day Report"
//					);
//				}
//			}
		}
	}
	
	public class ViewConvertedItemsReport : AbstractCommand
	{
		public override void Run()
		{
//			using (DateRangeForm f = new DateRangeForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(
//						new ReportForm(
//							new ConvertedItemReport(),
//							SessionFacade.FindConvertedItemsByDateRangeDS(f.DateFrom, f.DateTo)
//						),
//						"Converted Items Report"
//					);
//				}
//			}
		}
	}
	
	public class ViewItemDiscountSalesReport : AbstractCommand
	{
		public override void Run()
		{
//			using (DateRangeForm f = new DateRangeForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(
//						new ReportForm(
//							new ItemDiscountSalesReport(),
//							SessionFacade.FindItemsSoldWithVendorDiscountsDS(f.DateFrom, f.DateTo, null)
//						),
//						"Item Sold Report"
//					);
//				}
//			}
		}
	}
	
	public class ReprintTruckLoadReport : AbstractCommand
	{
		public override void Run()
		{
//			using (SalesReportParameterForm f = new SalesReportParameterForm()) {
//        		if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//        			WorkbenchSingleton.AddChild(new ReportForm(new ReprintTruckLoadReport2(), SessionFacade.FindTruckLoadsBySalesmanRouteCustomerAndMonthDS(f.Salesman, f.Route, f.Customer, f.Date)), "Reprint Truck Load");
//        		}
//        	}
		}
	}
	
	public class ViewOverstockItemsReport : AbstractCommand
	{
		public override void Run()
		{
//			WorkbenchSingleton.AddChild(new ReportForm(new OverStockReport(), SessionFacade.FindOverstockItemsDS()), "Overstock Items Report");
		}
	}
	
	public class ViewEndingQuantityReport : AbstractCommand
	{
		public override void Run()
		{
//			using (EndingQuantityParameterForm f = new EndingQuantityParameterForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(new ReportForm(new EndingQuantityReport(), SessionFacade.ReadEndingQuantityByDateDS(f.Date)), "Ending Quantity Report");
//				}
//			}
		}
	}
	
	public class ViewRouteListReport : AbstractCommand
	{
		public override void Run()
		{
//			WorkbenchSingleton.AddChild(new ReportForm(new RouteListReport(), SessionFacade.FindAllRoutesDS()), "Route List Report");
		}
	}
	
	public class ViewSalesmanListReport : AbstractCommand
	{
		public override void Run()
		{
//			WorkbenchSingleton.AddChild(new ReportForm(new SalesmanListReport(), SessionFacade.FindAllSalesmenDS()), "Salesman List Report");
		}
	}
	
	public class ViewCustomerListReport : AbstractCommand
	{
		public override void Run()
		{
//			WorkbenchSingleton.AddChild(new ReportForm(new CustomerListReport(), SessionFacade.FindAllCustomersDS()), "Customer List Report");
		}
	}
	
	public class ViewVendorListReport : AbstractCommand
	{
		public override void Run()
		{
//			WorkbenchSingleton.AddChild(new ReportForm(new VendorListReport(), SessionFacade.FindAllVendorsDS()), "Vendor List Report");
		}
	}
	
	public class ViewItemReceiptReport : AbstractCommand
	{
		public override void Run()
		{
//			using (DateRangeForm f = new DateRangeForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(new ReportForm(new ItemReceiptReport2(), SessionFacade.FindItemReceiptsByDate(f.DateFrom, f.DateTo)), "Item Receipt Report");
//				}
//			}
		}
	}
	
	public class ViewDamageBreakingsReport : AbstractCommand
	{
		public override void Run()
		{
//			DataSet ds = new DataSet();
//            WorkbenchSingleton.AddChild(new ReportForm(new DamageBreakingsReport(), ds), "Damage Breakings");
		}
	}
	
	public class ViewPhysicalCountReport : AbstractCommand
	{
		public override void Run()
		{
//			using (DateForm f = new DateForm()) {
//        		if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//		            WorkbenchSingleton.AddChild(new ReportForm(new PhysicalCountReport(), SessionFacade.FindPhysicalCountsByDateDS(f.Date)));
//        		}
//        	}
		}
	}
	
	public class ViewPurchaseOrderReport : AbstractCommand
	{
		public override void Run()
		{
//			using (PONoForm f = new PONoForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(new ReportForm(new PurchaseOrderReport(), SessionFacade.ReadPurchaseOrderByPkDS(f.Id)), "Purchase Order Report");
//				}
//			}
		}
	}
	
	public class ViewTruckLoadByRefNoReport : AbstractCommand
	{
		int id;
		
		public int Id {
			get { return id; }
			set { id = value; }
		}
		
		public ViewTruckLoadByRefNoReport() : this(0)
		{
			
		}
		
		public ViewTruckLoadByRefNoReport(int id)
		{
			this.id = id;
		}
		
		public override void Run()
		{
//			if (id == 0) {
//				using (TruckLoadReferenceForm f = new TruckLoadReferenceForm()) {
//					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//						WorkbenchSingleton.AddChild(new ReportForm(new TruckLoadByReferenceNoReport(), SessionFacade.ReadTruckLoadByPkDS(f.No)), "Truck Load by Ref No");
//					}
//				}
//			} else {
//				WorkbenchSingleton.AddChild(new ReportForm(new TruckLoadByReferenceNoReport(), SessionFacade.ReadTruckLoadByPkDS(id)), "Truck Load by Ref No");
//			}
		}
	}
	
	public class ViewSalesReport : AbstractCommand
	{
		public override void Run()
		{
//			using (SalesReportParameterForm f = new SalesReportParameterForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(new ReportForm(new SalesReport(), SessionFacade.FindSalesByRouteSalesmanCustomerAndDateDS(f.Route, f.Salesman, f.Customer, f.Date)), "Sales Report");
//				}
//			}
		}
	}
	
	public class ViewToDoListReport : AbstractCommand
	{
		public override void Run()
		{
//			using (DateRangeForm f = new DateRangeForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(new ReportForm(new ToDoListReport(), SessionFacade.FindToDosByRangeDS(f.DateFrom, f.DateTo)), "To Do List Report");
//				}
//			}
		}
	}
	
	public class ViewItemEndingQuantityReport : AbstractCommand
	{
		public override void Run()
		{
//			using (DateForm f = new DateForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(new ReportForm(new ItemEndingQuantityReport(), SessionFacade.FindItemsEndingQuantityDS(f.Date)), "Item Ending Quantity Report");
//				}
//			}
		}
	}
	
	public class ViewSalesSummaryReport : AbstractCommand
	{
		public override void Run()
		{
//			using (DateForm f = new DateForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(new ReportForm(new SalesSummaryReport(), SessionFacade.FindSalesSummaryByDateDS(f.Date)), "Sales Summary Report");
//				}
//			}
		}
	}
	
	public class ViewSalesReportByRange : AbstractCommand
	{
		public override void Run()
		{
//			using (DateRangeForm f = new DateRangeForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(new ReportForm(new SalesReportByRange(), SessionFacade.FindSalesByRangeDS(f.DateFrom, f.DateTo)), "Sales Report By Range");
//				}
//			}
		}
	}
	
	public class ViewSalesReportByRange3 : AbstractCommand
	{
		public override void Run()
		{
//			using (SalesReportByRangeParameterForm f = new SalesReportByRangeParameterForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(
//						new ReportForm(new SalesReportByRange3(), 
//						               SessionFacade.FindSalesByDateWithParametersDS2(f.Customer, f.Route, f.Salesman, f.DateFrom, f.DateTo)),
//						"Sales Report By Range (with Parameters)");
//				}
//			}
		}
	}
	
	public class ViewSalesReportByDate : AbstractCommand
	{
		public override void Run()
		{
//			using (DateRangeForm f = new DateRangeForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(new ReportForm(new SalesReportByRange2(), SessionFacade.FindSalesByDateDS2(f.DateFrom, f.DateTo)), "Sales Report By Range (Sales Only)");
//				}
//			}
		}
	}
	
	public class ViewUCSConversionReport : AbstractCommand
	{
		public override void Run()
		{
//			using (DateRangeForm f = new DateRangeForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(new ReportForm(new UCSConversionReport(), SessionFacade.FindUCSConversionDS(f.DateFrom, f.DateTo)), "UCS Conversion Report");
//				}
//			}
		}
	}
	
	public class ViewSalesReportPerItem : AbstractCommand
	{
		TruckLoad load;
		
		public ViewSalesReportPerItem()
		{
		}
		
		public ViewSalesReportPerItem(TruckLoad load)
		{
			this.load = load;
		}
		
		public override void Run()
		{
//			if (load == null) {
//				using (SalesReportParameterForm f = new SalesReportParameterForm()) {
//					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//						WorkbenchSingleton.AddChild(new ReportForm(new SalesReport2(), SessionFacade.FindSalesByRouteSalesmanCustomerAndDateDS2(f.Route, f.Salesman, f.Customer, f.Date)), "Sales Report Per Item");
//					}
//				}
//			} else {
//				WorkbenchSingleton.AddChild(new ReportForm(new SalesReport2(), SessionFacade.FindSalesByRouteSalesmanCustomerAndDateDS2(load.Route, load.Salesman, load.Customer, load.Date)), "Sales Report Per Item");
//			}
		}
	}
	
	public class ViewNegativeItemsReport : AbstractCommand
	{
		public override void Run()
		{
//			WorkbenchSingleton.AddChild(new ReportForm(new NegativeItemsReport(), SessionFacade.FindNegativeItems()), "Negative Items Report");
		}
	}
	
	public class ViewSalesInformation : AbstractCommand
	{
		public override void Run()
		{
//			using (SalesReportParameterForm f = new SalesReportParameterForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//        			WorkbenchSingleton.AddChild(new ReportForm(new SalesInformationReport(), SessionFacade.FindSalesInfoByRouteSalesmanCustomerAndDateDS(f.Route, f.Salesman, f.Customer, f.Date)), "Sales Information");
//        		}
//        	}
		}
	}
	
	public class ViewMonthlyReports : AbstractCommand
	{
		public override void Run()
		{
//			using (MonthlyReportForm f = new MonthlyReportForm()) {
//        		if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(new ReportForm(new MonthlySalesReport(), SessionFacade.FindSalesByRouteSalesmanAndMonthDS(f.Route, f.Salesman, f.Date)), "Monthly Sales Report");
//        		}
//        	}
		}
	}
	
	public class ViewWeeklyReports : AbstractCommand
	{
		public override void Run()
		{
//			using (WeeklyReportParameterForm f = new WeeklyReportParameterForm()) {
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					WorkbenchSingleton.AddChild(new ReportForm(
//						new WeeklySalesReport(), 
//						SessionFacade.FindSalesByRouteSalesmanAndRangeDS(f.Route, f.Salesman, f.DateFrom, f.DateTo))
//					);
//				}
//			}
		}
	}
}
