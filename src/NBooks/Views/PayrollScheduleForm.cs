//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Models;

namespace NBooks.Views
{
	/// <summary>
	/// Description of PayrollScheduleForm.
	/// </summary>
	public partial class PayrollScheduleForm : BaseForm
	{
		PayrollSchedule schedule;
		
		public PayrollSchedule PayrollSchedule {
			get { 
				return schedule;
			}
			set {
				schedule = value;
			}
		}
		
		public PayrollScheduleForm() : this(new PayrollSchedule())
		{
		}
		
		public PayrollScheduleForm(PayrollSchedule schedule)
		{
			InitializeComponent();
			this.PayrollSchedule = schedule;
		}
		
		public event PayrollScheduleEventHandler SavePayrollSchedule;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SavePayrollSchedule != null) {
				SavePayrollSchedule(PayrollSchedule, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
