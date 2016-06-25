//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class SalesInfoForm : BaseForm
	{
		SalesInfo info;
		IList<Route> routes;
		IList<SalesRep> reps;
		IList<Customer> customers;
		
		public IList<Customer> Customers {
			get { return customers; }
			set { customers = value; SwfUtility.SetupComboBox(comboBoxCustomer, customers, "Id", "Name", info.Customer); }
		}
		
		public IList<SalesRep> SalesReps {
			get { return reps; }
			set { reps = value; SwfUtility.SetupComboBox(comboBoxSalesRep, reps, "Id", "Name", info.SalesRep); }
		}
		
		public IList<Route> Routes {
			get { return routes; }
			set { routes = value; SwfUtility.SetupComboBox(comboBoxRoute, routes, "Id", "Code", info.Route); }
		}
		
		public SalesInfo SalesInfo {
			get {
				info.Date = dateTimePickerDate.Value;
				info.Route = SwfUtility.GetComboBoxValue<Route>(comboBoxRoute);
				info.SalesRep = SwfUtility.GetComboBoxValue<SalesRep>(comboBoxSalesRep);
				info.Customer = SwfUtility.GetComboBoxValue<Customer>(comboBoxCustomer);
				info.PreparedBy = textBoxPreparedBy.Text;
				info.ReceivedBy = textBoxReceivedby.Text;
				return info;
			}
			set {
				info = value; 
				dateTimePickerDate.Value = DateUtility.GetValid(info.Date);
				textBoxPreparedBy.Text = info.PreparedBy;
				textBoxReceivedby.Text = info.ReceivedBy;
				RefreshList();
			}
		}
		
		public SalesInfoForm() : this(new SalesInfo())
		{
		}
		
		public SalesInfoForm(SalesInfo info)
		{
			InitializeComponent();
			this.SalesInfo = info;
			addToolStripMenuItem.Click += delegate { buttonAdd.PerformClick(); };
			modifyToolStripMenuItem.Click += delegate { ListView1DoubleClick(this, null); };
			listView1.Resize += delegate { columnHeader2.Width = listView1.Width - 22 - (columnHeader1.Width + columnHeader3.Width + columnHeader4.Width); };
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListRoutes != null) ListRoutes(this, null);
			if (ListSalesReps != null) ListSalesReps(this, null);
			if (ListCustomers != null) ListCustomers(this, null);
		}
		
		public event EventHandler ListRoutes;
		public event EventHandler ListSalesReps;
		public event EventHandler ListCustomers;
		public event SalesInfoEventHandler SaveSalesInfo;
		public event SalesInfoEventHandler SaveSalesInfoAndClear;
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonAddClick(object sender, EventArgs e)
		{
			using (SalesInfoDetailForm f = new SalesInfoDetailForm()) {
				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
					info.AddDetail(f.Detail);
					RefreshList();
				}
			}
		}
		
		void RefreshList()
		{
			listView1.Items.Clear();
			foreach (SalesInfoDetail i in info.Details) {
				ListViewItem li = listView1.Items.Add(i.CheckNo);
				li.SubItems.Add(i.Description);
				li.SubItems.Add(i.Amount.ToString("0.00"));
				li.SubItems.Add(i.Type);
			}
			labelTotalAmount.Text = info.TotalAmount.ToString("0.00");
		}
		
		void ButtonSaveAndCloseClick(object sender, EventArgs e)
		{
			if (SaveSalesInfo != null) {
				SaveSalesInfo(SalesInfo, e);
			}
		}
		
		void ButtonClearClick(object sender, EventArgs e)
		{
			this.SalesInfo = new SalesInfo();
		}
		
		void ButtonSaveAndClearClick(object sender, EventArgs e)
		{
			if (SaveSalesInfoAndClear != null) {
				SaveSalesInfoAndClear(SalesInfo, e);
			}
		}
		
		void ListView1DoubleClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0) {
				SalesInfoDetail i = info.Details[listView1.SelectedItems[0].Index];
				using (SalesInfoDetailForm f = new SalesInfoDetailForm(i)) {
					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
						RefreshList();
					}
				}
			}
		}
		
		void DeleteToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0) {
				SalesInfoDetail i = info.Details[listView1.SelectedItems[0].Index];
				info.Details.Remove(i);
				RefreshList();
			}
		}
		
		void SalesInfoFormKeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode) {
				case Keys.F3:
					buttonAdd.PerformClick();
					break;
				default:
					break;
			}
		}
	}
}
