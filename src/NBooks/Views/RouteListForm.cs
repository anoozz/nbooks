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
	public partial class RouteListForm : BaseForm
	{
		IList<Route> routes;
		
		public IList<Route> Routes {
			get { return routes; }
			set { 
				routes = value; 
				listView1.Items.Clear();
				foreach (Route r in routes) {
					ListViewItem li = listView1.Items.Add(r.Code);
					li.SubItems.Add(r.Description);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public RouteListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader2.Width = listView1.Width - 22 - (columnHeader1.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddRoute().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditRoute(routes[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						DeleteRoute(routes[li.Index], null);
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						MakeInactiveRoute(routes[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListRoutes != null) ListRoutes(this, null);
		}
		
		public event EventHandler ListRoutes;
		public event RouteEventHandler DeleteRoute;
		public event RouteEventHandler MakeInactiveRoute;
	}
}
