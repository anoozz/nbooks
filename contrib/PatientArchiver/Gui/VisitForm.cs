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
	/// Description of VisitForm.
	/// </summary>
	public partial class VisitForm : Form
	{
		Visit visit;
		
		public Visit Visit {
			get {
				return visit;
			}
			set {
				visit = value;
			}
		}
		
		public VisitForm() : this(new Visit())
		{
		}
		
		public VisitForm(Visit visit)
		{
			InitializeComponent();
			this.Visit = visit;
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnPatientsList(e);
		}
		
		public event EventHandler<VisitEventArgs> VisitSave;
		public event EventHandler PatientsList;
		
		protected virtual void OnPatientsList(EventArgs e)
		{
			if (PatientsList != null) {
				PatientsList(this, e);
			}
		}
		
		protected virtual void OnVisitSave(VisitEventArgs e)
		{
			if (VisitSave != null) {
				VisitSave(this, e);
			}
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			OnVisitSave(new VisitEventArgs(Visit));
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
