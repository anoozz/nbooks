//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Commands;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class SalesInfoListForm : BaseForm
	{
		IList<SalesInfo> infos;
		
		public IList<SalesInfo> SalesInfos {
			get { return infos; }
			set { 
				infos = value;
				listView1.Items.Clear();
				foreach (var i in infos) {
					ListViewItem li = listView1.Items.Add(i.Id.ToString());
					li.SubItems.Add(i.Date.ToShortDateString());
					li.SubItems.Add(i.Route != null ? i.Route.Code : "");
					li.SubItems.Add(i.SalesRep != null ? i.SalesRep.Name : "");
					li.SubItems.Add(i.TotalAmount.ToString("###,##0.00"));
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public SalesInfoListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader3.Width = listView1.Width - 22 - (columnHeader1.Width + columnHeader2.Width + columnHeader4.Width + columnHeader5.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			createSalesInformationToolStripMenuItem.Click += delegate { new AddSalesInfo().Run(); };
			modifyToolStripMenuItem.Click += delegate { ListView1DoubleClick(this, null); };
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListSalesInfos != null) ListSalesInfos(this, null);
		}
		
		public event EventHandler ListSalesInfos;
		
		void ListView1DoubleClick(object sender, EventArgs e)
		{
			if(listView1.SelectedItems.Count > 0) {
				SalesInfo t = infos[listView1.SelectedItems[0].Index];
				WorkbenchSingleton.AddChild(new SalesInfoForm(t), "Edit Sales Information");
			}
		}
		
		void DeleteToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(listView1.SelectedItems.Count > 0) {
				foreach (ListViewItem li in listView1.SelectedItems) {
					SalesInfo s = infos[li.Index];
					DeleteSalesInfo(s, null);
				}
				OnActivated(null);
			}
		}
		
		public event SalesInfoEventHandler DeleteSalesInfo;
		public event SalesInfoEventHandler CloseSalesInfo;
		
		void CloseToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(listView1.SelectedItems.Count > 0) {
				using (AdminPasswordForm f = new AdminPasswordForm()) {
					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
						foreach (ListViewItem li in listView1.SelectedItems) {
							SalesInfo s = infos[li.Index];
							CloseSalesInfo(s, null);
						}
						OnActivated(null);
					}
				}
			}
		}
	}
}
