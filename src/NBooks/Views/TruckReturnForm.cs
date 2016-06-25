// one line to give the library's name and an idea of what it does.
// Copyright (C) 2010 Ian Escarro <ian.escarro@gmail.com>
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class TruckReturnForm : BaseForm
	{
		TruckReturn ret;
		IList<SalesRep> reps;
		IList<Route> routes;
		IList<Customer> customers;
		
		public bool ToBePrinted {
			get { return checkBoxToBePrinted.Checked; }
		}
		
		public IList<Customer> Customers {
			get { return customers; }
			set { 
				customers = value;
				SwfUtility.SetupComboBox(comboBoxCustomer, customers, "Id", "Name", ret.Customer);
			}
		}
		
		public IList<Route> Routes {
			get { return routes; }
			set { 
				routes = value;
				SwfUtility.SetupComboBox(comboBoxRoute, routes, "Id", "Code", ret.Route);
			}
		}
		
		public IList<SalesRep> SalesReps {
			get { return reps; }
			set { 
				reps = value;
				SwfUtility.SetupComboBox(comboBoxSalesRep, reps, "Id", "Name", ret.SalesRep);
			}
		}
		
		public TruckReturn TruckReturn {
			get {
				ret.Date = dateTimePickerDate.Value;
				ret.Route = SwfUtility.GetComboBoxValue<Route>(comboBoxRoute);
				ret.SalesRep = SwfUtility.GetComboBoxValue<SalesRep>(comboBoxSalesRep);
				ret.Customer = SwfUtility.GetComboBoxValue<Customer>(comboBoxCustomer);
				ret.TruckNo = textBoxTruckNo.Text;
				ret.PreparedBy = textBoxPreparedBy.Text;
				ret.ApprovedBy = textBoxApprovedBy.Text;
				ret.ReleasedBy = textBoxReleasedBy.Text;
				ret.RecordedBy = textBoxRecordedBy.Text;
				ret.Remarks = textBoxRemarks.Text;
				return ret;
			}
			set { 
				ret = value;
				dateTimePickerDate.Value = DateUtility.GetValid(ret.Date);
				textBoxTruckNo.Text = ret.TruckNo;
				textBoxPreparedBy.Text = ret.PreparedBy;
				textBoxApprovedBy.Text = ret.ApprovedBy;
				textBoxReleasedBy.Text = ret.ReleasedBy;
				textBoxRecordedBy.Text = ret.RecordedBy;
				textBoxRemarks.Text = ret.Remarks;
				deleteToolStripMenuItem.Enabled = buttonDelete.Enabled = ret.Id == 0;
				ret.ItemsChanged += new EventHandler(ReturnItemsChanged);
				ReturnItemsChanged(this, null);
			}
		}
		
		public TruckReturnForm() : this(new TruckReturn())
		{
		}
		
		public TruckReturnForm(TruckReturn _return)
		{
			InitializeComponent();
			this.TruckReturn = _return;
			listViewItems.Resize += delegate { columnHeader2.Width = listViewItems.Width - 22 - (columnHeader1.Width + columnHeader3.Width + columnHeader4.Width + columnHeader5.Width + columnHeader6.Width + columnHeader7.Width); };
			
			newToolStripMenuItem.Click += delegate { 
				if (ItemAdding != null) ItemAdding(new TruckReturnItem(), null);
			};
			editToolStripMenuItem.Click += delegate { 
				if (listViewItems.SelectedItems.Count > 0) {
//					TruckReturnItem i = ret.Items[listViewItems.SelectedItems[0].Index];
//					using (TruckReturnItemForm f = new TruckReturnItemForm(i)) {
//						if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//							ReturnItemsChanged(this, null);
//						}
//					}
					if (ItemChanging != null) ItemChanging(ret.Items[listViewItems.SelectedItems[0].Index], null);
				}
			};
			deleteToolStripMenuItem.Click += delegate { 
				if (listViewItems.SelectedItems.Count > 0) {
					ret.RemoveItem(ret.Items[listViewItems.SelectedItems[0].Index]);
				}
			};
			
			buttonNew.Click += delegate { newToolStripMenuItem.PerformClick(); };
			buttonEdit.Click += delegate { editToolStripMenuItem.PerformClick(); };
			buttonDelete.Click += delegate { deleteToolStripMenuItem.PerformClick(); };
		}
		
		void ReturnItemsChanged(object sender, EventArgs e)
		{
			listViewItems.Items.Clear();
			foreach (TruckReturnItem i in ret.Items) {
				ListViewItem li = listViewItems.Items.Add(i.Item.Name);
				li.SubItems.Add(i.Item.SalesDescription);
				li.SubItems.Add(i.Item.Unit != null ? i.Item.Unit.Name : "");
				li.SubItems.Add(i.Item.SalesPrice.ToString("0.00"));
				li.SubItems.Add(i.Quantity.ToString("0.00"));
				li.SubItems.Add(i.Discount.ToString("0.00"));
				li.SubItems.Add(i.Amount.ToString("0.00"));
				SwfUtility.AlternateBackColor(li);
			}
			labelTotalAmount.Text = ret.TotalAmount.ToString("0.00");
			labelTotalQuantity.Text = ret.TotalQuantity.ToString("0.00");
			labelTotalDiscount.Text = ret.TotalDiscount.ToString("0.00");
			labelNetTotal.Text = ret.NetTotal.ToString("0.00");
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListRoutes != null) ListRoutes(this, null);
			if (ListSalesReps != null) ListSalesReps(this, null);
			if (ListCustomers != null) ListCustomers(this, null);
		}
		
		protected virtual void OnSaveTruckReturn(EventArgs e)
		{
			if (SaveTruckReturn != null) {
				SaveTruckReturn(TruckReturn, e);
			}
		}
		
		public event TruckReturnEventHandler SaveTruckReturn;
		public event TruckReturnEventHandler SaveTruckReturnAndClear;
		public event TruckReturnEventHandler SaveTruckReturnAndClose;
		public event EventHandler ListRoutes;
		public event EventHandler ListSalesReps;
		public event EventHandler ListCustomers;
		public event TruckReturnItemEventHandler ItemAdding;
		public event TruckReturnItemEventHandler ItemChanging;
		
