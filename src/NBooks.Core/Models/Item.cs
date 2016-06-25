//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Item : BaseModel<Item>
	{
		public virtual double VendorDiscount { get; set; }
		public virtual Vendor PreferredVendor { get; set; }
		public virtual double UCS { get; set; }
		public virtual bool Inactive { get; set; }
		public virtual double ToLargePacking { get; set; }
		public virtual double BeginningQty { get; set; }
		public virtual int Type { get; set; }
		public virtual string Name { get; set; }
		public virtual string PartNumber { get; set; }
		public virtual string SalesDescription { get; set; }
		public virtual double OnHand { get; set; }
		[Obsolete()]
		public virtual string UnitMeasure { get; set; }
		public virtual double SalesPrice { get; set; }
		public virtual double ReorderPoint { get; set; }		
		public virtual double OverStockLevel { get; set; }
		public virtual Unit Unit { get; set; }
		public virtual Account COGSAccount { get; set; }
		public virtual Account IncomeAccount { get; set; }
		public virtual Account AssetAccount { get; set; }
		public virtual SalesTaxCode SalesTaxCode { get; set; }
		public virtual string PurchaseDescription { get; set; }
		public virtual double Cost { get; set; }
		public virtual Category Category { get; set; }
		public virtual double TotalValue { get; set; }
		
		public virtual string Description {
			get {
				return SalesDescription != "" ? SalesDescription : PurchaseDescription;
			}
		}

        public virtual string NameAndDescription {
            get { return Name + " - " + SalesDescription; }
        }
		
		public Item()
		{
		}
		
		public Item(string name)
		{
			this.Name = name;
		}
		
		public override string ToString()
		{
			return string.Format("[ Id: {0}, Description: {1} ]", Id, SalesDescription);
		}
		
		public virtual bool IsEmpty()
		{
			return Name.ToUpper().IndexOf("MT-") < 0;
		}
		
		public virtual bool IsFullCase()
		{
			return Name.ToUpper().IndexOf("FC-") >= 0;
		}
		
		public virtual bool IsSMBFullCase()
		{
			return Name.ToUpper().IndexOf("SMBFC-") >= 0;
		}
		
		public virtual void Convert(Item item, double quantity)
		{
			this.OnHand -= quantity;
			item.OnHand += quantity * item.ToLargePacking;
		}
	}
	
	public class ItemType
	{
		public ItemTypeEnum Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public ItemType()
		{
		}
		
		public ItemType(ItemTypeEnum id, string name, string description)
		{
			this.Id = id;
			this.Name = name;
			this.Description = description;
		}
	}
	
	public enum ItemTypeEnum
	{
		/// <summary>
		/// 0 = Service
		/// </summary>
		Service,
		
		/// <summary>
		/// 1 = Inventory part item type
		/// </summary>
		InventoryPart,
		
		/// <summary>
		/// 2 = Non inventory part item type
		/// </summary>
		NonInventoryPart,
		
		/// <summary>
		/// 3 = Other charge
		/// </summary>
		OtherCharge,
		
		/// <summary>
		/// 4 = Sub total item type
		/// </summary>
		SubTotal,
		
		/// <summary>
		/// 5 = Group item type
		/// </summary>
		Group,
		
		/// <summary>
		/// 6 = Discount item type
		/// </summary>
		Discount,
		
		/// <summary>
		/// 7 = Payment item type
		/// </summary>
		Payment,
		
		/// <summary>
		/// 8 = Sales tax item type
		/// </summary>
		SalesTaxItem,
		
		/// <summary>
		/// 9 = Sales tax group
		/// </summary>
		SalesTaxGroup
	}
	
	public class ItemEventArgs : EventArgs
	{
		public Item Item { get; set; }
		
		public ItemEventArgs(Item item)
		{
			this.Item = item;
		}
	}
	
	public delegate void ItemEventHandler(Item sender, EventArgs e);
}
