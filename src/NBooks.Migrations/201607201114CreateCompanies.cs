using System;
using Rooko.Core;

namespace Migrations
{
	public class CreateCompanies : Migration
	{
		public CreateCompanies() : base("b58faba1-e080-4f4b-a801-22b4aa6052ca")
		{
    	}
		
		public override void Migrate()
		{
			CreateTable(
				"company",
				new Column("id", "integer", true, true, true),
				new Column("name"),
				new Column("ship_to_name"),
				new Column("ship_to_address"),
				new Column("address"),
				new Column("phone"),
				new Column("fax"),
				new Column("email"),
				new Column("website"),
				new Column("legal_name"),
				new Column("legal_address"),
				new Column("legal_address1"),
				new Column("city"),
				new Column("state_id", "integer"),
				new Column("zip"),
				new Column("legal_country_id", "integer"),
				new Column("country_id", "integer"),
				new Column("fiscal_year", "integer"),
				new Column("tax_year", "integer"),
				new Column("income_tax_form", "integer"),
				new Column("ein"),
				new Column("ssn"),
				new Column("payroll_contact"),
				new Column("payroll_contact_title"),
				new Column("payroll_contact_phone")
			);
		}
		
		public override void Rollback()
		{
			DropTable("company");
		}
	}
}
