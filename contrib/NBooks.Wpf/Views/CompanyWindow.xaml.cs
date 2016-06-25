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
	/// Interaction logic for CompanyWindow.xaml
	/// </summary>
	public partial class CompanyWindow : Window, ICompanyView
	{
		Company company;
		IList<Country> countries;
		IList<Country> legalCountries;
		
		public IList<Country> LegalCountries {
			get { return legalCountries; }
			set { legalCountries = value; }
		}
		
		public IList<Country> Countries {
			get { return countries; }
			set { countries = value; }
		}
		
		public Company Company {
			get { 
				return company;
			}
			set { 
				company = value;
			}
		}
		
		public CompanyWindow(Company company)
		{
			InitializeComponent();
			this.Company = company;
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListCountries != null) ListCountries(this, null);
			if (ListLegalCountries != null) ListLegalCountries(this, null);
		}
		
		public event CompanyEventHandler SaveCompany;
		
		protected virtual void OnSaveCompany(EventArgs e)
		{
			if (SaveCompany != null) {
				SaveCompany(Company, e);
			}
		}
		public event EventHandler ListCountries;
		public event EventHandler ListLegalCountries;
	}
}