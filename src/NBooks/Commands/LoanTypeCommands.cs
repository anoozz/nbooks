//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Views;

namespace NBooks.Commands
{
	/// <summary>
	/// </summary>
	/// <author></author>
	public class ListLoanTypes : AbstractCommand
	{
		public override void Run()
		{
			var form = new LoanTypeListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddLoanType : AbstractCommand
	{
		public override void Run()
		{
			var form = new LoanTypeForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditLoanType : AbstractCommand
	{
		LoanType type;
		
		public EditLoanType(LoanType type)
		{
			this.type = type;
		}
		
		public override void Run()
		{
			var form = new LoanTypeForm(type);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
