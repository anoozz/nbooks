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
	partial class TruckReturnForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruckReturnForm));
			this.textBoxTruckNo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.labelTotalAmount = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxRecordedBy = new System.Windows.Forms.TextBox();
			this.textBoxApprovedBy = new System.Windows.Forms.TextBox();
			this.textBoxReleasedBy = new System.Windows.Forms.TextBox();
			this.textBoxPreparedBy = new System.Windows.Forms.TextBox();
			this.comboBoxSalesRep = new System.Windows.Forms.ComboBox();
			this.comboBoxRoute = new System.Windows.Forms.ComboBox();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonSaveAndClose = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonNew = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelSumSelected = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
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
			this.buttonSaveAndClear = new System.Windows.Forms.Button();
			this.checkBoxToBePrinted = new System.Windows.Forms.CheckBox();
			this.labelTotalQuantity = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxRemarks = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
			this.labelTotalDiscount = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.labelNetTotal = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxTruckNo
			// 
			this.textBoxTruckNo.Location = new System.Drawing.Point(376, 6);
			this.textBoxTruckNo.Name = "textBoxTruckNo";
			this.textBoxTruckNo.Size = new System.Drawing.Size(128, 21);
			this.textBoxTruckNo.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.Location = new System.Drawing.Point(263, 401);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 36;
			this.label7.Text = "Approved by:";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.Location = new System.Drawing.Point(263, 425);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 35;
			this.label8.Text = "Recorded by:";
			// 
			// labelTotalAmount
			// 
			this.labelTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTotalAmount.ForeColor = System.Drawing.Color.Red;
			this.labelTotalAmount.Location = new System.Drawing.Point(574, 368);
			this.labelTotalAmount.Name = "labelTotalAmount";
			this.labelTotalAmount.Size = new System.Drawing.Size(84, 23);
			this.labelTotalAmount.TabIndex = 42;
			this.labelTotalAmount.Text = "0.00";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Location = new System.Drawing.Point(512, 368);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(61, 23);
			this.label9.TabIndex = 43;
			this.label9.Text = "Total:";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.Location = new System.Drawing.Point(7, 425);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 34;
			this.label6.Text = "Released by:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 37;
			this.label4.Text = "Date";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 40;
			this.label3.Text = "Route Number";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(261, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 38;
			this.label2.Text = "Truck Number";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(261, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 39;
			this.label1.Text = "Salesman";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.Location = new System.Drawing.Point(7, 401);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 33;
			this.label5.Text = "Prepared by:";
			// 
			// textBoxRecordedBy
			// 
			this.textBoxRecordedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxRecordedBy.Location = new System.Drawing.Point(375, 425);
			this.textBoxRecordedBy.Name = "textBoxRecordedBy";
			this.textBoxRecordedBy.Size = new System.Drawing.Size(128, 21);
			this.textBoxRecordedBy.TabIndex = 10;
			// 
			// textBoxApprovedBy
			// 
			this.textBoxApprovedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxApprovedBy.Location = new System.Drawing.Point(375, 401);
			this.textBoxApprovedBy.Name = "textBoxApprovedBy";
			this.textBoxApprovedBy.Size = new System.Drawing.Size(128, 21);
			this.textBoxApprovedBy.TabIndex = 9;
			// 
			// textBoxReleasedBy
			// 
			this.textBoxReleasedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxReleasedBy.Location = new System.Drawing.Point(111, 425);
			this.textBoxReleasedBy.Name = "textBoxReleasedBy";
			this.textBoxReleasedBy.Size = new System.Drawing.Size(144, 21);
			this.textBoxReleasedBy.TabIndex = 8;
			// 
			// textBoxPreparedBy
			// 
			this.textBoxPreparedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxPreparedBy.Location = new System.Drawing.Point(111, 401);
			this.textBoxPreparedBy.Name = "textBoxPreparedBy";
			this.textBoxPreparedBy.Size = new System.Drawing.Size(144, 21);
			this.textBoxPreparedBy.TabIndex = 7;
			// 
			// comboBoxSalesRep
			// 
			this.comboBoxSalesRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSalesRep.FormattingEnabled = true;
			this.comboBoxSalesRep.Location = new System.Drawing.Point(376, 31);
			this.comboBoxSalesRep.Name = "comboBoxSalesRep";
			this.comboBoxSalesRep.Size = new System.Drawing.Size(128, 21);
			this.comboBoxSalesRep.TabIndex = 4;
			// 
			// comboBoxRoute
			// 
			this.comboBoxRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxRoute.FormattingEnabled = true;
			this.comboBoxRoute.Location = new System.Drawing.Point(123, 31);
			this.comboBoxRoute.Name = "comboBoxRoute";
			this.comboBoxRoute.Size = new System.Drawing.Size(128, 21);
			this.comboBoxRoute.TabIndex = 2;
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDate.Location = new System.Drawing.Point(123, 7);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(128, 21);
			this.dateTimePickerDate.TabIndex = 1;
			// 
			// buttonClear
			// 
			this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonClear.Location = new System.Drawing.Point(216, 480);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(67, 32);
			this.buttonClear.TabIndex = 14;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
			// 
			// buttonSaveAndClose
			// 
			this.buttonSaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonSaveAndClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveAndClose.Image")));
			this.buttonSaveAndClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSaveAndClose.Location = new System.Drawing.Point(8, 480);
			this.buttonSaveAndClose.Name = "buttonSaveAndClose";
			this.buttonSaveAndClose.Size = new System.Drawing.Size(112, 32);
			this.buttonSaveAndClose.TabIndex = 12;
			this.buttonSaveAndClose.Text = "Save && Close";
			this.buttonSaveAndClose.UseVisualStyleBackColor = true;
			this.buttonSaveAndClose.Click += new System.EventHandler(this.ButtonSaveAndCloseClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
			this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonDelete.Location = new System.Drawing.Point(176, 239);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(80, 32);
			this.buttonDelete.TabIndex = 46;
			this.buttonDelete.TabStop = false;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			// 
			// buttonModify
			// 
			this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonModify.Image")));
			this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonEdit.Location = new System.Drawing.Point(96, 239);
			this.buttonEdit.Name = "buttonModify";
			this.buttonEdit.Size = new System.Drawing.Size(80, 32);
			this.buttonEdit.TabIndex = 7;
			this.buttonEdit.TabStop = false;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			// 
			// buttonAdd
			// 
			this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
			this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonNew.Location = new System.Drawing.Point(8, 238);
			this.buttonNew.Name = "buttonAdd";
			this.buttonNew.Size = new System.Drawing.Size(88, 32);
			this.buttonNew.TabIndex = 6;
			this.buttonNew.TabStop = false;
			this.buttonNew.Text = "New [F3]";
			this.buttonNew.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.labelSumSelected);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.listViewItems);
			this.groupBox1.Controls.Add(this.buttonNew);
			this.groupBox1.Controls.Add(this.buttonEdit);
			this.groupBox1.Controls.Add(this.buttonDelete);
			this.groupBox1.Location = new System.Drawing.Point(8, 82);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(649, 279);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// labelSumSelected
			// 
			this.labelSumSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSumSelected.ForeColor = System.Drawing.Color.Red;
			this.labelSumSelected.Location = new System.Drawing.Point(562, 245);
			this.labelSumSelected.Name = "labelSumSelected";
			this.labelSumSelected.Size = new System.Drawing.Size(75, 23);
			this.labelSumSelected.TabIndex = 59;
			this.labelSumSelected.Text = "0.00";
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label15.Location = new System.Drawing.Point(459, 245);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(97, 23);
			this.label15.TabIndex = 58;
			this.label15.Text = "Sum Selected:";
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
			this.listViewItems.HideSelection = false;
			this.listViewItems.Location = new System.Drawing.Point(8, 16);
			this.listViewItems.Name = "listViewItems";
			this.listViewItems.Size = new System.Drawing.Size(632, 213);
			this.listViewItems.TabIndex = 1;
			this.listViewItems.UseCompatibleStateImageBehavior = false;
			this.listViewItems.View = System.Windows.Forms.View.Details;
			this.listViewItems.SelectedIndexChanged += new System.EventHandler(this.ListViewItemsSelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Item Code";
			this.columnHeader1.Width = 75;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Description";
			this.columnHeader2.Width = 87;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Unit";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Unit Price";
			this.columnHeader4.Width = 73;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Quantity";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Discount";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Amount";
			this.columnHeader7.Width = 93;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.editToolStripMenuItem,
									this.toolStripMenuItem1,
									this.deleteToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(153, 98);
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.ShowShortcutKeys = false;
			this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newToolStripMenuItem.Text = "New";
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
			this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.deleteToolStripMenuItem.ShowShortcutKeys = false;
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			// 
			// buttonSaveAndClear
			// 
			this.buttonSaveAndClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonSaveAndClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSaveAndClear.Location = new System.Drawing.Point(120, 480);
			this.buttonSaveAndClear.Name = "buttonSaveAndClear";
			this.buttonSaveAndClear.Size = new System.Drawing.Size(96, 32);
			this.buttonSaveAndClear.TabIndex = 13;
			this.buttonSaveAndClear.Text = "Save && Clear";
			this.buttonSaveAndClear.UseVisualStyleBackColor = true;
			this.buttonSaveAndClear.Click += new System.EventHandler(this.ButtonSaveAndClearClick);
			// 
			// checkBoxToBePrinted
			// 
			this.checkBoxToBePrinted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxToBePrinted.Location = new System.Drawing.Point(8, 368);
			this.checkBoxToBePrinted.Name = "checkBoxToBePrinted";
			this.checkBoxToBePrinted.Size = new System.Drawing.Size(104, 24);
			this.checkBoxToBePrinted.TabIndex = 6;
			this.checkBoxToBePrinted.Text = "To be printed";
			this.checkBoxToBePrinted.UseVisualStyleBackColor = true;
			// 
			// labelTotalQuantity
			// 
			this.labelTotalQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTotalQuantity.ForeColor = System.Drawing.Color.Red;
			this.labelTotalQuantity.Location = new System.Drawing.Point(295, 371);
			this.labelTotalQuantity.Name = "labelTotalQuantity";
			this.labelTotalQuantity.Size = new System.Drawing.Size(80, 23);
			this.labelTotalQuantity.TabIndex = 51;
			this.labelTotalQuantity.Text = "0.00";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.Location = new System.Drawing.Point(231, 371);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 23);
			this.label10.TabIndex = 50;
			this.label10.Text = "Quantity:";
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label11.Location = new System.Drawing.Point(7, 448);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 53;
			this.label11.Text = "Remarks:";
			// 
			// textBoxRemarks
			// 
			this.textBoxRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxRemarks.Location = new System.Drawing.Point(111, 448);
			this.textBoxRemarks.Name = "textBoxRemarks";
			this.textBoxRemarks.Size = new System.Drawing.Size(392, 21);
			this.textBoxRemarks.TabIndex = 11;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 59);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 55;
			this.label12.Text = "Customer";
			// 
			// comboBoxCustomer
			// 
			this.comboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCustomer.FormattingEnabled = true;
			this.comboBoxCustomer.Location = new System.Drawing.Point(123, 58);
			this.comboBoxCustomer.Name = "comboBoxCustomer";
			this.comboBoxCustomer.Size = new System.Drawing.Size(128, 21);
			this.comboBoxCustomer.TabIndex = 54;
			// 
			// labelTotalDiscount
			// 
			this.labelTotalDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTotalDiscount.ForeColor = System.Drawing.Color.Red;
			this.labelTotalDiscount.Location = new System.Drawing.Point(574, 392);
			this.labelTotalDiscount.Name = "labelTotalDiscount";
			this.labelTotalDiscount.Size = new System.Drawing.Size(89, 23);
			this.labelTotalDiscount.TabIndex = 57;
			this.labelTotalDiscount.Text = "0.00";
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.Location = new System.Drawing.Point(512, 392);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(64, 23);
			this.label14.TabIndex = 56;
			this.label14.Text = "Discount";
			// 
			// labelNetTotal
			// 
			this.labelNetTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNetTotal.ForeColor = System.Drawing.Color.Red;
			this.labelNetTotal.Location = new System.Drawing.Point(574, 416);
			this.labelNetTotal.Name = "labelNetTotal";
			this.labelNetTotal.Size = new System.Drawing.Size(89, 23);
			this.labelNetTotal.TabIndex = 59;
			this.labelNetTotal.Text = "0.00";
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label16.Location = new System.Drawing.Point(512, 416);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(64, 23);
			this.label16.TabIndex = 58;
			this.label16.Text = "Net Total";
			// 
			// TruckReturnForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(671, 522);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.comboBoxCustomer);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.labelNetTotal);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.labelTotalDiscount);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.labelTotalQuantity);
			this.Controls.Add(this.textBoxRemarks);
			this.Controls.Add(this.checkBoxToBePrinted);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.buttonSaveAndClear);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxTruckNo);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.labelTotalAmount);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.textBoxRecordedBy);
			this.Controls.Add(this.textBoxApprovedBy);
			this.Controls.Add(this.textBoxReleasedBy);
			this.Controls.Add(this.textBoxPreparedBy);
			this.Controls.Add(this.comboBoxRoute);
			this.Controls.Add(this.comboBoxSalesRep);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.buttonSaveAndClose);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "TruckReturnForm";
			this.Text = "Enter Truck Returns";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TruckReturnFormKeyDown);
			this.groupBox1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ListView listViewItems;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.Label labelNetTotal;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label labelSumSelected;
		private System.Windows.Forms.Label labelTotalDiscount;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ComboBox comboBoxCustomer;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBoxRemarks;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label labelTotalQuantity;
		private System.Windows.Forms.CheckBox checkBoxToBePrinted;
		private System.Windows.Forms.Button buttonSaveAndClear;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonSaveAndClose;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxTruckNo;
		private System.Windows.Forms.TextBox textBoxRecordedBy;
		private System.Windows.Forms.TextBox textBoxApprovedBy;
		private System.Windows.Forms.TextBox textBoxReleasedBy;
		private System.Windows.Forms.TextBox textBoxPreparedBy;
		private System.Windows.Forms.ComboBox comboBoxSalesRep;
		private System.Windows.Forms.ComboBox comboBoxRoute;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Label labelTotalAmount;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}
