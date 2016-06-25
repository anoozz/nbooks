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
	partial class SalesTaxCodeForm
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
			this.radioButtonNonTaxable = new System.Windows.Forms.RadioButton();
			this.radioButtonTaxable = new System.Windows.Forms.RadioButton();
			this.checkBoxInactive = new System.Windows.Forms.CheckBox();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelNote = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.textBoxCode = new System.Windows.Forms.TextBox();
			this.labelCode = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// radioButtonNonTaxable
			// 
			this.radioButtonNonTaxable.Checked = true;
			this.radioButtonNonTaxable.Location = new System.Drawing.Point(8, 120);
			this.radioButtonNonTaxable.Name = "radioButtonNonTaxable";
			this.radioButtonNonTaxable.Size = new System.Drawing.Size(104, 24);
			this.radioButtonNonTaxable.TabIndex = 115;
			this.radioButtonNonTaxable.TabStop = true;
			this.radioButtonNonTaxable.Text = "Non-taxable";
			this.radioButtonNonTaxable.UseVisualStyleBackColor = true;
			// 
			// radioButtonTaxable
			// 
			this.radioButtonTaxable.Location = new System.Drawing.Point(8, 96);
			this.radioButtonTaxable.Name = "radioButtonTaxable";
			this.radioButtonTaxable.Size = new System.Drawing.Size(104, 24);
			this.radioButtonTaxable.TabIndex = 114;
			this.radioButtonTaxable.TabStop = true;
			this.radioButtonTaxable.Text = "Taxable";
			this.radioButtonTaxable.UseVisualStyleBackColor = true;
			// 
			// checkBoxInactive
			// 
			this.checkBoxInactive.Location = new System.Drawing.Point(208, 88);
			this.checkBoxInactive.Name = "checkBoxInactive";
			this.checkBoxInactive.Size = new System.Drawing.Size(104, 36);
			this.checkBoxInactive.TabIndex = 118;
			this.checkBoxInactive.Text = "Sales tax code is inactive";
			this.checkBoxInactive.UseVisualStyleBackColor = true;
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(8, 72);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(160, 21);
			this.textBoxDescription.TabIndex = 113;
			// 
			// labelDescription
			// 
			this.labelDescription.Location = new System.Drawing.Point(8, 56);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(100, 23);
			this.labelDescription.TabIndex = 121;
			this.labelDescription.Text = "Description";
			// 
			// labelNote
			// 
			this.labelNote.Location = new System.Drawing.Point(72, 32);
			this.labelNote.Name = "labelNote";
			this.labelNote.Size = new System.Drawing.Size(128, 23);
			this.labelNote.TabIndex = 120;
			this.labelNote.Text = "(maximum 3 characters)";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(208, 40);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 117;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(208, 16);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 116;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// textBoxCode
			// 
			this.textBoxCode.Location = new System.Drawing.Point(8, 32);
			this.textBoxCode.Name = "textBoxCode";
			this.textBoxCode.Size = new System.Drawing.Size(64, 21);
			this.textBoxCode.TabIndex = 112;
			// 
			// labelCode
			// 
			this.labelCode.Location = new System.Drawing.Point(8, 16);
			this.labelCode.Name = "labelCode";
			this.labelCode.Size = new System.Drawing.Size(100, 23);
			this.labelCode.TabIndex = 119;
			this.labelCode.Text = "Sales Tax Code";
			// 
			// SalesTaxCodeForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 149);
			this.Controls.Add(this.radioButtonNonTaxable);
			this.Controls.Add(this.radioButtonTaxable);
			this.Controls.Add(this.checkBoxInactive);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.labelNote);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.textBoxCode);
			this.Controls.Add(this.labelCode);
			this.Name = "SalesTaxCodeForm";
			this.Text = "New Sales Tax Code";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labelCode;
		private System.Windows.Forms.TextBox textBoxCode;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelNote;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.CheckBox checkBoxInactive;
		private System.Windows.Forms.RadioButton radioButtonTaxable;
		private System.Windows.Forms.RadioButton radioButtonNonTaxable;
	}
}
