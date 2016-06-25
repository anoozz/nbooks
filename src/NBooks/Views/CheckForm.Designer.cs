//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class CheckForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxAccount = new System.Windows.Forms.ComboBox();
			this.buttonSaveAndClose = new System.Windows.Forms.Button();
			this.buttonSaveAndClear = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxVendor = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxMemo = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.listViewAccounts = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.listViewItems = new System.Windows.Forms.ListView();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxAmount = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.toolStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButtonSave,
									this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(480, 25);
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
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bank Account";
			// 
			// comboBoxAccount
			// 
			this.comboBoxAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAccount.FormattingEnabled = true;
			this.comboBoxAccount.Location = new System.Drawing.Point(112, 32);
			this.comboBoxAccount.Name = "comboBoxAccount";
			this.comboBoxAccount.Size = new System.Drawing.Size(121, 21);
			this.comboBoxAccount.TabIndex = 2;
			// 
			// buttonSaveAndClose
			// 
			this.buttonSaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveAndClose.Location = new System.Drawing.Point(224, 376);
			this.buttonSaveAndClose.Name = "buttonSaveAndClose";
			this.buttonSaveAndClose.Size = new System.Drawing.Size(83, 23);
			this.buttonSaveAndClose.TabIndex = 4;
			this.buttonSaveAndClose.Text = "Save && Close";
			this.buttonSaveAndClose.UseVisualStyleBackColor = true;
			this.buttonSaveAndClose.Click += new System.EventHandler(this.ButtonSaveAndCloseClick);
			// 
			// buttonSaveAndClear
			// 
			this.buttonSaveAndClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveAndClear.Location = new System.Drawing.Point(312, 376);
			this.buttonSaveAndClear.Name = "buttonSaveAndClear";
			this.buttonSaveAndClear.Size = new System.Drawing.Size(83, 23);
			this.buttonSaveAndClear.TabIndex = 5;
			this.buttonSaveAndClear.Text = "Save && Clear";
			this.buttonSaveAndClear.UseVisualStyleBackColor = true;
			this.buttonSaveAndClear.Click += new System.EventHandler(this.ButtonSaveAndClearClick);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Location = new System.Drawing.Point(400, 376);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(280, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Date";
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDate.Location = new System.Drawing.Point(328, 32);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(88, 21);
			this.dateTimePickerDate.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Pay to the Order of";
			// 
			// comboBoxVendor
			// 
			this.comboBoxVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVendor.FormattingEnabled = true;
			this.comboBoxVendor.Location = new System.Drawing.Point(112, 56);
			this.comboBoxVendor.Name = "comboBoxVendor";
			this.comboBoxVendor.Size = new System.Drawing.Size(152, 21);
			this.comboBoxVendor.TabIndex = 10;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 88);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(336, 21);
			this.textBox1.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Address";
			// 
			// richTextBoxAddress
			// 
			this.richTextBoxAddress.Location = new System.Drawing.Point(88, 112);
			this.richTextBoxAddress.Name = "richTextBoxAddress";
			this.richTextBoxAddress.Size = new System.Drawing.Size(256, 56);
			this.richTextBoxAddress.TabIndex = 13;
			this.richTextBoxAddress.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "Memo";
			// 
			// textBoxMemo
			// 
			this.textBoxMemo.Location = new System.Drawing.Point(88, 176);
			this.textBoxMemo.Name = "textBoxMemo";
			this.textBoxMemo.Size = new System.Drawing.Size(256, 21);
			this.textBoxMemo.TabIndex = 15;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(8, 200);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(464, 168);
			this.tabControl1.TabIndex = 16;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.listViewAccounts);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(456, 142);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Expenses";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// listViewAccounts
			// 
			this.listViewAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listViewAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6});
			this.listViewAccounts.FullRowSelect = true;
			this.listViewAccounts.Location = new System.Drawing.Point(8, 8);
			this.listViewAccounts.Name = "listViewAccounts";
			this.listViewAccounts.Size = new System.Drawing.Size(440, 120);
			this.listViewAccounts.TabIndex = 4;
			this.listViewAccounts.UseCompatibleStateImageBehavior = false;
			this.listViewAccounts.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Account";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Amount";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Memo";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Customer";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Billable";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Class";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button3);
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.listViewItems);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(456, 142);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Items";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button3.Location = new System.Drawing.Point(168, 112);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Show PO";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.Location = new System.Drawing.Point(88, 112);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Receive All";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(8, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Select PO";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// listViewItems
			// 
			this.listViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader7,
									this.columnHeader8,
									this.columnHeader9,
									this.columnHeader10,
									this.columnHeader11,
									this.columnHeader12,
									this.columnHeader13,
									this.columnHeader14,
									this.columnHeader15});
			this.listViewItems.FullRowSelect = true;
			this.listViewItems.Location = new System.Drawing.Point(8, 8);
			this.listViewItems.Name = "listViewItems";
			this.listViewItems.Size = new System.Drawing.Size(440, 96);
			this.listViewItems.TabIndex = 0;
			this.listViewItems.UseCompatibleStateImageBehavior = false;
			this.listViewItems.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Item";
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Description";
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Qty";
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "U/M";
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Cost";
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Amount";
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Customer";
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Billable";
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Class";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(280, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "Amount";
			// 
			// textBoxAmount
			// 
			this.textBoxAmount.Location = new System.Drawing.Point(328, 56);
			this.textBoxAmount.Name = "textBoxAmount";
			this.textBoxAmount.Size = new System.Drawing.Size(88, 21);
			this.textBoxAmount.TabIndex = 18;
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button4.Location = new System.Drawing.Point(8, 376);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 19;
			this.button4.Text = "Clear Splits";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button5.Location = new System.Drawing.Point(88, 376);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 20;
			this.button5.Text = "Recalculate";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// CheckForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 405);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBoxAmount);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.textBoxMemo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.richTextBoxAddress);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBoxVendor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSaveAndClear);
			this.Controls.Add(this.buttonSaveAndClose);
			this.Controls.Add(this.comboBoxAccount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "CheckForm";
			this.Text = "Write Checks";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ListView listViewAccounts;
		private System.Windows.Forms.ListView listViewItems;
		private System.Windows.Forms.ComboBox comboBoxVendor;
		private System.Windows.Forms.RichTextBox richTextBoxAddress;
		private System.Windows.Forms.TextBox textBoxMemo;
		private System.Windows.Forms.TextBox textBoxAmount;
		private System.Windows.Forms.ToolStripButton toolStripButtonSave;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ComboBox comboBoxAccount;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSaveAndClear;
		private System.Windows.Forms.Button buttonSaveAndClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
