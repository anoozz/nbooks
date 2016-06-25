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
	public class ListJobTypes : AbstractCommand
	{
		public override void Run()
		{
			var form = new JobTypeListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddJobType : AbstractCommand
	{
		public override void Run()
		{
			var form = new JobTypeForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditJobType : AbstractCommand
	{
		JobType type;
		
		public EditJobType(JobType type)
		{
			this.type = type;
		}
		
		public override void Run()
		{
			var form = new JobTypeForm(type);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
