using System;
using Rooko.Core;

namespace Migrations
{
	public class CreateJobTypes : Migration
	{
		public CreateJobTypes() : base("b4f11774-9d7b-4dab-9b4e-251b15cf90da")
		{
    	}
		
		public override void Migrate()
		{
			CreateTable(
				"job_types",
				new Column("id", "integer", true, true, true),
				new Column("name"),
				new Column("inactive", "boolean")
			);
		}
		
		public override void Rollback()
		{
			DropTable("job_types");
		}
	}
}
