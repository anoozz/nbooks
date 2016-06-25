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
	public class AddBillPayment : AbstractCommand
	{
		public override void Run()
		{
//			var view = new BillPaymentForm();
//			view.ListBills += delegate { view.Bills = Bill.FindAll(); };
//			view.ListPaymentMethods += delegate { view.PaymentMethods = PaymentMethod.FindActive(); };
//			view.ListAccounts += delegate { view.Accounts = Account.FindActive(); };
//			view.SaveBillPayment += delegate(BillPayment sender, EventArgs e) { 
//				sender.SaveOrUpdate();
//				view.Close();
//			};
//			WorkbenchSingleton.AddChild(view);
			BillPaymentForm form = new BillPaymentForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
