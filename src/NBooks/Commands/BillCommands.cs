//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Gui;
using NBooks.Core.Util;
using NBooks.Views;

namespace NBooks.Commands
{
	public class ListBills : AbstractCommand
	{
		public override void Run()
		{
			BillListForm form = new BillListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddBill : AbstractCommand
	{
		public override void Run()
		{
//			IBillController controller = new BillController(
//				new BillForm(),
//				new BillService(new NHibernateBillDao()),
//				new NHibernateVendorDao(),
//				new NHibernateAccountDao(),
//				new NHibernateTermsDao(),
//				new NHibernateItemDao(),
//				new BillItemForm(),
//				new ItemListOfValueForm(),
//				new BillAccountForm()
//			);
//			controller.ItemAdding += delegate(BillItem sender, EventArgs e) { 
//				controller.BillItemView.BillItem = sender;
//				if (WorkbenchSingleton.AddDialog((Form)controller.BillItemView) == DialogResult.OK) {
//					controller.BillView.Bill.AddItem(controller.BillItemView.BillItem);
//				}
//			};
//			controller.FindItem += delegate { 
//				if (WorkbenchSingleton.AddDialog((Form)controller.ItemListOfValueView) == DialogResult.OK) {
//					controller.BillItemView.BillItem.Item = controller.ItemListOfValueView.SelectedItem;
//				}
//			};
//			controller.AccountAdding += delegate(BillAccount sender, EventArgs e) { 
//				controller.BillAccountView.BillAccount = sender;
//				if (WorkbenchSingleton.AddDialog((Form)controller.BillAccountView) == DialogResult.OK) {
//					controller.BillView.Bill.AddAccount(controller.BillAccountView.BillAccount);
//				}
//			};
//			WorkbenchSingleton.AddChild((Form)controller.BillView);
			BillForm form = new BillForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
