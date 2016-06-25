//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class ChangePasswordForm
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
			this.textBoxAswer = new System.Windows.Forms.TextBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBoxChallengeQuestion = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxNewPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxAswer
			// 
			this.textBoxAswer.Location = new System.Drawing.Point(136, 224);
			this.textBoxAswer.Name = "textBoxAswer";
			this.textBoxAswer.Size = new System.Drawing.Size(304, 21);
			this.textBoxAswer.TabIndex = 34;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(248, 176);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(208, 23);
			this.linkLabel1.TabIndex = 33;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "How will this help me reset my password?";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(368, 280);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 32;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(288, 280);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 31;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(136, 248);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(176, 23);
			this.label9.TabIndex = 30;
			this.label9.Text = "Answer is not case sensitive.";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 224);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 29;
			this.label8.Text = "Answer";
			// 
			// comboBoxChallengeQuestion
			// 
			this.comboBoxChallengeQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxChallengeQuestion.FormattingEnabled = true;
			this.comboBoxChallengeQuestion.Location = new System.Drawing.Point(136, 200);
			this.comboBoxChallengeQuestion.Name = "comboBoxChallengeQuestion";
			this.comboBoxChallengeQuestion.Size = new System.Drawing.Size(304, 21);
			this.comboBoxChallengeQuestion.TabIndex = 28;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 200);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 27;
			this.label7.Text = "Challenge Question";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(232, 23);
			this.label6.TabIndex = 26;
			this.label6.Text = "Select a challenge question and enter answer.";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(160, 23);
			this.label5.TabIndex = 25;
			this.label5.Text = "Setup Password Reset";
			// 
			// textBoxConfirmPassword
			// 
			this.textBoxConfirmPassword.Location = new System.Drawing.Point(136, 112);
			this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
			this.textBoxConfirmPassword.PasswordChar = '*';
			this.textBoxConfirmPassword.Size = new System.Drawing.Size(120, 21);
			this.textBoxConfirmPassword.TabIndex = 24;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 23);
			this.label4.TabIndex = 23;
			this.label4.Text = "Confirm New Password";
			// 
			// textBoxNewPassword
			// 
			this.textBoxNewPassword.Location = new System.Drawing.Point(136, 88);
			this.textBoxNewPassword.Name = "textBoxNewPassword";
			this.textBoxNewPassword.PasswordChar = '*';
			this.textBoxNewPassword.Size = new System.Drawing.Size(120, 21);
			this.textBoxNewPassword.TabIndex = 22;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 21;
			this.label3.Text = "New Password";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(136, 64);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.ReadOnly = true;
			this.textBoxName.Size = new System.Drawing.Size(120, 21);
			this.textBoxName.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 19;
			this.label2.Text = "User Name";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(424, 32);
			this.label1.TabIndex = 18;
			this.label1.Text = "A complex password is harder to guess and requires at least 7 characters, includi" +
			"ng one number and one uppercase letter (e.g. coMp1ex, Xample2).";
			// 
			// ChangePasswordForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 320);
			this.Controls.Add(this.textBoxAswer);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.comboBoxChallengeQuestion);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxConfirmPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxNewPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ChangePasswordForm";
			this.Text = "Change Password";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBoxAswer;
		private System.Windows.Forms.ComboBox comboBoxChallengeQuestion;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.TextBox textBoxConfirmPassword;
		private System.Windows.Forms.TextBox textBoxNewPassword;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}
