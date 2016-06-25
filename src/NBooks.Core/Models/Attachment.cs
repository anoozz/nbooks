//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public class Attachment
	{
		public virtual string Type { get; set; }
		public virtual byte[] Content { get; set; }
		
		public Attachment()
		{
		}
	}
	
	public delegate void AttachmentEventHandler(Attachment sender, EventArgs e);
}
