//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class AmountForm : BaseForm
	{
		public double Amount {
			get { return ConvertUtility.ToDouble(textBoxAmount.Text); }
		}
		
		public AmountForm()
		{
			InitializeComponent();
		}
	}
}
