using System;
using Rooko.Core;

namespace Migrations
{
	public class CreateVendors : Migration
	{
		public CreateVendors() : base("32f616b7-ec8d-4e32-85ae-17b6f8ae7521")
		{
    	}
		
		public override void Migrate()
		{
			CreateTable(
				"vendors",
				new Column("id", "integer", true, true, true),
				new Column("name"),
				new Column("address"),
				new Column("phone"),
				new Column("inactive"),
				new Column("balance"),
				new Column("contact")
			);
		}
		
		public override void Rollback()
		{
			DropTable("vendors");
		}
	}
}
