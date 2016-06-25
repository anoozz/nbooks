//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Util
{
	public class BaseCommand : AbstractCommand
	{
		public BaseCommand()
		{
			PreExecute();
		}
		
		~BaseCommand()
		{
			PostExecute();
		}
		
		public virtual void PreExecute()
		{
		}
		
		public virtual void PostExecute()
		{
		}
		
		public override void Run()
		{
			throw new NotImplementedException();
		}
	}
}
