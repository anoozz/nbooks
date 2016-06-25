//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Util;

namespace NBooks.Views
{
	public partial class PhysicalCountForm : BaseForm
	{
		PhysicalCount count;
		
		public PhysicalCount PhysicalCount {
			get {
				count.Date = dateTimePickerDate.Value;
				count.PreparedBy = textBoxPreparedBy.Text;
				count.ApprovedBy = textBoxApprovedBy.Text;
				count.Remarks = textBoxRemarks.Text;
				return count;
			}
			set { 
				count = value; 
				dateTimePickerDate.Value = DateUtility.GetValid(count.Date);
				textBoxPreparedBy.Text = count.PreparedBy;
				textBoxApprovedBy.Text = count.ApprovedBy;
				textBoxRemarks.Text = count.Remarks;
				RefreshList();
			}
		}
		
		public PhysicalCountForm() : this(new PhysicalCount())
		{
		}
		
		public PhysicalCountForm(PhysicalCount count)
		{
			InitializeComponent();
			this.PhysicalCount = count;
			listView1.Resize += delegate { columnHeader2.Width = listView1.Width - 22 - (columnHeader1.Width + columnHeader3.Width + columnHeader4.Width + columnHeader5.Width); };
			addToolStripMenuItem.Click += delegate { buttonAdd.PerformClick(); };
		}
		
		public event PhysicalCountEventHandler SavePhysicalCount;
		public event PhysicalCountEventHandler SavePhysicalCountAndClose;
		
		PhysicalCountItem GetInDetails(PhysicalCountItem item)
		{
			PhysicalCountItem dummy = null;
			foreach (var i in count.Items) {
				if (i.Item.Id == item.Item.Id) {
					return i;
				}
			}
			return dummy;
		}
		
		void ButtonAddClick(object sender, EventArgs e)
		{
			using (PhysicalCountItemForm f = new PhysicalCountItemForm()) {
				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
					PhysicalCountItem i = GetInDetails(f.Item);
					if (i != null) {
						i.AdjustedQty += f.Item.AdjustedQty;
					} else {
						count.AddItem(f.Item);
					}
					RefreshList();
					
					PhysicalCountItem i3 = f.Item;
					if (i3.Item.IsFullCase()) {
						using (PhysicalCountItemForm f2 = new PhysicalCountItemForm()) {
							string suggestedCode = ItemSuggestionUtility.Suggest(i3.Item.Name.ToUpper().Replace("FC-", "MT-"));
							f2.FindCode(suggestedCode, i3.AdjustedQty);
							if (WorkbenchSingleton.AddDialog(f2) == DialogResult.OK) {
								PhysicalCountItem i2 = GetInDetails(f2.Item);
								if (i2 != null) {
									i2.AdjustedQty += f2.Item.AdjustedQty;
								} else {
									count.AddItem(f2.Item);
								}
								RefreshList();
							}
						}
					} else if (i3.Item.IsSMBFullCase()) {
						using (PhysicalCountItemForm f2 = new PhysicalCountItemForm()) {
							string suggestedCode = ItemSuggestionUtility.Suggest(i3.Item.Name.ToUpper().Replace("SMBFC-", "SMBMT-"));
							f2.FindCode(suggestedCode, i3.AdjustedQty);
							if (WorkbenchSingleton.AddDialog(f2) == DialogResult.OK) {
								PhysicalCountItem i2 = GetInDetails(f2.Item);
								if (i2 != null) {
									i2.AdjustedQty += f2.Item.AdjustedQty;
								} else {
									count.AddItem(f2.Item);
								}
								RefreshList();
							}
						}
					}
				}
			}
		}
		
		void RefreshList()
		{
			listView1.Items.Clear();
			foreach (var item in count.Items) {
				ListViewItem li = listView1.Items.Add(item.Item.Name);
				li.SubItems.Add(item.Item.SalesDescription);
				li.SubItems.Add(item.Item.Unit != null ? item.Item.Unit.Name : "");
				li.SubItems.Add(item.OriginalQty.ToString("0.00"));
				li.SubItems.Add(item.AdjustedQty.ToString("0.00"));
			}
		}
		
		void ButtonSaveAndCloseClick(object sender, EventArgs e)
		{
			if (SavePhysicalCountAndClose != null) {
				SavePhysicalCountAndClose(PhysicalCount, e);
			}
		}
		
		void ButtonSaveAndClearClick(object sender, EventArgs e)
		{
			if (SavePhysicalCount != null) {
				SavePhysicalCount(PhysicalCount, e);
			}
		}
		
		void ButtonClearClick(object sender, EventArgs e)
		{
			this.PhysicalCount = new PhysicalCount();
		}
		
		void PhysicalCountFormKeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode) {
				case Keys.F3:
					buttonAdd.PerformClick();
					break;
			}
		}
		
		void TextBoxRemarksKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				buttonSaveAndClose.PerformClick();
			}
		}
		
		void ModifyToolStripMenuItemClick(object sender, EventArgs e)
		{
			ListView1DoubleClick(sender, e);
		}
		
		void ListView1DoubleClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0) {
				PhysicalCountItem item = count.Items[listView1.SelectedItems[0].Index];
				using (PhysicalCountItemForm f = new PhysicalCountItemForm(item)) {
					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
						RefreshList();
					}
				}
			}
		}
		
		void ButtonDeleteClick(object sender, EventArgs e)
		{
			DeleteToolStripMenuItemClick(sender, e);
		}
		
		void DeleteToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0) {
				PhysicalCountItem i = count.Items[listView1.SelectedItems[0].Index];
				count.Items.Remove(i);
				RefreshList();
			}
		}
		
		void ButtonModifyClick(object sender, EventArgs e)
		{
			ListView1DoubleClick(sender, e);
		}
	}
}
