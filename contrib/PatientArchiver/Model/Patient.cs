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
	/// Description of Patient.
	/// </summary>
	public class Patient
	{
		public virtual Name Name { get; set; }
		
		public Patient()
		{
		}
	}
	
	public class PatientEventArgs : EventArgs
	{
		public Patient Patient { get; set; }
		
		public PatientEventArgs(Patient patient)
		{
			this.Patient = patient;
		}
	}
}
