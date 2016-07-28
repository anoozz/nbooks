using System;
using Rooko.Core;

namespace Migrations
{
	public class CreateUsers : Migration
	{
		public CreateUsers() : base("9f2c26a3-a055-46c3-ae62-67951ea40d45")
		{
    	}
		
		public override void Migrate()
		{
			CreateTable(
				"users",
				new Column("id", "integer", true, true, true),
				new Column("name"),
				new Column("password"),
				new Column("challenge_question", "integer"),
				new Column("answer"),
				new Column("inactive", "boolean")
			);
		}
		
		public override void Rollback()
		{
			DropTable("users");
		}
	}
}
