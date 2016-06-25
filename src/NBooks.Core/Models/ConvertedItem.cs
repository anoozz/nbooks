//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public class ConvertedItem : BaseModel<ConvertedItem>
	{
		public virtual DateTime Date { get; set; }
		public virtual Item ItemFrom { get; set; }
		public virtual Item ItemTo { get; set; }
		public virtual double Quantity { get; set; }
		
		public ConvertedItem()
		{
		}
	}
	
	public delegate void ConvertedItemEventHandler(ConvertedItem sender, EventArgs e);
}
