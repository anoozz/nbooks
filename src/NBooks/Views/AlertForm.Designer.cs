//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class AlertForm
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
			this.button3 = new System.Windows.Forms.Button();
			this.buttonMarkAsDone = new System.Windows.Forms.Button();
			this.buttonRemindMeAgain = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(272, 112);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Help";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// buttonMarkAsDone
			// 
			this.buttonMarkAsDone.Location = new System.Drawing.Point(160, 112);
			this.buttonMarkAsDone.Name = "buttonMarkAsDone";
			this.buttonMarkAsDone.Size = new System.Drawing.Size(104, 23);
			this.buttonMarkAsDone.TabIndex = 4;
			this.buttonMarkAsDone.Text = "Mark as Done";
			this.buttonMarkAsDone.UseVisualStyleBackColor = true;
			this.buttonMarkAsDone.Click += new System.EventHandler(this.ButtonMarkAsDoneClick);
			// 
			// buttonRemindMeAgain
			// 
			this.buttonRemindMeAgain.Location = new System.Drawing.Point(24, 112);
			this.buttonRemindMeAgain.Name = "buttonRemindMeAgain";
			this.buttonRemindMeAgain.Size = new System.Drawing.Size(120, 23);
			this.buttonRemindMeAgain.TabIndex = 3;
			this.buttonRemindMeAgain.Text = "Remind Me Again";
			this.buttonRemindMeAgain.UseVisualStyleBackColor = true;
			this.buttonRemindMeAgain.Click += new System.EventHandler(this.ButtonRemindMeAgainClick);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"on opening",
									"tomorrow",
									"in two days",
									"--------------------------------------------------",
									"in one week",
									"in two weeks",
									"--------------------------------------------------",
									"in one month",
									"in two months"});
			this.comboBox1.Location = new System.Drawing.Point(232, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 10;
			this.comboBox1.Visible = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(216, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Click Remind Me Again to be reminded:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(40, 40);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(304, 23);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "linkLabel1";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Here is your reminder to:";
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDate.Location = new System.Drawing.Point(224, 80);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(96, 21);
			this.dateTimePickerDate.TabIndex = 2;
			// 
			// AlertForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 151);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.buttonMarkAsDone);
			this.Controls.Add(this.buttonRemindMeAgain);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label1);
			this.Name = "AlertForm";
			this.Text = "AlertForm";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.Button buttonMarkAsDone;
		private System.Windows.Forms.Button buttonRemindMeAgain;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button3;
	}
}
