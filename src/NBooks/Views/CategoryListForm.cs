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
	public partial class CategoryListForm : BaseForm
	{
		IList<Category> categories;
		
		public IList<Category> Categories {
			get { return categories; }
			set { 
				categories = value;
				listView1.Items.Clear();
				foreach (var c in categories) {
					ListViewItem li = listView1.Items.Add(c.Name);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public CategoryListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22; };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddCategory().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditCategory(categories[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						CategoryDelete(categories[li.Index], null);
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						CategoryMakeInactive(categories[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (CategoriesList != null) {
				CategoriesList(this, e);
			}
		}
		
		public event EventHandler CategoriesList;
		public event CategoryEventHandler CategoryMakeInactive;
		public event CategoryEventHandler CategoryDelete;
	}
}
