//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class ItemReceiptItemForm
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
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.textBoxUnit = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonFindItem = new System.Windows.Forms.Button();
			this.textBoxItem = new System.Windows.Forms.TextBox();
			this.textBoxDiscount = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxQuantity = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Item";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name";
			// 
			// textBoxName
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(80, 40);
			this.textBoxDescription.Name = "textBoxName";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.Size = new System.Drawing.Size(200, 21);
			this.textBoxDescription.TabIndex = 3;
			this.textBoxDescription.TabStop = false;
			// 
			// textBoxUnit
			// 
			this.textBoxUnit.Location = new System.Drawing.Point(80, 64);
			this.textBoxUnit.Name = "textBoxUnit";
			this.textBoxUnit.ReadOnly = true;
			this.textBoxUnit.Size = new System.Drawing.Size(100, 21);
			this.textBoxUnit.TabIndex = 5;
			this.textBoxUnit.TabStop = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Unit";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(80, 88);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.ReadOnly = true;
			this.textBoxPrice.Size = new System.Drawing.Size(100, 21);
			this.textBoxPrice.TabIndex = 7;
			this.textBoxPrice.TabStop = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Price";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(7, 134);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Quantity";
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(137, 171);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 4;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(217, 171);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonFindItem
			// 
			this.buttonFindItem.Location = new System.Drawing.Point(240, 16);
			this.buttonFindItem.Name = "buttonFindItem";
			this.buttonFindItem.Size = new System.Drawing.Size(32, 23);
			this.buttonFindItem.TabIndex = 2;
			this.buttonFindItem.Text = "...";
			this.buttonFindItem.UseVisualStyleBackColor = true;
			this.buttonFindItem.Click += new System.EventHandler(this.ButtonFindItemClick);
			// 
			// textBoxCode
			// 
			this.textBoxItem.Location = new System.Drawing.Point(80, 16);
			this.textBoxItem.Name = "textBoxCode";
			this.textBoxItem.Size = new System.Drawing.Size(160, 21);
			this.textBoxItem.TabIndex = 1;
			// 
			// textBoxDiscount
			// 
			this.textBoxDiscount.Location = new System.Drawing.Point(79, 111);
			this.textBoxDiscount.Name = "textBoxDiscount";
			this.textBoxDiscount.ReadOnly = true;
			this.textBoxDiscount.Size = new System.Drawing.Size(100, 21);
			this.textBoxDiscount.TabIndex = 9;
			this.textBoxDiscount.TabStop = false;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(7, 111);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 22);
			this.label6.TabIndex = 10;
			this.label6.Text = "Discount";
			// 
			// textBoxQuantity
			// 
			this.textBoxQuantity.Location = new System.Drawing.Point(79, 134);
			this.textBoxQuantity.Name = "textBoxQuantity";
			this.textBoxQuantity.Size = new System.Drawing.Size(100, 21);
			this.textBoxQuantity.TabIndex = 3;
			// 
			// ItemReceiptItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(301, 206);
			this.Controls.Add(this.textBoxDiscount);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.buttonFindItem);
			this.Controls.Add(this.textBoxItem);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.textBoxQuantity);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxUnit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ItemReceiptItemForm";
			this.Text = "Item Receipt Item";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxDiscount;
		private System.Windows.Forms.TextBox textBoxItem;
		private System.Windows.Forms.Button buttonFindItem;
		private System.Windows.Forms.TextBox textBoxQuantity;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.TextBox textBoxUnit;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
