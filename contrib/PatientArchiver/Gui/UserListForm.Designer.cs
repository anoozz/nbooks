/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 2/21/2011
 * Time: 2:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace PatientArchiver.Gui
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.buttonAddUser = new System.Windows.Forms.Button();
			this.buttonEditUser = new System.Windows.Forms.Button();
			this.buttonDeleteUser = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(8, 32);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 95);
			this.listBox1.TabIndex = 0;
			// 
			// buttonAddUser
			// 
			this.buttonAddUser.Location = new System.Drawing.Point(168, 40);
			this.buttonAddUser.Name = "buttonAddUser";
			this.buttonAddUser.Size = new System.Drawing.Size(88, 23);
			this.buttonAddUser.TabIndex = 1;
			this.buttonAddUser.Text = "Add User...";
			this.buttonAddUser.UseVisualStyleBackColor = true;
			// 
			// buttonEditUser
			// 
			this.buttonEditUser.Location = new System.Drawing.Point(168, 64);
			this.buttonEditUser.Name = "buttonEditUser";
			this.buttonEditUser.Size = new System.Drawing.Size(88, 23);
			this.buttonEditUser.TabIndex = 2;
			this.buttonEditUser.Text = "Edit User...";
			this.buttonEditUser.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteUser
			// 
			this.buttonDeleteUser.Location = new System.Drawing.Point(168, 104);
			this.buttonDeleteUser.Name = "buttonDeleteUser";
			this.buttonDeleteUser.Size = new System.Drawing.Size(88, 23);
			this.buttonDeleteUser.TabIndex = 3;
			this.buttonDeleteUser.Text = "Delete User";
			this.buttonDeleteUser.UseVisualStyleBackColor = true;
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(168, 152);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(88, 23);
			this.buttonClose.TabIndex = 4;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
			// 
			// UserListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonDeleteUser);
			this.Controls.Add(this.buttonEditUser);
			this.Controls.Add(this.buttonAddUser);
			this.Controls.Add(this.listBox1);
			this.Name = "UserListForm";
			this.Text = "UserListForm";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonDeleteUser;
		private System.Windows.Forms.Button buttonEditUser;
		private System.Windows.Forms.Button buttonAddUser;
		private System.Windows.Forms.ListBox listBox1;
	}
}
