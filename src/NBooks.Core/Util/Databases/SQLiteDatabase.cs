// one line to give the library's name and an idea of what it does.
// Copyright (C) 2010 Ian Escarro <ian.escarro@gmail.com>
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System;
using NHibernate.Cfg;

namespace NBooks.Core.Util.Databases
{
	/// <summary>
	/// Description of SQLiteDatabase.
	/// </summary>
	public class SQLiteDatabase : Database
	{
		public SQLiteDatabase()
		{
		}
		
		public SQLiteDatabase(string connectionString) : base(connectionString)
		{
		}
		
		public override Configuration CreateConfiguration()
		{
			Configuration config = new Configuration();
			config.SetProperty("hibernate.dialect", "NHibernate.Dialect.SQLiteDialect");
			config.SetProperty("hibernate.connection.driver_class", "NHibernate.Driver.SQLite20Driver");
			config.SetProperty("hibernate.connection.provider", "NHibernate.Connection.DriverConnectionProvider");
			config.SetProperty("hibernate.query.substitutions", "true=1;false=0");
			config.SetProperty("hibernate.connection.connection_string", ConnectionString);
			return config;
		}
	}
}
