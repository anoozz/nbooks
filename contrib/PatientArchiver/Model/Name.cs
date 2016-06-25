/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 2/21/2011
 * Time: 2:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace PatientArchiver.Model
{
	/// <summary>
	/// Description of Name.
	/// </summary>
	public class Name
	{
		public string Title { get; set; }
		public string Last { get; set; }
		public string First { get; set; }
		public string Middle { get; set; }
		
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
