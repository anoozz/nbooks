//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class PaymentInvoiceForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxCustomer = new System.Windows.Forms.TextBox();
			this.textBoxAmountDue = new System.Windows.Forms.TextBox();
			this.textBoxAmountPaid = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.textBoxDate = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Customer";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Invoice Date";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Amount Due";
			// 
			// textBoxCustomer
			// 
			this.textBoxCustomer.Location = new System.Drawing.Point(96, 16);
			this.textBoxCustomer.Name = "textBoxCustomer";
			this.textBoxCustomer.ReadOnly = true;
			this.textBoxCustomer.Size = new System.Drawing.Size(176, 21);
			this.textBoxCustomer.TabIndex = 3;
			// 
			// textBoxAmountDue
			// 
			this.textBoxAmountDue.Location = new System.Drawing.Point(96, 64);
			this.textBoxAmountDue.Name = "textBoxAmountDue";
			this.textBoxAmountDue.ReadOnly = true;
			this.textBoxAmountDue.Size = new System.Drawing.Size(100, 21);
			this.textBoxAmountDue.TabIndex = 5;
			this.textBoxAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBoxAmountPaid
			// 
			this.textBoxAmountPaid.Location = new System.Drawing.Point(96, 88);
			this.textBoxAmountPaid.Name = "textBoxAmountPaid";
			this.textBoxAmountPaid.Size = new System.Drawing.Size(100, 21);
			this.textBoxAmountPaid.TabIndex = 7;
			this.textBoxAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Amount Paid";
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(144, 120);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 8;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(224, 120);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 9;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// textBoxDate
			// 
			this.textBoxDate.Location = new System.Drawing.Point(96, 40);
			this.textBoxDate.Name = "textBoxDate";
			this.textBoxDate.ReadOnly = true;
			this.textBoxDate.Size = new System.Drawing.Size(100, 21);
			this.textBoxDate.TabIndex = 10;
			this.textBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// PaymentInvoiceForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(306, 152);
			this.Controls.Add(this.textBoxDate);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.textBoxAmountPaid);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxAmountDue);
			this.Controls.Add(this.textBoxCustomer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "PaymentInvoiceForm";
			this.Text = "Payment Invoice";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBoxCustomer;
		private System.Windows.Forms.TextBox textBoxAmountDue;
		private System.Windows.Forms.TextBox textBoxAmountPaid;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
