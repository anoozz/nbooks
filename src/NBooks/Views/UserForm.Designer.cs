//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class UserForm
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
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxModule = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listViewGrantedPriveleges = new System.Windows.Forms.ListView();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.listViewAvailablePriveleges = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(328, 64);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(87, 25);
			this.buttonCancel.TabIndex = 17;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(328, 32);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(87, 25);
			this.buttonOk.TabIndex = 16;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// textBoxConfirmPassword
			// 
			this.textBoxConfirmPassword.Location = new System.Drawing.Point(131, 95);
			this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
			this.textBoxConfirmPassword.PasswordChar = '*';
			this.textBoxConfirmPassword.Size = new System.Drawing.Size(177, 22);
			this.textBoxConfirmPassword.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(19, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 25);
			this.label4.TabIndex = 14;
			this.label4.Text = "Confirm Password";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(9, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(317, 25);
			this.label3.TabIndex = 13;
			this.label3.Text = "Provide a name and an optional password for this user.";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(131, 69);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(177, 22);
			this.textBoxPassword.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(19, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 25);
			this.label2.TabIndex = 11;
			this.label2.Text = "Password";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(131, 43);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(177, 22);
			this.textBoxName.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(19, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 25);
			this.label1.TabIndex = 9;
			this.label1.Text = "User Name";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 18;
			this.label5.Text = "Module";
			// 
			// comboBoxModule
			// 
			this.comboBoxModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxModule.FormattingEnabled = true;
			this.comboBoxModule.Location = new System.Drawing.Point(80, 128);
			this.comboBoxModule.Name = "comboBoxModule";
			this.comboBoxModule.Size = new System.Drawing.Size(121, 22);
			this.comboBoxModule.TabIndex = 19;
			this.comboBoxModule.SelectedIndexChanged += new System.EventHandler(this.ComboBoxModuleSelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listViewGrantedPriveleges);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.buttonRemove);
			this.groupBox1.Controls.Add(this.buttonAdd);
			this.groupBox1.Controls.Add(this.listViewAvailablePriveleges);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(8, 152);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(480, 264);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "User Priveleges";
			// 
			// listViewGrantedPriveleges
			// 
			this.listViewGrantedPriveleges.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader2});
			this.listViewGrantedPriveleges.FullRowSelect = true;
			this.listViewGrantedPriveleges.HideSelection = false;
			this.listViewGrantedPriveleges.Location = new System.Drawing.Point(296, 40);
			this.listViewGrantedPriveleges.MultiSelect = false;
			this.listViewGrantedPriveleges.Name = "listViewGrantedPriveleges";
			this.listViewGrantedPriveleges.Size = new System.Drawing.Size(168, 216);
			this.listViewGrantedPriveleges.TabIndex = 8;
			this.listViewGrantedPriveleges.UseCompatibleStateImageBehavior = false;
			this.listViewGrantedPriveleges.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Commands";
			this.columnHeader2.Width = 140;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(296, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(128, 23);
			this.label7.TabIndex = 7;
			this.label7.Text = "Granted Priveleges";
			// 
			// buttonRemove
			// 
			this.buttonRemove.Location = new System.Drawing.Point(184, 128);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(104, 23);
			this.buttonRemove.TabIndex = 5;
			this.buttonRemove.Text = "< Remove";
			this.buttonRemove.UseVisualStyleBackColor = true;
			this.buttonRemove.Click += new System.EventHandler(this.ButtonRemoveClick);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(184, 96);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(104, 23);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "Add >";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// listViewAvailablePriveleges
			// 
			this.listViewAvailablePriveleges.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1});
			this.listViewAvailablePriveleges.FullRowSelect = true;
			this.listViewAvailablePriveleges.HideSelection = false;
			this.listViewAvailablePriveleges.Location = new System.Drawing.Point(8, 40);
			this.listViewAvailablePriveleges.MultiSelect = false;
			this.listViewAvailablePriveleges.Name = "listViewAvailablePriveleges";
			this.listViewAvailablePriveleges.Size = new System.Drawing.Size(168, 216);
			this.listViewAvailablePriveleges.TabIndex = 1;
			this.listViewAvailablePriveleges.UseCompatibleStateImageBehavior = false;
			this.listViewAvailablePriveleges.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Commands";
			this.columnHeader1.Width = 140;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(128, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "Available Priveleges";
			// 
			// UserForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 423);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.comboBoxModule);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.textBoxConfirmPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label1);
			this.Name = "UserForm";
			this.Text = "New User";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ListView listViewGrantedPriveleges;
		private System.Windows.Forms.ListView listViewAvailablePriveleges;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.ComboBox comboBoxModule;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxConfirmPassword;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
	}
}
