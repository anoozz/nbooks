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
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	/// <summary>
	/// Description of TruckReturnForm2.
	/// </summary>
	public partial class TruckReturnForm2 : BaseForm
	{
		TruckReturn ret;
		IList<Customer> customers;
		
		public IList<Customer> Customers {
			get { return customers; }
			set { customers = value; SwfUtility.SetupComboBox(comboBoxCustomer, customers, "Id", "Name", ret.Customer); }
		}
		
		public TruckReturn TruckReturn {
			get {
				ret.Customer = SwfUtility.GetComboBoxValue<Customer>(comboBoxCustomer);
				ret.Date = dateTimePickerDate.Value;
				return ret;
			}
			set { 
				ret = value; 
				dateTimePickerDate.Value = DateUtility.GetValid(dateTimePickerDate.Value);
				ret.ItemsChanged += delegate { ReturnItemsChanged(); };
				ReturnItemsChanged();
			}
		}
		
		public TruckReturnForm2() : this(new TruckReturn())
		{
		}
		
		public TruckReturnForm2(TruckReturn ret)
		{
			InitializeComponent();
			this.TruckReturn = ret;
			listView1.Resize += delegate { columnHeader2.Width = listView1.Width - 22 - (columnHeader1.Width + columnHeader3.Width + columnHeader4.Width + columnHeader5.Width + columnHeader6.Width); };
		}
		
		void ReturnItemsChanged()
		{
			listView1.Items.Clear();
			foreach (var i in ret.Items) {
				ListViewItem li = listView1.Items.Add(i.Item.Name);
				li.SubItems.Add(i.Item.SalesDescription);
				li.SubItems.Add(i.UnitPrice.ToString("###,##0.00"));
				li.SubItems.Add(i.Quantity.ToString("0.0"));
				li.SubItems.Add(i.Discount.ToString("###,##0.00"));
				li.SubItems.Add(i.Amount.ToString("###,##0.00"));
			}
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListCustomers != null) ListCustomers(this, null);
		}
		
		public event TruckReturnEventHandler SaveTruckReturn;
		public event EventHandler ListCustomers;
		
		protected virtual void OnSaveTruckReturn(EventArgs e)
		{
			if (SaveTruckReturn != null) {
				SaveTruckReturn(TruckReturn, e);
			}
		}
		
		void ButtonSaveAndCloseClick(object sender, EventArgs e)
		{
			OnSaveTruckReturn(e);
			Close();
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void NewToolStripMenuItemClick(object sender, EventArgs e)
		{
			using (var f = new TruckReturnItemForm()) {
				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
					ret.AddItem(f.ReturnItem);
				}
			}
		}
	}
}
