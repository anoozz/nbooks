//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class JobTypeForm : BaseForm
	{
		JobType type;
		
		public JobType JobType {
			get {
				type.Name = textBoxName.Text;
				type.Inactive = checkBoxInactive.Checked;
				return type;
			}
			set { 
				type = value;
				textBoxName.Text = type.Name;
				checkBoxInactive.Checked = type.Inactive;
			}
		}
		
		public JobTypeForm() : this(new JobType())
		{
		}
		
		public JobTypeForm(JobType type)
		{
			InitializeComponent();
			this.JobType = type;
		}
		
		public event JobTypeEventHandler JobTypeSave;
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (JobTypeSave != null) {
				JobTypeSave(JobType, e);
			}
		}
	}
}
