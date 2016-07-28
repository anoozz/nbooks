using System;
using Rooko.Core;

namespace Migrations
{
	public class CreateItems : Migration
	{
		public CreateItems() : base("f959d991-cef4-46c0-937b-845d6c73c749")
		{
    	}
		
		public override void Migrate()
		{
			CreateTable(
				"items",
				new Column("id", "integer", true, true, true),
				new Column("name"),
				new Column("sales_description"),
				new Column("on_hand", "double"),
				new Column("unit_measure"),
				new Column("sales_price", "double"),
				new Column("reorder_point"),
				new Column("overstock_level", "double"),
				new Column("part_number"),
				new Column("beginning_qty", "double"),
				new Column("tolarge_packing", "double"),
				new Column("inactive", "boolean"),
				new Column("ucs", "double"),
				new Column("preferred_vendor_id", "integer"),
				new Column("vendor_discount", "double"),
				new Column("purchase_description"),
				new Column("cost", "double"),
				new Column("type", "integer"),
				new Column("unit_id", "integer"),
				new Column("income_account_id", "integer"),
				new Column("cogs_account_id", "integer"),
				new Column("sales_tax_code_id", "integer"),
				new Column("asset_account_id", "integer"),
				new Column("total_value", "double"),
				new Column("value_as_of", "datetime")
			);
		}
		
		public override void Rollback()
		{
			DropTable("items");
		}
	}
}
