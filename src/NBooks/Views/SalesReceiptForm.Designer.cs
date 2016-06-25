//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class SalesReceiptForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReceiptForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxRefNo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.listViewItems = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBoxCustomerMessage = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBoxTaxItem = new System.Windows.Forms.ComboBox();
			this.checkBoxToBePrinted = new System.Windows.Forms.CheckBox();
			this.checkBoxToBeEmailed = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBoxSalesTaxCode = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxMemo = new System.Windows.Forms.TextBox();
			this.buttonSaveAndClose = new System.Windows.Forms.Button();
			this.buttonSaveAndClear = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.comboBoxVehicleTrip = new System.Windows.Forms.ComboBox();
			this.labelVehicleTrip = new System.Windows.Forms.Label();
			this.comboBoxAccount = new System.Windows.Forms.ComboBox();
			this.labelAccount = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButtonSave,
									this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(535, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButtonSave
			// 
			this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
			this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSave.Name = "toolStripButtonSave";
			this.toolStripButtonSave.Size = new System.Drawing.Size(51, 22);
			this.toolStripButtonSave.Text = "Save";
			this.toolStripButtonSave.Click += new System.EventHandler(this.ToolStripButtonSaveClick);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(58, 22);
			this.toolStripDropDownButton1.Text = "Print";
			// 
			// richTextBoxAddress
			// 
			this.richTextBoxAddress.Location = new System.Drawing.Point(64, 80);
			this.richTextBoxAddress.Name = "richTextBoxAddress";
			this.richTextBoxAddress.Size = new System.Drawing.Size(152, 72);
			this.richTextBoxAddress.TabIndex = 24;
			this.richTextBoxAddress.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 23;
			this.label4.Text = "Address";
			// 
			// comboBoxCustomer
			// 
			this.comboBoxCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCustomer.FormattingEnabled = true;
			this.comboBoxCustomer.Location = new System.Drawing.Point(64, 56);
			this.comboBoxCustomer.Name = "comboBoxCustomer";
			this.comboBoxCustomer.Size = new System.Drawing.Size(152, 21);
			this.comboBoxCustomer.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 21;
			this.label1.Text = "Customer";
			// 
			// comboBoxPaymentMethod
			// 
			this.comboBoxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPaymentMethod.FormattingEnabled = true;
			this.comboBoxPaymentMethod.Location = new System.Drawing.Point(320, 128);
			this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
			this.comboBoxPaymentMethod.Size = new System.Drawing.Size(88, 21);
			this.comboBoxPaymentMethod.TabIndex = 36;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(232, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 35;
			this.label5.Text = "Payment Method";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(320, 104);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(88, 21);
			this.textBox1.TabIndex = 34;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(232, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 33;
			this.label3.Text = "Check No";
			// 
			// textBoxRefNo
			// 
			this.textBoxRefNo.Location = new System.Drawing.Point(320, 80);
			this.textBoxRefNo.Name = "textBoxRefNo";
			this.textBoxRefNo.Size = new System.Drawing.Size(88, 21);
			this.textBoxRefNo.TabIndex = 32;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(232, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 31;
			this.label7.Text = "Ref No";
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDate.Location = new System.Drawing.Point(320, 56);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(88, 21);
			this.dateTimePickerDate.TabIndex = 30;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(232, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 29;
			this.label2.Text = "Date";
			// 
			// listViewItems
			// 
			this.listViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6,
									this.columnHeader7});
			this.listViewItems.ContextMenuStrip = this.contextMenuStrip1;
			this.listViewItems.FullRowSelect = true;
			this.listViewItems.Location = new System.Drawing.Point(8, 160);
			this.listViewItems.Name = "listViewItems";
			this.listViewItems.Size = new System.Drawing.Size(520, 120);
			this.listViewItems.TabIndex = 37;
			this.listViewItems.UseCompatibleStateImageBehavior = false;
			this.listViewItems.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Item";
			this.columnHeader1.Width = 130;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Description";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Qty";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "U/M";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Rate";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Amount";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Tax";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.editToolStripMenuItem,
									this.toolStripMenuItem1,
									this.deleteToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(126, 76);
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.newToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.newToolStripMenuItem.Text = "New";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 6);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.Location = new System.Drawing.Point(8, 288);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 38;
			this.label6.Text = "Customer Message";
			// 
			// comboBoxCustomerMessage
			// 
			this.comboBoxCustomerMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.comboBoxCustomerMessage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCustomerMessage.FormattingEnabled = true;
			this.comboBoxCustomerMessage.Location = new System.Drawing.Point(8, 304);
			this.comboBoxCustomerMessage.Name = "comboBoxCustomerMessage";
			this.comboBoxCustomerMessage.Size = new System.Drawing.Size(121, 21);
			this.comboBoxCustomerMessage.TabIndex = 39;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.Location = new System.Drawing.Point(200, 288);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 40;
			this.label8.Text = "Tax";
			// 
			// comboBoxTaxItem
			// 
			this.comboBoxTaxItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxTaxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTaxItem.FormattingEnabled = true;
			this.comboBoxTaxItem.Location = new System.Drawing.Point(240, 288);
			this.comboBoxTaxItem.Name = "comboBoxTaxItem";
			this.comboBoxTaxItem.Size = new System.Drawing.Size(80, 21);
			this.comboBoxTaxItem.TabIndex = 41;
			// 
			// checkBoxToBePrinted
			// 
			this.checkBoxToBePrinted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxToBePrinted.Checked = true;
			this.checkBoxToBePrinted.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxToBePrinted.Location = new System.Drawing.Point(8, 328);
			this.checkBoxToBePrinted.Name = "checkBoxToBePrinted";
			this.checkBoxToBePrinted.Size = new System.Drawing.Size(104, 24);
			this.checkBoxToBePrinted.TabIndex = 42;
			this.checkBoxToBePrinted.Text = "To be printed";
			this.checkBoxToBePrinted.UseVisualStyleBackColor = true;
			// 
			// checkBoxToBeEmailed
			// 
			this.checkBoxToBeEmailed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxToBeEmailed.Location = new System.Drawing.Point(104, 328);
			this.checkBoxToBeEmailed.Name = "checkBoxToBeEmailed";
			this.checkBoxToBeEmailed.Size = new System.Drawing.Size(104, 24);
			this.checkBoxToBeEmailed.TabIndex = 43;
			this.checkBoxToBeEmailed.Text = "To be emailed";
			this.checkBoxToBeEmailed.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Location = new System.Drawing.Point(208, 328);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 44;
			this.label9.Text = "Customer Tax Code";
			// 
			// comboBoxSalesTaxCode
			// 
			this.comboBoxSalesTaxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSalesTaxCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSalesTaxCode.FormattingEnabled = true;
			this.comboBoxSalesTaxCode.Location = new System.Drawing.Point(312, 328);
			this.comboBoxSalesTaxCode.Name = "comboBoxSalesTaxCode";
			this.comboBoxSalesTaxCode.Size = new System.Drawing.Size(56, 21);
			this.comboBoxSalesTaxCode.TabIndex = 45;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.Location = new System.Drawing.Point(376, 328);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 46;
			this.label10.Text = "Memo";
			// 
			// textBoxMemo
			// 
			this.textBoxMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxMemo.Location = new System.Drawing.Point(416, 328);
			this.textBoxMemo.Name = "textBoxMemo";
			this.textBoxMemo.Size = new System.Drawing.Size(112, 21);
			this.textBoxMemo.TabIndex = 47;
			// 
			// buttonSaveAndClose
			// 
			this.buttonSaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveAndClose.Location = new System.Drawing.Point(280, 360);
			this.buttonSaveAndClose.Name = "buttonSaveAndClose";
			this.buttonSaveAndClose.Size = new System.Drawing.Size(83, 23);
			this.buttonSaveAndClose.TabIndex = 48;
			this.buttonSaveAndClose.Text = "Save && Close";
			this.buttonSaveAndClose.UseVisualStyleBackColor = true;
			this.buttonSaveAndClose.Click += new System.EventHandler(this.ButtonSaveAndCloseClick);
			// 
			// buttonSaveAndClear
			// 
			this.buttonSaveAndClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveAndClear.Location = new System.Drawing.Point(368, 360);
			this.buttonSaveAndClear.Name = "buttonSaveAndClear";
			this.buttonSaveAndClear.Size = new System.Drawing.Size(83, 23);
			this.buttonSaveAndClear.TabIndex = 49;
			this.buttonSaveAndClear.Text = "Save && Clear";
			this.buttonSaveAndClear.UseVisualStyleBackColor = true;
			this.buttonSaveAndClear.Click += new System.EventHandler(this.ButtonSaveAndClearClick);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Location = new System.Drawing.Point(456, 360);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 50;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// comboBoxVehicleTrip
			// 
			this.comboBoxVehicleTrip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxVehicleTrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVehicleTrip.FormattingEnabled = true;
			this.comboBoxVehicleTrip.Location = new System.Drawing.Point(80, 32);
			this.comboBoxVehicleTrip.Name = "comboBoxVehicleTrip";
			this.comboBoxVehicleTrip.Size = new System.Drawing.Size(136, 21);
			this.comboBoxVehicleTrip.TabIndex = 52;
			// 
			// labelVehicleTrip
			// 
			this.labelVehicleTrip.Location = new System.Drawing.Point(8, 32);
			this.labelVehicleTrip.Name = "labelVehicleTrip";
			this.labelVehicleTrip.Size = new System.Drawing.Size(100, 23);
			this.labelVehicleTrip.TabIndex = 51;
			this.labelVehicleTrip.Text = "Vehicle Trip";
			// 
			// comboBoxAccount
			// 
			this.comboBoxAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAccount.FormattingEnabled = true;
			this.comboBoxAccount.Location = new System.Drawing.Point(320, 32);
			this.comboBoxAccount.Name = "comboBoxAccount";
			this.comboBoxAccount.Size = new System.Drawing.Size(121, 21);
			this.comboBoxAccount.TabIndex = 54;
			this.comboBoxAccount.Visible = false;
			// 
			// labelAccount
			// 
			this.labelAccount.Location = new System.Drawing.Point(256, 32);
			this.labelAccount.Name = "labelAccount";
			this.labelAccount.Size = new System.Drawing.Size(100, 23);
			this.labelAccount.TabIndex = 53;
			this.labelAccount.Text = "Account";
			this.labelAccount.Visible = false;
			// 
			// SalesReceiptForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(535, 389);
			this.Controls.Add(this.comboBoxAccount);
			this.Controls.Add(this.labelAccount);
			this.Controls.Add(this.comboBoxVehicleTrip);
			this.Controls.Add(this.labelVehicleTrip);
			this.Controls.Add(this.listViewItems);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSaveAndClear);
			this.Controls.Add(this.buttonSaveAndClose);
			this.Controls.Add(this.textBoxMemo);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.comboBoxSalesTaxCode);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.checkBoxToBeEmailed);
			this.Controls.Add(this.checkBoxToBePrinted);
			this.Controls.Add(this.comboBoxTaxItem);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.comboBoxCustomerMessage);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBoxPaymentMethod);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxRefNo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.richTextBoxAddress);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBoxCustomer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "SalesReceiptForm";
			this.Text = "Enter Sales Receipt";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labelVehicleTrip;
		private System.Windows.Forms.Label labelAccount;
		private System.Windows.Forms.ComboBox comboBoxAccount;
		private System.Windows.Forms.ComboBox comboBoxVehicleTrip;
		private System.Windows.Forms.ToolStripButton toolStripButtonSave;
		private System.Windows.Forms.CheckBox checkBoxToBePrinted;
		private System.Windows.Forms.CheckBox checkBoxToBeEmailed;
		private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
		private System.Windows.Forms.ComboBox comboBoxCustomerMessage;
		private System.Windows.Forms.ComboBox comboBoxTaxItem;
		private System.Windows.Forms.ComboBox comboBoxSalesTaxCode;
		private System.Windows.Forms.TextBox textBoxMemo;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSaveAndClear;
		private System.Windows.Forms.Button buttonSaveAndClose;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listViewItems;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxRefNo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxCustomer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextBoxAddress;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
