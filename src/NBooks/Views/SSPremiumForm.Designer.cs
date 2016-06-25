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
	partial class SSPremiumForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxContribution = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxEE = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxEC = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxER = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxRangeTo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxRangeFrom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBoxInactive = new System.Windows.Forms.CheckBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.textBoxCode = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxContribution);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.textBoxEE);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textBoxEC);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBoxER);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBoxRangeTo);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBoxRangeFrom);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(8, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(192, 184);
			this.groupBox1.TabIndex = 40;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Range Compensation";
			// 
			// textBoxContribution
			// 
			this.textBoxContribution.Location = new System.Drawing.Point(80, 152);
			this.textBoxContribution.Name = "textBoxContribution";
			this.textBoxContribution.Size = new System.Drawing.Size(104, 20);
			this.textBoxContribution.TabIndex = 11;
			this.textBoxContribution.Text = "0.00";
			this.textBoxContribution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "Contribution";
			// 
			// textBoxEE
			// 
			this.textBoxEE.Location = new System.Drawing.Point(80, 120);
			this.textBoxEE.Name = "textBoxEE";
			this.textBoxEE.Size = new System.Drawing.Size(104, 20);
			this.textBoxEE.TabIndex = 9;
			this.textBoxEE.Text = "0.00";
			this.textBoxEE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 120);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 8;
			this.label6.Text = "EE";
			// 
			// textBoxEC
			// 
			this.textBoxEC.Location = new System.Drawing.Point(80, 96);
			this.textBoxEC.Name = "textBoxEC";
			this.textBoxEC.Size = new System.Drawing.Size(104, 20);
			this.textBoxEC.TabIndex = 7;
			this.textBoxEC.Text = "0.00";
			this.textBoxEC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "EC";
			// 
			// textBoxER
			// 
			this.textBoxER.Location = new System.Drawing.Point(80, 72);
			this.textBoxER.Name = "textBoxER";
			this.textBoxER.Size = new System.Drawing.Size(104, 20);
			this.textBoxER.TabIndex = 5;
			this.textBoxER.Text = "0.00";
			this.textBoxER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "ER";
			// 
			// textBoxRangeTo
			// 
			this.textBoxRangeTo.Location = new System.Drawing.Point(80, 48);
			this.textBoxRangeTo.Name = "textBoxRangeTo";
			this.textBoxRangeTo.Size = new System.Drawing.Size(104, 20);
			this.textBoxRangeTo.TabIndex = 3;
			this.textBoxRangeTo.Text = "0.00";
			this.textBoxRangeTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Up to";
			// 
			// textBoxRangeFrom
			// 
			this.textBoxRangeFrom.Location = new System.Drawing.Point(80, 24);
			this.textBoxRangeFrom.Name = "textBoxRangeFrom";
			this.textBoxRangeFrom.Size = new System.Drawing.Size(104, 20);
			this.textBoxRangeFrom.TabIndex = 1;
			this.textBoxRangeFrom.Text = "0.00";
			this.textBoxRangeFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "From";
			// 
			// checkBoxInactive
			// 
			this.checkBoxInactive.Location = new System.Drawing.Point(216, 80);
			this.checkBoxInactive.Name = "checkBoxInactive";
			this.checkBoxInactive.Size = new System.Drawing.Size(104, 36);
			this.checkBoxInactive.TabIndex = 39;
			this.checkBoxInactive.Text = "SSS premium is inactive";
			this.checkBoxInactive.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonCancel.Location = new System.Drawing.Point(216, 40);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 38;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonOk
			// 
			this.buttonOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonOk.Location = new System.Drawing.Point(216, 16);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 37;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// textBoxCode
			// 
			this.textBoxCode.Location = new System.Drawing.Point(8, 24);
			this.textBoxCode.Name = "textBoxCode";
			this.textBoxCode.Size = new System.Drawing.Size(184, 20);
			this.textBoxCode.TabIndex = 36;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 23);
			this.label1.TabIndex = 35;
			this.label1.Text = "Monthly Bracket Salary Code";
			// 
			// SSSPremiumForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 265);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.checkBoxInactive);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.textBoxCode);
			this.Controls.Add(this.label1);
			this.Name = "SSSPremiumForm";
			this.Text = "New SSS Premium";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxCode;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.CheckBox checkBoxInactive;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxRangeFrom;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxRangeTo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxER;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxEC;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxEE;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxContribution;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
