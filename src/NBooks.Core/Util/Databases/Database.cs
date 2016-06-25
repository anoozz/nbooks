//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NHibernate.Cfg;

namespace NBooks.Core.Util.Databases
{
	public class Database
	{
		public Database()
		{
		}
		
		public Database(string connectionString)
		{
			this.ConnectionString = connectionString;
		}
		
		public string Type { get; set; }
		
		public string ConnectionString { get; set; }
		
		public static Database GetDatabase(string type)
		{
			switch (type) {
				case "mysql":
					return new MySqlDatabase();
				case "sqlite":
					return new SQLiteDatabase();
				default:
					throw new NotSupportedException();
			}
		}
		
		public virtual Configuration CreateConfiguration()
		{
			throw new NotImplementedException();
		}
		
		public virtual void Create()
		{
			throw new NotImplementedException();
		}
	}
}
