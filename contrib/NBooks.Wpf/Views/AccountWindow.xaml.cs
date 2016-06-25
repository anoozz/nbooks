/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 1/4/2011
 * Time: 11:11 AM
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
using NBooks.Core.Views;

namespace NBooks.Wpf.Views
{
	/// <summary>
	/// Interaction logic for AccountWindow.xaml
	/// </summary>
	public partial class AccountWindow : Window, IAccountView
	{
		Account account;
		
		public Account Account {
			get { return account; }
			set { account = value; }
		}
		
		public AccountWindow()
		{
			InitializeComponent();
		}
		
		public event AccountEventHandler SaveAccount;
		
		protected virtual void OnSaveAccount(EventArgs e)
		{
			if (SaveAccount != null) {
				SaveAccount(Account, e);
			}
		}
	}
}