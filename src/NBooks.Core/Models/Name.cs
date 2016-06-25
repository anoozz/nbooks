//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public class Name
	{
		public string Last { get; set; }
		public string First { get; set; }
		public string Middle { get; set; }
		public string Title { get; set; }
		
		public Name()
		{
		}
		
		public Name(string last, string first, string middle) : this("", last, first, middle)
		{
		}
		
		public Name(string title, string last, string first, string middle)
		{
			this.Title = title;
			this.Last = last;
			this.First = first;
			this.Middle = middle;
		}
		
		public override string ToString()
		{
			return string.Format("{0}, {1} {2}", Last, First, Middle);
		}
	}
}
