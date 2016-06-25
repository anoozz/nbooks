//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Models;

namespace NBooks.Views
{
	/// <summary>
	/// Description of SalesOrderForm.
	/// </summary>
	public partial class SalesOrderForm : BaseForm
	{
		SalesOrder order;
		
		public SalesOrder SalesOrder {
			get { 
				return order;
			}
			set { 
				order = value; 
			}
		}
		
		public SalesOrderForm() : this(new SalesOrder())
		{
		}
		
		public SalesOrderForm(SalesOrder order)
		{
			InitializeComponent();
			this.SalesOrder = order;
		}
		
		protected virtual void OnSaveSalesOrder(EventArgs e)
		{
			if (SaveSalesOrder != null) {
				SaveSalesOrder(SalesOrder, e);
			}
		}
		
		public event SalesOrderEventHandler SaveSalesOrder;
	}
}
