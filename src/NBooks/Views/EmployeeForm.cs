//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class EmployeeForm : BaseForm
	{
		Employee employee;
		IList<Position> positions;
		IList<Department> departments;
		IList<EmployeeType> types;
		IList<Shift> shifts;
		IList<TaxCode> taxCodes;
		Image dummyImage;
		IList<State> states;
		IList<WorkersComp> workersComps;
		IList<PhilHealthPremium> philHealthPremiums;
		IList<PagIbigPremium> pagIbigPremiums;
		
		public IList<PagIbigPremium> PagIbigPremiums {
			get { return pagIbigPremiums; }
			set { 
				pagIbigPremiums = value; 
				SwfUtility.SetupComboBox(comboBoxPagIBIGPremium, pagIbigPremiums, "Id", "Code", employee.PagIbigPremium); 
			}
		}
		
		public IList<PhilHealthPremium> PhilHealthPremiums {
			get { return philHealthPremiums; }
			set {
				philHealthPremiums = value;
				SwfUtility.SetupComboBox(comboBoxPhilHealthPremium, philHealthPremiums, "Id", "Code", employee.PhilHealthPremium);
			}
		}
		
		public IList<WorkersComp> WorkersComps {
			get { return workersComps; }
			set { 
				workersComps = value; 
				SwfUtility.SetupComboBox(comboBoxWorkersComp, workersComps, "Id", "Code", employee.WorkersComp);
			}
		}
		
		public IList<State> States {
			get { return states; }
			set { 
				states = value;
				SwfUtility.SetupComboBox(comboBoxState, states, "Id", "ShortName", employee.State);
			}
		}
		
		public Employee Employee {
			get { 
				employee.LegalName = new Name(textBoxTitle.Text, textBoxLastName.Text, textBoxFirstName.Text, textBoxMI.Text);
				employee.SSSNo = textBoxSSNo.Text;
				employee.Gender = comboBoxGender.SelectedIndex;
				employee.DateOfBirth = dateTimePickerDateOfBirth.Value;
				employee.Address = new Address(textBoxStreet1.Text, textBoxStreet2.Text, textBoxCity.Text, "", textBoxZip.Text, "");
				employee.Phone = textBoxPhone.Text;
				employee.Cellular = textBoxCellular.Text;
				employee.Email = textBoxEmail.Text;
				employee.State = SwfUtility.GetComboBoxValue<State>(comboBoxState);
				employee.AccountNo = textBoxAccountNo.Text;
				employee.DateHired = dateTimePickerHireDate.Value;
				employee.ImageByte = ImageUtility.ToByteArray(pictureBoxImage.Image);
				return employee;
			}
			set { 
				employee = value;
				if (employee.LegalName != null) {
					textBoxTitle.Text = employee.LegalName.Title;
					textBoxFirstName.Text = employee.LegalName.First;
					textBoxMI.Text = employee.LegalName.Middle;
					textBoxLastName.Text = employee.LegalName.Last;
				}
				textBoxSSNo.Text = employee.SSSNo;
				comboBoxGender.SelectedIndex = employee.Gender;
				dateTimePickerDateOfBirth.Value = DateUtility.GetValid(employee.DateOfBirth);
				if (employee.Address != null) {
					textBoxStreet1.Text = employee.Address.Street1;
					textBoxStreet2.Text = employee.Address.Street2;
					textBoxCity.Text = employee.Address.City;
					textBoxZip.Text = employee.Address.Zip;
				}
				textBoxPhone.Text = employee.Phone;
				textBoxCellular.Text = employee.Cellular;
				textBoxEmail.Text = employee.Email;
				textBoxAccountNo.Text = employee.AccountNo;
				pictureBoxImage.Image = ImageUtility.ToImage(employee.ImageByte);
				dateTimePickerHireDate.Value = DateUtility.GetValid(employee.DateHired);
				if (employee.Id > 0) {
					buttonNotes.Visible = true;
				}
			}
		}
		
		public IList<TaxCode> TaxCodes {
			get { return taxCodes; }
			set { 
				taxCodes = value; 
				SwfUtility.SetupComboBox(comboBoxTaxCode, taxCodes, "Id", "Description", employee.TaxCode); 
			}
		}
		
		public IList<Shift> Shifts {
			get { return shifts; }
			set { 
				shifts = value;
//				SwfUtility.SetupComboBox(comboBoxShift, shifts, "Id", "Name", employee.Shift); 
			}
		}
		
		public IList<EmployeeType> EmployeeTypes {
			get { return types; }
			set { 
				types = value; 
				SwfUtility.SetupComboBox(comboBoxType, types, "Id", "Name", employee.EmployeeType); 
			}
		}
		
		public IList<Department> Departments {
			get { return departments; }
			set { 
				departments = value; 
//				SwfUtility.SetupComboBox(comboBoxDepartment, departments, "Id", "Name", employee.Department); 
			}
		}
		
		public IList<Position> Positions {
			get { return positions; }
			set { 
				positions = value; 
//				SwfUtility.SetupComboBox(comboBoxPosition, positions, "Id", "Name", employee.Position); 
			}
		}
		
		public EmployeeForm() : this(new Employee())
		{
		}
		
		public EmployeeForm(Employee employee)
		{
			InitializeComponent();
			dummyImage = pictureBoxImage.Image;
			this.Employee = employee;
			comboBoxChangeTabs.SelectedIndex = 0;
			textBoxFirstName.Select();
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			OnEmployeeSave(new EmployeeEventArgs(Employee));
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListPagIbigPremiums != null) ListPagIbigPremiums(this, e);
			if (ListPositions != null) ListPositions(this, e);
			if (ListStates != null) ListStates(this, e);
			if (ListDepartments != null) ListDepartments(this, e);
			if (ListEmployeeTypes != null) ListEmployeeTypes(this, e);
			if (ListShifts != null) ListShifts(this, e);
			if (ListTaxCodes != null) ListTaxCodes(this, e);
		}
		
		public event EventHandler<EmployeeEventArgs> EmployeeSave;
		
		protected virtual void OnEmployeeSave(EmployeeEventArgs e)
		{
			if (EmployeeSave != null) {
				EmployeeSave(this, e);
			}
		}
		public event EventHandler ListPagIbigPremiums;
		public event EventHandler ListPositions;
		public event EventHandler ListStates;
		public event EventHandler ListDepartments;
		public event EventHandler ListEmployeeTypes;
		public event EventHandler ListShifts;
		public event EventHandler ListTaxCodes;
		
		void ButtonNotesClick(object sender, EventArgs e)
		{
			WorkbenchSingleton.AddDialog(new NotepadForm(employee));
		}
		
		void ComboBoxChangeTabsSelectedIndexChanged(object sender, EventArgs e)
		{
			tabControl1.TabPages.Clear();
			switch (comboBoxChangeTabs.SelectedIndex) {
				case 0: // Personal Info
					tabControl1.TabPages.AddRange(new TabPage[] { tabPage1, tabPage2, tabPage3 });
					break;
				case 1: // Payroll and Compensation Info
					tabControl1.TabPages.AddRange(new TabPage[] { tabPage4 });
					break;
				case 2: // Employment Info
					tabControl1.TabPages.AddRange(new TabPage[] { tabPage5 });
					break;
				case 3: // Workers Compensation
					tabControl1.TabPages.AddRange(new TabPage[] { tabPage6 });
					break;
				default:
					break;
			}
		}
		
		void TextBoxNameTextChanged(object sender, EventArgs e)
		{
			labelName.Text = new Name(textBoxLastName.Text, textBoxFirstName.Text, textBoxMI.Text).ToString();
		}
	}
}
