//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Data;
using System.Data.SQLite;

namespace NBooks.Core.Util
{
	public class SQLiteUtility
	{
		public SQLiteUtility()
		{
		}
		
		public static int ExecuteNonQuery(SQLiteConnection conn, string cmdText, params SQLiteParameter[] paramz)
		{
			SQLiteCommand cmd = new SQLiteCommand(cmdText, conn);
			foreach (SQLiteParameter param in paramz) {
				cmd.Parameters.Add(param);
			}
			return cmd.ExecuteNonQuery();
		}
		
		public static SQLiteDataReader ExecuteReader(SQLiteConnection conn, string cmdText, params SQLiteParameter[] paramz)
		{
			SQLiteCommand cmd = new SQLiteCommand(cmdText, conn);
			foreach (SQLiteParameter param in paramz) {
				cmd.Parameters.Add(param);
			}
			return cmd.ExecuteReader();
		}
		
		public static void ExecuteDataAdapter(SQLiteConnection conn, string cmdText, string tableName, DataSet ds, params SQLiteParameter[] paramz)
		{
			SQLiteDataAdapter da = new SQLiteDataAdapter(cmdText, conn);
			da.Fill(ds, tableName);
		}
	}
}
