//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Models;

namespace NBooks.Views
{
	/// <summary>
	/// Description of CompanyListPane.
	/// </summary>
	public partial class CompanyListPane : BaseUserControl
	{
		IList<Company> companies;
		
		public IList<Company> Companies {
			get { return companies; }
			set { 
				companies = value; 
				listBox1.Items.Clear();
				foreach (var c in companies) {
					listBox1.Items.Add(c.Name);
				}
			}
		}
		
		public CompanyListPane()
		{
			InitializeComponent();
		}
		
		void ButtonOpenClick(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex > 0) {
				Company c = companies[listBox1.SelectedIndex];
				c.Open();
			}
		}
	}
}
