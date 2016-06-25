//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class BillAccountForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxAccount = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxAmount = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxMemo = new System.Windows.Forms.TextBox();
			this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.checkBoxBillable = new System.Windows.Forms.CheckBox();
			this.comboBoxClass = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Account";
			// 
			// comboBoxAccount
			// 
			this.comboBoxAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAccount.FormattingEnabled = true;
			this.comboBoxAccount.Location = new System.Drawing.Point(64, 8);
			this.comboBoxAccount.Name = "comboBoxAccount";
			this.comboBoxAccount.Size = new System.Drawing.Size(121, 21);
			this.comboBoxAccount.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Amount";
			// 
			// textBoxAmount
			// 
			this.textBoxAmount.Location = new System.Drawing.Point(64, 32);
			this.textBoxAmount.Name = "textBoxAmount";
			this.textBoxAmount.Size = new System.Drawing.Size(100, 21);
			this.textBoxAmount.TabIndex = 3;
			this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(128, 160);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Ok";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(208, 160);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Memo";
			// 
			// textBoxMemo
			// 
			this.textBoxMemo.Location = new System.Drawing.Point(64, 56);
			this.textBoxMemo.Name = "textBoxMemo";
			this.textBoxMemo.Size = new System.Drawing.Size(176, 21);
			this.textBoxMemo.TabIndex = 7;
			// 
			// comboBoxCustomer
			// 
			this.comboBoxCustomer.FormattingEnabled = true;
			this.comboBoxCustomer.Location = new System.Drawing.Point(64, 80);
			this.comboBoxCustomer.Name = "comboBoxCustomer";
			this.comboBoxCustomer.Size = new System.Drawing.Size(121, 21);
			this.comboBoxCustomer.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Customer";
			// 
			// checkBoxBillable
			// 
			this.checkBoxBillable.Location = new System.Drawing.Point(8, 104);
			this.checkBoxBillable.Name = "checkBoxBillable";
			this.checkBoxBillable.Size = new System.Drawing.Size(104, 24);
			this.checkBoxBillable.TabIndex = 10;
			this.checkBoxBillable.Text = "Billable";
			this.checkBoxBillable.UseVisualStyleBackColor = true;
			// 
			// comboBoxClass
			// 
			this.comboBoxClass.FormattingEnabled = true;
			this.comboBoxClass.Location = new System.Drawing.Point(64, 128);
			this.comboBoxClass.Name = "comboBoxClass";
			this.comboBoxClass.Size = new System.Drawing.Size(88, 21);
			this.comboBoxClass.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Class";
			// 
			// BillAccountForm
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 192);
			this.Controls.Add(this.comboBoxClass);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.checkBoxBillable);
			this.Controls.Add(this.comboBoxCustomer);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxMemo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxAmount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxAccount);
			this.Controls.Add(this.label1);
			this.Name = "BillAccountForm";
			this.Text = "New Bill Account";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox comboBoxClass;
		private System.Windows.Forms.CheckBox checkBoxBillable;
		private System.Windows.Forms.ComboBox comboBoxCustomer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxMemo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBoxAmount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxAccount;
		private System.Windows.Forms.Label label1;
	}
}
