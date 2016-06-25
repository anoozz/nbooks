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
	/// Description of Clinic.
	/// </summary>
	public class Clinic
	{
		public virtual string Name { get; set; }
		public virtual string Address { get; set; }
		
		public Clinic()
		{
		}
	}
}
