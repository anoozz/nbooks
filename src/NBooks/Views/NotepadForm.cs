//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Models;

namespace NBooks.Views
{
	/// <summary>
	/// Description of NotepadForm.
	/// </summary>
	public partial class NotepadForm : BaseForm
	{
		INotes notes;
		
		public INotes Notes {
			get { return notes; }
			set { 
				notes = value; 
				richTextBoxNotes.Text = notes.Notes;
				groupBoxNotes.Text = "Notes for " + notes.Name;
				labelName.Text = notes.ToString();
				Text = "Notepad - " + notes.Name;
			}
		}
		
		public NotepadForm(INotes notes)
		{
			InitializeComponent();
			Notes = notes;
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			notes.Notes = richTextBoxNotes.Text;
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
