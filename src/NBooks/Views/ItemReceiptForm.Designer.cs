//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class ItemReceiptForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemReceiptForm));
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxPreparedBy = new System.Windows.Forms.TextBox();
			this.textBoxApprovedBy = new System.Windows.Forms.TextBox();
			this.buttonSaveAndClear = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonSaveAndClose = new System.Windows.Forms.Button();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.comboBoxVendor = new System.Windows.Forms.ComboBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.sumSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBoxReferenceNo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxRemarks = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.labelTotalQuantity = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelTotalAmount = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonModify = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.listViewItems = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.labelTotalReturnedQuantity = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.labelTotalReturnedAmount = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.buttonDelete2 = new System.Windows.Forms.Button();
			this.buttonModify2 = new System.Windows.Forms.Button();
			this.buttonAdd2 = new System.Windows.Forms.Button();
			this.listViewReturnedItems = new System.Windows.Forms.ListView();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.modifyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.sumSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.Location = new System.Drawing.Point(280, 293);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 25);
			this.label7.TabIndex = 56;
			this.label7.Text = "Approved by:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(19, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 25);
			this.label4.TabIndex = 57;
			this.label4.Text = "Date";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(243, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 25);
			this.label3.TabIndex = 58;
			this.label3.Text = "Vendor";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.Location = new System.Drawing.Point(9, 293);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 25);
			this.label5.TabIndex = 55;
			this.label5.Text = "Prepared by:";
			// 
			// textBoxPreparedBy
			// 
			this.textBoxPreparedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxPreparedBy.Location = new System.Drawing.Point(93, 293);
			this.textBoxPreparedBy.Name = "textBoxPreparedBy";
			this.textBoxPreparedBy.Size = new System.Drawing.Size(167, 22);
			this.textBoxPreparedBy.TabIndex = 5;
			// 
			// textBoxApprovedBy
			// 
			this.textBoxApprovedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxApprovedBy.Location = new System.Drawing.Point(364, 293);
			this.textBoxApprovedBy.Name = "textBoxApprovedBy";
			this.textBoxApprovedBy.Size = new System.Drawing.Size(167, 22);
			this.textBoxApprovedBy.TabIndex = 6;
			this.textBoxApprovedBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxRemarksKeyDown);
			// 
			// buttonSaveAndClear
			// 
			this.buttonSaveAndClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonSaveAndClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSaveAndClear.Location = new System.Drawing.Point(140, 354);
			this.buttonSaveAndClear.Name = "buttonSaveAndClear";
			this.buttonSaveAndClear.Size = new System.Drawing.Size(103, 33);
			this.buttonSaveAndClear.TabIndex = 9;
			this.buttonSaveAndClear.Text = "Save && Clear";
			this.buttonSaveAndClear.UseVisualStyleBackColor = true;
			this.buttonSaveAndClear.Click += new System.EventHandler(this.ButtonSaveAndClearClick);
			// 
			// buttonClear
			// 
			this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonClear.Location = new System.Drawing.Point(243, 354);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 33);
			this.buttonClear.TabIndex = 0;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
			// 
			// buttonSaveAndClose
			// 
			this.buttonSaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonSaveAndClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveAndClose.Image")));
			this.buttonSaveAndClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSaveAndClose.Location = new System.Drawing.Point(9, 354);
			this.buttonSaveAndClose.Name = "buttonSaveAndClose";
			this.buttonSaveAndClose.Size = new System.Drawing.Size(131, 33);
			this.buttonSaveAndClose.TabIndex = 8;
			this.buttonSaveAndClose.Text = "Save && Close";
			this.buttonSaveAndClose.UseVisualStyleBackColor = true;
			this.buttonSaveAndClose.Click += new System.EventHandler(this.ButtonSaveAndCloseClick);
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDate.Location = new System.Drawing.Point(112, 9);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(121, 22);
			this.dateTimePickerDate.TabIndex = 1;
			// 
			// comboBoxSupplier
			// 
			this.comboBoxVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVendor.FormattingEnabled = true;
			this.comboBoxVendor.Location = new System.Drawing.Point(308, 9);
			this.comboBoxVendor.Name = "comboBoxSupplier";
			this.comboBoxVendor.Size = new System.Drawing.Size(186, 22);
			this.comboBoxVendor.TabIndex = 2;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.addToolStripMenuItem,
									this.modifyToolStripMenuItem,
									this.deleteToolStripMenuItem,
									this.toolStripMenuItem1,
									this.sumSelectedToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(150, 98);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.addToolStripMenuItem.Text = "New";
			// 
			// modifyToolStripMenuItem
			// 
			this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
			this.modifyToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.modifyToolStripMenuItem.Text = "Edit";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 6);
			// 
			// sumSelectedToolStripMenuItem
			// 
			this.sumSelectedToolStripMenuItem.Name = "sumSelectedToolStripMenuItem";
			this.sumSelectedToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.sumSelectedToolStripMenuItem.Text = "Sum Selected";
			this.sumSelectedToolStripMenuItem.Click += new System.EventHandler(this.SumSelectedToolStripMenuItemClick);
			// 
			// textBoxReferenceNo
			// 
			this.textBoxReferenceNo.Location = new System.Drawing.Point(112, 34);
			this.textBoxReferenceNo.Name = "textBoxReferenceNo";
			this.textBoxReferenceNo.Size = new System.Drawing.Size(121, 22);
			this.textBoxReferenceNo.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(19, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 25);
			this.label2.TabIndex = 75;
			this.label2.Text = "Reference No";
			// 
			// textBoxRemarks
			// 
			this.textBoxRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxRemarks.Location = new System.Drawing.Point(93, 319);
			this.textBoxRemarks.Name = "textBoxRemarks";
			this.textBoxRemarks.Size = new System.Drawing.Size(438, 22);
			this.textBoxRemarks.TabIndex = 7;
			this.textBoxRemarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxRemarksKeyDown);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.Location = new System.Drawing.Point(9, 319);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 25);
			this.label6.TabIndex = 78;
			this.label6.Text = "Remarks:";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(8, 64);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(576, 224);
			this.tabControl1.TabIndex = 79;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.labelTotalQuantity);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.labelTotalAmount);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.buttonDelete);
			this.tabPage1.Controls.Add(this.buttonModify);
			this.tabPage1.Controls.Add(this.buttonAdd);
			this.tabPage1.Controls.Add(this.listViewItems);
			this.tabPage1.Location = new System.Drawing.Point(4, 23);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(568, 197);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Line Items";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// labelTotalQuantity
			// 
			this.labelTotalQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTotalQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalQuantity.ForeColor = System.Drawing.Color.Red;
			this.labelTotalQuantity.Location = new System.Drawing.Point(299, 160);
			this.labelTotalQuantity.Name = "labelTotalQuantity";
			this.labelTotalQuantity.Size = new System.Drawing.Size(93, 25);
			this.labelTotalQuantity.TabIndex = 78;
			this.labelTotalQuantity.Text = "0.00";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(224, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 25);
			this.label1.TabIndex = 77;
			this.label1.Text = "Quantity:";
			// 
			// labelTotalAmount
			// 
			this.labelTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTotalAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalAmount.ForeColor = System.Drawing.Color.Red;
			this.labelTotalAmount.Location = new System.Drawing.Point(467, 160);
			this.labelTotalAmount.Name = "labelTotalAmount";
			this.labelTotalAmount.Size = new System.Drawing.Size(93, 25);
			this.labelTotalAmount.TabIndex = 75;
			this.labelTotalAmount.Text = "0.00";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(411, 160);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(93, 25);
			this.label9.TabIndex = 76;
			this.label9.Text = "Total:";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
			this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonDelete.Location = new System.Drawing.Point(204, 120);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(93, 33);
			this.buttonDelete.TabIndex = 8;
			this.buttonDelete.TabStop = false;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// buttonModify
			// 
			this.buttonModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonModify.Image = ((System.Drawing.Image)(resources.GetObject("buttonModify.Image")));
			this.buttonModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonModify.Location = new System.Drawing.Point(111, 120);
			this.buttonModify.Name = "buttonModify";
			this.buttonModify.Size = new System.Drawing.Size(93, 33);
			this.buttonModify.TabIndex = 7;
			this.buttonModify.TabStop = false;
			this.buttonModify.Text = "Modify";
			this.buttonModify.UseVisualStyleBackColor = true;
			this.buttonModify.Click += new System.EventHandler(this.ButtonModifyClick);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
			this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonAdd.Location = new System.Drawing.Point(8, 120);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(103, 33);
			this.buttonAdd.TabIndex = 6;
			this.buttonAdd.TabStop = false;
			this.buttonAdd.Text = "Add [F3]";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// listView1
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
									this.columnHeader14,
									this.columnHeader6,
									this.columnHeader13});
			this.listViewItems.ContextMenuStrip = this.contextMenuStrip1;
			this.listViewItems.FullRowSelect = true;
			this.listViewItems.HideSelection = false;
			this.listViewItems.Location = new System.Drawing.Point(8, 8);
			this.listViewItems.Name = "listView1";
			this.listViewItems.Size = new System.Drawing.Size(551, 104);
			this.listViewItems.TabIndex = 5;
			this.listViewItems.UseCompatibleStateImageBehavior = false;
			this.listViewItems.View = System.Windows.Forms.View.Details;
			this.listViewItems.DoubleClick += new System.EventHandler(this.ListView1DoubleClick);
			this.listViewItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView1KeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Code";
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
			// columnHeader13
			// 
			this.columnHeader13.Text = "Amount";
			this.columnHeader13.Width = 93;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.labelTotalReturnedQuantity);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.labelTotalReturnedAmount);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.buttonDelete2);
			this.tabPage2.Controls.Add(this.buttonModify2);
			this.tabPage2.Controls.Add(this.buttonAdd2);
			this.tabPage2.Controls.Add(this.listViewReturnedItems);
			this.tabPage2.Location = new System.Drawing.Point(4, 23);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(568, 197);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Return Empty Items";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// labelTotalReturnedQuantity
			// 
			this.labelTotalReturnedQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTotalReturnedQuantity.Location = new System.Drawing.Point(296, 160);
			this.labelTotalReturnedQuantity.Name = "labelTotalReturnedQuantity";
			this.labelTotalReturnedQuantity.Size = new System.Drawing.Size(93, 25);
			this.labelTotalReturnedQuantity.TabIndex = 82;
			this.labelTotalReturnedQuantity.Text = "0.00";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.Location = new System.Drawing.Point(221, 160);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(75, 25);
			this.label10.TabIndex = 81;
			this.label10.Text = "Quantity:";
			// 
			// labelTotalReturnedAmount
			// 
			this.labelTotalReturnedAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTotalReturnedAmount.Location = new System.Drawing.Point(464, 160);
			this.labelTotalReturnedAmount.Name = "labelTotalReturnedAmount";
			this.labelTotalReturnedAmount.Size = new System.Drawing.Size(93, 25);
			this.labelTotalReturnedAmount.TabIndex = 79;
			this.labelTotalReturnedAmount.Text = "0.00";
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.Location = new System.Drawing.Point(408, 160);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(93, 25);
			this.label12.TabIndex = 80;
			this.label12.Text = "Total:";
			// 
			// buttonDelete2
			// 
			this.buttonDelete2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDelete2.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete2.Image")));
			this.buttonDelete2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonDelete2.Location = new System.Drawing.Point(204, 120);
			this.buttonDelete2.Name = "buttonDelete2";
			this.buttonDelete2.Size = new System.Drawing.Size(93, 33);
			this.buttonDelete2.TabIndex = 12;
			this.buttonDelete2.TabStop = false;
			this.buttonDelete2.Text = "Delete";
			this.buttonDelete2.UseVisualStyleBackColor = true;
			this.buttonDelete2.Click += new System.EventHandler(this.ButtonDelete2Click);
			// 
			// buttonModify2
			// 
			this.buttonModify2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonModify2.Image = ((System.Drawing.Image)(resources.GetObject("buttonModify2.Image")));
			this.buttonModify2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonModify2.Location = new System.Drawing.Point(111, 120);
			this.buttonModify2.Name = "buttonModify2";
			this.buttonModify2.Size = new System.Drawing.Size(93, 33);
			this.buttonModify2.TabIndex = 11;
			this.buttonModify2.TabStop = false;
			this.buttonModify2.Text = "Modify";
			this.buttonModify2.UseVisualStyleBackColor = true;
			this.buttonModify2.Click += new System.EventHandler(this.ButtonModify2Click);
			// 
			// buttonAdd2
			// 
			this.buttonAdd2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonAdd2.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd2.Image")));
			this.buttonAdd2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonAdd2.Location = new System.Drawing.Point(8, 120);
			this.buttonAdd2.Name = "buttonAdd2";
			this.buttonAdd2.Size = new System.Drawing.Size(103, 33);
			this.buttonAdd2.TabIndex = 10;
			this.buttonAdd2.TabStop = false;
			this.buttonAdd2.Text = "Add [F3]";
			this.buttonAdd2.UseVisualStyleBackColor = true;
			this.buttonAdd2.Click += new System.EventHandler(this.ButtonAdd2Click);
			// 
			// listView2
			// 
			this.listViewReturnedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listViewReturnedItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader7,
									this.columnHeader8,
									this.columnHeader9,
									this.columnHeader10,
									this.columnHeader11,
									this.columnHeader12});
			this.listViewReturnedItems.ContextMenuStrip = this.contextMenuStrip2;
			this.listViewReturnedItems.FullRowSelect = true;
			this.listViewReturnedItems.HideSelection = false;
			this.listViewReturnedItems.Location = new System.Drawing.Point(8, 8);
			this.listViewReturnedItems.Name = "listView2";
			this.listViewReturnedItems.Size = new System.Drawing.Size(551, 104);
			this.listViewReturnedItems.TabIndex = 9;
			this.listViewReturnedItems.UseCompatibleStateImageBehavior = false;
			this.listViewReturnedItems.View = System.Windows.Forms.View.Details;
			this.listViewReturnedItems.DoubleClick += new System.EventHandler(this.ListView2DoubleClick);
			this.listViewReturnedItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView2KeyDown);
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Code";
			this.columnHeader7.Width = 75;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Description";
			this.columnHeader8.Width = 87;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Unit";
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Unit Price";
			this.columnHeader10.Width = 73;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Quantity";
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Amount";
			this.columnHeader12.Width = 93;
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.addToolStripMenuItem1,
									this.modifyToolStripMenuItem1,
									this.deleteToolStripMenuItem1,
									this.toolStripMenuItem2,
									this.sumSelectedToolStripMenuItem1});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(150, 98);
			// 
			// addToolStripMenuItem1
			// 
			this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
			this.addToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
			this.addToolStripMenuItem1.Text = "New";
			// 
			// modifyToolStripMenuItem1
			// 
			this.modifyToolStripMenuItem1.Name = "modifyToolStripMenuItem1";
			this.modifyToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
			this.modifyToolStripMenuItem1.Text = "Edit";
			// 
			// deleteToolStripMenuItem1
			// 
			this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
			this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
			this.deleteToolStripMenuItem1.Text = "Delete";
			this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteToolStripMenuItem1Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(146, 6);
			// 
			// sumSelectedToolStripMenuItem1
			// 
			this.sumSelectedToolStripMenuItem1.Name = "sumSelectedToolStripMenuItem1";
			this.sumSelectedToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
			this.sumSelectedToolStripMenuItem1.Text = "Sum Selected";
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "UCS";
			// 
			// ItemReceiptForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(591, 404);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.textBoxRemarks);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxReferenceNo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxVendor);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.buttonSaveAndClear);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonSaveAndClose);
			this.Controls.Add(this.textBoxApprovedBy);
			this.Controls.Add(this.textBoxPreparedBy);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "ItemReceiptForm";
			this.Text = "Enter Item Receipts";
			this.contextMenuStrip1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ToolStripMenuItem sumSelectedToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.Label labelTotalReturnedQuantity;
		private System.Windows.Forms.Label labelTotalReturnedAmount;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button buttonDelete2;
		private System.Windows.Forms.Button buttonModify2;
		private System.Windows.Forms.Button buttonAdd2;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ListView listViewReturnedItems;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxRemarks;
		private System.Windows.Forms.ToolStripMenuItem sumSelectedToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxReferenceNo;
		private System.Windows.Forms.Label labelTotalAmount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelTotalQuantity;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonSaveAndClose;
		private System.Windows.Forms.Button buttonSaveAndClear;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonModify;
		private System.Windows.Forms.TextBox textBoxApprovedBy;
		private System.Windows.Forms.TextBox textBoxPreparedBy;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.ComboBox comboBoxVendor;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listViewItems;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
	}
}
