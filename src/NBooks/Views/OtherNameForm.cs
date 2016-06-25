//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Gui;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class OtherNameForm : BaseForm
	{
		OtherName name;
		
		public OtherName OtherName {
			get {
				name.Name = textBoxName.Text;
				name.CompanyName = textBoxCompanyName.Text;
				name.LegalName = new Name(textBoxTitle.Text, textBoxLastName.Text, textBoxFirstName.Text, textBoxMI.Text);
				name.Address = richTextBoxAddress.Text;
				name.Contact = textBoxContact.Text;
				name.Phone = textBoxPhone.Text;
				name.Fax = textBoxFax.Text;
				name.AltPhone = textBoxAltPhone.Text;
				name.AltContact = textBoxAltContact.Text;
				name.Email = textBoxEmail.Text;
				name.CC = textBoxCC.Text;
				name.PrintOnCheckAs = textBoxPrintOnCheckAs.Text;
				name.Inactive = checkBoxInactive.Checked;
				return name;
			}
			set {
				name = value;
				textBoxName.Text = name.Name;
				textBoxCompanyName.Text = name.CompanyName;
				if (name.LegalName != null) {
					textBoxTitle.Text = name.LegalName.Title;
					textBoxLastName.Text = name.LegalName.Last;
					textBoxFirstName.Text = name.LegalName.First;
					textBoxMI.Text = name.LegalName.Middle;
				}
				richTextBoxAddress.Text = name.Address;
				textBoxContact.Text = name.Contact;
				textBoxPhone.Text = name.Phone;
				textBoxFax.Text = name.Fax;
				textBoxAltPhone.Text = name.AltPhone;
				textBoxAltContact.Text = name.AltContact;
				textBoxEmail.Text = name.Email;
				textBoxCC.Text = name.CC;
				textBoxPrintOnCheckAs.Text = name.PrintOnCheckAs;
				checkBoxInactive.Checked = name.Inactive;
				if (name.Id > 0) {
					buttonNotes.Visible = true;
				}
			}
		}
		
		public OtherNameForm() : this(new OtherName())
		{
		}
		
		public OtherNameForm(OtherName name)
		{
			InitializeComponent();
			this.OtherName = name;
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SaveOtherName != null) SaveOtherName(OtherName, null);
		}
		
		public event OtherNameEventHandler SaveOtherName;
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonNotesClick(object sender, EventArgs e)
		{
			WorkbenchSingleton.AddDialog(new NotepadForm(name));
		}
	}
}