//		void ButtonAddClick(object sender, EventArgs e)
//		{
//			using (TruckReturnItemForm f = new TruckReturnItemForm()) {
//				f.Customer = (comboBoxCustomer.DataSource as IList<Customer>)[comboBoxCustomer.SelectedIndex];
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					ret.AddItem(f.Item);
//					
//					TruckReturnItem i = f.Item;
//					if (i.Item.IsFullCase()) {
//						using (TruckReturnItemForm returnItemForm = new TruckReturnItemForm()) {
//							returnItemForm.Customer = (comboBoxCustomer.DataSource as IList<Customer>)[comboBoxCustomer.SelectedIndex];
//							string suggestedCode = ItemSuggestionUtility.Suggest(i.Item.Name.ToUpper().Replace("FC-", "MT-"));
//							returnItemForm.FindCode(suggestedCode, i.Quantity);
//							if (WorkbenchSingleton.AddDialog(returnItemForm) == DialogResult.OK) {
//								ret.AddItem(returnItemForm.Item);
//							}
//						}
//					} else if (i.Item.IsSMBFullCase()) {
//						using (TruckReturnItemForm returnItemForm = new TruckReturnItemForm()) {
//							returnItemForm.Customer = (comboBoxCustomer.DataSource as IList<Customer>)[comboBoxCustomer.SelectedIndex];
//							string suggestedCode = ItemSuggestionUtility.Suggest(i.Item.Name.ToUpper().Replace("SMBFC-", "SMBMT-"));
//							returnItemForm.FindCode(suggestedCode, i.Quantity);
//							if (WorkbenchSingleton.AddDialog(returnItemForm) == DialogResult.OK) {
//								ret.AddItem(returnItemForm.Item);
//							}
//						}
//					}
//				}
//			}
//		}
		
		void ButtonClearClick(object sender, EventArgs e)
		{
			this.TruckReturn = new TruckReturn();
		}
		
		void ButtonSaveAndCloseClick(object sender, EventArgs e)
		{
			if (SaveTruckReturnAndClose != null) {
				SaveTruckReturnAndClose(TruckReturn, null);
			}
		}
		
		void ButtonSaveAndClearClick(object sender, EventArgs e)
		{
			if (SaveTruckReturnAndClear != null) {
				SaveTruckReturnAndClear(TruckReturn, null);
			}
		}
		
		void TruckReturnFormKeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode) {
				case Keys.F3:
					buttonNew.PerformClick();
					break;
				default:
					break;
			}
		}
		
		void ListViewItemsSelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewItems.SelectedItems.Count > 0) {
				double sum = 0;
				foreach (ListViewItem li in listViewItems.SelectedItems) {
					TruckReturnItem i = ret.Items[li.Index];
					sum += i.Amount;
				}
				labelSumSelected.Text = sum.ToString("###,##0.00");
			}
		}
	}
}
