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
	partial class CompanyForm
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
			this.buttonShipToAddress = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.textBoxPhone2 = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.textBoxContact = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBoxSSN = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.textBoxEIN = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.comboBoxIncomeTaxForm = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.comboBoxTaxYear = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.comboBoxFiscalYear = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBoxLegalCountry = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxZip = new System.Windows.Forms.TextBox();
			this.comboBoxState = new System.Windows.Forms.ComboBox();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxLegalAddress2 = new System.Windows.Forms.TextBox();
			this.textBoxLegalAddress = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxLegalName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxWebsite = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxFax = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxCountry = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonShipToAddress
			// 
			this.buttonShipToAddress.Location = new System.Drawing.Point(544, 88);
			this.buttonShipToAddress.Name = "buttonShipToAddress";
			this.buttonShipToAddress.Size = new System.Drawing.Size(136, 23);
			this.buttonShipToAddress.TabIndex = 17;
			this.buttonShipToAddress.Text = "Ship to Address...";
			this.buttonShipToAddress.UseVisualStyleBackColor = true;
			this.buttonShipToAddress.Click += new System.EventHandler(this.ButtonShipToAddressClick);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(544, 40);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(136, 23);
			this.buttonCancel.TabIndex = 15;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(544, 16);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(136, 23);
			this.buttonOk.TabIndex = 14;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.textBoxPhone2);
			this.groupBox5.Controls.Add(this.label21);
			this.groupBox5.Controls.Add(this.textBoxTitle);
			this.groupBox5.Controls.Add(this.label20);
			this.groupBox5.Controls.Add(this.textBoxContact);
			this.groupBox5.Controls.Add(this.label19);
			this.groupBox5.Controls.Add(this.label18);
			this.groupBox5.Location = new System.Drawing.Point(392, 264);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(288, 128);
			this.groupBox5.TabIndex = 13;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Payroll Tax Form Information";
			// 
			// textBoxPhone2
			// 
			this.textBoxPhone2.Location = new System.Drawing.Point(72, 96);
			this.textBoxPhone2.Name = "textBoxPhone2";
			this.textBoxPhone2.Size = new System.Drawing.Size(104, 21);
			this.textBoxPhone2.TabIndex = 6;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(8, 96);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(100, 23);
			this.label21.TabIndex = 5;
			this.label21.Text = "Phone";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(72, 72);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(208, 21);
			this.textBoxTitle.TabIndex = 4;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(8, 72);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(100, 23);
			this.label20.TabIndex = 3;
			this.label20.Text = "Title";
			// 
			// textBoxContact
			// 
			this.textBoxContact.Location = new System.Drawing.Point(72, 16);
			this.textBoxContact.Name = "textBoxContact";
			this.textBoxContact.Size = new System.Drawing.Size(208, 21);
			this.textBoxContact.TabIndex = 2;
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(8, 40);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(272, 23);
			this.label19.TabIndex = 1;
			this.label19.Text = "(Name of person preparing and signing payroll tax forms)";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(8, 16);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 23);
			this.label18.TabIndex = 0;
			this.label18.Text = "Contact";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBoxSSN);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.textBoxEIN);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Location = new System.Drawing.Point(392, 152);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(288, 112);
			this.groupBox4.TabIndex = 12;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Company Identification";
			// 
			// textBoxSSN
			// 
			this.textBoxSSN.Location = new System.Drawing.Point(184, 56);
			this.textBoxSSN.Name = "textBoxSSN";
			this.textBoxSSN.Size = new System.Drawing.Size(96, 21);
			this.textBoxSSN.TabIndex = 3;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(8, 56);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(184, 48);
			this.label17.TabIndex = 2;
			this.label17.Text = "Social Security Number\r\n(SSN is used on 1099\'s if\r\nno EIN is entered)";
			// 
			// textBoxEIN
			// 
			this.textBoxEIN.Location = new System.Drawing.Point(184, 16);
			this.textBoxEIN.Name = "textBoxEIN";
			this.textBoxEIN.Size = new System.Drawing.Size(96, 21);
			this.textBoxEIN.TabIndex = 1;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(8, 16);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(184, 32);
			this.label16.TabIndex = 0;
			this.label16.Text = "Federal Employer Identification No.\r\n(EIN is required for Payroll)";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.comboBoxIncomeTaxForm);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.comboBoxTaxYear);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.comboBoxFiscalYear);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Location = new System.Drawing.Point(8, 296);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(376, 96);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Report Information";
			// 
			// comboBoxIncomeTaxForm
			// 
			this.comboBoxIncomeTaxForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxIncomeTaxForm.FormattingEnabled = true;
			this.comboBoxIncomeTaxForm.Items.AddRange(new object[] {
									"Form 1120 (Corporation)",
									"Form 1120S (S Corporation)",
									"Form 1065 (Partnership)",
									"Form 990 (Exempt Organization)",
									"Form 990-PF (Ret of Priv Foundn)",
									"Form 990-T (Bux Tx Ret)",
									"Form 1040 (Sole Proprietor)",
									"<Other/None>"});
			this.comboBoxIncomeTaxForm.Location = new System.Drawing.Point(144, 64);
			this.comboBoxIncomeTaxForm.Name = "comboBoxIncomeTaxForm";
			this.comboBoxIncomeTaxForm.Size = new System.Drawing.Size(216, 21);
			this.comboBoxIncomeTaxForm.TabIndex = 19;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(24, 64);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(120, 23);
			this.label15.TabIndex = 18;
			this.label15.Text = "Income Tax Form Used";
			// 
			// comboBoxTaxYear
			// 
			this.comboBoxTaxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTaxYear.FormattingEnabled = true;
			this.comboBoxTaxYear.Items.AddRange(new object[] {
									"January",
									"February",
									"March",
									"April",
									"May",
									"June",
									"July",
									"August",
									"September",
									"October",
									"November",
									"December"});
			this.comboBoxTaxYear.Location = new System.Drawing.Point(232, 40);
			this.comboBoxTaxYear.Name = "comboBoxTaxYear";
			this.comboBoxTaxYear.Size = new System.Drawing.Size(80, 21);
			this.comboBoxTaxYear.TabIndex = 17;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(176, 40);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 16;
			this.label14.Text = "Tax Year";
			// 
			// comboBoxFiscalYear
			// 
			this.comboBoxFiscalYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFiscalYear.FormattingEnabled = true;
			this.comboBoxFiscalYear.Items.AddRange(new object[] {
									"January",
									"February",
									"March",
									"April",
									"May",
									"June",
									"July",
									"August",
									"September",
									"October",
									"November",
									"December"});
			this.comboBoxFiscalYear.Location = new System.Drawing.Point(88, 40);
			this.comboBoxFiscalYear.Name = "comboBoxFiscalYear";
			this.comboBoxFiscalYear.Size = new System.Drawing.Size(80, 21);
			this.comboBoxFiscalYear.TabIndex = 15;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(24, 40);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 14;
			this.label13.Text = "Fiscal Year";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(144, 23);
			this.label12.TabIndex = 0;
			this.label12.Text = "Firsth month in your:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBoxLegalCountry);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.textBoxZip);
			this.groupBox2.Controls.Add(this.comboBoxState);
			this.groupBox2.Controls.Add(this.textBoxCity);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.textBoxLegalAddress2);
			this.groupBox2.Controls.Add(this.textBoxLegalAddress);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.textBoxLegalName);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Location = new System.Drawing.Point(8, 152);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(376, 144);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Legal Information";
			// 
			// comboBoxLegalCountry
			// 
			this.comboBoxLegalCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLegalCountry.FormattingEnabled = true;
			this.comboBoxLegalCountry.Location = new System.Drawing.Point(88, 112);
			this.comboBoxLegalCountry.Name = "comboBoxLegalCountry";
			this.comboBoxLegalCountry.Size = new System.Drawing.Size(104, 21);
			this.comboBoxLegalCountry.TabIndex = 13;
			this.comboBoxLegalCountry.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLegalCountrySelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 112);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 12;
			this.label11.Text = "Legal Country";
			// 
			// textBoxZip
			// 
			this.textBoxZip.Location = new System.Drawing.Point(240, 88);
			this.textBoxZip.Name = "textBoxZip";
			this.textBoxZip.Size = new System.Drawing.Size(80, 21);
			this.textBoxZip.TabIndex = 11;
			// 
			// comboBoxState
			// 
			this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxState.FormattingEnabled = true;
			this.comboBoxState.Location = new System.Drawing.Point(184, 88);
			this.comboBoxState.Name = "comboBoxState";
			this.comboBoxState.Size = new System.Drawing.Size(48, 21);
			this.comboBoxState.TabIndex = 10;
			// 
			// textBoxCity
			// 
			this.textBoxCity.Location = new System.Drawing.Point(88, 88);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(88, 21);
			this.textBoxCity.TabIndex = 9;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 88);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 8;
			this.label10.Text = "City/State/ZIP";
			// 
			// textBoxLegalAddress2
			// 
			this.textBoxLegalAddress2.Location = new System.Drawing.Point(88, 64);
			this.textBoxLegalAddress2.Name = "textBoxLegalAddress2";
			this.textBoxLegalAddress2.Size = new System.Drawing.Size(184, 21);
			this.textBoxLegalAddress2.TabIndex = 7;
			// 
			// textBoxLegalAddress
			// 
			this.textBoxLegalAddress.Location = new System.Drawing.Point(88, 40);
			this.textBoxLegalAddress.Name = "textBoxLegalAddress";
			this.textBoxLegalAddress.Size = new System.Drawing.Size(184, 21);
			this.textBoxLegalAddress.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 4;
			this.label9.Text = "Legal Address";
			// 
			// textBoxLegalName
			// 
			this.textBoxLegalName.Location = new System.Drawing.Point(88, 16);
			this.textBoxLegalName.Name = "textBoxLegalName";
			this.textBoxLegalName.Size = new System.Drawing.Size(184, 21);
			this.textBoxLegalName.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 2;
			this.label8.Text = "Legal Name";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxWebsite);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.textBoxEmail);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textBoxFax);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBoxPhone);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.comboBoxCountry);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.richTextBoxAddress);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBoxName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(528, 144);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Contact Information";
			// 
			// textBoxWebsite
			// 
			this.textBoxWebsite.Location = new System.Drawing.Point(336, 112);
			this.textBoxWebsite.Name = "textBoxWebsite";
			this.textBoxWebsite.Size = new System.Drawing.Size(160, 21);
			this.textBoxWebsite.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(280, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Website";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(336, 88);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(160, 21);
			this.textBoxEmail.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(280, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Email";
			// 
			// textBoxFax
			// 
			this.textBoxFax.Location = new System.Drawing.Point(336, 64);
			this.textBoxFax.Name = "textBoxFax";
			this.textBoxFax.Size = new System.Drawing.Size(160, 21);
			this.textBoxFax.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(280, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Fax";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Location = new System.Drawing.Point(336, 40);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(160, 21);
			this.textBoxPhone.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(280, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Phone";
			// 
			// comboBoxCountry
			// 
			this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCountry.FormattingEnabled = true;
			this.comboBoxCountry.Location = new System.Drawing.Point(88, 112);
			this.comboBoxCountry.Name = "comboBoxCountry";
			this.comboBoxCountry.Size = new System.Drawing.Size(104, 21);
			this.comboBoxCountry.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Country";
			// 
			// richTextBoxAddress
			// 
			this.richTextBoxAddress.Location = new System.Drawing.Point(88, 40);
			this.richTextBoxAddress.Name = "richTextBoxAddress";
			this.richTextBoxAddress.Size = new System.Drawing.Size(184, 64);
			this.richTextBoxAddress.TabIndex = 3;
			this.richTextBoxAddress.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Address";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(88, 16);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(216, 21);
			this.textBoxName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Company Name";
			// 
			// CompanyForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(687, 402);
			this.Controls.Add(this.buttonShipToAddress);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "CompanyForm";
			this.Text = "Company Information";
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox textBoxPhone2;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.TextBox textBoxContact;
		private System.Windows.Forms.TextBox textBoxSSN;
		private System.Windows.Forms.TextBox textBoxEIN;
		private System.Windows.Forms.ComboBox comboBoxIncomeTaxForm;
		private System.Windows.Forms.ComboBox comboBoxTaxYear;
		private System.Windows.Forms.ComboBox comboBoxFiscalYear;
		private System.Windows.Forms.ComboBox comboBoxLegalCountry;
		private System.Windows.Forms.TextBox textBoxZip;
		private System.Windows.Forms.ComboBox comboBoxState;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.TextBox textBoxLegalAddress2;
		private System.Windows.Forms.TextBox textBoxLegalAddress;
		private System.Windows.Forms.TextBox textBoxLegalName;
		private System.Windows.Forms.TextBox textBoxWebsite;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.TextBox textBoxFax;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.ComboBox comboBoxCountry;
		private System.Windows.Forms.RichTextBox richTextBoxAddress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonShipToAddress;
	}
}
