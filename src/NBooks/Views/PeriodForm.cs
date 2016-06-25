//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class PeriodForm : BaseForm
	{
		Period period;
		
		public Period Period {
			get { 
				period.Name = textBoxName.Text;
				period.DateFrom = dateTimePickerDateFrom.Value;
				period.DateTo = dateTimePickerDateTo.Value;
				period.Inactive = checkBoxInactive.Checked;
				return period; 
			}
			set { 
				period = value;
				textBoxName.Text = period.Name;
				dateTimePickerDateFrom.Value = DateUtility.GetValid(period.DateFrom);
				dateTimePickerDateTo.Value = DateUtility.GetValid(period.DateTo);
				checkBoxInactive.Checked = period.Inactive;
				period.CategoriesChanged += delegate { PeriodCategoriesChanged(); };
				PeriodCategoriesChanged();
			}
		}
		
		public PeriodForm() : this(new Period())
		{
		}
		
		public PeriodForm(Period period)
		{
			InitializeComponent();
			this.Period = period;
		}
		
		void PeriodCategoriesChanged()
		{
			listView1.Items.Clear();
			foreach (var c in period.Categories) {
				ListViewItem li = listView1.Items.Add(c.Category.Name);
				li.SubItems.Add(c.Target.ToString("0.00"));
				SwfUtility.AlternateBackColor(li);
			}
		}
		
		public event PeriodEventHandler SavePeriod;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SavePeriod != null) {
				SavePeriod(Period, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonNewClick(object sender, EventArgs e)
		{
			using (var f = new PeriodCategoryForm()) {
				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
					period.AddCategory(f.Category);
				}
			}
		}
	}
}
