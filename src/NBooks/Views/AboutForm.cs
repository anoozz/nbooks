//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Util;
using NBooks.Util;

namespace NBooks.Views
{
	public partial class AboutForm : BaseForm
	{
		public AboutForm()
		{
			InitializeComponent();
			this.Text = "About " + ApplicationUtility.ProductName;
			labelProductName.Text = ApplicationUtility.ProductName;
			labelVersion.Text = "Version " + ApplicationUtility.ProductVersion;
		}
		
		void LinkLabelSiteLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start((sender as LinkLabel).Text);
		}
	}
}
