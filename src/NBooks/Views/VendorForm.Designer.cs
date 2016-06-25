// one line to give the library's name and an idea of what it does.
// Copyright (C) 2010 Ian Escarro <ian.escarro@gmail.com>
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

namespace NBooks.Views
{
	partial class VendorForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorForm));
			this.buttonNotes = new System.Windows.Forms.Button();
			this.dateTimePickerBalanceAsOf = new System.Windows.Forms.DateTimePicker();
			this.labelBalanceAsOf = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageAddress = new System.Windows.Forms.TabPage();
			this.textBoxPrintOnCheckAs = new System.Windows.Forms.TextBox();
			this.labelPrintOnCheckAs = new System.Windows.Forms.Label();
			this.buttonAddressDetails = new System.Windows.Forms.Button();
			this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
			this.labelAddress = new System.Windows.Forms.Label();
			this.textBoxCC = new System.Windows.Forms.TextBox();
			this.labelCC = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.textBoxAltContact = new System.Windows.Forms.TextBox();
			this.labelAltContact = new System.Windows.Forms.Label();
			this.textBoxAltPhone = new System.Windows.Forms.TextBox();
			this.labelAltPhone = new System.Windows.Forms.Label();
			this.textBoxFax = new System.Windows.Forms.TextBox();
			this.labelFax = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.textBoxContact = new System.Windows.Forms.TextBox();
			this.labelContact = new System.Windows.Forms.Label();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.labelLastName = new System.Windows.Forms.Label();
			this.textBoxMI = new System.Windows.Forms.TextBox();
			this.labelMI = new System.Windows.Forms.Label();
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.textBoxCompanyName = new System.Windows.Forms.TextBox();
			this.labelCompanyName = new System.Windows.Forms.Label();
			this.tabPageAdditional = new System.Windows.Forms.TabPage();
			this.groupBoxCustomFields = new System.Windows.Forms.GroupBox();
			this.buttonDefineFields = new System.Windows.Forms.Button();
			this.textBox19 = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.checkBoxEligibleFor1099 = new System.Windows.Forms.CheckBox();
			this.textBoxTaxId = new System.Windows.Forms.TextBox();
			this.labelTaxId = new System.Windows.Forms.Label();
			this.textBoxCreditLimit = new System.Windows.Forms.TextBox();
			this.labelCreditLimit = new System.Windows.Forms.Label();
			this.groupBoxCategorizingAndDefaults = new System.Windows.Forms.GroupBox();
			this.comboBoxTerms = new System.Windows.Forms.ComboBox();
			this.labelTerms = new System.Windows.Forms.Label();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.labelType = new System.Windows.Forms.Label();
			this.textBoxAccountNo = new System.Windows.Forms.TextBox();
			this.labelAccountNo = new System.Windows.Forms.Label();
			this.tabPageAccount = new System.Windows.Forms.TabPage();
			this.buttonClearAll = new System.Windows.Forms.Button();
			this.comboBoxAccountPrefill3 = new System.Windows.Forms.ComboBox();
			this.comboBoxAccountPrefill2 = new System.Windows.Forms.ComboBox();
			this.comboBoxAccountPrefill1 = new System.Windows.Forms.ComboBox();
			this.labelPrefillLabel = new System.Windows.Forms.Label();
			this.textBoxBalance = new System.Windows.Forms.TextBox();
			this.labelBalance = new System.Windows.Forms.Label();
			this.checkBoxInactive = new System.Windows.Forms.CheckBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPageAddress.SuspendLayout();
			this.tabPageAdditional.SuspendLayout();
			this.groupBoxCustomFields.SuspendLayout();
			this.groupBoxCategorizingAndDefaults.SuspendLayout();
			this.tabPageAccount.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonNotes
			// 
			this.buttonNotes.Location = new System.Drawing.Point(480, 64);
			this.buttonNotes.Name = "buttonNotes";
			this.buttonNotes.Size = new System.Drawing.Size(75, 23);
			this.buttonNotes.TabIndex = 173;
			this.buttonNotes.Text = "Notes";
			this.buttonNotes.UseVisualStyleBackColor = true;
			this.buttonNotes.Visible = false;
			this.buttonNotes.Click += new System.EventHandler(this.ButtonNotesClick);
			// 
			// dateTimePickerBalanceAsOf
			// 
			this.dateTimePickerBalanceAsOf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerBalanceAsOf.Location = new System.Drawing.Point(256, 32);
			this.dateTimePickerBalanceAsOf.Name = "dateTimePickerBalanceAsOf";
			this.dateTimePickerBalanceAsOf.Size = new System.Drawing.Size(96, 21);
			this.dateTimePickerBalanceAsOf.TabIndex = 172;
			// 
			// labelBalanceAsOf
			// 
			this.labelBalanceAsOf.Location = new System.Drawing.Point(200, 32);
			this.labelBalanceAsOf.Name = "labelBalanceAsOf";
			this.labelBalanceAsOf.Size = new System.Drawing.Size(100, 23);
			this.labelBalanceAsOf.TabIndex = 171;
			this.labelBalanceAsOf.Text = "as of";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageAddress);
			this.tabControl1.Controls.Add(this.tabPageAdditional);
			this.tabControl1.Controls.Add(this.tabPageAccount);
			this.tabControl1.Location = new System.Drawing.Point(8, 56);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(464, 368);
			this.tabControl1.TabIndex = 170;
			// 
			// tabPageAddress
			// 
			this.tabPageAddress.Controls.Add(this.textBoxPrintOnCheckAs);
			this.tabPageAddress.Controls.Add(this.labelPrintOnCheckAs);
			this.tabPageAddress.Controls.Add(this.buttonAddressDetails);
			this.tabPageAddress.Controls.Add(this.richTextBoxAddress);
			this.tabPageAddress.Controls.Add(this.labelAddress);
			this.tabPageAddress.Controls.Add(this.textBoxCC);
			this.tabPageAddress.Controls.Add(this.labelCC);
			this.tabPageAddress.Controls.Add(this.textBoxEmail);
			this.tabPageAddress.Controls.Add(this.labelEmail);
			this.tabPageAddress.Controls.Add(this.textBoxAltContact);
			this.tabPageAddress.Controls.Add(this.labelAltContact);
			this.tabPageAddress.Controls.Add(this.textBoxAltPhone);
			this.tabPageAddress.Controls.Add(this.labelAltPhone);
			this.tabPageAddress.Controls.Add(this.textBoxFax);
			this.tabPageAddress.Controls.Add(this.labelFax);
			this.tabPageAddress.Controls.Add(this.textBoxPhone);
			this.tabPageAddress.Controls.Add(this.labelPhone);
			this.tabPageAddress.Controls.Add(this.textBoxContact);
			this.tabPageAddress.Controls.Add(this.labelContact);
			this.tabPageAddress.Controls.Add(this.textBoxLastName);
			this.tabPageAddress.Controls.Add(this.labelLastName);
			this.tabPageAddress.Controls.Add(this.textBoxMI);
			this.tabPageAddress.Controls.Add(this.labelMI);
			this.tabPageAddress.Controls.Add(this.textBoxFirstName);
			this.tabPageAddress.Controls.Add(this.labelFirstName);
			this.tabPageAddress.Controls.Add(this.textBoxTitle);
			this.tabPageAddress.Controls.Add(this.labelTitle);
			this.tabPageAddress.Controls.Add(this.textBoxCompanyName);
			this.tabPageAddress.Controls.Add(this.labelCompanyName);
			this.tabPageAddress.Location = new System.Drawing.Point(4, 22);
			this.tabPageAddress.Name = "tabPageAddress";
			this.tabPageAddress.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAddress.Size = new System.Drawing.Size(456, 342);
			this.tabPageAddress.TabIndex = 0;
			this.tabPageAddress.Text = "Address Info";
			this.tabPageAddress.UseVisualStyleBackColor = true;
			// 
			// textBoxPrintOnCheckAs
			// 
			this.textBoxPrintOnCheckAs.Location = new System.Drawing.Point(240, 192);
			this.textBoxPrintOnCheckAs.Name = "textBoxPrintOnCheckAs";
			this.textBoxPrintOnCheckAs.Size = new System.Drawing.Size(208, 21);
			this.textBoxPrintOnCheckAs.TabIndex = 36;
			// 
			// labelPrintOnCheckAs
			// 
			this.labelPrintOnCheckAs.Location = new System.Drawing.Point(240, 176);
			this.labelPrintOnCheckAs.Name = "labelPrintOnCheckAs";
			this.labelPrintOnCheckAs.Size = new System.Drawing.Size(100, 23);
			this.labelPrintOnCheckAs.TabIndex = 35;
			this.labelPrintOnCheckAs.Text = "Print on Check As";
			// 
			// buttonAddressDetails
			// 
			this.buttonAddressDetails.Location = new System.Drawing.Point(88, 192);
			this.buttonAddressDetails.Name = "buttonAddressDetails";
			this.buttonAddressDetails.Size = new System.Drawing.Size(104, 23);
			this.buttonAddressDetails.TabIndex = 34;
			this.buttonAddressDetails.Text = "Address Details";
			this.buttonAddressDetails.UseVisualStyleBackColor = true;
			this.buttonAddressDetails.Click += new System.EventHandler(this.ButtonAddressDetailsClick);
			// 
			// richTextBoxAddress
			// 
			this.richTextBoxAddress.AcceptsTab = true;
			this.richTextBoxAddress.Location = new System.Drawing.Point(88, 104);
			this.richTextBoxAddress.Name = "richTextBoxAddress";
			this.richTextBoxAddress.Size = new System.Drawing.Size(144, 80);
			this.richTextBoxAddress.TabIndex = 33;
			this.richTextBoxAddress.Text = "";
			// 
			// labelAddress
			// 
			this.labelAddress.Location = new System.Drawing.Point(8, 104);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(100, 23);
			this.labelAddress.TabIndex = 32;
			this.labelAddress.Text = "Address";
			// 
			// textBoxCC
			// 
			this.textBoxCC.Location = new System.Drawing.Point(304, 152);
			this.textBoxCC.Name = "textBoxCC";
			this.textBoxCC.Size = new System.Drawing.Size(144, 21);
			this.textBoxCC.TabIndex = 30;
			// 
			// labelCC
			// 
			this.labelCC.Location = new System.Drawing.Point(240, 152);
			this.labelCC.Name = "labelCC";
			this.labelCC.Size = new System.Drawing.Size(100, 23);
			this.labelCC.TabIndex = 29;
			this.labelCC.Text = "CC";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(304, 128);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(144, 21);
			this.textBoxEmail.TabIndex = 28;
			// 
			// labelEmail
			// 
			this.labelEmail.Location = new System.Drawing.Point(240, 128);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(100, 23);
			this.labelEmail.TabIndex = 27;
			this.labelEmail.Text = "Email";
			// 
			// textBoxAltContact
			// 
			this.textBoxAltContact.Location = new System.Drawing.Point(304, 104);
			this.textBoxAltContact.Name = "textBoxAltContact";
			this.textBoxAltContact.Size = new System.Drawing.Size(144, 21);
			this.textBoxAltContact.TabIndex = 26;
			// 
			// labelAltContact
			// 
			this.labelAltContact.Location = new System.Drawing.Point(240, 104);
			this.labelAltContact.Name = "labelAltContact";
			this.labelAltContact.Size = new System.Drawing.Size(100, 23);
			this.labelAltContact.TabIndex = 25;
			this.labelAltContact.Text = "Alt Contact";
			// 
			// textBoxAltPhone
			// 
			this.textBoxAltPhone.Location = new System.Drawing.Point(304, 80);
			this.textBoxAltPhone.Name = "textBoxAltPhone";
			this.textBoxAltPhone.Size = new System.Drawing.Size(144, 21);
			this.textBoxAltPhone.TabIndex = 24;
			// 
			// labelAltPhone
			// 
			this.labelAltPhone.Location = new System.Drawing.Point(240, 80);
			this.labelAltPhone.Name = "labelAltPhone";
			this.labelAltPhone.Size = new System.Drawing.Size(100, 23);
			this.labelAltPhone.TabIndex = 23;
			this.labelAltPhone.Text = "Alt Phone";
			// 
			// textBoxFax
			// 
			this.textBoxFax.Location = new System.Drawing.Point(304, 56);
			this.textBoxFax.Name = "textBoxFax";
			this.textBoxFax.Size = new System.Drawing.Size(144, 21);
			this.textBoxFax.TabIndex = 22;
			// 
			// labelFax
			// 
			this.labelFax.Location = new System.Drawing.Point(240, 56);
			this.labelFax.Name = "labelFax";
			this.labelFax.Size = new System.Drawing.Size(100, 23);
			this.labelFax.TabIndex = 21;
			this.labelFax.Text = "Fax";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Location = new System.Drawing.Point(304, 32);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(144, 21);
			this.textBoxPhone.TabIndex = 20;
			// 
			// labelPhone
			// 
			this.labelPhone.Location = new System.Drawing.Point(240, 32);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(100, 23);
			this.labelPhone.TabIndex = 19;
			this.labelPhone.Text = "Phone";
			// 
			// textBoxContact
			// 
			this.textBoxContact.Location = new System.Drawing.Point(304, 8);
			this.textBoxContact.Name = "textBoxContact";
			this.textBoxContact.Size = new System.Drawing.Size(144, 21);
			this.textBoxContact.TabIndex = 18;
			// 
			// labelContact
			// 
			this.labelContact.Location = new System.Drawing.Point(240, 8);
			this.labelContact.Name = "labelContact";
			this.labelContact.Size = new System.Drawing.Size(100, 23);
			this.labelContact.TabIndex = 17;
			this.labelContact.Text = "Contact";
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(88, 80);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(144, 21);
			this.textBoxLastName.TabIndex = 16;
			// 
			// labelLastName
			// 
			this.labelLastName.Location = new System.Drawing.Point(8, 80);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(100, 23);
			this.labelLastName.TabIndex = 15;
			this.labelLastName.Text = "Last Name";
			// 
			// textBoxMI
			// 
			this.textBoxMI.Location = new System.Drawing.Point(208, 56);
			this.textBoxMI.Name = "textBoxMI";
			this.textBoxMI.Size = new System.Drawing.Size(24, 21);
			this.textBoxMI.TabIndex = 14;
			// 
			// labelMI
			// 
			this.labelMI.Location = new System.Drawing.Point(184, 56);
			this.labelMI.Name = "labelMI";
			this.labelMI.Size = new System.Drawing.Size(32, 23);
			this.labelMI.TabIndex = 13;
			this.labelMI.Text = "MI";
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Location = new System.Drawing.Point(88, 56);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(88, 21);
			this.textBoxFirstName.TabIndex = 12;
			// 
			// labelFirstName
			// 
			this.labelFirstName.Location = new System.Drawing.Point(8, 56);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(100, 23);
			this.labelFirstName.TabIndex = 11;
			this.labelFirstName.Text = "First Name";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(88, 32);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(144, 21);
			this.textBoxTitle.TabIndex = 10;
			// 
			// labelTitle
			// 
			this.labelTitle.Location = new System.Drawing.Point(8, 32);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(100, 23);
			this.labelTitle.TabIndex = 9;
			this.labelTitle.Text = "Mr./Ms./...";
			// 
			// textBoxCompanyName
			// 
			this.textBoxCompanyName.Location = new System.Drawing.Point(88, 8);
			this.textBoxCompanyName.Name = "textBoxCompanyName";
			this.textBoxCompanyName.Size = new System.Drawing.Size(144, 21);
			this.textBoxCompanyName.TabIndex = 8;
			// 
			// labelCompanyName
			// 
			this.labelCompanyName.Location = new System.Drawing.Point(8, 8);
			this.labelCompanyName.Name = "labelCompanyName";
			this.labelCompanyName.Size = new System.Drawing.Size(100, 23);
			this.labelCompanyName.TabIndex = 7;
			this.labelCompanyName.Text = "Company Name";
			// 
			// tabPageAdditional
			// 
			this.tabPageAdditional.Controls.Add(this.groupBoxCustomFields);
			this.tabPageAdditional.Controls.Add(this.checkBoxEligibleFor1099);
			this.tabPageAdditional.Controls.Add(this.textBoxTaxId);
			this.tabPageAdditional.Controls.Add(this.labelTaxId);
			this.tabPageAdditional.Controls.Add(this.textBoxCreditLimit);
			this.tabPageAdditional.Controls.Add(this.labelCreditLimit);
			this.tabPageAdditional.Controls.Add(this.groupBoxCategorizingAndDefaults);
			this.tabPageAdditional.Controls.Add(this.textBoxAccountNo);
			this.tabPageAdditional.Controls.Add(this.labelAccountNo);
			this.tabPageAdditional.Location = new System.Drawing.Point(4, 22);
			this.tabPageAdditional.Name = "tabPageAdditional";
			this.tabPageAdditional.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAdditional.Size = new System.Drawing.Size(456, 342);
			this.tabPageAdditional.TabIndex = 1;
			this.tabPageAdditional.Text = "Additional Info";
			this.tabPageAdditional.UseVisualStyleBackColor = true;
			// 
			// groupBoxCustomFields
			// 
			this.groupBoxCustomFields.Controls.Add(this.buttonDefineFields);
			this.groupBoxCustomFields.Controls.Add(this.textBox19);
			this.groupBoxCustomFields.Controls.Add(this.label24);
			this.groupBoxCustomFields.Location = new System.Drawing.Point(216, 40);
			this.groupBoxCustomFields.Name = "groupBoxCustomFields";
			this.groupBoxCustomFields.Size = new System.Drawing.Size(232, 240);
			this.groupBoxCustomFields.TabIndex = 24;
			this.groupBoxCustomFields.TabStop = false;
			this.groupBoxCustomFields.Text = "Custom Fields";
			// 
			// buttonDefineFields
			// 
			this.buttonDefineFields.Location = new System.Drawing.Point(128, 208);
			this.buttonDefineFields.Name = "buttonDefineFields";
			this.buttonDefineFields.Size = new System.Drawing.Size(99, 23);
			this.buttonDefineFields.TabIndex = 29;
			this.buttonDefineFields.Text = "Define Fields";
			this.buttonDefineFields.UseVisualStyleBackColor = true;
			// 
			// textBox19
			// 
			this.textBox19.Location = new System.Drawing.Point(80, 16);
			this.textBox19.Name = "textBox19";
			this.textBox19.Size = new System.Drawing.Size(144, 21);
			this.textBox19.TabIndex = 28;
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(8, 16);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(100, 23);
			this.label24.TabIndex = 27;
			this.label24.Text = "Label1";
			// 
			// checkBoxEligibleFor1099
			// 
			this.checkBoxEligibleFor1099.Location = new System.Drawing.Point(8, 200);
			this.checkBoxEligibleFor1099.Name = "checkBoxEligibleFor1099";
			this.checkBoxEligibleFor1099.Size = new System.Drawing.Size(152, 24);
			this.checkBoxEligibleFor1099.TabIndex = 16;
			this.checkBoxEligibleFor1099.Text = "Vendor eligible for 1099";
			this.checkBoxEligibleFor1099.UseVisualStyleBackColor = true;
			// 
			// textBoxTaxId
			// 
			this.textBoxTaxId.Location = new System.Drawing.Point(80, 176);
			this.textBoxTaxId.Name = "textBoxTaxId";
			this.textBoxTaxId.Size = new System.Drawing.Size(128, 21);
			this.textBoxTaxId.TabIndex = 15;
			// 
			// labelTaxId
			// 
			this.labelTaxId.Location = new System.Drawing.Point(8, 176);
			this.labelTaxId.Name = "labelTaxId";
			this.labelTaxId.Size = new System.Drawing.Size(100, 23);
			this.labelTaxId.TabIndex = 14;
			this.labelTaxId.Text = "Tax ID";
			// 
			// textBoxCreditLimit
			// 
			this.textBoxCreditLimit.Location = new System.Drawing.Point(80, 152);
			this.textBoxCreditLimit.Name = "textBoxCreditLimit";
			this.textBoxCreditLimit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBoxCreditLimit.Size = new System.Drawing.Size(128, 21);
			this.textBoxCreditLimit.TabIndex = 13;
			// 
			// labelCreditLimit
			// 
			this.labelCreditLimit.Location = new System.Drawing.Point(8, 152);
			this.labelCreditLimit.Name = "labelCreditLimit";
			this.labelCreditLimit.Size = new System.Drawing.Size(100, 23);
			this.labelCreditLimit.TabIndex = 12;
			this.labelCreditLimit.Text = "Credit Limit";
			// 
			// groupBoxCategorizingAndDefaults
			// 
			this.groupBoxCategorizingAndDefaults.Controls.Add(this.comboBoxTerms);
			this.groupBoxCategorizingAndDefaults.Controls.Add(this.labelTerms);
			this.groupBoxCategorizingAndDefaults.Controls.Add(this.comboBoxType);
			this.groupBoxCategorizingAndDefaults.Controls.Add(this.labelType);
			this.groupBoxCategorizingAndDefaults.Location = new System.Drawing.Point(8, 32);
			this.groupBoxCategorizingAndDefaults.Name = "groupBoxCategorizingAndDefaults";
			this.groupBoxCategorizingAndDefaults.Size = new System.Drawing.Size(200, 100);
			this.groupBoxCategorizingAndDefaults.TabIndex = 11;
			this.groupBoxCategorizingAndDefaults.TabStop = false;
			this.groupBoxCategorizingAndDefaults.Text = "Categorizing and Defaults";
			// 
			// comboBoxTerms
			// 
			this.comboBoxTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTerms.FormattingEnabled = true;
			this.comboBoxTerms.Location = new System.Drawing.Point(8, 72);
			this.comboBoxTerms.Name = "comboBoxTerms";
			this.comboBoxTerms.Size = new System.Drawing.Size(160, 21);
			this.comboBoxTerms.TabIndex = 3;
			// 
			// labelTerms
			// 
			this.labelTerms.Location = new System.Drawing.Point(8, 56);
			this.labelTerms.Name = "labelTerms";
			this.labelTerms.Size = new System.Drawing.Size(100, 23);
			this.labelTerms.TabIndex = 2;
			this.labelTerms.Text = "Terms";
			// 
			// comboBoxType
			// 
			this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Location = new System.Drawing.Point(8, 32);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(160, 21);
			this.comboBoxType.TabIndex = 1;
			// 
			// labelType
			// 
			this.labelType.Location = new System.Drawing.Point(8, 16);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(100, 23);
			this.labelType.TabIndex = 0;
			this.labelType.Text = "Type";
			// 
			// textBoxAccountNo
			// 
			this.textBoxAccountNo.Location = new System.Drawing.Point(80, 8);
			this.textBoxAccountNo.Name = "textBoxAccountNo";
			this.textBoxAccountNo.Size = new System.Drawing.Size(128, 21);
			this.textBoxAccountNo.TabIndex = 10;
			// 
			// labelAccountNo
			// 
			this.labelAccountNo.Location = new System.Drawing.Point(8, 8);
			this.labelAccountNo.Name = "labelAccountNo";
			this.labelAccountNo.Size = new System.Drawing.Size(100, 23);
			this.labelAccountNo.TabIndex = 9;
			this.labelAccountNo.Text = "Account No";
			// 
			// tabPageAccount
			// 
			this.tabPageAccount.Controls.Add(this.buttonClearAll);
			this.tabPageAccount.Controls.Add(this.comboBoxAccountPrefill3);
			this.tabPageAccount.Controls.Add(this.comboBoxAccountPrefill2);
			this.tabPageAccount.Controls.Add(this.comboBoxAccountPrefill1);
			this.tabPageAccount.Controls.Add(this.labelPrefillLabel);
			this.tabPageAccount.Location = new System.Drawing.Point(4, 22);
			this.tabPageAccount.Name = "tabPageAccount";
			this.tabPageAccount.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAccount.Size = new System.Drawing.Size(456, 342);
			this.tabPageAccount.TabIndex = 2;
			this.tabPageAccount.Text = "Account Prefill";
			this.tabPageAccount.UseVisualStyleBackColor = true;
			// 
			// buttonClearAll
			// 
			this.buttonClearAll.Location = new System.Drawing.Point(24, 144);
			this.buttonClearAll.Name = "buttonClearAll";
			this.buttonClearAll.Size = new System.Drawing.Size(75, 23);
			this.buttonClearAll.TabIndex = 4;
			this.buttonClearAll.Text = "Clear All";
			this.buttonClearAll.UseVisualStyleBackColor = true;
			// 
			// comboBoxAccountPrefill3
			// 
			this.comboBoxAccountPrefill3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAccountPrefill3.FormattingEnabled = true;
			this.comboBoxAccountPrefill3.Location = new System.Drawing.Point(24, 112);
			this.comboBoxAccountPrefill3.Name = "comboBoxAccountPrefill3";
			this.comboBoxAccountPrefill3.Size = new System.Drawing.Size(160, 21);
			this.comboBoxAccountPrefill3.TabIndex = 3;
			// 
			// comboBoxAccountPrefill2
			// 
			this.comboBoxAccountPrefill2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAccountPrefill2.FormattingEnabled = true;
			this.comboBoxAccountPrefill2.Location = new System.Drawing.Point(24, 80);
			this.comboBoxAccountPrefill2.Name = "comboBoxAccountPrefill2";
			this.comboBoxAccountPrefill2.Size = new System.Drawing.Size(160, 21);
			this.comboBoxAccountPrefill2.TabIndex = 2;
			// 
			// comboBoxAccountPrefill1
			// 
			this.comboBoxAccountPrefill1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAccountPrefill1.FormattingEnabled = true;
			this.comboBoxAccountPrefill1.Location = new System.Drawing.Point(24, 48);
			this.comboBoxAccountPrefill1.Name = "comboBoxAccountPrefill1";
			this.comboBoxAccountPrefill1.Size = new System.Drawing.Size(160, 21);
			this.comboBoxAccountPrefill1.TabIndex = 1;
			// 
			// labelPrefillLabel
			// 
			this.labelPrefillLabel.Location = new System.Drawing.Point(24, 24);
			this.labelPrefillLabel.Name = "labelPrefillLabel";
			this.labelPrefillLabel.Size = new System.Drawing.Size(192, 23);
			this.labelPrefillLabel.TabIndex = 0;
			this.labelPrefillLabel.Text = "Select accounts to pre-fill transactions";
			// 
			// textBoxBalance
			// 
			this.textBoxBalance.Location = new System.Drawing.Point(96, 32);
			this.textBoxBalance.Name = "textBoxBalance";
			this.textBoxBalance.Size = new System.Drawing.Size(96, 21);
			this.textBoxBalance.TabIndex = 169;
			this.textBoxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelBalance
			// 
			this.labelBalance.Location = new System.Drawing.Point(8, 32);
			this.labelBalance.Name = "labelBalance";
			this.labelBalance.Size = new System.Drawing.Size(100, 23);
			this.labelBalance.TabIndex = 168;
			this.labelBalance.Text = "Opening Balance";
			// 
			// checkBoxInactive
			// 
			this.checkBoxInactive.Location = new System.Drawing.Point(480, 104);
			this.checkBoxInactive.Name = "checkBoxInactive";
			this.checkBoxInactive.Size = new System.Drawing.Size(104, 36);
			this.checkBoxInactive.TabIndex = 167;
			this.checkBoxInactive.Text = "Vendor is inactive";
			this.checkBoxInactive.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(480, 40);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 166;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(480, 16);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 165;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(96, 8);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(256, 21);
			this.textBoxName.TabIndex = 164;
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(8, 8);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(100, 23);
			this.labelName.TabIndex = 163;
			this.labelName.Text = "Vendor Name";
			// 
			// VendorForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 431);
			this.Controls.Add(this.buttonNotes);
			this.Controls.Add(this.dateTimePickerBalanceAsOf);
			this.Controls.Add(this.labelBalanceAsOf);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.textBoxBalance);
			this.Controls.Add(this.labelBalance);
			this.Controls.Add(this.checkBoxInactive);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "VendorForm";
			this.Text = "New Vendor";
			this.tabControl1.ResumeLayout(false);
			this.tabPageAddress.ResumeLayout(false);
			this.tabPageAddress.PerformLayout();
			this.tabPageAdditional.ResumeLayout(false);
			this.tabPageAdditional.PerformLayout();
			this.groupBoxCustomFields.ResumeLayout(false);
			this.groupBoxCustomFields.PerformLayout();
			this.groupBoxCategorizingAndDefaults.ResumeLayout(false);
			this.tabPageAccount.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelBalance;
		private System.Windows.Forms.TextBox textBoxBalance;
		private System.Windows.Forms.Label labelPrefillLabel;
		private System.Windows.Forms.ComboBox comboBoxAccountPrefill1;
		private System.Windows.Forms.ComboBox comboBoxAccountPrefill2;
		private System.Windows.Forms.ComboBox comboBoxAccountPrefill3;
		private System.Windows.Forms.Button buttonClearAll;
		private System.Windows.Forms.TabPage tabPageAccount;
		private System.Windows.Forms.Label labelAccountNo;
		private System.Windows.Forms.TextBox textBoxAccountNo;
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.ComboBox comboBoxType;
		private System.Windows.Forms.Label labelTerms;
		private System.Windows.Forms.ComboBox comboBoxTerms;
		private System.Windows.Forms.GroupBox groupBoxCategorizingAndDefaults;
		private System.Windows.Forms.Label labelCreditLimit;
		private System.Windows.Forms.TextBox textBoxCreditLimit;
		private System.Windows.Forms.Label labelTaxId;
		private System.Windows.Forms.TextBox textBoxTaxId;
		private System.Windows.Forms.CheckBox checkBoxEligibleFor1099;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.Button buttonDefineFields;
		private System.Windows.Forms.GroupBox groupBoxCustomFields;
		private System.Windows.Forms.TabPage tabPageAdditional;
		private System.Windows.Forms.Label labelCompanyName;
		private System.Windows.Forms.TextBox textBoxCompanyName;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.Label labelFirstName;
		private System.Windows.Forms.TextBox textBoxFirstName;
		private System.Windows.Forms.Label labelMI;
		private System.Windows.Forms.TextBox textBoxMI;
		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.TextBox textBoxLastName;
		private System.Windows.Forms.Label labelContact;
		private System.Windows.Forms.TextBox textBoxContact;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.Label labelFax;
		private System.Windows.Forms.TextBox textBoxFax;
		private System.Windows.Forms.Label labelAltPhone;
		private System.Windows.Forms.TextBox textBoxAltPhone;
		private System.Windows.Forms.Label labelAltContact;
		private System.Windows.Forms.TextBox textBoxAltContact;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Label labelCC;
		private System.Windows.Forms.TextBox textBoxCC;
		private System.Windows.Forms.Label labelAddress;
		private System.Windows.Forms.RichTextBox richTextBoxAddress;
		private System.Windows.Forms.Button buttonAddressDetails;
		private System.Windows.Forms.Label labelPrintOnCheckAs;
		private System.Windows.Forms.TextBox textBoxPrintOnCheckAs;
		private System.Windows.Forms.TabPage tabPageAddress;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label labelBalanceAsOf;
		private System.Windows.Forms.DateTimePicker dateTimePickerBalanceAsOf;
		private System.Windows.Forms.Button buttonNotes;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.CheckBox checkBoxInactive;
	}
}
