//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using NBooks.Core.Repositories;

namespace NBooks.Data
{
	public class MySqlRepositoryFactory : RepositoryFactory
	{
		static MySqlConnection connection = null;
		
		static MySqlRepositoryFactory()
		{
			connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysql"].ConnectionString);
		}
		
		public MySqlRepositoryFactory()
		{
		}
		
		public static MySqlConnection GetConnection()
		{
			return connection;
		}
	}
}
