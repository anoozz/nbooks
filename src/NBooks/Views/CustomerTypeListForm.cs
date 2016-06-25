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
	public partial class CustomerTypeListForm : BaseForm
	{
		IList<CustomerType> types;
		
		public IList<CustomerType> CustomerTypes {
			get { return types; }
			set { 
				types = value; 
				listView1.Items.Clear();
				foreach (var d in types) {
					ListViewItem li = listView1.Items.Add(d.Name);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public CustomerTypeListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22; };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddCustomerType().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditCustomerType(types[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						DeleteCustomerType(types[li.Index], null);
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						MakeInactiveCustomerType(types[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListCustomerTypes != null) ListCustomerTypes(this, e);
		}
		
		public event EventHandler ListCustomerTypes;
		public event CustomerTypeEventHandler DeleteCustomerType;
		public event CustomerTypeEventHandler MakeInactiveCustomerType;
	}
}
