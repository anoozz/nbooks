//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class UserListForm
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
			this.buttonClosingDate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonView = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.listBoxUsers = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// buttonClosingDate
			// 
			this.buttonClosingDate.Location = new System.Drawing.Point(120, 176);
			this.buttonClosingDate.Name = "buttonClosingDate";
			this.buttonClosingDate.Size = new System.Drawing.Size(88, 23);
			this.buttonClosingDate.TabIndex = 42;
			this.buttonClosingDate.Text = "Closing Date...";
			this.buttonClosingDate.UseVisualStyleBackColor = true;
			this.buttonClosingDate.Click += new System.EventHandler(this.ButtonClosingDateClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 176);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 41;
			this.label1.Text = "Set the closing date:";
			// 
			// buttonView
			// 
			this.buttonView.Location = new System.Drawing.Point(240, 96);
			this.buttonView.Name = "buttonView";
			this.buttonView.Size = new System.Drawing.Size(96, 23);
			this.buttonView.TabIndex = 39;
			this.buttonView.Text = "View User";
			this.buttonView.UseVisualStyleBackColor = true;
			// 
			// buttonClose
			// 
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClose.Location = new System.Drawing.Point(240, 144);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(96, 23);
			this.buttonClose.TabIndex = 38;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(240, 72);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(96, 23);
			this.buttonDelete.TabIndex = 37;
			this.buttonDelete.Text = "Delete User";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Location = new System.Drawing.Point(240, 32);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(96, 23);
			this.buttonEdit.TabIndex = 36;
			this.buttonEdit.Text = "Edit User...";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.ButtonEditClick);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(240, 8);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(96, 23);
			this.buttonAdd.TabIndex = 35;
			this.buttonAdd.Text = "Add User...";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// listBox1
			// 
			this.listBoxUsers.FormattingEnabled = true;
			this.listBoxUsers.Location = new System.Drawing.Point(8, 8);
			this.listBoxUsers.Name = "listBox1";
			this.listBoxUsers.Size = new System.Drawing.Size(224, 160);
			this.listBoxUsers.TabIndex = 34;
			// 
			// UserListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 213);
			this.Controls.Add(this.buttonClosingDate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonView);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.listBoxUsers);
			this.Name = "UserListForm";
			this.Text = "User List";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonClosingDate;
		private System.Windows.Forms.ListBox listBoxUsers;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonClose;
	}
}
