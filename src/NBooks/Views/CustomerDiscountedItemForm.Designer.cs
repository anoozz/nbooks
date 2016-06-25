//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class CustomerDiscountedItemForm
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
			this.buttonFindItem = new System.Windows.Forms.Button();
			this.textBoxCode = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.textBoxDiscount = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxUnit = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonFindItem
			// 
			this.buttonFindItem.Location = new System.Drawing.Point(286, 16);
			this.buttonFindItem.Name = "buttonFindItem";
			this.buttonFindItem.Size = new System.Drawing.Size(37, 25);
			this.buttonFindItem.TabIndex = 37;
			this.buttonFindItem.Text = "...";
			this.buttonFindItem.UseVisualStyleBackColor = true;
			this.buttonFindItem.Click += new System.EventHandler(this.ButtonFindItemClick);
			// 
			// textBoxCode
			// 
			this.textBoxCode.Location = new System.Drawing.Point(100, 16);
			this.textBoxCode.Name = "textBoxCode";
			this.textBoxCode.Size = new System.Drawing.Size(186, 22);
			this.textBoxCode.TabIndex = 36;
			this.textBoxCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCodeKeyDown);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(258, 163);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(87, 25);
			this.buttonCancel.TabIndex = 40;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(165, 163);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(87, 25);
			this.buttonOk.TabIndex = 39;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// textBoxDiscount
			// 
			this.textBoxDiscount.Location = new System.Drawing.Point(100, 120);
			this.textBoxDiscount.Name = "textBoxDiscount";
			this.textBoxDiscount.Size = new System.Drawing.Size(116, 22);
			this.textBoxDiscount.TabIndex = 38;
			this.textBoxDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxDiscountKeyDown);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 25);
			this.label5.TabIndex = 48;
			this.label5.Text = "Discount";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(100, 94);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.ReadOnly = true;
			this.textBoxPrice.Size = new System.Drawing.Size(116, 22);
			this.textBoxPrice.TabIndex = 47;
			this.textBoxPrice.TabStop = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 25);
			this.label4.TabIndex = 46;
			this.label4.Text = "Price";
			// 
			// textBoxUnit
			// 
			this.textBoxUnit.Location = new System.Drawing.Point(100, 68);
			this.textBoxUnit.Name = "textBoxUnit";
			this.textBoxUnit.ReadOnly = true;
			this.textBoxUnit.Size = new System.Drawing.Size(116, 22);
			this.textBoxUnit.TabIndex = 45;
			this.textBoxUnit.TabStop = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 25);
			this.label3.TabIndex = 44;
			this.label3.Text = "Unit";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(100, 42);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.ReadOnly = true;
			this.textBoxName.Size = new System.Drawing.Size(233, 22);
			this.textBoxName.TabIndex = 43;
			this.textBoxName.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 25);
			this.label2.TabIndex = 42;
			this.label2.Text = "Name";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 25);
			this.label1.TabIndex = 41;
			this.label1.Text = "Item";
			// 
			// CustomerDiscountedItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 213);
			this.Controls.Add(this.buttonFindItem);
			this.Controls.Add(this.textBoxCode);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.textBoxDiscount);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxUnit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "CustomerDiscountedItemForm";
			this.Text = "Customer Discounts";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxUnit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxDiscount;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.TextBox textBoxCode;
		private System.Windows.Forms.Button buttonFindItem;
	}
}
