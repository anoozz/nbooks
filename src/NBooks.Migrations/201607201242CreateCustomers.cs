using System;
using Rooko.Core;

namespace Migrations
{
	public class CreateCustomers : Migration
	{
		public CreateCustomers() : base("8a7b6d5a-2d22-4b22-a523-7582a8417534")
		{
		}
		
		public override void Migrate()
		{
			CreateTable(
				"customers",
				new Column("id", "integer", true, true, true),
				new Column("name"),
				new Column("address"),
				new Column("phone"),
				new Column("trade_assistance"),
				new Column("classification"),
				new Column("type_of_deal"),
				new Column("balance", "double"),
				new Column("inactive", "boolean"),
				new Column("company_name"),
				new Column("balance_as_of"),
				new Column("title"),
				new Column("first_name"),
				new Column("last_name"),
				new Column("middle_name"),
				new Column("ship_to_address"),
				new Column("contact"),
				new Column("fax"),
				new Column("alt_phone"),
				new Column("alt_contact"),
				new Column("email"),
				new Column("cc"),
				new Column("customer_type_id", "integer"),
				new Column("terms_id", "integer"),
				new Column("sales_rep_id", "integer"),
				new Column("send_method", "integer"),
				new Column("sales_tax_code_id", "integer"),
				new Column("tax_item_id", "integer"),
				new Column("resale_number"),
				new Column("price_level_id", "integer"),
				new Column("account_no"),
				new Column("credit_limit", "double"),
				new Column("payment_method_id", "integer"),
				new Column("credit_card_no"),
				new Column("cc_expiry_month"),
				new Column("cc_expiry_year"),
				new Column("name_on_card"),
				new Column("cc_address"),
				new Column("cc_zip_code"),
				new Column("job_status", "integer"),
				new Column("start_date", "datetime"),
				new Column("projected_end", "datetime"),
				new Column("end_date", "datetime"),
				new Column("job_description"),
				new Column("job_type_id", "integer"),
				new Column("notes")
			);
		}
		
		public override void Rollback()
		{
			DropTable("customers");
		}
	}
}
