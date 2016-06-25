//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.IO;
using System.Windows.Forms;
using NBooks.Core.Models;
using System.Collections.Generic;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace NBooks.Core.Util
{
	public static class ApplicationUtility
	{
		public static string ProductName {
			get { return Application.ProductName; }
		}
		
		public static string ProductVersion {
			get { 
				Version v = new Version(Application.ProductVersion);
				return string.Format("{0}.{1}.{2}", v.Major, v.Minor, v.Build);
			}
		}
		
		public static string ProductNameAndVersion {
			get { return ProductName + " " + ProductVersion; }
		}
		
		public static string RootDirectory {
			get { return Application.StartupPath; }
		}
		
		public static string DocDirectory {
			get { return Path.Combine(RootDirectory, "../doc"); }
		}
		
		public static string ConfigDirectory {
			get { return Path.Combine(RootDirectory, "../config"); }
		}
		
		public static string TemplatesDirectory {
			get { return Path.Combine(RootDirectory, "../templates"); }
		}
		
		static ApplicationUtility()
		{
		}
	}
}
