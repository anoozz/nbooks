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
	partial class NonInventoryPartItemPane
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBoxUnit = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxPartNumber = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxParent = new System.Windows.Forms.ComboBox();
			this.checkBoxSubitemOf = new System.Windows.Forms.CheckBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.comboBoxAccount = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBoxTaxCode = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBoxUnit);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(8, 48);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(440, 48);
			this.groupBox2.TabIndex = 226;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Unit of Measure";
			// 
			// comboBoxUnit
			// 
			this.comboBoxUnit.FormattingEnabled = true;
			this.comboBoxUnit.Location = new System.Drawing.Point(72, 16);
			this.comboBoxUnit.Name = "comboBoxUnit";
			this.comboBoxUnit.Size = new System.Drawing.Size(176, 21);
			this.comboBoxUnit.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "U/M Set";
			// 
			// textBoxPartNumber
			// 
			this.textBoxPartNumber.Location = new System.Drawing.Point(288, 24);
			this.textBoxPartNumber.Name = "textBoxPartNumber";
			this.textBoxPartNumber.Size = new System.Drawing.Size(160, 21);
			this.textBoxPartNumber.TabIndex = 225;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(288, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 23);
			this.label2.TabIndex = 224;
			this.label2.Text = "Manufacturer\'s Part Number";
			// 
			// comboBoxParent
			// 
			this.comboBoxParent.Enabled = false;
			this.comboBoxParent.FormattingEnabled = true;
			this.comboBoxParent.Location = new System.Drawing.Point(128, 24);
			this.comboBoxParent.Name = "comboBoxParent";
			this.comboBoxParent.Size = new System.Drawing.Size(152, 21);
			this.comboBoxParent.TabIndex = 223;
			// 
			// checkBoxSubitemOf
			// 
			this.checkBoxSubitemOf.Enabled = false;
			this.checkBoxSubitemOf.Location = new System.Drawing.Point(128, 0);
			this.checkBoxSubitemOf.Name = "checkBoxSubitemOf";
			this.checkBoxSubitemOf.Size = new System.Drawing.Size(104, 24);
			this.checkBoxSubitemOf.TabIndex = 222;
			this.checkBoxSubitemOf.Text = "Subitem of";
			this.checkBoxSubitemOf.UseVisualStyleBackColor = true;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(8, 24);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(112, 21);
			this.textBoxName.TabIndex = 221;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.comboBoxAccount);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Controls.Add(this.comboBoxTaxCode);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Controls.Add(this.textBoxPrice);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.richTextBoxDescription);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Location = new System.Drawing.Point(8, 128);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(440, 96);
			this.groupBox5.TabIndex = 227;
			this.groupBox5.TabStop = false;
			// 
			// comboBoxAccount
			// 
			this.comboBoxAccount.FormattingEnabled = true;
			this.comboBoxAccount.Location = new System.Drawing.Point(304, 64);
			this.comboBoxAccount.Name = "comboBoxAccount";
			this.comboBoxAccount.Size = new System.Drawing.Size(128, 21);
			this.comboBoxAccount.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(240, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Account";
			// 
			// comboBoxTaxCode
			// 
			this.comboBoxTaxCode.FormattingEnabled = true;
			this.comboBoxTaxCode.Location = new System.Drawing.Point(304, 40);
			this.comboBoxTaxCode.Name = "comboBoxTaxCode";
			this.comboBoxTaxCode.Size = new System.Drawing.Size(72, 21);
			this.comboBoxTaxCode.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(240, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "Tax Code";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(304, 16);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBoxPrice.Size = new System.Drawing.Size(72, 21);
			this.textBoxPrice.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(240, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Price";
			// 
			// richTextBoxDescription
			// 
			this.richTextBoxDescription.Location = new System.Drawing.Point(8, 32);
			this.richTextBoxDescription.Name = "richTextBoxDescription";
			this.richTextBoxDescription.Size = new System.Drawing.Size(224, 56);
			this.richTextBoxDescription.TabIndex = 1;
			this.richTextBoxDescription.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(200, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Description";
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(8, 8);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(100, 23);
			this.labelName.TabIndex = 220;
			this.labelName.Text = "Item Name/Number";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(8, 104);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(424, 24);
			this.checkBox1.TabIndex = 228;
			this.checkBox1.Text = "This item is used in assemblies or is purchased for a specific customer:job";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// NonInventoryPartItemPane
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.textBoxPartNumber);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxParent);
			this.Controls.Add(this.checkBoxSubitemOf);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.labelName);
			this.Name = "NonInventoryPartItemPane";
			this.Size = new System.Drawing.Size(455, 233);
			this.groupBox2.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBoxPartNumber;
		private System.Windows.Forms.ComboBox comboBoxAccount;
		private System.Windows.Forms.ComboBox comboBoxTaxCode;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.RichTextBox richTextBoxDescription;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.CheckBox checkBoxSubitemOf;
		private System.Windows.Forms.ComboBox comboBoxParent;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxUnit;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}
