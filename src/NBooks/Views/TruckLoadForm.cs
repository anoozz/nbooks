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

using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class TruckLoadForm : BaseForm
	{
		TruckLoad load;
		IList<Customer> customers = new List<Customer>();
		IList<Route> routes = new List<Route>();
		IList<SalesRep> reps = new List<SalesRep>();
		
		public bool ToBePrinted {
			get { return checkBoxToBePrinted.Checked; }
		}
		
		public IList<SalesRep> SalesReps {
			get { return reps; }
			set { reps = value; }
		}
		
		public IList<Route> Routes {
			get { return routes; }
			set { routes = value; }
		}
		
		public IList<Customer> Customers {
			get { return customers; }
			set { 
				customers = value;
				SwfUtility.SetupComboBox(comboBoxCustomer, customers, "Id", "Name", load.Customer);
			}
		}
		
		public TruckLoad TruckLoad {
			get { 
				load.Customer = SwfUtility.GetComboBoxValue<Customer>(comboBoxCustomer);
				load.Date = dateTimePickerDate.Value;
				load.Memo = textBoxMemo.Text;
				return load;
			}
			set { 
				load = value;
				dateTimePickerDate.Value = DateUtility.GetValid(load.Date);
				textBoxMemo.Text = load.Memo;
				load.ItemsChanged += new EventHandler(LoadItemsChanged);
				LoadItemsChanged(this, null);
			}
		}
		
		public TruckLoadForm() : this(new TruckLoad())
		{
		}
		
		public TruckLoadForm(TruckLoad load)
		{
			InitializeComponent();
			this.TruckLoad = load;
			listViewItems.Resize += delegate { columnHeader2.Width = listViewItems.Width - 22 - (columnHeader1.Width + columnHeader3.Width + columnHeader4.Width + columnHeader5.Width + columnHeader6.Width + columnHeader7.Width); };
			newToolStripMenuItem.Click += delegate { 
				if (ItemAdding != null) ItemAdding(new TruckLoadItem(), null);
			};
			editToolStripMenuItem.Click += delegate { 
				if (listViewItems.SelectedItems.Count > 0) {
					using (TruckLoadItemForm f = new TruckLoadItemForm(load.Items[listViewItems.SelectedItems[0].Index])) {
						if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
							LoadItemsChanged(this, null);
						}
					}
				}
			};
			listViewItems.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if (listViewItems.SelectedItems.Count > 0) {
					load.RemoveItem(load.Items[listViewItems.SelectedItems[0].Index]);
				}
			};
		}
		
		void LoadItemsChanged(object sender, EventArgs e)
		{
			listViewItems.Items.Clear();
			foreach (var i in load.Items) {
				ListViewItem li = listViewItems.Items.Add(i.Item.Name);
				li.SubItems.Add(i.Item.SalesDescription);
				li.SubItems.Add(i.Unit != null ? i.Unit.Name : "");
				li.SubItems.Add(i.Price.ToString("###,##0.00"));
				li.SubItems.Add(i.Quantity.ToString("0.0"));
				li.SubItems.Add(i.Discount.ToString("###,##0.00"));
				li.SubItems.Add(i.Amount.ToString("###,##0.00"));
			}
			labelTotal.Text = load.TotalAmount.ToString("###,##0.00");
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListCustomers != null) ListCustomers(this, null);
			if (ListRoutes != null) ListRoutes(this, null);
			if (ListSalesReps != null) ListSalesReps(this, null);
		}
		
		public event TruckLoadEventHandler SaveTruckLoad;
		public event TruckLoadEventHandler SaveTruckLoadAndClose;
		public event TruckLoadEventHandler SaveTruckLoadAndClear;
		public event EventHandler ListCustomers;
		public event EventHandler ListRoutes;
		public event EventHandler ListSalesReps;
		public event TruckLoadItemEventHandler ItemAdding;
		
		void ButtonSaveAndCloseClick(object sender, EventArgs e)
		{
			if (SaveTruckLoadAndClose != null) {
				SaveTruckLoadAndClose(TruckLoad, null);
			}
		}
		
		void ButtonSaveAndClearClick(object sender, EventArgs e)
		{
			if (SaveTruckLoadAndClear != null) {
				SaveTruckLoadAndClear(TruckLoad, null);
			}
		}
		
		void ToolStripButtonSaveClick(object sender, EventArgs e)
		{
			if (SaveTruckLoad != null) {
				SaveTruckLoad(TruckLoad, null);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
//		void NewToolStripMenuItemClick(object sender, EventArgs e)
//		{
//			using (TruckLoadItemForm loadItemForm = new TruckLoadItemForm()) {
//				loadItemForm.Customer = SwfUtility.GetComboBoxValue<Customer>(comboBoxCustomer);
//				if (WorkbenchSingleton.AddDialog(loadItemForm) == DialogResult.OK) {
//					load.AddItem(loadItemForm.Item);
//					
//					TruckLoadItem loadItem = loadItemForm.Item;
//					if (loadItem.Item.IsFullCase()) {
//						using (TruckLoadItemForm suggedLoadItemForm = new TruckLoadItemForm()) {
//							string suggestedCode = ItemSuggestionUtility.Suggest(loadItem.Item.Name.ToUpper().Replace("FC-", "MT-"));
//							suggedLoadItemForm.FindCode(suggestedCode, loadItem.Quantity);
//							if (WorkbenchSingleton.AddDialog(suggedLoadItemForm) == DialogResult.OK) {
//								load.AddItem(suggedLoadItemForm.Item);
//							}
//						}
//					} else if (loadItem.Item.IsSMBFullCase()) {
//						using (TruckLoadItemForm suggestedLoadItemForm = new TruckLoadItemForm()) {
//							string suggestedCode = ItemSuggestionUtility.Suggest(loadItem.Item.Name.ToUpper().Replace("SMBFC-", "SMBMT-"));
//							suggestedLoadItemForm.FindCode(suggestedCode, loadItem.Quantity);
//							if (WorkbenchSingleton.AddDialog(suggestedLoadItemForm) == DialogResult.OK) {
//								load.AddItem(suggestedLoadItemForm.Item);
//							}
//						}
//					}
//				}
//			}
//		}
	}
}
