//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.Drawing.Printing;

namespace NBooks.Core.Util
{
	public class DefaultPrinter : IPrinter
	{
		public DefaultPrinter()
		{
		}
		
		public void Print(string str)
		{
			PrintDocument d = new PrintDocument();
			d.PrintPage += delegate(object sender, PrintPageEventArgs e) { 
				e.Graphics.DrawString(str, new Font("Courier New", 9, FontStyle.Bold), Brushes.Black, 0, 0);
			};
			d.Print();
		}
	}
}
