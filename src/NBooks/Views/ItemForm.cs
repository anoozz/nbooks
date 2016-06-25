//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Core.Views;

namespace NBooks.Views
{
	public partial class ItemForm : BaseForm, IItemView
	{
		Item item;
		IList<Vendor> vendors;
		IList<Unit> units;
		IList<Account> cogsAccounts;
		IList<Account> incomeAccounts;
		IList<Account> assetAccounts;
		IList<SalesTaxCode> taxCodes;
		
		public IList<SalesTaxCode> SalesTaxCodes {
			get { return taxCodes; }
			set { taxCodes = value; SwfUtility.SetupComboBox(comboBoxTaxCode, taxCodes, "Id", "code", item.SalesTaxCode); }
		}
		
		public IList<Account> AssetAccounts {
			get { return assetAccounts; }
			set { assetAccounts = value; SwfUtility.SetupComboBox(comboBoxAssetAccount, assetAccounts, "Id", "Name", item.AssetAccount); }
		}
		
		public IList<Account> IncomeAccounts {
			get { return incomeAccounts; }
			set { incomeAccounts = value; SwfUtility.SetupComboBox(comboBoxIncomeAccount, incomeAccounts, "Id", "Name", item.IncomeAccount); }
		}
		
		public IList<Account> CogsAccounts {
			get { return cogsAccounts; }
			set { cogsAccounts = value; SwfUtility.SetupComboBox(comboBoxCOGSAccount, cogsAccounts, "Id", "Name", item.COGSAccount); }
		}
		
		public IList<Unit> Units {
			get { return units; }
			set { units = value; SwfUtility.SetupComboBox(comboBoxUnit, units, "Id", "Name", item.Unit); }
		}
		
		public IList<Vendor> Vendors {
			get { return vendors; }
			set { vendors = value; SwfUtility.SetupComboBox(comboBoxVendor, vendors, "Id", "Name", item.PreferredVendor); }
		}
		
		public Item Item {
			get {
				item.Type = comboBoxType.SelectedIndex;
				item.Name = textBoxName.Text;
				item.SalesDescription = richTextBoxSalesDescription.Text;
				item.Unit = SwfUtility.GetComboBoxValue<Unit>(comboBoxUnit);
				item.SalesPrice =  ConvertUtility.ToDouble(textBoxSalesPrice.Text);
				item.OnHand = ConvertUtility.ToDouble(textBoxOnHand.Text);
				item.ReorderPoint = ConvertUtility.ToDouble(textBoxReorderPoint.Text);
				item.Cost = ConvertUtility.ToDouble(textBoxCost.Text);
				item.COGSAccount = SwfUtility.GetComboBoxValue<Account>(comboBoxCOGSAccount);
				item.IncomeAccount = SwfUtility.GetComboBoxValue<Account>(comboBoxIncomeAccount);
				item.AssetAccount = SwfUtility.GetComboBoxValue<Account>(comboBoxAssetAccount);
				item.UCS = Convert.ToDouble(textBoxUCS.Text);
				item.PreferredVendor = SwfUtility.GetComboBoxValue<Vendor>(comboBoxVendor);
				item.Inactive = checkBoxInactive.Checked;
				item.PurchaseDescription = richTextBoxPurchaseDescription.Text;
				item.TotalValue = ConvertUtility.ToDouble(textBoxTotalValue.Text);
				return item;
			}
			set { 
				item = value;
				comboBoxType.SelectedIndex = item.Type;
				textBoxName.Text = item.Name;
				richTextBoxSalesDescription.Text = item.SalesDescription;
				textBoxSalesPrice.Text = item.SalesPrice.ToString("0.00");
				textBoxCost.Text = item.Cost.ToString("0.00");
				textBoxOnHand.Text = item.OnHand.ToString("0.0");
				textBoxReorderPoint.Text = item.ReorderPoint.ToString("0.0");
				textBoxUCS.Text = item.UCS.ToString("0.0");
				checkBoxInactive.Checked = item.Inactive;
				richTextBoxPurchaseDescription.Text = item.PurchaseDescription;
				textBoxTotalValue.Text = item.TotalValue.ToString("0.00");
				if (item.Id > 0) {
					comboBoxType.Enabled = textBoxOnHand.Enabled = textBoxTotalValue.Enabled = dateTimePickerValueAsOf.Enabled = false;
				}
			}
		}
		
		public static ItemType[] ItemTypes {
			get {
				return new ItemType[] {
					new ServiceItemType(),
					new InventoryPartItemType(),
					new NonInventoryPartItemType(),
				};
			}
		}
		
		public ItemForm() : this(new Item())
		{
		}
		
		public ItemForm(Item item)
		{
			InitializeComponent();
			
			SwfUtility.SetupComboBox(comboBoxType, ItemTypes, "Id", "Name");
			this.Item = item;
			textBoxName.Select();
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnVendorsList(e);
			OnUnitsList(e);
			if (IncomeAccountsList != null) IncomeAccountsList(this, e);
			if (CogsAccountsList != null) CogsAccountsList(this, e);
			if (AssetAccountsList != null) AssetAccountsList(this, e);
			if (ListSalesTaxCodes != null) ListSalesTaxCodes(this, e);
		}
		
		public event EventHandler ListSalesTaxCodes;
		public event EventHandler VendorsList;
		
		protected virtual void OnVendorsList(EventArgs e)
		{
			if (VendorsList != null) {
				VendorsList(this, e);
			}
		}
		public event EventHandler UnitsList;
		
		protected virtual void OnUnitsList(EventArgs e)
		{
			if (UnitsList != null) {
				UnitsList(this, e);
			}
		}
		public event EventHandler IncomeAccountsList;
		public event EventHandler CogsAccountsList;
		public event EventHandler AssetAccountsList;
		public event EventHandler<ItemEventArgs> ItemSave;
		
		protected virtual void OnItemSave(ItemEventArgs e)
		{
			if (ItemSave != null) {
				ItemSave(this, e);
			}
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			OnItemSave(new ItemEventArgs(Item));
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ComboBoxTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			ItemType t = SwfUtility.GetComboBoxValue<ItemType>(comboBoxType);
			if (t != null) {
				labelType.Text = t.Description;
			}
		}
	}
}
