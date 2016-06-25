//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

using NBooks.Commands;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Data.NHibernate;
using NBooks.Util;
using NHibernate.Cfg;

namespace NBooks
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			if (ProcessUtility.CheckInstance("nbooks")) {
				return;
			}
			
			ResourceUtility.Manager = new ResourceManager("NBooks.ApplicationResource", Assembly.GetExecutingAssembly());
			
			var config = new Configuration();
			config.Configure();
			config.AddAssembly(typeof(NBooks.Core.Models.Company).Assembly);
			NHibernateHelper.Configuration = config;
			
			ReadDefaultCompany();
			InitializeWorkbench();
			
			new ShowHomePage().Run();
			Application.Run(WorkbenchSingleton.MainForm);
			NHibernateHelper.CloseSession();
		}
		
		static void ReadDefaultCompany()
		{
//			CompanySingleton.Instance = new CompanyService(new NHibernateCompanyDao()).Read(1);
			CompanySingleton.Instance = Company.Read(1);
			CompanySingleton.Instance.NameChanged += delegate { 
				WorkbenchSingleton.MainForm.Text = ApplicationUtility.ProductNameAndVersion + " - " + CompanySingleton.Instance.Name;
			};
		}
		
		static void InitializeWorkbench()
		{
			IWorkbench workbench = new MainForm();
			
			workbench.WorkbenchMenu = new DefaultMenu();
//			IList<Company> companies = Company.FindRecent();
//			foreach (Company c in companies) {
//				workbench.WorkbenchMenu.PreviousOpenCompaniesMenuItem.DropDownItems.Add(new BToolStripMenuItem(c.Database.ConnectionString));
//			}
//			if (companies.Count > 0) {
//				companies[companies.Count - 1].Open();
//			}
			
			WorkbenchSingleton.Attach(workbench);
			WorkbenchSingleton.MainForm.Text = ApplicationUtility.ProductNameAndVersion + " - " + CompanySingleton.Instance.Name;
			
//			workbench.Login += delegate {
//				workbench.FreezeControlForLogin();
//				ILoginController login = new LoginController(
//					new LoginForm(CompanySingleton.Instance),
//					new NHibernateUserDao()
//				);
//				if (WorkbenchSingleton.AddDialog((Form)login.View) == DialogResult.Cancel) {
//					workbench.Close();
//				} else {
//					workbench.UnFreezeControlForLogin();
//					new ShowHomePage().Run();
//				}
//			};
		}
	}
}
