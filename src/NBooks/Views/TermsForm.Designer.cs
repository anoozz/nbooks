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
	partial class TermsForm
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
			this.checkBoxInactive = new System.Windows.Forms.CheckBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// checkBoxInactive
			// 
			this.checkBoxInactive.Location = new System.Drawing.Point(264, 88);
			this.checkBoxInactive.Name = "checkBoxInactive";
			this.checkBoxInactive.Size = new System.Drawing.Size(104, 36);
			this.checkBoxInactive.TabIndex = 307;
			this.checkBoxInactive.Text = "Terms is inactive";
			this.checkBoxInactive.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(264, 40);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 306;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(264, 16);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 305;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(224, 232);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(112, 23);
			this.label14.TabIndex = 304;
			this.label14.Text = "th day of the month.";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(160, 232);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(64, 21);
			this.textBox8.TabIndex = 303;
			this.textBox8.Text = "1";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(24, 232);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(144, 23);
			this.label15.TabIndex = 302;
			this.label15.Text = "Discount if paid before the";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(208, 208);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 23);
			this.label8.TabIndex = 301;
			this.label8.Text = ".";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(144, 208);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(64, 21);
			this.textBox5.TabIndex = 300;
			this.textBox5.Text = "0.00";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(24, 208);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(168, 23);
			this.label9.TabIndex = 299;
			this.label9.Text = "Discount percentage is";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(264, 184);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 298;
			this.label10.Text = "days of due date.";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(200, 184);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(64, 21);
			this.textBox6.TabIndex = 297;
			this.textBox6.Text = "0";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(24, 184);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(184, 23);
			this.label11.TabIndex = 296;
			this.label11.Text = "Due the next month if issued within";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(192, 160);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(112, 23);
			this.label12.TabIndex = 295;
			this.label12.Text = "th day of the month.";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(128, 160);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(64, 21);
			this.textBox7.TabIndex = 294;
			this.textBox7.Text = "1";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(24, 160);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 293;
			this.label13.Text = "Net due before the";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(8, 136);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 292;
			this.radioButton2.Text = "Date Driven";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(200, 112);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 23);
			this.label6.TabIndex = 291;
			this.label6.Text = "days.";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(136, 112);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(64, 21);
			this.textBox4.TabIndex = 290;
			this.textBox4.Text = "0";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(160, 23);
			this.label7.TabIndex = 289;
			this.label7.Text = "Discount if paid within";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(208, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 23);
			this.label4.TabIndex = 288;
			this.label4.Text = ".";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(144, 88);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(64, 21);
			this.textBox3.TabIndex = 287;
			this.textBox3.Text = "0.00";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(160, 23);
			this.label5.TabIndex = 286;
			this.label5.Text = "Discount percentage is";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(152, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 285;
			this.label3.Text = "days.";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(88, 64);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(64, 21);
			this.textBox2.TabIndex = 284;
			this.textBox2.Text = "0";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 283;
			this.label2.Text = "Net due in";
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(8, 40);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 282;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Standard";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(48, 8);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(184, 21);
			this.textBoxName.TabIndex = 281;
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(8, 8);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(100, 23);
			this.labelName.TabIndex = 280;
			this.labelName.Text = "Terms";
			// 
			// TermsForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 263);
			this.Controls.Add(this.checkBoxInactive);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelName);
			this.Name = "TermsForm";
			this.Text = "New Terms";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.CheckBox checkBoxInactive;
	}
}
