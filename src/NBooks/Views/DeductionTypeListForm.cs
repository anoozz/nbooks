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
	public partial class DeductionTypeListForm : BaseForm
	{
		IList<DeductionType> types;
		
		public IList<DeductionType> DeductionTypes {
			get { return types; }
			set { 
				types = value;
				listView1.Items.Clear();
				foreach (var c in types) {
					ListViewItem li = listView1.Items.Add(c.Name);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public DeductionTypeListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22; };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddDeductionType().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditDeductionType(types[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						DeleteDeductionType(types[li.Index], null);
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						MakeInactiveDeductionType(types[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListDeductionTypes != null) {
				ListDeductionTypes(this, e);
			}
		}
		
		public event EventHandler ListDeductionTypes;
		public event DeductionTypeEventHandler MakeInactiveDeductionType;
		public event DeductionTypeEventHandler DeleteDeductionType;
	}
}
