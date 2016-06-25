//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Models;

namespace NBooks.Views.ListOfValues
{
	/// <summary>
	/// Description of CustomerListOfValueForm.
	/// </summary>
	public partial class CustomerListOfValueForm : ListOfValueForm<Customer>
	{
		public CustomerListOfValueForm()
		{
			InitializeComponent();
		}
		
		protected override void OnItemsChanged(EventArgs e)
		{
			base.OnItemsChanged(e);
		}
	}
}
