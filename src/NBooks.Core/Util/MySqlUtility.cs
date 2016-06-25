//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace NBooks.Core.Util
{
	public class MySqlUtility
	{
		public MySqlUtility()
		{
		}
		
		public static int ExecuteNonQuery(MySqlConnection conn, string cmdText, params MySqlParameter[] paramz)
		{
			MySqlCommand cmd = new MySqlCommand(cmdText, conn);
			foreach (MySqlParameter param in paramz) {
				cmd.Parameters.Add(param);
			}
			return cmd.ExecuteNonQuery();
		}
		
		public static MySqlDataReader ExecuteReader(MySqlConnection conn, string cmdText, params MySqlParameter[] paramz)
		{
			MySqlCommand cmd = new MySqlCommand(cmdText, conn);
			foreach (MySqlParameter param in paramz) {
				cmd.Parameters.Add(param);
			}
			return cmd.ExecuteReader();
		}
		
		public static void ExecuteDataAdapter(MySqlConnection conn, string cmdText, string tableName, DataSet ds, params MySqlParameter[] paramz)
		{
			MySqlDataAdapter da = new MySqlDataAdapter(cmdText, conn);
			da.Fill(ds, tableName);
		}
	}
}
