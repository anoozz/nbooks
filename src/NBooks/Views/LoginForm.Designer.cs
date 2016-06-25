//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonHelp = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonResetPassword = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelCompanyName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, 120);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(72, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 67;
			this.pictureBox1.TabStop = false;
			// 
			// buttonHelp
			// 
			this.buttonHelp.Location = new System.Drawing.Point(200, 176);
			this.buttonHelp.Name = "buttonHelp";
			this.buttonHelp.Size = new System.Drawing.Size(75, 23);
			this.buttonHelp.TabIndex = 66;
			this.buttonHelp.Text = "Help";
			this.buttonHelp.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(112, 176);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 65;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(24, 176);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 64;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// buttonResetPassword
			// 
			this.buttonResetPassword.Location = new System.Drawing.Point(200, 144);
			this.buttonResetPassword.Name = "buttonResetPassword";
			this.buttonResetPassword.Size = new System.Drawing.Size(128, 23);
			this.buttonResetPassword.TabIndex = 63;
			this.buttonResetPassword.Text = "Reset Password...";
			this.buttonResetPassword.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(120, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(256, 23);
			this.label5.TabIndex = 62;
			this.label5.Text = "Passwords are case-sensitive.";
			// 
			// linkLabelForgotPassword
			// 
			this.linkLabelForgotPassword.Location = new System.Drawing.Point(264, 96);
			this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
			this.linkLabelForgotPassword.Size = new System.Drawing.Size(120, 23);
			this.linkLabelForgotPassword.TabIndex = 61;
			this.linkLabelForgotPassword.TabStop = true;
			this.linkLabelForgotPassword.Text = "Forgot your password?";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(120, 96);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(136, 21);
			this.textBoxPassword.TabIndex = 60;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(120, 72);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(136, 21);
			this.textBoxName.TabIndex = 59;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 58;
			this.label4.Text = "Password";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 57;
			this.label3.Text = "User Name";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelCompanyName
			// 
			this.labelCompanyName.Location = new System.Drawing.Point(16, 40);
			this.labelCompanyName.Name = "labelCompanyName";
			this.labelCompanyName.Size = new System.Drawing.Size(368, 23);
			this.labelCompanyName.TabIndex = 56;
			this.labelCompanyName.Text = "Company Name";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(368, 23);
			this.label1.TabIndex = 55;
			this.label1.Text = "Please enter your user name and password to log in:";
			// 
			// LoginForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 210);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonHelp);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonResetPassword);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.linkLabelForgotPassword);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelCompanyName);
			this.Controls.Add(this.label1);
			this.Name = "LoginForm";
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button buttonResetPassword;
		private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
		private System.Windows.Forms.Label labelCompanyName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonHelp;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
