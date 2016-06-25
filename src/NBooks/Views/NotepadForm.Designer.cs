//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class NotepadForm
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
			this.buttonPrint = new System.Windows.Forms.Button();
			this.buttonNewToDo = new System.Windows.Forms.Button();
			this.buttonDateStamp = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
			this.groupBoxNotes = new System.Windows.Forms.GroupBox();
			this.labelName = new System.Windows.Forms.Label();
			this.groupBoxNotes.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonPrint
			// 
			this.buttonPrint.Location = new System.Drawing.Point(296, 160);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(96, 23);
			this.buttonPrint.TabIndex = 87;
			this.buttonPrint.Text = "Print...";
			this.buttonPrint.UseVisualStyleBackColor = true;
			// 
			// buttonNewToDo
			// 
			this.buttonNewToDo.Location = new System.Drawing.Point(296, 120);
			this.buttonNewToDo.Name = "buttonNewToDo";
			this.buttonNewToDo.Size = new System.Drawing.Size(96, 23);
			this.buttonNewToDo.TabIndex = 86;
			this.buttonNewToDo.Text = "New To Do...";
			this.buttonNewToDo.UseVisualStyleBackColor = true;
			// 
			// buttonDateStamp
			// 
			this.buttonDateStamp.Location = new System.Drawing.Point(296, 96);
			this.buttonDateStamp.Name = "buttonDateStamp";
			this.buttonDateStamp.Size = new System.Drawing.Size(96, 23);
			this.buttonDateStamp.TabIndex = 85;
			this.buttonDateStamp.Text = "Date Stamp";
			this.buttonDateStamp.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(296, 40);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(96, 23);
			this.buttonCancel.TabIndex = 83;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(296, 16);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(96, 23);
			this.buttonOk.TabIndex = 82;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// richTextBoxNotes
			// 
			this.richTextBoxNotes.Location = new System.Drawing.Point(8, 120);
			this.richTextBoxNotes.Name = "richTextBoxNotes";
			this.richTextBoxNotes.Size = new System.Drawing.Size(280, 200);
			this.richTextBoxNotes.TabIndex = 81;
			this.richTextBoxNotes.Text = "";
			// 
			// groupBoxNotes
			// 
			this.groupBoxNotes.Controls.Add(this.labelName);
			this.groupBoxNotes.Location = new System.Drawing.Point(8, 8);
			this.groupBoxNotes.Name = "groupBoxNotes";
			this.groupBoxNotes.Size = new System.Drawing.Size(280, 100);
			this.groupBoxNotes.TabIndex = 80;
			this.groupBoxNotes.TabStop = false;
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(8, 16);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(264, 72);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "label1";
			// 
			// NotepadForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 329);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.buttonNewToDo);
			this.Controls.Add(this.buttonDateStamp);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.richTextBoxNotes);
			this.Controls.Add(this.groupBoxNotes);
			this.Name = "NotepadForm";
			this.Text = "NotepadForm";
			this.groupBoxNotes.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.GroupBox groupBoxNotes;
		private System.Windows.Forms.RichTextBox richTextBoxNotes;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonDateStamp;
		private System.Windows.Forms.Button buttonNewToDo;
		private System.Windows.Forms.Button buttonPrint;
	}
}
