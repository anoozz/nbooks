//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class CustomerForm
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
			this.buttonNotes = new System.Windows.Forms.Button();
			this.dateTimePickerBalanceAsOf = new System.Windows.Forms.DateTimePicker();
			this.labelBalanceAsOf = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageAddress = new System.Windows.Forms.TabPage();
			this.groupBoxAddresses = new System.Windows.Forms.GroupBox();
			this.buttonShipTo = new System.Windows.Forms.Button();
			this.buttonBillTo = new System.Windows.Forms.Button();
			this.richTextBoxShipTo = new System.Windows.Forms.RichTextBox();
			this.labelShipTo = new System.Windows.Forms.Label();
			this.buttonCopyAddress = new System.Windows.Forms.Button();
			this.richTextBoxBillTo = new System.Windows.Forms.RichTextBox();
			this.labelBillTo = new System.Windows.Forms.Label();
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
			this.label26 = new System.Windows.Forms.Label();
			this.groupBoxSalesTaxInformation = new System.Windows.Forms.GroupBox();
			this.textBoxResaleNumber = new System.Windows.Forms.TextBox();
			this.labelResaleNo = new System.Windows.Forms.Label();
			this.comboBoxTaxItem = new System.Windows.Forms.ComboBox();
			this.labelTaxItem = new System.Windows.Forms.Label();
			this.comboBoxTaxCode = new System.Windows.Forms.ComboBox();
			this.labelTaxCode = new System.Windows.Forms.Label();
			this.comboBoxPriceLevel = new System.Windows.Forms.ComboBox();
			this.labelPriceLevel = new System.Windows.Forms.Label();
			this.groupBoxCategorizingAndDefaults = new System.Windows.Forms.GroupBox();
			this.comboBoxSendMethod = new System.Windows.Forms.ComboBox();
			this.labelPreferredSendMethod = new System.Windows.Forms.Label();
			this.comboBoxSalesRep = new System.Windows.Forms.ComboBox();
			this.labelRep = new System.Windows.Forms.Label();
			this.comboBoxTerms = new System.Windows.Forms.ComboBox();
			this.labelTerms = new System.Windows.Forms.Label();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.labelType = new System.Windows.Forms.Label();
			this.tabPagePayment = new System.Windows.Forms.TabPage();
			this.groupBoxPreferredPaymentMethod = new System.Windows.Forms.GroupBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.textBoxZipCode = new System.Windows.Forms.TextBox();
			this.labelZipCode = new System.Windows.Forms.Label();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.labelAddress = new System.Windows.Forms.Label();
			this.textBoxNameOnCard = new System.Windows.Forms.TextBox();
			this.labelNameOnCard = new System.Windows.Forms.Label();
			this.textBoxExpYear = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.textBoxExpMonth = new System.Windows.Forms.TextBox();
			this.labelExpDate = new System.Windows.Forms.Label();
			this.textBoxCreditCardNo = new System.Windows.Forms.TextBox();
			this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
			this.labelCreditCardNo = new System.Windows.Forms.Label();
			this.textBoxCreditLimit = new System.Windows.Forms.TextBox();
			this.labelCreditLimit = new System.Windows.Forms.Label();
			this.textBoxAccountNo = new System.Windows.Forms.TextBox();
			this.labelAccountNo = new System.Windows.Forms.Label();
			this.tabPageJob = new System.Windows.Forms.TabPage();
			this.comboBoxJobType = new System.Windows.Forms.ComboBox();
			this.labelJobType = new System.Windows.Forms.Label();
			this.textBoxJobDescription = new System.Windows.Forms.TextBox();
			this.labelJobDescription = new System.Windows.Forms.Label();
			this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
			this.labelEndDate = new System.Windows.Forms.Label();
			this.dateTimePickerProjectedEnd = new System.Windows.Forms.DateTimePicker();
			this.labelProjectedEnd = new System.Windows.Forms.Label();
			this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
			this.labelStartDate = new System.Windows.Forms.Label();
			this.comboBoxJobStatus = new System.Windows.Forms.ComboBox();
			this.labelJobStatus = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonNew = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.textBoxBalance = new System.Windows.Forms.TextBox();
			this.labelBalance = new System.Windows.Forms.Label();
			this.checkBoxInactive = new System.Windows.Forms.CheckBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPageAddress.SuspendLayout();
			this.groupBoxAddresses.SuspendLayout();
			this.tabPageAdditional.SuspendLayout();
			this.groupBoxCustomFields.SuspendLayout();
			this.groupBoxSalesTaxInformation.SuspendLayout();
			this.groupBoxCategorizingAndDefaults.SuspendLayout();
			this.tabPagePayment.SuspendLayout();
			this.groupBoxPreferredPaymentMethod.SuspendLayout();
			this.tabPageJob.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonNotes
			// 
			this.buttonNotes.Location = new System.Drawing.Point(480, 64);
			this.buttonNotes.Name = "buttonNotes";
			this.buttonNotes.Size = new System.Drawing.Size(75, 23);
			this.buttonNotes.TabIndex = 170;
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
			this.dateTimePickerBalanceAsOf.TabIndex = 169;
			// 
			// labelBalanceAsOf
			// 
			this.labelBalanceAsOf.Location = new System.Drawing.Point(200, 32);
			this.labelBalanceAsOf.Name = "labelBalanceAsOf";
			this.labelBalanceAsOf.Size = new System.Drawing.Size(100, 23);
			this.labelBalanceAsOf.TabIndex = 168;
			this.labelBalanceAsOf.Text = "as of";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageAddress);
			this.tabControl1.Controls.Add(this.tabPageAdditional);
			this.tabControl1.Controls.Add(this.tabPagePayment);
			this.tabControl1.Controls.Add(this.tabPageJob);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(8, 56);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(464, 368);
			this.tabControl1.TabIndex = 167;
			// 
			// tabPageAddress
			// 
			this.tabPageAddress.Controls.Add(this.groupBoxAddresses);
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
			// groupBoxAddresses
			// 
			this.groupBoxAddresses.Controls.Add(this.buttonShipTo);
			this.groupBoxAddresses.Controls.Add(this.buttonBillTo);
			this.groupBoxAddresses.Controls.Add(this.richTextBoxShipTo);
			this.groupBoxAddresses.Controls.Add(this.labelShipTo);
			this.groupBoxAddresses.Controls.Add(this.buttonCopyAddress);
			this.groupBoxAddresses.Controls.Add(this.richTextBoxBillTo);
			this.groupBoxAddresses.Controls.Add(this.labelBillTo);
			this.groupBoxAddresses.Location = new System.Drawing.Point(8, 176);
			this.groupBoxAddresses.Name = "groupBoxAddresses";
			this.groupBoxAddresses.Size = new System.Drawing.Size(440, 152);
			this.groupBoxAddresses.TabIndex = 31;
			this.groupBoxAddresses.TabStop = false;
			this.groupBoxAddresses.Text = "Addresses";
			// 
			// buttonShipTo
			// 
			this.buttonShipTo.Location = new System.Drawing.Point(240, 120);
			this.buttonShipTo.Name = "buttonShipTo";
			this.buttonShipTo.Size = new System.Drawing.Size(104, 23);
			this.buttonShipTo.TabIndex = 6;
			this.buttonShipTo.Text = "Address Details";
			this.buttonShipTo.UseVisualStyleBackColor = true;
			this.buttonShipTo.Click += new System.EventHandler(this.ButtonShipToClick);
			// 
			// buttonBillTo
			// 
			this.buttonBillTo.Location = new System.Drawing.Point(8, 120);
			this.buttonBillTo.Name = "buttonBillTo";
			this.buttonBillTo.Size = new System.Drawing.Size(104, 23);
			this.buttonBillTo.TabIndex = 5;
			this.buttonBillTo.Text = "Address Details";
			this.buttonBillTo.UseVisualStyleBackColor = true;
			this.buttonBillTo.Click += new System.EventHandler(this.ButtonBillToClick);
			// 
			// richTextBoxShipTo
			// 
			this.richTextBoxShipTo.Location = new System.Drawing.Point(240, 32);
			this.richTextBoxShipTo.Name = "richTextBoxShipTo";
			this.richTextBoxShipTo.Size = new System.Drawing.Size(152, 80);
			this.richTextBoxShipTo.TabIndex = 4;
			this.richTextBoxShipTo.Text = "";
			// 
			// labelShipTo
			// 
			this.labelShipTo.Location = new System.Drawing.Point(240, 16);
			this.labelShipTo.Name = "labelShipTo";
			this.labelShipTo.Size = new System.Drawing.Size(100, 23);
			this.labelShipTo.TabIndex = 3;
			this.labelShipTo.Text = "Ship To";
			// 
			// buttonCopyAddress
			// 
			this.buttonCopyAddress.Location = new System.Drawing.Point(168, 56);
			this.buttonCopyAddress.Name = "buttonCopyAddress";
			this.buttonCopyAddress.Size = new System.Drawing.Size(64, 23);
			this.buttonCopyAddress.TabIndex = 2;
			this.buttonCopyAddress.Text = "Copy >>";
			this.buttonCopyAddress.UseVisualStyleBackColor = true;
			// 
			// richTextBoxBillTo
			// 
			this.richTextBoxBillTo.Location = new System.Drawing.Point(8, 32);
			this.richTextBoxBillTo.Name = "richTextBoxBillTo";
			this.richTextBoxBillTo.Size = new System.Drawing.Size(152, 80);
			this.richTextBoxBillTo.TabIndex = 1;
			this.richTextBoxBillTo.Text = "";
			// 
			// labelBillTo
			// 
			this.labelBillTo.Location = new System.Drawing.Point(8, 16);
			this.labelBillTo.Name = "labelBillTo";
			this.labelBillTo.Size = new System.Drawing.Size(100, 23);
			this.labelBillTo.TabIndex = 0;
			this.labelBillTo.Text = "Bill To";
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
			this.tabPageAdditional.Controls.Add(this.groupBoxSalesTaxInformation);
			this.tabPageAdditional.Controls.Add(this.comboBoxPriceLevel);
			this.tabPageAdditional.Controls.Add(this.labelPriceLevel);
			this.tabPageAdditional.Controls.Add(this.groupBoxCategorizingAndDefaults);
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
			this.groupBoxCustomFields.Controls.Add(this.label26);
			this.groupBoxCustomFields.Location = new System.Drawing.Point(216, 40);
			this.groupBoxCustomFields.Name = "groupBoxCustomFields";
			this.groupBoxCustomFields.Size = new System.Drawing.Size(232, 248);
			this.groupBoxCustomFields.TabIndex = 25;
			this.groupBoxCustomFields.TabStop = false;
			this.groupBoxCustomFields.Text = "Custom Fields";
			// 
			// buttonDefineFields
			// 
			this.buttonDefineFields.Location = new System.Drawing.Point(128, 216);
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
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(8, 16);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(100, 23);
			this.label26.TabIndex = 27;
			this.label26.Text = "Label1";
			// 
			// groupBoxSalesTaxInformation
			// 
			this.groupBoxSalesTaxInformation.Controls.Add(this.textBoxResaleNumber);
			this.groupBoxSalesTaxInformation.Controls.Add(this.labelResaleNo);
			this.groupBoxSalesTaxInformation.Controls.Add(this.comboBoxTaxItem);
			this.groupBoxSalesTaxInformation.Controls.Add(this.labelTaxItem);
			this.groupBoxSalesTaxInformation.Controls.Add(this.comboBoxTaxCode);
			this.groupBoxSalesTaxInformation.Controls.Add(this.labelTaxCode);
			this.groupBoxSalesTaxInformation.Location = new System.Drawing.Point(8, 192);
			this.groupBoxSalesTaxInformation.Name = "groupBoxSalesTaxInformation";
			this.groupBoxSalesTaxInformation.Size = new System.Drawing.Size(200, 100);
			this.groupBoxSalesTaxInformation.TabIndex = 21;
			this.groupBoxSalesTaxInformation.TabStop = false;
			this.groupBoxSalesTaxInformation.Text = "Sales Tax Information";
			// 
			// textBoxResaleNumber
			// 
			this.textBoxResaleNumber.Location = new System.Drawing.Point(80, 72);
			this.textBoxResaleNumber.Name = "textBoxResaleNumber";
			this.textBoxResaleNumber.Size = new System.Drawing.Size(112, 21);
			this.textBoxResaleNumber.TabIndex = 11;
			// 
			// labelResaleNo
			// 
			this.labelResaleNo.Location = new System.Drawing.Point(80, 56);
			this.labelResaleNo.Name = "labelResaleNo";
			this.labelResaleNo.Size = new System.Drawing.Size(100, 23);
			this.labelResaleNo.TabIndex = 10;
			this.labelResaleNo.Text = "Resale Number";
			// 
			// comboBoxTaxItem
			// 
			this.comboBoxTaxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTaxItem.FormattingEnabled = true;
			this.comboBoxTaxItem.Location = new System.Drawing.Point(80, 32);
			this.comboBoxTaxItem.Name = "comboBoxTaxItem";
			this.comboBoxTaxItem.Size = new System.Drawing.Size(112, 21);
			this.comboBoxTaxItem.TabIndex = 9;
			// 
			// labelTaxItem
			// 
			this.labelTaxItem.Location = new System.Drawing.Point(80, 16);
			this.labelTaxItem.Name = "labelTaxItem";
			this.labelTaxItem.Size = new System.Drawing.Size(64, 23);
			this.labelTaxItem.TabIndex = 8;
			this.labelTaxItem.Text = "Tax Item";
			// 
			// comboBoxTaxCode
			// 
			this.comboBoxTaxCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTaxCode.FormattingEnabled = true;
			this.comboBoxTaxCode.Location = new System.Drawing.Point(8, 32);
			this.comboBoxTaxCode.Name = "comboBoxTaxCode";
			this.comboBoxTaxCode.Size = new System.Drawing.Size(64, 21);
			this.comboBoxTaxCode.TabIndex = 7;
			// 
			// labelTaxCode
			// 
			this.labelTaxCode.Location = new System.Drawing.Point(8, 16);
			this.labelTaxCode.Name = "labelTaxCode";
			this.labelTaxCode.Size = new System.Drawing.Size(64, 23);
			this.labelTaxCode.TabIndex = 6;
			this.labelTaxCode.Text = "Tax Code";
			// 
			// comboBoxPriceLevel
			// 
			this.comboBoxPriceLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPriceLevel.FormattingEnabled = true;
			this.comboBoxPriceLevel.Location = new System.Drawing.Point(320, 8);
			this.comboBoxPriceLevel.Name = "comboBoxPriceLevel";
			this.comboBoxPriceLevel.Size = new System.Drawing.Size(121, 21);
			this.comboBoxPriceLevel.TabIndex = 20;
			// 
			// labelPriceLevel
			// 
			this.labelPriceLevel.Location = new System.Drawing.Point(216, 8);
			this.labelPriceLevel.Name = "labelPriceLevel";
			this.labelPriceLevel.Size = new System.Drawing.Size(100, 23);
			this.labelPriceLevel.TabIndex = 19;
			this.labelPriceLevel.Text = "Price Level";
			// 
			// groupBoxCategorizingAndDefaults
			// 
			this.groupBoxCategorizingAndDefaults.Controls.Add(this.comboBoxSendMethod);
			this.groupBoxCategorizingAndDefaults.Controls.Add(this.labelPreferredSendMethod);
			this.groupBoxCategorizingAndDefaults.Controls.Add(this.comboBoxSalesRep);
			this.groupBoxCategorizingAndDefaults.Controls.Add(this.labelRep);
			this.groupBoxCategorizingAndDefaults.Controls.Add(this.comboBoxTerms);
			this.groupBoxCategorizingAndDefaults.Controls.Add(this.labelTerms);
			this.groupBoxCategorizingAndDefaults.Controls.Add(this.comboBoxType);
			this.groupBoxCategorizingAndDefaults.Controls.Add(this.labelType);
			this.groupBoxCategorizingAndDefaults.Location = new System.Drawing.Point(8, 8);
			this.groupBoxCategorizingAndDefaults.Name = "groupBoxCategorizingAndDefaults";
			this.groupBoxCategorizingAndDefaults.Size = new System.Drawing.Size(200, 184);
			this.groupBoxCategorizingAndDefaults.TabIndex = 12;
			this.groupBoxCategorizingAndDefaults.TabStop = false;
			this.groupBoxCategorizingAndDefaults.Text = "Categorizing and Defaults";
			// 
			// comboBoxSendMethod
			// 
			this.comboBoxSendMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSendMethod.FormattingEnabled = true;
			this.comboBoxSendMethod.Items.AddRange(new object[] {
									"Email",
									"Mail",
									"None"});
			this.comboBoxSendMethod.Location = new System.Drawing.Point(8, 152);
			this.comboBoxSendMethod.Name = "comboBoxSendMethod";
			this.comboBoxSendMethod.Size = new System.Drawing.Size(160, 21);
			this.comboBoxSendMethod.TabIndex = 7;
			// 
			// labelPreferredSendMethod
			// 
			this.labelPreferredSendMethod.Location = new System.Drawing.Point(8, 136);
			this.labelPreferredSendMethod.Name = "labelPreferredSendMethod";
			this.labelPreferredSendMethod.Size = new System.Drawing.Size(136, 23);
			this.labelPreferredSendMethod.TabIndex = 6;
			this.labelPreferredSendMethod.Text = "Preferred Send Method";
			// 
			// comboBoxSalesRep
			// 
			this.comboBoxSalesRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSalesRep.FormattingEnabled = true;
			this.comboBoxSalesRep.Location = new System.Drawing.Point(8, 112);
			this.comboBoxSalesRep.Name = "comboBoxSalesRep";
			this.comboBoxSalesRep.Size = new System.Drawing.Size(88, 21);
			this.comboBoxSalesRep.TabIndex = 5;
			// 
			// labelRep
			// 
			this.labelRep.Location = new System.Drawing.Point(8, 96);
			this.labelRep.Name = "labelRep";
			this.labelRep.Size = new System.Drawing.Size(100, 23);
			this.labelRep.TabIndex = 4;
			this.labelRep.Text = "Rep";
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
			// tabPagePayment
			// 
			this.tabPagePayment.Controls.Add(this.groupBoxPreferredPaymentMethod);
			this.tabPagePayment.Controls.Add(this.textBoxCreditLimit);
			this.tabPagePayment.Controls.Add(this.labelCreditLimit);
			this.tabPagePayment.Controls.Add(this.textBoxAccountNo);
			this.tabPagePayment.Controls.Add(this.labelAccountNo);
			this.tabPagePayment.Location = new System.Drawing.Point(4, 22);
			this.tabPagePayment.Name = "tabPagePayment";
			this.tabPagePayment.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePayment.Size = new System.Drawing.Size(456, 342);
			this.tabPagePayment.TabIndex = 2;
			this.tabPagePayment.Text = "Payment Info";
			this.tabPagePayment.UseVisualStyleBackColor = true;
			// 
			// groupBoxPreferredPaymentMethod
			// 
			this.groupBoxPreferredPaymentMethod.Controls.Add(this.linkLabel1);
			this.groupBoxPreferredPaymentMethod.Controls.Add(this.textBoxZipCode);
			this.groupBoxPreferredPaymentMethod.Controls.Add(this.labelZipCode);
			this.groupBoxPreferredPaymentMethod.Controls.Add(this.textBoxAddress);
			this.groupBoxPreferredPaymentMethod.Controls.Add(this.labelAddress);
			this.groupBoxPreferredPaymentMethod.Controls.Add(this.textBoxNameOnCard);
			this.groupBoxPreferredPaymentMethod.Controls.Add(this.labelNameOnCard);
			this.groupBoxPreferredPaymentMethod.Controls.Add(this.textBoxExpYear);
			this.groupBoxPreferredPaymentMethod.Controls.Add(this.label31);
			this.groupBoxPreferredPaymentMethod.Controls.Add(this.textBoxExpMonth);
			this.groupBoxPreferredPaymentMethod.Controls.Add(this.labelExpDate);
			this.groupBoxPreferredPaymentMethod.Controls.Add(this.textBoxCreditCardNo);
			this.groupBoxPreferredPaymentMethod.Controls.Add(this.comboBoxPaymentMethod);
			this.groupBoxPreferredPaymentMethod.Controls.Add(this.labelCreditCardNo);
			this.groupBoxPreferredPaymentMethod.Location = new System.Drawing.Point(8, 80);
			this.groupBoxPreferredPaymentMethod.Name = "groupBoxPreferredPaymentMethod";
			this.groupBoxPreferredPaymentMethod.Size = new System.Drawing.Size(368, 176);
			this.groupBoxPreferredPaymentMethod.TabIndex = 33;
			this.groupBoxPreferredPaymentMethod.TabStop = false;
			this.groupBoxPreferredPaymentMethod.Text = "Preferred Payment Method";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(8, 144);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(200, 23);
			this.linkLabel1.TabIndex = 46;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Can I save the Card Security Code?";
			// 
			// textBoxZipCode
			// 
			this.textBoxZipCode.Location = new System.Drawing.Point(88, 120);
			this.textBoxZipCode.Name = "textBoxZipCode";
			this.textBoxZipCode.Size = new System.Drawing.Size(112, 21);
			this.textBoxZipCode.TabIndex = 45;
			// 
			// labelZipCode
			// 
			this.labelZipCode.Location = new System.Drawing.Point(8, 120);
			this.labelZipCode.Name = "labelZipCode";
			this.labelZipCode.Size = new System.Drawing.Size(100, 23);
			this.labelZipCode.TabIndex = 44;
			this.labelZipCode.Text = "Zip Code";
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(88, 96);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(200, 21);
			this.textBoxAddress.TabIndex = 43;
			// 
			// labelAddress
			// 
			this.labelAddress.Location = new System.Drawing.Point(8, 96);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(100, 23);
			this.labelAddress.TabIndex = 42;
			this.labelAddress.Text = "Address";
			// 
			// textBoxNameOnCard
			// 
			this.textBoxNameOnCard.Location = new System.Drawing.Point(88, 72);
			this.textBoxNameOnCard.Name = "textBoxNameOnCard";
			this.textBoxNameOnCard.Size = new System.Drawing.Size(200, 21);
			this.textBoxNameOnCard.TabIndex = 41;
			// 
			// labelNameOnCard
			// 
			this.labelNameOnCard.Location = new System.Drawing.Point(8, 72);
			this.labelNameOnCard.Name = "labelNameOnCard";
			this.labelNameOnCard.Size = new System.Drawing.Size(100, 23);
			this.labelNameOnCard.TabIndex = 40;
			this.labelNameOnCard.Text = "Name on card";
			// 
			// textBoxExpYear
			// 
			this.textBoxExpYear.Location = new System.Drawing.Point(304, 48);
			this.textBoxExpYear.Name = "textBoxExpYear";
			this.textBoxExpYear.Size = new System.Drawing.Size(40, 21);
			this.textBoxExpYear.TabIndex = 39;
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(294, 48);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(26, 23);
			this.label31.TabIndex = 38;
			this.label31.Text = "/";
			// 
			// textBoxExpMonth
			// 
			this.textBoxExpMonth.Location = new System.Drawing.Point(256, 48);
			this.textBoxExpMonth.Name = "textBoxExpMonth";
			this.textBoxExpMonth.Size = new System.Drawing.Size(32, 21);
			this.textBoxExpMonth.TabIndex = 37;
			// 
			// labelExpDate
			// 
			this.labelExpDate.Location = new System.Drawing.Point(208, 48);
			this.labelExpDate.Name = "labelExpDate";
			this.labelExpDate.Size = new System.Drawing.Size(56, 23);
			this.labelExpDate.TabIndex = 36;
			this.labelExpDate.Text = "Exp Date";
			// 
			// textBoxCreditCardNo
			// 
			this.textBoxCreditCardNo.Location = new System.Drawing.Point(88, 48);
			this.textBoxCreditCardNo.Name = "textBoxCreditCardNo";
			this.textBoxCreditCardNo.Size = new System.Drawing.Size(112, 21);
			this.textBoxCreditCardNo.TabIndex = 35;
			// 
			// comboBoxPaymentMethod
			// 
			this.comboBoxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPaymentMethod.FormattingEnabled = true;
			this.comboBoxPaymentMethod.Location = new System.Drawing.Point(8, 16);
			this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
			this.comboBoxPaymentMethod.Size = new System.Drawing.Size(121, 21);
			this.comboBoxPaymentMethod.TabIndex = 0;
			// 
			// labelCreditCardNo
			// 
			this.labelCreditCardNo.Location = new System.Drawing.Point(8, 48);
			this.labelCreditCardNo.Name = "labelCreditCardNo";
			this.labelCreditCardNo.Size = new System.Drawing.Size(100, 23);
			this.labelCreditCardNo.TabIndex = 34;
			this.labelCreditCardNo.Text = "Credit Card No";
			// 
			// textBoxCreditLimit
			// 
			this.textBoxCreditLimit.Location = new System.Drawing.Point(80, 48);
			this.textBoxCreditLimit.Name = "textBoxCreditLimit";
			this.textBoxCreditLimit.Size = new System.Drawing.Size(112, 21);
			this.textBoxCreditLimit.TabIndex = 32;
			this.textBoxCreditLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelCreditLimit
			// 
			this.labelCreditLimit.Location = new System.Drawing.Point(8, 48);
			this.labelCreditLimit.Name = "labelCreditLimit";
			this.labelCreditLimit.Size = new System.Drawing.Size(100, 23);
			this.labelCreditLimit.TabIndex = 31;
			this.labelCreditLimit.Text = "Credit Limit";
			// 
			// textBoxAccountNo
			// 
			this.textBoxAccountNo.Location = new System.Drawing.Point(80, 16);
			this.textBoxAccountNo.Name = "textBoxAccountNo";
			this.textBoxAccountNo.Size = new System.Drawing.Size(112, 21);
			this.textBoxAccountNo.TabIndex = 30;
			// 
			// labelAccountNo
			// 
			this.labelAccountNo.Location = new System.Drawing.Point(8, 16);
			this.labelAccountNo.Name = "labelAccountNo";
			this.labelAccountNo.Size = new System.Drawing.Size(100, 23);
			this.labelAccountNo.TabIndex = 29;
			this.labelAccountNo.Text = "Account No";
			// 
			// tabPageJob
			// 
			this.tabPageJob.Controls.Add(this.comboBoxJobType);
			this.tabPageJob.Controls.Add(this.labelJobType);
			this.tabPageJob.Controls.Add(this.textBoxJobDescription);
			this.tabPageJob.Controls.Add(this.labelJobDescription);
			this.tabPageJob.Controls.Add(this.dateTimePickerEndDate);
			this.tabPageJob.Controls.Add(this.labelEndDate);
			this.tabPageJob.Controls.Add(this.dateTimePickerProjectedEnd);
			this.tabPageJob.Controls.Add(this.labelProjectedEnd);
			this.tabPageJob.Controls.Add(this.dateTimePickerStartDate);
			this.tabPageJob.Controls.Add(this.labelStartDate);
			this.tabPageJob.Controls.Add(this.comboBoxJobStatus);
			this.tabPageJob.Controls.Add(this.labelJobStatus);
			this.tabPageJob.Location = new System.Drawing.Point(4, 22);
			this.tabPageJob.Name = "tabPageJob";
			this.tabPageJob.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageJob.Size = new System.Drawing.Size(456, 342);
			this.tabPageJob.TabIndex = 3;
			this.tabPageJob.Text = "Job Info";
			this.tabPageJob.UseVisualStyleBackColor = true;
			// 
			// comboBoxJobType
			// 
			this.comboBoxJobType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxJobType.FormattingEnabled = true;
			this.comboBoxJobType.Location = new System.Drawing.Point(296, 88);
			this.comboBoxJobType.Name = "comboBoxJobType";
			this.comboBoxJobType.Size = new System.Drawing.Size(144, 21);
			this.comboBoxJobType.TabIndex = 11;
			// 
			// labelJobType
			// 
			this.labelJobType.Location = new System.Drawing.Point(296, 72);
			this.labelJobType.Name = "labelJobType";
			this.labelJobType.Size = new System.Drawing.Size(140, 23);
			this.labelJobType.TabIndex = 10;
			this.labelJobType.Text = "Job Type";
			// 
			// textBoxJobDescription
			// 
			this.textBoxJobDescription.Location = new System.Drawing.Point(24, 88);
			this.textBoxJobDescription.Name = "textBoxJobDescription";
			this.textBoxJobDescription.Size = new System.Drawing.Size(264, 21);
			this.textBoxJobDescription.TabIndex = 9;
			// 
			// labelJobDescription
			// 
			this.labelJobDescription.Location = new System.Drawing.Point(24, 72);
			this.labelJobDescription.Name = "labelJobDescription";
			this.labelJobDescription.Size = new System.Drawing.Size(100, 23);
			this.labelJobDescription.TabIndex = 8;
			this.labelJobDescription.Text = "Job Description";
			// 
			// dateTimePickerEndDate
			// 
			this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerEndDate.Location = new System.Drawing.Point(344, 40);
			this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
			this.dateTimePickerEndDate.Size = new System.Drawing.Size(96, 21);
			this.dateTimePickerEndDate.TabIndex = 7;
			// 
			// labelEndDate
			// 
			this.labelEndDate.Location = new System.Drawing.Point(344, 24);
			this.labelEndDate.Name = "labelEndDate";
			this.labelEndDate.Size = new System.Drawing.Size(96, 23);
			this.labelEndDate.TabIndex = 6;
			this.labelEndDate.Text = "End Date";
			// 
			// dateTimePickerProjectedEnd
			// 
			this.dateTimePickerProjectedEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerProjectedEnd.Location = new System.Drawing.Point(240, 40);
			this.dateTimePickerProjectedEnd.Name = "dateTimePickerProjectedEnd";
			this.dateTimePickerProjectedEnd.Size = new System.Drawing.Size(96, 21);
			this.dateTimePickerProjectedEnd.TabIndex = 5;
			// 
			// labelProjectedEnd
			// 
			this.labelProjectedEnd.Location = new System.Drawing.Point(240, 24);
			this.labelProjectedEnd.Name = "labelProjectedEnd";
			this.labelProjectedEnd.Size = new System.Drawing.Size(96, 23);
			this.labelProjectedEnd.TabIndex = 4;
			this.labelProjectedEnd.Text = "Projected End";
			// 
			// dateTimePickerStartDate
			// 
			this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerStartDate.Location = new System.Drawing.Point(136, 40);
			this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
			this.dateTimePickerStartDate.Size = new System.Drawing.Size(96, 21);
			this.dateTimePickerStartDate.TabIndex = 3;
			// 
			// labelStartDate
			// 
			this.labelStartDate.Location = new System.Drawing.Point(136, 24);
			this.labelStartDate.Name = "labelStartDate";
			this.labelStartDate.Size = new System.Drawing.Size(96, 23);
			this.labelStartDate.TabIndex = 2;
			this.labelStartDate.Text = "Start Date";
			// 
			// comboBoxJobStatus
			// 
			this.comboBoxJobStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxJobStatus.FormattingEnabled = true;
			this.comboBoxJobStatus.Location = new System.Drawing.Point(24, 40);
			this.comboBoxJobStatus.Name = "comboBoxJobStatus";
			this.comboBoxJobStatus.Size = new System.Drawing.Size(104, 21);
			this.comboBoxJobStatus.TabIndex = 1;
			// 
			// labelJobStatus
			// 
			this.labelJobStatus.Location = new System.Drawing.Point(24, 24);
			this.labelJobStatus.Name = "labelJobStatus";
			this.labelJobStatus.Size = new System.Drawing.Size(100, 23);
			this.labelJobStatus.TabIndex = 0;
			this.labelJobStatus.Text = "Job Status";
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.buttonDelete);
			this.tabPage1.Controls.Add(this.buttonEdit);
			this.tabPage1.Controls.Add(this.buttonNew);
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(456, 342);
			this.tabPage1.TabIndex = 4;
			this.tabPage1.Text = "Discounted Items";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDelete.Location = new System.Drawing.Point(368, 72);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 23);
			this.buttonDelete.TabIndex = 7;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonEdit.Location = new System.Drawing.Point(368, 32);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(75, 23);
			this.buttonEdit.TabIndex = 6;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.ButtonEditClick);
			// 
			// buttonNew
			// 
			this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonNew.Location = new System.Drawing.Point(368, 8);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(75, 23);
			this.buttonNew.TabIndex = 5;
			this.buttonNew.Text = "New";
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.ButtonNewClick);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4});
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(8, 8);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(352, 320);
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Item";
			this.columnHeader1.Width = 84;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Description";
			this.columnHeader2.Width = 98;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Price";
			this.columnHeader3.Width = 67;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Discount";
			this.columnHeader4.Width = 79;
			// 
			// textBoxBalance
			// 
			this.textBoxBalance.Location = new System.Drawing.Point(96, 32);
			this.textBoxBalance.Name = "textBoxBalance";
			this.textBoxBalance.Size = new System.Drawing.Size(96, 21);
			this.textBoxBalance.TabIndex = 166;
			this.textBoxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelBalance
			// 
			this.labelBalance.Location = new System.Drawing.Point(8, 32);
			this.labelBalance.Name = "labelBalance";
			this.labelBalance.Size = new System.Drawing.Size(100, 23);
			this.labelBalance.TabIndex = 165;
			this.labelBalance.Text = "Opening Balance";
			// 
			// checkBoxInactive
			// 
			this.checkBoxInactive.Location = new System.Drawing.Point(480, 104);
			this.checkBoxInactive.Name = "checkBoxInactive";
			this.checkBoxInactive.Size = new System.Drawing.Size(104, 36);
			this.checkBoxInactive.TabIndex = 164;
			this.checkBoxInactive.Text = "Customer is inactive";
			this.checkBoxInactive.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(480, 40);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 163;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(480, 16);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 162;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(96, 8);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(256, 21);
			this.textBoxName.TabIndex = 161;
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(8, 8);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(100, 23);
			this.labelName.TabIndex = 160;
			this.labelName.Text = "Customer Name";
			// 
			// CustomerForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 432);
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
			this.Name = "CustomerForm";
			this.Text = "New Customer";
			this.tabControl1.ResumeLayout(false);
			this.tabPageAddress.ResumeLayout(false);
			this.tabPageAddress.PerformLayout();
			this.groupBoxAddresses.ResumeLayout(false);
			this.tabPageAdditional.ResumeLayout(false);
			this.groupBoxCustomFields.ResumeLayout(false);
			this.groupBoxCustomFields.PerformLayout();
			this.groupBoxSalesTaxInformation.ResumeLayout(false);
			this.groupBoxSalesTaxInformation.PerformLayout();
			this.groupBoxCategorizingAndDefaults.ResumeLayout(false);
			this.tabPagePayment.ResumeLayout(false);
			this.tabPagePayment.PerformLayout();
			this.groupBoxPreferredPaymentMethod.ResumeLayout(false);
			this.groupBoxPreferredPaymentMethod.PerformLayout();
			this.tabPageJob.ResumeLayout(false);
			this.tabPageJob.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.CheckBox checkBoxInactive;
		private System.Windows.Forms.Label labelBalance;
		private System.Windows.Forms.TextBox textBoxBalance;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label labelJobStatus;
		private System.Windows.Forms.ComboBox comboBoxJobStatus;
		private System.Windows.Forms.Label labelStartDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
		private System.Windows.Forms.Label labelProjectedEnd;
		private System.Windows.Forms.DateTimePicker dateTimePickerProjectedEnd;
		private System.Windows.Forms.Label labelEndDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
		private System.Windows.Forms.Label labelJobDescription;
		private System.Windows.Forms.TextBox textBoxJobDescription;
		private System.Windows.Forms.Label labelJobType;
		private System.Windows.Forms.ComboBox comboBoxJobType;
		private System.Windows.Forms.TabPage tabPageJob;
		private System.Windows.Forms.Label labelAccountNo;
		private System.Windows.Forms.TextBox textBoxAccountNo;
		private System.Windows.Forms.Label labelCreditLimit;
		private System.Windows.Forms.TextBox textBoxCreditLimit;
		private System.Windows.Forms.Label labelCreditCardNo;
		private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
		private System.Windows.Forms.TextBox textBoxCreditCardNo;
		private System.Windows.Forms.Label labelExpDate;
		private System.Windows.Forms.TextBox textBoxExpMonth;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.TextBox textBoxExpYear;
		private System.Windows.Forms.Label labelNameOnCard;
		private System.Windows.Forms.TextBox textBoxNameOnCard;
		private System.Windows.Forms.Label labelAddress;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Label labelZipCode;
		private System.Windows.Forms.TextBox textBoxZipCode;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.GroupBox groupBoxPreferredPaymentMethod;
		private System.Windows.Forms.TabPage tabPagePayment;
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.ComboBox comboBoxType;
		private System.Windows.Forms.Label labelTerms;
		private System.Windows.Forms.ComboBox comboBoxTerms;
		private System.Windows.Forms.Label labelRep;
		private System.Windows.Forms.ComboBox comboBoxSalesRep;
		private System.Windows.Forms.Label labelPreferredSendMethod;
		private System.Windows.Forms.ComboBox comboBoxSendMethod;
		private System.Windows.Forms.GroupBox groupBoxCategorizingAndDefaults;
		private System.Windows.Forms.Label labelPriceLevel;
		private System.Windows.Forms.ComboBox comboBoxPriceLevel;
		private System.Windows.Forms.Label labelTaxCode;
		private System.Windows.Forms.ComboBox comboBoxTaxCode;
		private System.Windows.Forms.Label labelTaxItem;
		private System.Windows.Forms.ComboBox comboBoxTaxItem;
		private System.Windows.Forms.Label labelResaleNo;
		private System.Windows.Forms.TextBox textBoxResaleNumber;
		private System.Windows.Forms.GroupBox groupBoxSalesTaxInformation;
		private System.Windows.Forms.Label label26;
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
		private System.Windows.Forms.TextBox textBoxPhone;
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
		private System.Windows.Forms.Label labelBillTo;
		private System.Windows.Forms.RichTextBox richTextBoxBillTo;
		private System.Windows.Forms.Button buttonCopyAddress;
		private System.Windows.Forms.Label labelShipTo;
		private System.Windows.Forms.RichTextBox richTextBoxShipTo;
		private System.Windows.Forms.Button buttonBillTo;
		private System.Windows.Forms.Button buttonShipTo;
		private System.Windows.Forms.GroupBox groupBoxAddresses;
		private System.Windows.Forms.TabPage tabPageAddress;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label labelBalanceAsOf;
		private System.Windows.Forms.DateTimePicker dateTimePickerBalanceAsOf;
		private System.Windows.Forms.Button buttonNotes;
	}
}
