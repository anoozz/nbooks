//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Repositories;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Data.NHibernate;
using NBooks.Views;

namespace NBooks.Commands
{
	public class ListTerms : AbstractCommand
	{
		public override void Run()
		{
			TermsListForm form = new TermsListForm();
			ITermsRepository dao = new NHibernateTermsDao();
			form.TermsList += delegate { form.Terms = dao.FindActive(); };
			form.TermsAdd += delegate { new AddTerms().Run(); };
			form.TermsEdit += delegate(object sender, TermsEventArgs e) { 
				new EditTerms(e.Terms).Run();
			};
			form.TermsDelete += delegate(object sender, TermsEventArgs e) { 
				dao.Delete(e.Terms);
			};
			form.TermsMakeInactive += delegate(object sender, TermsEventArgs e) { 
				dao.MakeInactive(e.Terms);
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddTerms : AbstractCommand
	{
		public override void Run()
		{
			TermsForm form = new TermsForm();
			ITermsRepository dao = new NHibernateTermsDao();
			form.TermsSave += delegate(object sender, TermsEventArgs e) { 
				dao.SaveOrUpdate(e.Terms);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditTerms : AbstractCommand
	{
		Terms terms;
		
		public EditTerms(Terms terms)
		{
			this.terms = terms;
		}
		
		public override void Run()
		{
			TermsForm form = new TermsForm(terms);
			ITermsRepository dao = new NHibernateTermsDao();
			form.TermsSave += delegate(object sender, TermsEventArgs e) { 
				dao.SaveOrUpdate(e.Terms);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form, "Edit Terms");
		}
	}
}
