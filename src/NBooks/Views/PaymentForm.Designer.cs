//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class PaymentForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButtonPrint = new System.Windows.Forms.ToolStripDropDownButton();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
			this.buttonSaveAndClose = new System.Windows.Forms.Button();
			this.buttonSaveAndClear = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.listViewInvoices = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.buttonFindCustomerInvoice = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxRefNo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxMemo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxCardNo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.payToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.enterPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
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
			this.label1.Text = "Received From";
			// 
			// comboBoxCustomer
			// 
			this.comboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCustomer.FormattingEnabled = true;
			this.comboBoxCustomer.Location = new System.Drawing.Point(104, 32);
			this.comboBoxCustomer.Name = "comboBoxCustomer";
			this.comboBoxCustomer.Size = new System.Drawing.Size(121, 21);
			this.comboBoxCustomer.TabIndex = 2;
			// 
			// buttonSaveAndClose
			// 
			this.buttonSaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveAndClose.Location = new System.Drawing.Point(248, 360);
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
			this.buttonSaveAndClear.Location = new System.Drawing.Point(336, 360);
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
			this.buttonCancel.Location = new System.Drawing.Point(424, 360);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// listView1
			// 
			this.listViewInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listViewInvoices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5});
			this.listViewInvoices.ContextMenuStrip = this.contextMenuStrip1;
			this.listViewInvoices.FullRowSelect = true;
			this.listViewInvoices.Location = new System.Drawing.Point(8, 168);
			this.listViewInvoices.Name = "listView1";
			this.listViewInvoices.Size = new System.Drawing.Size(488, 184);
			this.listViewInvoices.TabIndex = 6;
			this.listViewInvoices.UseCompatibleStateImageBehavior = false;
			this.listViewInvoices.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Date";
			this.columnHeader1.Width = 80;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Number";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Orig. Amt.";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader3.Width = 80;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Amt. Due";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader4.Width = 80;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Payment";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader5.Width = 80;
			// 
			// buttonFindCustomerInvoice
			// 
			this.buttonFindCustomerInvoice.Location = new System.Drawing.Point(344, 136);
			this.buttonFindCustomerInvoice.Name = "buttonFindCustomerInvoice";
			this.buttonFindCustomerInvoice.Size = new System.Drawing.Size(152, 23);
			this.buttonFindCustomerInvoice.TabIndex = 7;
			this.buttonFindCustomerInvoice.Text = "Find a Customer/Invoice...";
			this.buttonFindCustomerInvoice.UseVisualStyleBackColor = true;
			this.buttonFindCustomerInvoice.Click += new System.EventHandler(this.ButtonFindCustomerInvoiceClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(272, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Date";
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDate.Location = new System.Drawing.Point(336, 56);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(96, 21);
			this.dateTimePickerDate.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Amount";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(104, 56);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 21);
			this.textBox1.TabIndex = 11;
			// 
			// comboBoxPaymentMethod
			// 
			this.comboBoxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPaymentMethod.FormattingEnabled = true;
			this.comboBoxPaymentMethod.Location = new System.Drawing.Point(104, 88);
			this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
			this.comboBoxPaymentMethod.Size = new System.Drawing.Size(121, 21);
			this.comboBoxPaymentMethod.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Payment Method";
			// 
			// textBoxRefNo
			// 
			this.textBoxRefNo.Location = new System.Drawing.Point(368, 88);
			this.textBoxRefNo.Name = "textBoxRefNo";
			this.textBoxRefNo.Size = new System.Drawing.Size(100, 21);
			this.textBoxRefNo.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(272, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "Reference #";
			// 
			// textBoxMemo
			// 
			this.textBoxMemo.Location = new System.Drawing.Point(104, 112);
			this.textBoxMemo.Name = "textBoxMemo";
			this.textBoxMemo.Size = new System.Drawing.Size(100, 21);
			this.textBoxMemo.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 112);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "Memo";
			// 
			// textBoxCardNo
			// 
			this.textBoxCardNo.Location = new System.Drawing.Point(104, 136);
			this.textBoxCardNo.Name = "textBoxCardNo";
			this.textBoxCardNo.Size = new System.Drawing.Size(100, 21);
			this.textBoxCardNo.TabIndex = 19;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 136);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 18;
			this.label7.Text = "Card No";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.payToolStripMenuItem,
									this.toolStripMenuItem1,
									this.deleteToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(117, 54);
			// 
			// payToolStripMenuItem
			// 
			this.payToolStripMenuItem.Name = "payToolStripMenuItem";
			this.payToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.payToolStripMenuItem.Text = "Pay";
			this.payToolStripMenuItem.Click += new System.EventHandler(this.PayToolStripMenuItemClick);
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
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.enterPaymentToolStripMenuItem});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(157, 48);
			// 
			// enterPaymentToolStripMenuItem
			// 
			this.enterPaymentToolStripMenuItem.Name = "enterPaymentToolStripMenuItem";
			this.enterPaymentToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.enterPaymentToolStripMenuItem.Text = "Enter Payment";
			this.enterPaymentToolStripMenuItem.Click += new System.EventHandler(this.EnterPaymentToolStripMenuItemClick);
			// 
			// PaymentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 390);
			this.Controls.Add(this.textBoxCardNo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxMemo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxRefNo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBoxPaymentMethod);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonFindCustomerInvoice);
			this.Controls.Add(this.listViewInvoices);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSaveAndClear);
			this.Controls.Add(this.buttonSaveAndClose);
			this.Controls.Add(this.comboBoxCustomer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "PaymentForm";
			this.Text = "Receive Payments";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem enterPaymentToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem payToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonSave;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonPrint;
		private System.Windows.Forms.TextBox textBoxRefNo;
		private System.Windows.Forms.TextBox textBoxCardNo;
		private System.Windows.Forms.TextBox textBoxMemo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonFindCustomerInvoice;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listViewInvoices;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSaveAndClear;
		private System.Windows.Forms.Button buttonSaveAndClose;
		private System.Windows.Forms.ComboBox comboBoxCustomer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
