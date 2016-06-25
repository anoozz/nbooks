//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class PriceLevelForm : BaseForm
	{
		PriceLevel level;
		
		public PriceLevel PriceLevel {
			get { 
				level.Name = textBoxName.Text;
				level.Inactive = checkBoxInactive.Checked;
				return level;
			}
			set {
				level = value;
				textBoxName.Text = level.Name;
				checkBoxInactive.Checked = level.Inactive;
			}
		}
		
		public PriceLevelForm() : this(new PriceLevel())
		{
		}
		
		public PriceLevelForm(PriceLevel level)
		{
			InitializeComponent();
			this.PriceLevel = level;
		}
		
		public event PriceLevelEventHandler SavePriceLevel;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SavePriceLevel != null) {
				SavePriceLevel(PriceLevel, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
