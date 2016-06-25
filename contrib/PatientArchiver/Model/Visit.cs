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
	/// Description of Visit.
	/// </summary>
	public class Visit
	{
		public virtual Patient Patient { get; set; }
		public virtual DateTime Date { get; set; }
		
		public Visit()
		{
		}
	}
	
	public class VisitEventArgs : EventArgs
	{
		public Visit Visit { get; set; }
		
		public VisitEventArgs(Visit visit)
		{
			this.Visit = Visit;
		}
	}
}
