/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 1/4/2011
 * Time: 11:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Input;
using NBooks.Wpf.Views;

namespace NBooks.Wpf.Commands
{
	public class ShowAbout : ICommand
	{
		public event EventHandler CanExecuteChanged;
		
		public void Execute(object parameter)
		{
			throw new NotImplementedException();
		}
		
		public bool CanExecute(object parameter)
		{
			throw new NotImplementedException();
		}
	}
}
