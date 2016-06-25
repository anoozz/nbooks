//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class InvoiceForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.buttonSaveAndClose = new System.Windows.Forms.Button();
			this.buttonSaveAndClear = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.richTextBoxBillToAddress = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxRefNo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxPONo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxTerms = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxCustomerMessage = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.labelTotalAmount = new System.Windows.Forms.Label();
			this.checkBoxToBePrinted = new System.Windows.Forms.CheckBox();
			this.checkBoxToBeEmailed = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxMemo = new System.Windows.Forms.TextBox();
			this.labelAccount = new System.Windows.Forms.Label();
			this.comboBoxAccount = new System.Windows.Forms.ComboBox();
			this.comboBoxVehicleTrip = new System.Windows.Forms.ComboBox();
			this.labelVehicleTrip = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.listViewItems = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.toolStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButtonSave,
									this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(496, 25);
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
			// buttonSaveAndClose
			// 
			this.buttonSaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveAndClose.Location = new System.Drawing.Point(240, 360);
			this.buttonSaveAndClose.Name = "buttonSaveAndClose";
			this.buttonSaveAndClose.Size = new System.Drawing.Size(83, 23);
			this.buttonSaveAndClose.TabIndex = 3;
			this.buttonSaveAndClose.Text = "Save && Close";
			this.buttonSaveAndClose.UseVisualStyleBackColor = true;
			this.buttonSaveAndClose.Click += new System.EventHandler(this.ButtonSaveAndCloseClick);
			// 
			// buttonSaveAndClear
			// 
			this.buttonSaveAndClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveAndClear.Location = new System.Drawing.Point(328, 360);
			this.buttonSaveAndClear.Name = "buttonSaveAndClear";
			this.buttonSaveAndClear.Size = new System.Drawing.Size(83, 23);
			this.buttonSaveAndClear.TabIndex = 4;
			this.buttonSaveAndClear.Text = "Save && Clear";
			this.buttonSaveAndClear.UseVisualStyleBackColor = true;
			this.buttonSaveAndClear.Click += new System.EventHandler(this.ButtonSaveAndClearClick);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Location = new System.Drawing.Point(416, 360);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(232, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Date";
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDate.Location = new System.Drawing.Point(288, 56);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(88, 21);
			this.dateTimePickerDate.TabIndex = 7;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.editToolStripMenuItem,
									this.toolStripMenuItem1,
									this.deleteToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(117, 76);
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.newToolStripMenuItem.ShowShortcutKeys = false;
			this.newToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.newToolStripMenuItem.Text = "New";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 6);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			// 
			// richTextBoxBillToAddress
			// 
			this.richTextBoxBillToAddress.Location = new System.Drawing.Point(64, 80);
			this.richTextBoxBillToAddress.Name = "richTextBoxBillToAddress";
			this.richTextBoxBillToAddress.Size = new System.Drawing.Size(152, 72);
			this.richTextBoxBillToAddress.TabIndex = 20;
			this.richTextBoxBillToAddress.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 19;
			this.label4.Text = "Bill To";
			// 
			// comboBoxCustomer
			// 
			this.comboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCustomer.FormattingEnabled = true;
			this.comboBoxCustomer.Location = new System.Drawing.Point(64, 56);
			this.comboBoxCustomer.Name = "comboBoxCustomer";
			this.comboBoxCustomer.Size = new System.Drawing.Size(152, 21);
			this.comboBoxCustomer.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 17;
			this.label1.Text = "Customer";
			// 
			// textBoxRefNo
			// 
			this.textBoxRefNo.Location = new System.Drawing.Point(288, 80);
			this.textBoxRefNo.Name = "textBoxRefNo";
			this.textBoxRefNo.Size = new System.Drawing.Size(88, 21);
			this.textBoxRefNo.TabIndex = 24;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(232, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 23;
			this.label7.Text = "Ref No";
			// 
			// textBoxPONo
			// 
			this.textBoxPONo.Location = new System.Drawing.Point(288, 104);
			this.textBoxPONo.Name = "textBoxPONo";
			this.textBoxPONo.Size = new System.Drawing.Size(88, 21);
			this.textBoxPONo.TabIndex = 26;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(232, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 25;
			this.label3.Text = "PO No";
			// 
			// comboBoxTerms
			// 
			this.comboBoxTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTerms.FormattingEnabled = true;
			this.comboBoxTerms.Location = new System.Drawing.Point(288, 128);
			this.comboBoxTerms.Name = "comboBoxTerms";
			this.comboBoxTerms.Size = new System.Drawing.Size(88, 21);
			this.comboBoxTerms.TabIndex = 28;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(232, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 27;
			this.label5.Text = "Terms";
			// 
			// comboBoxCustomerMessage
			// 
			this.comboBoxCustomerMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.comboBoxCustomerMessage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCustomerMessage.FormattingEnabled = true;
			this.comboBoxCustomerMessage.Location = new System.Drawing.Point(8, 312);
			this.comboBoxCustomerMessage.Name = "comboBoxCustomerMessage";
			this.comboBoxCustomerMessage.Size = new System.Drawing.Size(152, 21);
			this.comboBoxCustomerMessage.TabIndex = 30;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.Location = new System.Drawing.Point(8, 296);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 29;
			this.label6.Text = "Customer Message";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.Location = new System.Drawing.Point(360, 296);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 23);
			this.label8.TabIndex = 31;
			this.label8.Text = "Total";
			// 
			// labelTotalAmount
			// 
			this.labelTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTotalAmount.Location = new System.Drawing.Point(392, 296);
			this.labelTotalAmount.Name = "labelTotalAmount";
			this.labelTotalAmount.Size = new System.Drawing.Size(76, 23);
			this.labelTotalAmount.TabIndex = 32;
			this.labelTotalAmount.Text = "0.00";
			this.labelTotalAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// checkBoxToBePrinted
			// 
			this.checkBoxToBePrinted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxToBePrinted.Location = new System.Drawing.Point(8, 336);
			this.checkBoxToBePrinted.Name = "checkBoxToBePrinted";
			this.checkBoxToBePrinted.Size = new System.Drawing.Size(104, 24);
			this.checkBoxToBePrinted.TabIndex = 33;
			this.checkBoxToBePrinted.Text = "To be printed";
			this.checkBoxToBePrinted.UseVisualStyleBackColor = true;
			// 
			// checkBoxToBeEmailed
			// 
			this.checkBoxToBeEmailed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxToBeEmailed.Location = new System.Drawing.Point(8, 360);
			this.checkBoxToBeEmailed.Name = "checkBoxToBeEmailed";
			this.checkBoxToBeEmailed.Size = new System.Drawing.Size(104, 24);
			this.checkBoxToBeEmailed.TabIndex = 34;
			this.checkBoxToBeEmailed.Text = "To be emailed";
			this.checkBoxToBeEmailed.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label10.Location = new System.Drawing.Point(176, 328);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 35;
			this.label10.Text = "Memo";
			// 
			// textBoxMemo
			// 
			this.textBoxMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxMemo.Location = new System.Drawing.Point(216, 328);
			this.textBoxMemo.Name = "textBoxMemo";
			this.textBoxMemo.Size = new System.Drawing.Size(144, 21);
			this.textBoxMemo.TabIndex = 36;
			// 
			// labelAccount
			// 
			this.labelAccount.Location = new System.Drawing.Point(224, 32);
			this.labelAccount.Name = "labelAccount";
			this.labelAccount.Size = new System.Drawing.Size(100, 23);
			this.labelAccount.TabIndex = 37;
			this.labelAccount.Text = "Account";
			this.labelAccount.Visible = false;
			// 
			// comboBoxAccount
			// 
			this.comboBoxAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAccount.FormattingEnabled = true;
			this.comboBoxAccount.Location = new System.Drawing.Point(288, 32);
			this.comboBoxAccount.Name = "comboBoxAccount";
			this.comboBoxAccount.Size = new System.Drawing.Size(121, 21);
			this.comboBoxAccount.TabIndex = 38;
			this.comboBoxAccount.Visible = false;
			// 
			// comboBoxVehicleTrip
			// 
			this.comboBoxVehicleTrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVehicleTrip.FormattingEnabled = true;
			this.comboBoxVehicleTrip.Location = new System.Drawing.Point(96, 32);
			this.comboBoxVehicleTrip.Name = "comboBoxVehicleTrip";
			this.comboBoxVehicleTrip.Size = new System.Drawing.Size(121, 21);
			this.comboBoxVehicleTrip.TabIndex = 40;
			// 
			// labelVehicleTrip
			// 
			this.labelVehicleTrip.Location = new System.Drawing.Point(24, 32);
			this.labelVehicleTrip.Name = "labelVehicleTrip";
			this.labelVehicleTrip.Size = new System.Drawing.Size(100, 23);
			this.labelVehicleTrip.TabIndex = 39;
			this.labelVehicleTrip.Text = "Vehicle Trip";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.listViewItems);
			this.groupBox1.Location = new System.Drawing.Point(8, 152);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(480, 136);
			this.groupBox1.TabIndex = 41;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Invoice Items";
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Location = new System.Drawing.Point(400, 80);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 13;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(400, 40);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = "Edit";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(400, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "New";
			this.button1.UseVisualStyleBackColor = true;
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
									this.columnHeader6});
			this.listViewItems.ContextMenuStrip = this.contextMenuStrip1;
			this.listViewItems.FullRowSelect = true;
			this.listViewItems.Location = new System.Drawing.Point(8, 16);
			this.listViewItems.Name = "listViewItems";
			this.listViewItems.Size = new System.Drawing.Size(384, 112);
			this.listViewItems.TabIndex = 10;
			this.listViewItems.UseCompatibleStateImageBehavior = false;
			this.listViewItems.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Qty";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Item";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Description";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Rate";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader4.Width = 80;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Amount";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader5.Width = 80;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Tax";
			// 
			// InvoiceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 391);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.comboBoxVehicleTrip);
			this.Controls.Add(this.labelVehicleTrip);
			this.Controls.Add(this.comboBoxAccount);
			this.Controls.Add(this.labelAccount);
			this.Controls.Add(this.textBoxMemo);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.checkBoxToBeEmailed);
			this.Controls.Add(this.checkBoxToBePrinted);
			this.Controls.Add(this.labelTotalAmount);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.comboBoxCustomerMessage);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBoxTerms);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxRefNo);
			this.Controls.Add(this.textBoxPONo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.richTextBoxBillToAddress);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBoxCustomer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonSaveAndClear);
			this.Controls.Add(this.buttonSaveAndClose);
			this.Controls.Add(this.toolStrip1);
			this.Name = "InvoiceForm";
			this.Text = "Create Invoices";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labelVehicleTrip;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBoxVehicleTrip;
		private System.Windows.Forms.CheckBox checkBoxToBeEmailed;
		private System.Windows.Forms.TextBox textBoxPONo;
		private System.Windows.Forms.ToolStripButton toolStripButtonSave;
		private System.Windows.Forms.Label labelTotalAmount;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.Label labelAccount;
		private System.Windows.Forms.ComboBox comboBoxAccount;
		private System.Windows.Forms.TextBox textBoxMemo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox checkBoxToBePrinted;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxCustomerMessage;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxTerms;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxRefNo;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ComboBox comboBoxCustomer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextBoxBillToAddress;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listViewItems;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSaveAndClear;
		private System.Windows.Forms.Button buttonSaveAndClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
