//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class CompanyForm : BaseForm
	{
		Company company;
		IList<Country> countries;
		IList<Country> legalCountries;
		
		public IList<Country> LegalCountries {
			get { return legalCountries; }
			set { legalCountries = value; SwfUtility.SetupComboBox(comboBoxLegalCountry, legalCountries, "Id", "LongName", company.LegalCountry); }
		}
		
		public IList<Country> Countries {
			get { return countries; }
			set { countries = value; SwfUtility.SetupComboBox(comboBoxCountry, countries, "Id", "LongName", company.Country); }
		}
		
		public Company Company {
			get { 
				company.Name = textBoxName.Text;
				company.Address = richTextBoxAddress.Text;
				company.Country = SwfUtility.GetComboBoxValue<Country>(comboBoxCountry);
				company.Phone = textBoxPhone.Text;
				company.Fax = textBoxFax.Text;
				company.Email = textBoxEmail.Text;
				company.Website = textBoxWebsite.Text;
				company.LegalName = textBoxLegalName.Text;
				company.State = SwfUtility.GetComboBoxValue<State>(comboBoxState);
				company.LegalCountry = SwfUtility.GetComboBoxValue<Country>(comboBoxLegalCountry);
				company.LegalAddress = new Address(
					textBoxLegalAddress.Text, 
					textBoxLegalAddress2.Text, 
					textBoxCity.Text, 
					"", 
					textBoxZip.Text, 
					""
				);
				company.FiscalYear = comboBoxFiscalYear.SelectedIndex;
				company.TaxYear = comboBoxTaxYear.SelectedIndex;
				company.IncomeTaxForm = comboBoxIncomeTaxForm.SelectedIndex;
				company.EIN = textBoxEIN.Text;
				company.SSN = textBoxSSN.Text;
				company.PayrollContact = textBoxContact.Text;
				company.PayrollTitle = textBoxTitle.Text;
				company.PayrollPhone = textBoxPhone2.Text;
				return company; 
			}
			set { 
				company = value;
				textBoxName.Text = company.Name;
				richTextBoxAddress.Text = company.Address;
				textBoxPhone.Text = company.Phone;
				textBoxFax.Text = company.Fax;
				textBoxEmail.Text = company.Email;
				textBoxWebsite.Text = company.Website;
				textBoxLegalName.Text = company.LegalName;
				if (company.LegalAddress != null) {
					textBoxLegalAddress.Text = company.LegalAddress.Street1;
					textBoxLegalAddress2.Text = company.LegalAddress.Street2;
					textBoxCity.Text = company.LegalAddress.City;
					textBoxZip.Text = company.LegalAddress.Zip;
				}
				comboBoxFiscalYear.SelectedIndex = company.FiscalYear;
				comboBoxTaxYear.SelectedIndex = company.TaxYear;
				comboBoxIncomeTaxForm.SelectedIndex = company.IncomeTaxForm;
				textBoxEIN.Text = company.EIN;
				textBoxSSN.Text = company.SSN;
				textBoxContact.Text = company.PayrollContact;
				textBoxTitle.Text = company.PayrollTitle;
				textBoxPhone2.Text = company.PayrollPhone;
			}
		}
		
		public CompanyForm() : this(new Company())
		{
		}
		
		public CompanyForm(Company company)
		{
			InitializeComponent();
			this.Company = company;
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (CountriesList != null) CountriesList(this, null);
			if (LegalCountriesList != null) LegalCountriesList(this, null);
		}
		
		public event EventHandler CountriesList;
		public event EventHandler LegalCountriesList;
		public event EventHandler<CompanyEventArgs> CompanySave;
		
		protected virtual void OnCompanySave(CompanyEventArgs e)
		{
			if (CompanySave != null) {
				CompanySave(this, e);
			}
		}
		
		void ButtonShipToAddressClick(object sender, EventArgs e)
		{
			WorkbenchSingleton.AddDialog(new ShipToInformationForm(company));
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			OnCompanySave(new CompanyEventArgs(Company));
		}
		
		void ComboBoxLegalCountrySelectedIndexChanged(object sender, EventArgs e)
		{
			Country c = SwfUtility.GetComboBoxValue<Country>(comboBoxLegalCountry);
			if (c != null) {
				SwfUtility.SetupComboBox(comboBoxState, c.States, "Id", "ShortName", company.State);
			}
		}
	}
}
