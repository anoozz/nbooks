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
	partial class SalesRepForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesRepForm));
			this.buttonNotes = new System.Windows.Forms.Button();
			this.checkBoxInactive = new System.Windows.Forms.CheckBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
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
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonNotes
			// 
			this.buttonNotes.Location = new System.Drawing.Point(472, 64);
			this.buttonNotes.Name = "buttonNotes";
			this.buttonNotes.Size = new System.Drawing.Size(75, 23);
			this.buttonNotes.TabIndex = 83;
			this.buttonNotes.Text = "Notes";
			this.buttonNotes.UseVisualStyleBackColor = true;
			this.buttonNotes.Visible = false;
			this.buttonNotes.Click += new System.EventHandler(this.ButtonNotesClick);
			// 
			// checkBoxInactive
			// 
			this.checkBoxInactive.Location = new System.Drawing.Point(472, 112);
			this.checkBoxInactive.Name = "checkBoxInactive";
			this.checkBoxInactive.Size = new System.Drawing.Size(104, 36);
			this.checkBoxInactive.TabIndex = 82;
			this.checkBoxInactive.Text = "Other name is inactive";
			this.checkBoxInactive.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(472, 40);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 81;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(472, 16);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 80;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxPrintOnCheckAs);
			this.groupBox1.Controls.Add(this.labelPrintOnCheckAs);
			this.groupBox1.Controls.Add(this.buttonAddressDetails);
			this.groupBox1.Controls.Add(this.richTextBoxAddress);
			this.groupBox1.Controls.Add(this.labelAddress);
			this.groupBox1.Controls.Add(this.textBoxCC);
			this.groupBox1.Controls.Add(this.labelCC);
			this.groupBox1.Controls.Add(this.textBoxEmail);
			this.groupBox1.Controls.Add(this.labelEmail);
			this.groupBox1.Controls.Add(this.textBoxAltContact);
			this.groupBox1.Controls.Add(this.labelAltContact);
			this.groupBox1.Controls.Add(this.textBoxAltPhone);
			this.groupBox1.Controls.Add(this.labelAltPhone);
			this.groupBox1.Controls.Add(this.textBoxFax);
			this.groupBox1.Controls.Add(this.labelFax);
			this.groupBox1.Controls.Add(this.textBoxPhone);
			this.groupBox1.Controls.Add(this.labelPhone);
			this.groupBox1.Controls.Add(this.textBoxContact);
			this.groupBox1.Controls.Add(this.labelContact);
			this.groupBox1.Controls.Add(this.textBoxLastName);
			this.groupBox1.Controls.Add(this.labelLastName);
			this.groupBox1.Controls.Add(this.textBoxMI);
			this.groupBox1.Controls.Add(this.labelMI);
			this.groupBox1.Controls.Add(this.textBoxFirstName);
			this.groupBox1.Controls.Add(this.labelFirstName);
			this.groupBox1.Controls.Add(this.textBoxTitle);
			this.groupBox1.Controls.Add(this.labelTitle);
			this.groupBox1.Controls.Add(this.textBoxCompanyName);
			this.groupBox1.Controls.Add(this.labelCompanyName);
			this.groupBox1.Location = new System.Drawing.Point(8, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(456, 256);
			this.groupBox1.TabIndex = 79;
			this.groupBox1.TabStop = false;
			// 
			// textBoxPrintOnCheckAs
			// 
			this.textBoxPrintOnCheckAs.Location = new System.Drawing.Point(240, 200);
			this.textBoxPrintOnCheckAs.Name = "textBoxPrintOnCheckAs";
			this.textBoxPrintOnCheckAs.Size = new System.Drawing.Size(208, 21);
			this.textBoxPrintOnCheckAs.TabIndex = 65;
			// 
			// labelPrintOnCheckAs
			// 
			this.labelPrintOnCheckAs.Location = new System.Drawing.Point(240, 184);
			this.labelPrintOnCheckAs.Name = "labelPrintOnCheckAs";
			this.labelPrintOnCheckAs.Size = new System.Drawing.Size(100, 23);
			this.labelPrintOnCheckAs.TabIndex = 64;
			this.labelPrintOnCheckAs.Text = "Print on Check As";
			// 
			// buttonAddressDetails
			// 
			this.buttonAddressDetails.Location = new System.Drawing.Point(88, 200);
			this.buttonAddressDetails.Name = "buttonAddressDetails";
			this.buttonAddressDetails.Size = new System.Drawing.Size(104, 23);
			this.buttonAddressDetails.TabIndex = 63;
			this.buttonAddressDetails.Text = "Address Details";
			this.buttonAddressDetails.UseVisualStyleBackColor = true;
			// 
			// richTextBoxAddress
			// 
			this.richTextBoxAddress.Location = new System.Drawing.Point(88, 112);
			this.richTextBoxAddress.Name = "richTextBoxAddress";
			this.richTextBoxAddress.Size = new System.Drawing.Size(144, 80);
			this.richTextBoxAddress.TabIndex = 62;
			this.richTextBoxAddress.Text = "";
			// 
			// labelAddress
			// 
			this.labelAddress.Location = new System.Drawing.Point(8, 112);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(100, 23);
			this.labelAddress.TabIndex = 61;
			this.labelAddress.Text = "Address";
			// 
			// textBoxCC
			// 
			this.textBoxCC.Location = new System.Drawing.Point(304, 160);
			this.textBoxCC.Name = "textBoxCC";
			this.textBoxCC.Size = new System.Drawing.Size(144, 21);
			this.textBoxCC.TabIndex = 60;
			// 
			// labelCC
			// 
			this.labelCC.Location = new System.Drawing.Point(240, 160);
			this.labelCC.Name = "labelCC";
			this.labelCC.Size = new System.Drawing.Size(100, 23);
			this.labelCC.TabIndex = 59;
			this.labelCC.Text = "CC";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(304, 136);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(144, 21);
			this.textBoxEmail.TabIndex = 58;
			// 
			// labelEmail
			// 
			this.labelEmail.Location = new System.Drawing.Point(240, 136);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(100, 23);
			this.labelEmail.TabIndex = 57;
			this.labelEmail.Text = "Email";
			// 
			// textBoxAltContact
			// 
			this.textBoxAltContact.Location = new System.Drawing.Point(304, 112);
			this.textBoxAltContact.Name = "textBoxAltContact";
			this.textBoxAltContact.Size = new System.Drawing.Size(144, 21);
			this.textBoxAltContact.TabIndex = 56;
			// 
			// labelAltContact
			// 
			this.labelAltContact.Location = new System.Drawing.Point(240, 112);
			this.labelAltContact.Name = "labelAltContact";
			this.labelAltContact.Size = new System.Drawing.Size(100, 23);
			this.labelAltContact.TabIndex = 55;
			this.labelAltContact.Text = "Alt Contact";
			// 
			// textBoxAltPhone
			// 
			this.textBoxAltPhone.Location = new System.Drawing.Point(304, 88);
			this.textBoxAltPhone.Name = "textBoxAltPhone";
			this.textBoxAltPhone.Size = new System.Drawing.Size(144, 21);
			this.textBoxAltPhone.TabIndex = 54;
			// 
			// labelAltPhone
			// 
			this.labelAltPhone.Location = new System.Drawing.Point(240, 88);
			this.labelAltPhone.Name = "labelAltPhone";
			this.labelAltPhone.Size = new System.Drawing.Size(100, 23);
			this.labelAltPhone.TabIndex = 53;
			this.labelAltPhone.Text = "Alt Phone";
			// 
			// textBoxFax
			// 
			this.textBoxFax.Location = new System.Drawing.Point(304, 64);
			this.textBoxFax.Name = "textBoxFax";
			this.textBoxFax.Size = new System.Drawing.Size(144, 21);
			this.textBoxFax.TabIndex = 52;
			// 
			// labelFax
			// 
			this.labelFax.Location = new System.Drawing.Point(240, 64);
			this.labelFax.Name = "labelFax";
			this.labelFax.Size = new System.Drawing.Size(100, 23);
			this.labelFax.TabIndex = 51;
			this.labelFax.Text = "Fax";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Location = new System.Drawing.Point(304, 40);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(144, 21);
			this.textBoxPhone.TabIndex = 50;
			// 
			// labelPhone
			// 
			this.labelPhone.Location = new System.Drawing.Point(240, 40);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(100, 23);
			this.labelPhone.TabIndex = 49;
			this.labelPhone.Text = "Phone";
			// 
			// textBoxContact
			// 
			this.textBoxContact.Location = new System.Drawing.Point(304, 16);
			this.textBoxContact.Name = "textBoxContact";
			this.textBoxContact.Size = new System.Drawing.Size(144, 21);
			this.textBoxContact.TabIndex = 48;
			// 
			// labelContact
			// 
			this.labelContact.Location = new System.Drawing.Point(240, 16);
			this.labelContact.Name = "labelContact";
			this.labelContact.Size = new System.Drawing.Size(100, 23);
			this.labelContact.TabIndex = 47;
			this.labelContact.Text = "Contact";
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(88, 88);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(144, 21);
			this.textBoxLastName.TabIndex = 46;
			// 
			// labelLastName
			// 
			this.labelLastName.Location = new System.Drawing.Point(8, 88);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(100, 23);
			this.labelLastName.TabIndex = 45;
			this.labelLastName.Text = "Last Name";
			// 
			// textBoxMI
			// 
			this.textBoxMI.Location = new System.Drawing.Point(208, 64);
			this.textBoxMI.Name = "textBoxMI";
			this.textBoxMI.Size = new System.Drawing.Size(24, 21);
			this.textBoxMI.TabIndex = 44;
			// 
			// labelMI
			// 
			this.labelMI.Location = new System.Drawing.Point(184, 64);
			this.labelMI.Name = "labelMI";
			this.labelMI.Size = new System.Drawing.Size(32, 23);
			this.labelMI.TabIndex = 43;
			this.labelMI.Text = "MI";
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Location = new System.Drawing.Point(88, 64);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(88, 21);
			this.textBoxFirstName.TabIndex = 42;
			// 
			// labelFirstName
			// 
			this.labelFirstName.Location = new System.Drawing.Point(8, 64);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(100, 23);
			this.labelFirstName.TabIndex = 41;
			this.labelFirstName.Text = "First Name";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(88, 40);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(144, 21);
			this.textBoxTitle.TabIndex = 40;
			// 
			// labelTitle
			// 
			this.labelTitle.Location = new System.Drawing.Point(8, 40);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(100, 23);
			this.labelTitle.TabIndex = 39;
			this.labelTitle.Text = "Mr./Ms./...";
			// 
			// textBoxCompanyName
			// 
			this.textBoxCompanyName.Location = new System.Drawing.Point(88, 16);
			this.textBoxCompanyName.Name = "textBoxCompanyName";
			this.textBoxCompanyName.Size = new System.Drawing.Size(144, 21);
			this.textBoxCompanyName.TabIndex = 38;
			// 
			// labelCompanyName
			// 
			this.labelCompanyName.Location = new System.Drawing.Point(8, 16);
			this.labelCompanyName.Name = "labelCompanyName";
			this.labelCompanyName.Size = new System.Drawing.Size(100, 23);
			this.labelCompanyName.TabIndex = 37;
			this.labelCompanyName.Text = "Company Name";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(96, 8);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(256, 21);
			this.textBoxName.TabIndex = 78;
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(8, 8);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(100, 23);
			this.labelName.TabIndex = 77;
			this.labelName.Text = "Name";
			// 
			// SalesRepForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.Add(this.buttonNotes);
			this.Controls.Add(this.checkBoxInactive);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SalesRepForm";
			this.Text = "New Salesman";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labelName;
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
		private System.Windows.Forms.Button buttonAddressDetails;
		private System.Windows.Forms.Label labelPrintOnCheckAs;
		private System.Windows.Forms.TextBox textBoxPrintOnCheckAs;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonNotes;
		private System.Windows.Forms.RichTextBox richTextBoxAddress;
		private System.Windows.Forms.CheckBox checkBoxInactive;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
	}
}
