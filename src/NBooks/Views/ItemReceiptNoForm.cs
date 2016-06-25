//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Util;
using NBooks.Util;

namespace NBooks.Views
{
	/// <summary>
	/// Description of ItemReceiptNoForm.
	/// </summary>
	public partial class ItemReceiptNoForm : BaseForm
	{
		public int Id {
			get { return ConvertUtility.ToInt32(textBoxNo.Text); }
		}
		
		public ItemReceiptNoForm()
		{
			InitializeComponent();
		}
	}
}
