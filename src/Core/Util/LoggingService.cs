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
using System.Reflection;
using log4net;
using log4net.Config;

namespace NBooks.Core.Util
{
	/// <summary>
	/// Description of LoggingService.
	/// </summary>
	public class LoggingService
	{
		static ILog log = null;
		
		static LoggingService()
		{
			XmlConfigurator.Configure();
			log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		}
		
		public static void Info(string text)
		{
			log.Info(text);
		}
		
		public static void Debug(string text)
		{
			log.Debug(text);
		}
		
		public static void Error(string text)
		{
			log.Error(text);
		}
		
		public static void Fatal(string text)
		{
			log.Fatal(text);
		}
		
		public static void Warn(string text)
		{
			log.Warn(text);
		}
	}
}
