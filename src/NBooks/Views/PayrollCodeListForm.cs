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
	public partial class PayrollCodeListForm : BaseForm
	{
		IList<PayrollCode> codes;
		
		public IList<PayrollCode> PayrollCodes {
			get { return codes; }
			set { 
				codes = value;
				listView1.Items.Clear();
				foreach (var c in codes) {
					ListViewItem li = listView1.Items.Add(c.Code);
					li.SubItems.Add(c.DateFrom.ToShortDateString());
					li.SubItems.Add(c.DateTo.ToShortDateString());
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public PayrollCodeListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22 - (columnHeader2.Width + columnHeader3.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddPayrollCode().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditPayrollCode(codes[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						DeletePayrollCode(codes[li.Index], null);
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						MakeInactivePayrollCode(codes[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListPayrollCodes != null) {
				ListPayrollCodes(this, e);
			}
		}
		
		public event EventHandler ListPayrollCodes;
		public event PayrollCodeEventHandler MakeInactivePayrollCode;
		public event PayrollCodeEventHandler DeletePayrollCode;
	}
}
