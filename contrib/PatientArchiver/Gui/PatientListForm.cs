/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 2/21/2011
 * Time: 2:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using PatientArchiver.Model;

namespace PatientArchiver.Gui
{
	/// <summary>
	/// Description of PatientListForm.
	/// </summary>
	public partial class PatientListForm : Form
	{
		IList<Patient> patients;
		
		public IList<Patient> Patients {
			get { return patients; }
			set {
				patients = value;
				listView1.Items.Clear();
				foreach (var p in patients) {
					ListViewItem li = listView1.Items.Add(p.Name.ToString());
				}
			}
		}
		
		public PatientListForm()
		{
			InitializeComponent();
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnPatientsList(e);
		}
		
		public event EventHandler PatientsList;
		
		protected virtual void OnPatientsList(EventArgs e)
		{
			if (PatientsList != null) {
				PatientsList(this, e);
			}
		}
	}
}
