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
	public partial class PriceLevelListForm : BaseForm
	{
		IList<PriceLevel> levels;
		
		public IList<PriceLevel> PriceLevels {
			get { return levels; }
			set { 
				levels = value;
				listView1.Items.Clear();
				foreach (var l in levels) {
					ListViewItem li = listView1.Items.Add(l.Name);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public PriceLevelListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22; };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddPriceLevel().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditPriceLevel(levels[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						DeletePriceLevel(levels[li.Index], null);
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						MakeInactivePriceLevel(levels[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListPriceLevels != null) {
				ListPriceLevels(this, e);
			}
		}
		
		public event EventHandler ListPriceLevels;
		public event PriceLevelEventHandler MakeInactivePriceLevel;
		public event PriceLevelEventHandler DeletePriceLevel;
	}
}
