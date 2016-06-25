/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 01/04/2011
 * Time: 11:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

using NBooks.Core.Models;

namespace NBooks.Wpf.Views
{
	/// <summary>
	/// Interaction logic for SalesTaxCodeWindow.xaml
	/// </summary>
	public partial class SalesTaxCodeWindow : Window
	{
		SalesTaxCode code;
		
		public SalesTaxCode SalesTaxCode {
			get { 
				return code;
			}
			set { 
				code = value;
			}
		}
		
		public SalesTaxCodeWindow() : this(new SalesTaxCode())
		{
		}
		
		public SalesTaxCodeWindow(SalesTaxCode code)
		{
			InitializeComponent();
			this.SalesTaxCode = code;
		}
		
		public event SalesTaxCodeEventHandler SaveSalesTaxCode;
		
		protected virtual void OnSaveSalesTaxCode(EventArgs e)
		{
			if (SaveSalesTaxCode != null) {
				SaveSalesTaxCode(SalesTaxCode, e);
			}
		}
	}
}