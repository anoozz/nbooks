//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class ItemReceiptForm2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemReceiptForm2));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButtonPrint = new System.Windows.Forms.ToolStripDropDownButton();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxVendor = new System.Windows.Forms.ComboBox();
			this.buttonSaveAndClose = new System.Windows.Forms.Button();
			this.buttonSaveAndClear = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxMemo = new System.Windows.Forms.TextBox();
			this.textBoxRefNo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxTotal = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.buttonShowPO = new System.Windows.Forms.Button();
			this.buttonReceiveAll = new System.Windows.Forms.Button();
			this.buttonSelectPO = new System.Windows.Forms.Button();
			this.listViewItems = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.listViewAccounts = new System.Windows.Forms.ListView();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonClearSplits = new System.Windows.Forms.Button();
			this.buttonRecalculate = new System.Windows.Forms.Button();
			this.toolStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButtonSave,
									this.toolStripDropDownButtonPrint});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(505, 25);
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
			// toolStripDropDownButtonPrint
			// 
			this.toolStripDropDownButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonPrint.Image")));
			this.toolStripDropDownButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButtonPrint.Name = "toolStripDropDownButtonPrint";
			this.toolStripDropDownButtonPrint.Size = new System.Drawing.Size(58, 22);
			this.toolStripDropDownButtonPrint.Text = "Print";
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
			this.comboBoxVendor.FormattingEnabled = true;
			this.comboBoxVendor.Location = new System.Drawing.Point(72, 32);
			this.comboBoxVendor.Name = "comboBoxVendor";
			this.comboBoxVendor.Size = new System.Drawing.Size(121, 21);
			this.comboBoxVendor.TabIndex = 2;
			// 
			// buttonSaveAndClose
			// 
			this.buttonSaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveAndClose.Location = new System.Drawing.Point(248, 320);
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
			this.buttonSaveAndClear.Location = new System.Drawing.Point(336, 320);
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
			this.buttonCancel.Location = new System.Drawing.Point(424, 320);
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
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Date";
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDate.Location = new System.Drawing.Point(280, 32);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(96, 21);
			this.dateTimePickerDate.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Memo";
			// 
			// textBoxMemo
			// 
			this.textBoxMemo.Location = new System.Drawing.Point(72, 104);
			this.textBoxMemo.Name = "textBoxMemo";
			this.textBoxMemo.Size = new System.Drawing.Size(192, 21);
			this.textBoxMemo.TabIndex = 10;
			// 
			// textBoxRefNo
			// 
			this.textBoxRefNo.Location = new System.Drawing.Point(280, 56);
			this.textBoxRefNo.Name = "textBoxRefNo";
			this.textBoxRefNo.Size = new System.Drawing.Size(100, 21);
			this.textBoxRefNo.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(232, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Ref No";
			// 
			// textBoxTotal
			// 
			this.textBoxTotal.Location = new System.Drawing.Point(280, 80);
			this.textBoxTotal.Name = "textBoxTotal";
			this.textBoxTotal.ReadOnly = true;
			this.textBoxTotal.Size = new System.Drawing.Size(100, 21);
			this.textBoxTotal.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(232, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "Total";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(8, 128);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(488, 184);
			this.tabControl1.TabIndex = 15;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.buttonShowPO);
			this.tabPage1.Controls.Add(this.buttonReceiveAll);
			this.tabPage1.Controls.Add(this.buttonSelectPO);
			this.tabPage1.Controls.Add(this.listViewItems);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(480, 158);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Items";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// buttonShowPO
			// 
			this.buttonShowPO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonShowPO.Location = new System.Drawing.Point(168, 128);
			this.buttonShowPO.Name = "buttonShowPO";
			this.buttonShowPO.Size = new System.Drawing.Size(75, 23);
			this.buttonShowPO.TabIndex = 7;
			this.buttonShowPO.Text = "Show PO";
			this.buttonShowPO.UseVisualStyleBackColor = true;
			// 
			// buttonReceiveAll
			// 
			this.buttonReceiveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonReceiveAll.Location = new System.Drawing.Point(88, 128);
			this.buttonReceiveAll.Name = "buttonReceiveAll";
			this.buttonReceiveAll.Size = new System.Drawing.Size(75, 23);
			this.buttonReceiveAll.TabIndex = 6;
			this.buttonReceiveAll.Text = "Receive All";
			this.buttonReceiveAll.UseVisualStyleBackColor = true;
			// 
			// buttonSelectPO
			// 
			this.buttonSelectPO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonSelectPO.Location = new System.Drawing.Point(8, 128);
			this.buttonSelectPO.Name = "buttonSelectPO";
			this.buttonSelectPO.Size = new System.Drawing.Size(75, 23);
			this.buttonSelectPO.TabIndex = 5;
			this.buttonSelectPO.Text = "Select PO";
			this.buttonSelectPO.UseVisualStyleBackColor = true;
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
									this.columnHeader7,
									this.columnHeader8,
									this.columnHeader9});
			this.listViewItems.ContextMenuStrip = this.contextMenuStrip1;
			this.listViewItems.FullRowSelect = true;
			this.listViewItems.Location = new System.Drawing.Point(8, 8);
			this.listViewItems.Name = "listViewItems";
			this.listViewItems.Size = new System.Drawing.Size(464, 112);
			this.listViewItems.TabIndex = 4;
			this.listViewItems.UseCompatibleStateImageBehavior = false;
			this.listViewItems.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Item";
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
			this.columnHeader5.Text = "Cost";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Amount";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Customer";
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Billable";
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Class";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newItemToolStripMenuItem,
									this.editItemToolStripMenuItem,
									this.toolStripMenuItem1,
									this.deleteItemToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(142, 76);
			// 
			// newItemToolStripMenuItem
			// 
			this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
			this.newItemToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.newItemToolStripMenuItem.Text = "New Item";
			// 
			// editItemToolStripMenuItem
			// 
			this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
			this.editItemToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.editItemToolStripMenuItem.Text = "Edit Item";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
			// 
			// deleteItemToolStripMenuItem
			// 
			this.deleteItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteItemToolStripMenuItem.Image")));
			this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
			this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.deleteItemToolStripMenuItem.Text = "Delete Item";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.listViewAccounts);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(480, 158);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Expenses";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// listView2
			// 
			this.listViewAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listViewAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader10,
									this.columnHeader11,
									this.columnHeader12,
									this.columnHeader13,
									this.columnHeader14,
									this.columnHeader15});
			this.listViewAccounts.ContextMenuStrip = this.contextMenuStrip2;
			this.listViewAccounts.FullRowSelect = true;
			this.listViewAccounts.Location = new System.Drawing.Point(8, 8);
			this.listViewAccounts.Name = "listView2";
			this.listViewAccounts.Size = new System.Drawing.Size(464, 144);
			this.listViewAccounts.TabIndex = 0;
			this.listViewAccounts.UseCompatibleStateImageBehavior = false;
			this.listViewAccounts.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Account";
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Amount";
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Memo";
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
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newAccountToolStripMenuItem,
									this.editAccountToolStripMenuItem,
									this.toolStripMenuItem2,
									this.deleteAccountToolStripMenuItem});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(159, 76);
			// 
			// newAccountToolStripMenuItem
			// 
			this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
			this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.newAccountToolStripMenuItem.Text = "New Account";
			// 
			// editAccountToolStripMenuItem
			// 
			this.editAccountToolStripMenuItem.Name = "editAccountToolStripMenuItem";
			this.editAccountToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.editAccountToolStripMenuItem.Text = "Edit Account";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(155, 6);
			// 
			// deleteAccountToolStripMenuItem
			// 
			this.deleteAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteAccountToolStripMenuItem.Image")));
			this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
			this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.deleteAccountToolStripMenuItem.Text = "Delete Account";
			// 
			// buttonClearSplits
			// 
			this.buttonClearSplits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonClearSplits.Location = new System.Drawing.Point(8, 320);
			this.buttonClearSplits.Name = "buttonClearSplits";
			this.buttonClearSplits.Size = new System.Drawing.Size(75, 23);
			this.buttonClearSplits.TabIndex = 16;
			this.buttonClearSplits.Text = "Clear Splits";
			this.buttonClearSplits.UseVisualStyleBackColor = true;
			// 
			// buttonRecalculate
			// 
			this.buttonRecalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonRecalculate.Location = new System.Drawing.Point(88, 320);
			this.buttonRecalculate.Name = "buttonRecalculate";
			this.buttonRecalculate.Size = new System.Drawing.Size(75, 23);
			this.buttonRecalculate.TabIndex = 17;
			this.buttonRecalculate.Text = "Recalculate";
			this.buttonRecalculate.UseVisualStyleBackColor = true;
			// 
			// ItemReceiptForm2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 349);
			this.Controls.Add(this.buttonRecalculate);
			this.Controls.Add(this.buttonClearSplits);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.textBoxTotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxRefNo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxMemo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSaveAndClear);
			this.Controls.Add(this.buttonSaveAndClose);
			this.Controls.Add(this.comboBoxVendor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "ItemReceiptForm2";
			this.Text = "Create Item Receipts";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonPrint;
		private System.Windows.Forms.Button buttonClearSplits;
		private System.Windows.Forms.Button buttonRecalculate;
		private System.Windows.Forms.Button buttonShowPO;
		private System.Windows.Forms.Button buttonReceiveAll;
		private System.Windows.Forms.Button buttonSelectPO;
		private System.Windows.Forms.ToolStripButton toolStripButtonSave;
		private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem editAccountToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ListView listViewAccounts;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listViewItems;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TextBox textBoxTotal;
		private System.Windows.Forms.TextBox textBoxRefNo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxMemo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSaveAndClear;
		private System.Windows.Forms.Button buttonSaveAndClose;
		private System.Windows.Forms.ComboBox comboBoxVendor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
