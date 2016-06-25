//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Repositories;
using NBooks.Core.Views;

namespace NBooks.Core.Controllers
{
	public class ItemController : AbstractController
	{
		IItemRepository repository;
		IItemView view;
		
		public ItemController(IItemRepository repository, IItemView view)
		{
			this.repository = repository;
			this.view = view;
		}
		
		public IView Add()
		{
			return view;
		}
		
		public IView Edit(int id)
		{
			view.Item = repository.Read(id);
			return view;
		}
	}
}
