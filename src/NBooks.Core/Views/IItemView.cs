//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Core.Views
{
	public interface IItemView : IView
	{
		Item Item { get; set; }
	}
}
