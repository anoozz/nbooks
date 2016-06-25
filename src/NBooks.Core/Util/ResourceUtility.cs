//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.Reflection;
using System.Resources;

namespace NBooks.Util
{
	public static class ResourceUtility
	{
		static ResourceManager manager = null;
		
		public static ResourceManager Manager {
			get { return manager; }
			set { manager = value; }
		}
		
		static ResourceUtility()
		{
		}
		
		public static string GetString(string key)
		{
			return manager.GetString(key);
		}
		
		public static Image GetImage(string key)
		{
			return (Bitmap)manager.GetObject(key);
		}
	}
}
