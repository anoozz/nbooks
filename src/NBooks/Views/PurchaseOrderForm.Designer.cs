//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class PurchaseOrderForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxVendor = new System.Windows.Forms.ComboBox();
			this.listViewItems = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonSaveAndClose = new System.Windows.Forms.Button();
			this.buttonSaveAndClear = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxRefNo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.richTextBoxShipTo = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxClass = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxMemo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxVendorMessage = new System.Windows.Forms.TextBox();
			this.checkBoxToBePrinted = new System.Windows.Forms.CheckBox();
			this.checkBoxToBeEmailed = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.labelTotal = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButtonSave,
									this.toolStripDropDownButton1,
									this.toolStripDropDownButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(543, 25);
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
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(61, 22);
			this.toolStripDropDownButton1.Text = "Print";
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(65, 22);
			this.toolStripDropDownButton2.Text = "Email";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Vendor";
			// 
			// comboBoxVendor
			// 
			this.comboBoxVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVendor.FormattingEnabled = true;
			this.comboBoxVendor.Location = new System.Drawing.Point(64, 32);
			this.comboBoxVendor.Name = "comboBoxVendor";
			this.comboBoxVendor.Size = new System.Drawing.Size(152, 21);
			this.comboBoxVendor.TabIndex = 2;
			this.comboBoxVendor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVendorSelectedIndexChanged);
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
			this.listViewItems.Location = new System.Drawing.Point(8, 192);
			this.listViewItems.Name = "listViewItems";
			this.listViewItems.Size = new System.Drawing.Size(528, 128);
			this.listViewItems.TabIndex = 3;
			this.listViewItems.UseCompatibleStateImageBehavior = false;
			this.listViewItems.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Item";
			this.columnHeader1.Width = 100;
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
			this.columnHeader4.Text = "Rate";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader4.Width = 80;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Customer";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "U/M";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Amount";
			this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader7.Width = 80;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newItemToolStripMenuItem,
									this.editToolStripMenuItem,
									this.toolStripMenuItem1,
									this.deleteToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(153, 98);
			// 
			// newItemToolStripMenuItem
			// 
			this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
			this.newItemToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.newItemToolStripMenuItem.ShowShortcutKeys = false;
			this.newItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newItemToolStripMenuItem.Text = "New";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			// 
			// buttonSaveAndClose
			// 
			this.buttonSaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveAndClose.Location = new System.Drawing.Point(288, 368);
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
			this.buttonSaveAndClear.Location = new System.Drawing.Point(376, 368);
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
			this.buttonCancel.Location = new System.Drawing.Point(464, 368);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(232, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Date";
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDate.Location = new System.Drawing.Point(288, 32);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(88, 21);
			this.dateTimePickerDate.TabIndex = 8;
			// 
			// richTextBoxAddress
			// 
			this.richTextBoxAddress.Location = new System.Drawing.Point(64, 56);
			this.richTextBoxAddress.Name = "richTextBoxAddress";
			this.richTextBoxAddress.Size = new System.Drawing.Size(152, 72);
			this.richTextBoxAddress.TabIndex = 18;
			this.richTextBoxAddress.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 17;
			this.label4.Text = "Address";
			// 
			// textBoxRefNo
			// 
			this.textBoxRefNo.Location = new System.Drawing.Point(288, 136);
			this.textBoxRefNo.Name = "textBoxRefNo";
			this.textBoxRefNo.Size = new System.Drawing.Size(88, 21);
			this.textBoxRefNo.TabIndex = 24;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(232, 136);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 23;
			this.label7.Text = "Ref No";
			// 
			// richTextBoxShipTo
			// 
			this.richTextBoxShipTo.Location = new System.Drawing.Point(288, 56);
			this.richTextBoxShipTo.Name = "richTextBoxShipTo";
			this.richTextBoxShipTo.Size = new System.Drawing.Size(152, 72);
			this.richTextBoxShipTo.TabIndex = 28;
			this.richTextBoxShipTo.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(232, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 27;
			this.label5.Text = "Ship To";
			// 
			// comboBoxClass
			// 
			this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxClass.FormattingEnabled = true;
			this.comboBoxClass.Location = new System.Drawing.Point(64, 136);
			this.comboBoxClass.Name = "comboBoxClass";
			this.comboBoxClass.Size = new System.Drawing.Size(96, 21);
			this.comboBoxClass.TabIndex = 30;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 29;
			this.label3.Text = "Class";
			// 
			// textBoxMemo
			// 
			this.textBoxMemo.Location = new System.Drawing.Point(64, 160);
			this.textBoxMemo.Name = "textBoxMemo";
			this.textBoxMemo.Size = new System.Drawing.Size(312, 21);
			this.textBoxMemo.TabIndex = 32;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 31;
			this.label6.Text = "Memo";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.Location = new System.Drawing.Point(8, 328);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 33;
			this.label8.Text = "Vendor Message";
			// 
			// textBoxVendorMessage
			// 
			this.textBoxVendorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxVendorMessage.Location = new System.Drawing.Point(96, 328);
			this.textBoxVendorMessage.Name = "textBoxVendorMessage";
			this.textBoxVendorMessage.Size = new System.Drawing.Size(152, 21);
			this.textBoxVendorMessage.TabIndex = 34;
			// 
			// checkBoxToBePrinted
			// 
			this.checkBoxToBePrinted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxToBePrinted.Location = new System.Drawing.Point(8, 352);
			this.checkBoxToBePrinted.Name = "checkBoxToBePrinted";
			this.checkBoxToBePrinted.Size = new System.Drawing.Size(104, 24);
			this.checkBoxToBePrinted.TabIndex = 35;
			this.checkBoxToBePrinted.Text = "To be printed";
			this.checkBoxToBePrinted.UseVisualStyleBackColor = true;
			// 
			// checkBoxToBeEmailed
			// 
			this.checkBoxToBeEmailed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxToBeEmailed.Location = new System.Drawing.Point(104, 352);
			this.checkBoxToBeEmailed.Name = "checkBoxToBeEmailed";
			this.checkBoxToBeEmailed.Size = new System.Drawing.Size(104, 24);
			this.checkBoxToBeEmailed.TabIndex = 36;
			this.checkBoxToBeEmailed.Text = "To be emailed";
			this.checkBoxToBeEmailed.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Location = new System.Drawing.Point(312, 328);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 37;
			this.label9.Text = "Total";
			// 
			// labelTotal
			// 
			this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTotal.Location = new System.Drawing.Point(368, 328);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(100, 23);
			this.labelTotal.TabIndex = 38;
			this.labelTotal.Text = "0.00";
			this.labelTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// PurchaseOrderForm2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 399);
			this.Controls.Add(this.labelTotal);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.checkBoxToBeEmailed);
			this.Controls.Add(this.checkBoxToBePrinted);
			this.Controls.Add(this.textBoxVendorMessage);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBoxMemo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBoxClass);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.richTextBoxShipTo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxRefNo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.richTextBoxAddress);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSaveAndClear);
			this.Controls.Add(this.buttonSaveAndClose);
			this.Controls.Add(this.listViewItems);
			this.Controls.Add(this.comboBoxVendor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "PurchaseOrderForm2";
			this.Text = "Create Purchase Orders";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButtonSave;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.CheckBox checkBoxToBePrinted;
		private System.Windows.Forms.TextBox textBoxVendorMessage;
		private System.Windows.Forms.CheckBox checkBoxToBeEmailed;
		private System.Windows.Forms.ComboBox comboBoxClass;
		private System.Windows.Forms.RichTextBox richTextBoxShipTo;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxMemo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxRefNo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextBoxAddress;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ComboBox comboBoxVendor;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSaveAndClear;
		private System.Windows.Forms.Button buttonSaveAndClose;
		private System.Windows.Forms.ListView listViewItems;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
