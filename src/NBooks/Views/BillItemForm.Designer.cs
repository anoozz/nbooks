//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class BillItemForm
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
			this.textBoxItem = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.textBoxQuantity = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxRate = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxUnit = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonFindItem = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxItem
			// 
			this.textBoxItem.Location = new System.Drawing.Point(80, 8);
			this.textBoxItem.Name = "textBoxItem";
			this.textBoxItem.Size = new System.Drawing.Size(168, 21);
			this.textBoxItem.TabIndex = 23;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(216, 144);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 26;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(136, 144);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 25;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// textBoxQuantity
			// 
			this.textBoxQuantity.Location = new System.Drawing.Point(80, 104);
			this.textBoxQuantity.Name = "textBoxQuantity";
			this.textBoxQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBoxQuantity.Size = new System.Drawing.Size(100, 21);
			this.textBoxQuantity.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 34;
			this.label5.Text = "Quantity";
			// 
			// textBoxRate
			// 
			this.textBoxRate.Location = new System.Drawing.Point(80, 80);
			this.textBoxRate.Name = "textBoxRate";
			this.textBoxRate.ReadOnly = true;
			this.textBoxRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBoxRate.Size = new System.Drawing.Size(100, 21);
			this.textBoxRate.TabIndex = 33;
			this.textBoxRate.TabStop = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 32;
			this.label4.Text = "Price";
			// 
			// textBoxUnit
			// 
			this.textBoxUnit.Location = new System.Drawing.Point(80, 56);
			this.textBoxUnit.Name = "textBoxUnit";
			this.textBoxUnit.ReadOnly = true;
			this.textBoxUnit.Size = new System.Drawing.Size(100, 21);
			this.textBoxUnit.TabIndex = 31;
			this.textBoxUnit.TabStop = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 30;
			this.label3.Text = "Unit";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(80, 32);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.Size = new System.Drawing.Size(200, 21);
			this.textBoxDescription.TabIndex = 29;
			this.textBoxDescription.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 28;
			this.label2.Text = "Description";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 27;
			this.label1.Text = "Item";
			// 
			// buttonFindItem
			// 
			this.buttonFindItem.Location = new System.Drawing.Point(248, 8);
			this.buttonFindItem.Name = "buttonFindItem";
			this.buttonFindItem.Size = new System.Drawing.Size(32, 23);
			this.buttonFindItem.TabIndex = 35;
			this.buttonFindItem.Text = "...";
			this.buttonFindItem.UseVisualStyleBackColor = true;
			// 
			// BillItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(299, 178);
			this.Controls.Add(this.buttonFindItem);
			this.Controls.Add(this.textBoxItem);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.textBoxQuantity);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxRate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxUnit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "BillItemForm";
			this.Text = "Bill Item";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button buttonFindItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxUnit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxRate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxQuantity;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.TextBox textBoxItem;
	}
}
