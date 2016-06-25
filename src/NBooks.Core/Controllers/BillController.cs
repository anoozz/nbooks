//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;
using NBooks.Core.Repositories;
using NBooks.Core.Views;

namespace NBooks.Core.Controllers
{
	public class BillController
	{
		IBillRepository repository;
		IBillView view;
		
		public BillController(IBillRepository repository, IBillView view)
		{
			this.repository = repository;
			this.view = view;
			
			view.BillSave += delegate(object sender, BillEventArgs e) { 
				Add(e.Bill);
			};
		}
		
		public IView Add()
		{
			return view;
		}
		
		public void Add(Bill bill)
		{
			repository.SaveOrUpdate(bill);
		}
	}
}
