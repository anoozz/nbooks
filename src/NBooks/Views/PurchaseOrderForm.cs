//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class PurchaseOrderForm : BaseForm
	{
		PurchaseOrder order;
		IList<Vendor> vendors;
		IList<Class> classes;
		
		public IList<Class> Classes {
			get { return classes; }
			set {
				classes = value;
				SwfUtility.SetupComboBox(comboBoxClass, classes, "Id", "Name", order.Class);
			}
		}
		
		public IList<Vendor> Vendors {
			get { return vendors; }
			set {
				vendors = value;
				SwfUtility.SetupComboBox(comboBoxVendor, vendors, "Id", "Name", order.Vendor);
			}
		}
		
		public PurchaseOrder PurchaseOrder {
			get { 
				order.Vendor = SwfUtility.GetComboBoxValue<Vendor>(comboBoxVendor);
				order.Class = SwfUtility.GetComboBoxValue<Class>(comboBoxClass);
				order.Date = dateTimePickerDate.Value;
				order.Memo = textBoxMemo.Text;
				order.RefNo = textBoxRefNo.Text;
				order.VendorMessage = textBoxVendorMessage.Text;
				return order; 
			}
			set {
				order = value;
				dateTimePickerDate.Value = DateUtility.GetValid(order.Date);
				textBoxMemo.Text = order.Memo;
				textBoxRefNo.Text = order.RefNo;
				textBoxVendorMessage.Text = order.VendorMessage;
				order.ItemsChanged += new EventHandler(OrderItemsChanged);
				OrderItemsChanged(this, null);
			}
		}
		
		public PurchaseOrderForm() : this(new PurchaseOrder())
		{
		}
		
		public PurchaseOrderForm(PurchaseOrder order)
		{
			InitializeComponent();
			this.PurchaseOrder = order;
			
			listViewItems.Resize += delegate { columnHeader2.Width = listViewItems.Width - 22 - (columnHeader1.Width + columnHeader3.Width + columnHeader4.Width + columnHeader5.Width + columnHeader6.Width + columnHeader7.Width); };
			newItemToolStripMenuItem.Click += delegate { 
				if (ItemChanging != null) ItemChanging(new PurchaseOrderItem(), null);
			};
			editToolStripMenuItem.Click += delegate { 
				if (listViewItems.SelectedItems.Count > 0) {
					if (ItemChanging != null) ItemChanging(order.Items[listViewItems.SelectedItems[0].Index], null);
				}
			};
			listViewItems.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if (listViewItems.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listViewItems.SelectedItems) {
						order.RemoveItem(order.Items[li.Index]);
					}
				}
			};
		}
		
		void OrderItemsChanged(object sender, EventArgs e)
		{
			listViewItems.Items.Clear();
			foreach (var i in order.Items) {
				ListViewItem li = listViewItems.Items.Add(i.Item.Name);
				li.SubItems.Add(i.Item.PurchaseDescription);
				li.SubItems.Add(i.Quantity.ToString("0.0"));
				li.SubItems.Add(i.Rate.ToString("###,##0.00"));
				li.SubItems.Add(i.Customer != null ? i.Customer.Name : "");
				li.SubItems.Add(i.Unit != null ? i.Unit.Name : "");
				li.SubItems.Add(i.Amount.ToString("###,##0.00"));
			}
			labelTotal.Text = order.TotalAmount.ToString("###,##0.00");
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (VendorsList != null) VendorsList(this, null);
			if (ListClasses != null) ListClasses(this, null);
		}
		
		public event EventHandler VendorsList;
		public event EventHandler ListClasses;
		public event PurchaseOrderEventHandler SavePurchaseOrder;
		public event EventHandler<PurchaseOrderEventArgs> PurchaseOrderSaveAndClose;
		
		protected virtual void OnPurchaseOrderSaveAndClose(PurchaseOrderEventArgs e)
		{
			if (PurchaseOrderSaveAndClose != null) {
				PurchaseOrderSaveAndClose(this, e);
			}
		}
		public event PurchaseOrderEventHandler SavePurchaseOrderAndClear;
		public event PurchaseOrderItemEventHandler ItemChanging;
		
		void ButtonSaveAndCloseClick(object sender, EventArgs e)
		{
			OnPurchaseOrderSaveAndClose(new PurchaseOrderEventArgs(PurchaseOrder));
		}
		
		void ButtonSaveAndClearClick(object sender, EventArgs e)
		{
			if (SavePurchaseOrderAndClear != null) {
				SavePurchaseOrderAndClear(PurchaseOrder, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ComboBoxVendorSelectedIndexChanged(object sender, EventArgs e)
		{
			Vendor vendor = SwfUtility.GetComboBoxValue<Vendor>(comboBoxVendor);
			if (vendor != null) {
				richTextBoxAddress.Text = vendor.Address;
			}
		}
		
		void ToolStripButtonSaveClick(object sender, EventArgs e)
		{
			if (SavePurchaseOrder != null) {
				SavePurchaseOrder(PurchaseOrder, e);
			}
		}
	}
}
