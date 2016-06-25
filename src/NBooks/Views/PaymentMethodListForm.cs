//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Commands;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class PaymentMethodListForm : BaseForm
	{
		IList<PaymentMethod> methods;
		
		public IList<PaymentMethod> PaymentMethods {
			get { return methods; }
			set { 
				methods = value;
				listView1.Items.Clear();
				foreach (PaymentMethod m in methods) {
					ListViewItem li = listView1.Items.Add(m.Name);
					li.SubItems.Add(PaymentMethodForm.PaymentTypes[m.Type]);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public PaymentMethodListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22 - (columnHeader2.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddPaymentMethod().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					new EditPaymentMethod(PaymentMethods[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						DeletePaymentMethod(PaymentMethods[li.Index], null);
					}
				}
				OnActivated(null);
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						MakeInactivePaymentMethod(PaymentMethods[li.Index], null);
					}
				}
				OnActivated(null);
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListPaymentMethods != null) ListPaymentMethods(this, null);
		}
		
		public event EventHandler ListPaymentMethods;
		public event PaymentMethodEventHandler DeletePaymentMethod;
		public event PaymentMethodEventHandler MakeInactivePaymentMethod;
	}
}
