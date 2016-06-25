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
	partial class ServiceItemPane
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
			this.comboBoxParent = new System.Windows.Forms.ComboBox();
			this.checkBoxSubitemOf = new System.Windows.Forms.CheckBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.comboBoxCOGSAccount = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxRate = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
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
			this.groupBox5.Controls.Add(this.comboBoxCOGSAccount);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Controls.Add(this.textBoxRate);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.richTextBoxDescription);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Location = new System.Drawing.Point(8, 72);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(400, 104);
			this.groupBox5.TabIndex = 225;
			this.groupBox5.TabStop = false;
			// 
			// comboBoxCOGSAccount
			// 
			this.comboBoxCOGSAccount.FormattingEnabled = true;
			this.comboBoxCOGSAccount.Location = new System.Drawing.Point(240, 72);
			this.comboBoxCOGSAccount.Name = "comboBoxCOGSAccount";
			this.comboBoxCOGSAccount.Size = new System.Drawing.Size(136, 21);
			this.comboBoxCOGSAccount.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(240, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "Account";
			// 
			// textBoxCost
			// 
			this.textBoxRate.Location = new System.Drawing.Point(240, 32);
			this.textBoxRate.Name = "textBoxCost";
			this.textBoxRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBoxRate.Size = new System.Drawing.Size(72, 21);
			this.textBoxRate.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(240, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Rate";
			// 
			// richTextBoxDescription
			// 
			this.richTextBoxDescription.Location = new System.Drawing.Point(8, 32);
			this.richTextBoxDescription.Name = "richTextBoxDescription";
			this.richTextBoxDescription.Size = new System.Drawing.Size(224, 64);
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
			this.checkBox1.Location = new System.Drawing.Point(8, 48);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(408, 24);
			this.checkBox1.TabIndex = 226;
			this.checkBox1.Text = "This service is used in assemblies or is performed by a subcontractor or partner";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// ServiceItemPane
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.comboBoxParent);
			this.Controls.Add(this.checkBoxSubitemOf);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.labelName);
			this.Name = "ServiceItemPane";
			this.Size = new System.Drawing.Size(413, 183);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextBoxDescription;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxRate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxCOGSAccount;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.CheckBox checkBoxSubitemOf;
		private System.Windows.Forms.ComboBox comboBoxParent;
	}
}
