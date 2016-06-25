/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 2/21/2011
 * Time: 2:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

using PatientArchiver.Model;

namespace PatientArchiver.Gui
{
	/// <summary>
	/// Description of PatientForm.
	/// </summary>
	public partial class PatientForm : Form
	{
		Patient patient;
		
		public Patient Patient {
			get {
				patient.Name = new Name(textBoxLastName.Text, textBoxFirstName.Text, textBoxMiddleName.Text);
				return patient;
			}
			set {
				patient = value;
				if (patient.Name != null) {
					textBoxFirstName.Text = patient.Name.First;
					textBoxLastName.Text = patient.Name.Last;
					textBoxMiddleName.Text = patient.Name.Middle;
				}
			}
		}
		
		public PatientForm() : this(new Patient())
		{
		}
		
		public PatientForm(Patient patient)
		{
			InitializeComponent();
			this.Patient = patient;
		}
		
		public event EventHandler<PatientEventArgs> PatientSave;
		
		protected virtual void OnPatientSave(PatientEventArgs e)
		{
			if (PatientSave != null) {
				PatientSave(this, e);
			}
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			OnPatientSave(new PatientEventArgs(Patient));
		}
	}
}
