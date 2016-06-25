//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Util;

namespace NBooks.Views
{
	/// <summary>
	/// Description of SalesInfoDetailForm.
	/// </summary>
	public partial class SalesInfoDetailForm : BaseForm
	{
		SalesInfoDetail detail;
		
		public SalesInfoDetail Detail {
			get { return detail; }
			set { 
				detail = value;
				textBoxCheckNo.Text = detail.CheckNo;
				textBoxDescription.Text = detail.Description;
				textBoxAmount.Text = detail.Amount.ToString("0.00");
				comboBoxType.Text = detail.Type;
			}
		}
		
		public SalesInfoDetailForm() : this(new SalesInfoDetail())
		{
		}
		
		public SalesInfoDetailForm(SalesInfoDetail detail)
		{
			InitializeComponent();
			comboBoxType.SelectedIndex = 0;
			this.Detail = detail;
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			detail.CheckNo = textBoxCheckNo.Text;
			detail.Description = textBoxDescription.Text;
			detail.Amount = ConvertUtility.ToDouble(textBoxAmount.Text);
			detail.Type = comboBoxType.Text;
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
