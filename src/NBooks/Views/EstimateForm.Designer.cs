//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class EstimateForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstimateForm));
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.comboBoxClass = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBoxInactive = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxCustomerMessage = new System.Windows.Forms.ComboBox();
			this.checkBoxToBeEmailed = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxSalesTaxCode = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxMemo = new System.Windows.Forms.TextBox();
			this.buttonSaveAndClose = new System.Windows.Forms.Button();
			this.buttonSaveAndClear = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Customer";
			// 
			// comboBoxCustomer
			// 
			this.comboBoxCustomer.FormattingEnabled = true;
			this.comboBoxCustomer.Location = new System.Drawing.Point(8, 48);
			this.comboBoxCustomer.Name = "comboBoxCustomer";
			this.comboBoxCustomer.Size = new System.Drawing.Size(121, 21);
			this.comboBoxCustomer.TabIndex = 1;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButton1,
									this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(613, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(51, 22);
			this.toolStripButton1.Text = "Save";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(61, 22);
			this.toolStripDropDownButton1.Text = "Print";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2});
			this.listView1.FullRowSelect = true;
			this.listView1.Location = new System.Drawing.Point(8, 112);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(400, 96);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Item";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Description";
			// 
			// comboBoxClass
			// 
			this.comboBoxClass.FormattingEnabled = true;
			this.comboBoxClass.Location = new System.Drawing.Point(256, 48);
			this.comboBoxClass.Name = "comboBoxClass";
			this.comboBoxClass.Size = new System.Drawing.Size(80, 21);
			this.comboBoxClass.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(256, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Class";
			// 
			// checkBoxInactive
			// 
			this.checkBoxInactive.Location = new System.Drawing.Point(136, 32);
			this.checkBoxInactive.Name = "checkBoxInactive";
			this.checkBoxInactive.Size = new System.Drawing.Size(104, 32);
			this.checkBoxInactive.TabIndex = 6;
			this.checkBoxInactive.Text = "Estimate is inactive";
			this.checkBoxInactive.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 216);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 32);
			this.label3.TabIndex = 7;
			this.label3.Text = "Customer Message";
			// 
			// comboBoxCustomerMessage
			// 
			this.comboBoxCustomerMessage.FormattingEnabled = true;
			this.comboBoxCustomerMessage.Location = new System.Drawing.Point(72, 216);
			this.comboBoxCustomerMessage.Name = "comboBoxCustomerMessage";
			this.comboBoxCustomerMessage.Size = new System.Drawing.Size(112, 21);
			this.comboBoxCustomerMessage.TabIndex = 8;
			// 
			// checkBoxToBeEmailed
			// 
			this.checkBoxToBeEmailed.Location = new System.Drawing.Point(8, 256);
			this.checkBoxToBeEmailed.Name = "checkBoxToBeEmailed";
			this.checkBoxToBeEmailed.Size = new System.Drawing.Size(104, 24);
			this.checkBoxToBeEmailed.TabIndex = 9;
			this.checkBoxToBeEmailed.Text = "To be emailed";
			this.checkBoxToBeEmailed.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(128, 256);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Customer Tax Code";
			// 
			// comboBoxSalesTaxCode
			// 
			this.comboBoxSalesTaxCode.FormattingEnabled = true;
			this.comboBoxSalesTaxCode.Location = new System.Drawing.Point(232, 256);
			this.comboBoxSalesTaxCode.Name = "comboBoxSalesTaxCode";
			this.comboBoxSalesTaxCode.Size = new System.Drawing.Size(56, 21);
			this.comboBoxSalesTaxCode.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 280);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Memo";
			// 
			// textBoxMemo
			// 
			this.textBoxMemo.Location = new System.Drawing.Point(56, 280);
			this.textBoxMemo.Name = "textBoxMemo";
			this.textBoxMemo.Size = new System.Drawing.Size(104, 20);
			this.textBoxMemo.TabIndex = 13;
			// 
			// buttonSaveAndClose
			// 
			this.buttonSaveAndClose.Location = new System.Drawing.Point(184, 296);
			this.buttonSaveAndClose.Name = "buttonSaveAndClose";
			this.buttonSaveAndClose.Size = new System.Drawing.Size(83, 23);
			this.buttonSaveAndClose.TabIndex = 14;
			this.buttonSaveAndClose.Text = "Save && Close";
			this.buttonSaveAndClose.UseVisualStyleBackColor = true;
			// 
			// buttonSaveAndClear
			// 
			this.buttonSaveAndClear.Location = new System.Drawing.Point(272, 296);
			this.buttonSaveAndClear.Name = "buttonSaveAndClear";
			this.buttonSaveAndClear.Size = new System.Drawing.Size(83, 23);
			this.buttonSaveAndClear.TabIndex = 15;
			this.buttonSaveAndClear.Text = "Save && Clear";
			this.buttonSaveAndClear.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(360, 296);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 16;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(256, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "Date";
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDate.Location = new System.Drawing.Point(296, 72);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(96, 20);
			this.dateTimePickerDate.TabIndex = 18;
			// 
			// EstimateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 492);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSaveAndClear);
			this.Controls.Add(this.buttonSaveAndClose);
			this.Controls.Add(this.textBoxMemo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBoxSalesTaxCode);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.checkBoxToBeEmailed);
			this.Controls.Add(this.comboBoxCustomerMessage);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.checkBoxInactive);
			this.Controls.Add(this.comboBoxClass);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.comboBoxCustomer);
			this.Controls.Add(this.label1);
			this.Name = "EstimateForm";
			this.Text = "EstimateForm";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox checkBoxToBeEmailed;
		private System.Windows.Forms.TextBox textBoxMemo;
		private System.Windows.Forms.ComboBox comboBoxCustomerMessage;
		private System.Windows.Forms.ComboBox comboBoxSalesTaxCode;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.CheckBox checkBoxInactive;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSaveAndClear;
		private System.Windows.Forms.Button buttonSaveAndClose;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxClass;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ComboBox comboBoxCustomer;
		private System.Windows.Forms.Label label1;
	}
}
