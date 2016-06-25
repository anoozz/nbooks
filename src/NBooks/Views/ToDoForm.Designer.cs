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
	partial class ToDoForm
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
			this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePickerRemindOn = new System.Windows.Forms.DateTimePicker();
			this.checkBoxDone = new System.Windows.Forms.CheckBox();
			this.checkBoxInactive = new System.Windows.Forms.CheckBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Note";
			// 
			// richTextBoxNote
			// 
			this.richTextBoxNote.Location = new System.Drawing.Point(8, 24);
			this.richTextBoxNote.MaxLength = 500;
			this.richTextBoxNote.Name = "richTextBoxNote";
			this.richTextBoxNote.Size = new System.Drawing.Size(256, 240);
			this.richTextBoxNote.TabIndex = 1;
			this.richTextBoxNote.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(272, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Remind On";
			// 
			// dateTimePickerRemindOn
			// 
			this.dateTimePickerRemindOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerRemindOn.Location = new System.Drawing.Point(272, 24);
			this.dateTimePickerRemindOn.Name = "dateTimePickerRemindOn";
			this.dateTimePickerRemindOn.Size = new System.Drawing.Size(88, 20);
			this.dateTimePickerRemindOn.TabIndex = 3;
			// 
			// checkBoxDone
			// 
			this.checkBoxDone.Location = new System.Drawing.Point(272, 240);
			this.checkBoxDone.Name = "checkBoxDone";
			this.checkBoxDone.Size = new System.Drawing.Size(104, 24);
			this.checkBoxDone.TabIndex = 4;
			this.checkBoxDone.Text = "Done";
			this.checkBoxDone.UseVisualStyleBackColor = true;
			// 
			// checkBoxInactive
			// 
			this.checkBoxInactive.Location = new System.Drawing.Point(376, 88);
			this.checkBoxInactive.Name = "checkBoxInactive";
			this.checkBoxInactive.Size = new System.Drawing.Size(104, 36);
			this.checkBoxInactive.TabIndex = 8;
			this.checkBoxInactive.Text = "To do note is inactive";
			this.checkBoxInactive.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(376, 40);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(376, 16);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 6;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// ToDoForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 288);
			this.Controls.Add(this.checkBoxInactive);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.checkBoxDone);
			this.Controls.Add(this.dateTimePickerRemindOn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.richTextBoxNote);
			this.Controls.Add(this.label1);
			this.Name = "ToDoForm";
			this.Text = "New To Do";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox checkBoxDone;
		private System.Windows.Forms.DateTimePicker dateTimePickerRemindOn;
		private System.Windows.Forms.RichTextBox richTextBoxNote;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.CheckBox checkBoxInactive;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
