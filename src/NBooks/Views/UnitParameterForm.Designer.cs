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
	partial class UnitParameterForm
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
			this.comboBoxUnit = new System.Windows.Forms.ComboBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.checkBoxAll = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Unit of Measure";
			// 
			// comboBoxUnit
			// 
			this.comboBoxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxUnit.Enabled = false;
			this.comboBoxUnit.FormattingEnabled = true;
			this.comboBoxUnit.Items.AddRange(new object[] {
									"FULL CASE",
									"MT CASE",
									"FULL BOTTLE",
									"MT BOTTLE",
									"PACK",
									"PCS",
									"SHELL",
									"BOX"});
			this.comboBoxUnit.Location = new System.Drawing.Point(21, 37);
			this.comboBoxUnit.Name = "comboBoxUnit";
			this.comboBoxUnit.Size = new System.Drawing.Size(179, 21);
			this.comboBoxUnit.TabIndex = 1;
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(103, 89);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 2;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(184, 88);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// checkBoxAll
			// 
			this.checkBoxAll.Checked = true;
			this.checkBoxAll.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxAll.Location = new System.Drawing.Point(21, 67);
			this.checkBoxAll.Name = "checkBoxAll";
			this.checkBoxAll.Size = new System.Drawing.Size(89, 22);
			this.checkBoxAll.TabIndex = 4;
			this.checkBoxAll.Text = "All";
			this.checkBoxAll.UseVisualStyleBackColor = true;
			this.checkBoxAll.CheckedChanged += new System.EventHandler(this.CheckBoxAllCheckedChanged);
			// 
			// UnitParameterForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(268, 121);
			this.Controls.Add(this.checkBoxAll);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.comboBoxUnit);
			this.Controls.Add(this.label1);
			this.Name = "UnitParameterForm";
			this.Text = "Unit Parameter";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox checkBoxAll;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.ComboBox comboBoxUnit;
		private System.Windows.Forms.Label label1;
	}
}
