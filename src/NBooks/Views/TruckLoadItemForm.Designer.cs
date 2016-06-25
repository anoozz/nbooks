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
	partial class TruckLoadItemForm
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
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxUnit = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxItem = new System.Windows.Forms.TextBox();
			this.buttonFindItem = new System.Windows.Forms.Button();
			this.textBoxDiscount = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxQuantity = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(231, 171);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(151, 171);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 5;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(14, 134);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 22;
			this.label5.Text = "Quantity";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(89, 88);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.ReadOnly = true;
			this.textBoxPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBoxPrice.Size = new System.Drawing.Size(100, 21);
			this.textBoxPrice.TabIndex = 21;
			this.textBoxPrice.TabStop = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "Price";
			// 
			// textBoxUnit
			// 
			this.textBoxUnit.Location = new System.Drawing.Point(88, 64);
			this.textBoxUnit.Name = "textBoxUnit";
			this.textBoxUnit.ReadOnly = true;
			this.textBoxUnit.Size = new System.Drawing.Size(100, 21);
			this.textBoxUnit.TabIndex = 19;
			this.textBoxUnit.TabStop = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "Unit";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(88, 40);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.Size = new System.Drawing.Size(200, 21);
			this.textBoxDescription.TabIndex = 17;
			this.textBoxDescription.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "Description";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "Item";
			// 
			// textBoxItem
			// 
			this.textBoxItem.Location = new System.Drawing.Point(88, 16);
			this.textBoxItem.Name = "textBoxItem";
			this.textBoxItem.Size = new System.Drawing.Size(152, 21);
			this.textBoxItem.TabIndex = 0;
			// 
			// buttonFindItem
			// 
			this.buttonFindItem.Location = new System.Drawing.Point(240, 16);
			this.buttonFindItem.Name = "buttonFindItem";
			this.buttonFindItem.Size = new System.Drawing.Size(32, 23);
			this.buttonFindItem.TabIndex = 2;
			this.buttonFindItem.Text = "...";
			this.buttonFindItem.UseVisualStyleBackColor = true;
			// 
			// textBoxDiscount
			// 
			this.textBoxDiscount.Location = new System.Drawing.Point(89, 111);
			this.textBoxDiscount.Name = "textBoxDiscount";
			this.textBoxDiscount.ReadOnly = true;
			this.textBoxDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBoxDiscount.Size = new System.Drawing.Size(100, 21);
			this.textBoxDiscount.TabIndex = 3;
			this.textBoxDiscount.TabStop = false;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(14, 111);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 24;
			this.label6.Text = "Discount";
			// 
			// textBoxQuantity
			// 
			this.textBoxQuantity.Location = new System.Drawing.Point(89, 134);
			this.textBoxQuantity.Name = "textBoxQuantity";
			this.textBoxQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBoxQuantity.Size = new System.Drawing.Size(100, 21);
			this.textBoxQuantity.TabIndex = 4;
			// 
			// TruckLoadItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 205);
			this.Controls.Add(this.textBoxQuantity);
			this.Controls.Add(this.textBoxDiscount);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.buttonFindItem);
			this.Controls.Add(this.textBoxItem);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxUnit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "TruckLoadItemForm";
			this.Text = "Truck Load Item";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.TextBox textBoxDiscount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonFindItem;
		private System.Windows.Forms.TextBox textBoxItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxUnit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxQuantity;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
	}
}
