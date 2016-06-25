//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public class Config : BaseModel<Config>
	{
		public virtual string DataVersion { get; set; }
		
		public Config()
		{
		}
	}
}
