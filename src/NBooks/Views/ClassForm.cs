//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class ClassForm : BaseForm
	{
		Class clas;
		
		public Class Class {
			get { 
				clas.Name = textBoxName.Text;
				clas.Inactive = checkBoxInactive.Checked;
				return clas;
			}
			set { 
				clas = value; 
				textBoxName.Text = clas.Name;
				checkBoxInactive.Checked = clas.Inactive;
			}
		}
		
		public ClassForm() : this(new Class())
		{
		}
		
		public ClassForm(Class clas)
		{
			InitializeComponent();
			this.Class = clas;
		}
		
		public event ClassEventHandler ClassSave;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (ClassSave != null) {
				ClassSave(Class, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
