//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class AccountForm
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
			this.buttonSaveAndNew = new System.Windows.Forms.Button();
			this.buttonSaveAndClose = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.linkLabelHowToChoose = new System.Windows.Forms.LinkLabel();
			this.comboBoxTaxLineMapping = new System.Windows.Forms.ComboBox();
			this.labelTaxLineMapping = new System.Windows.Forms.Label();
			this.textBoxNote = new System.Windows.Forms.TextBox();
			this.labelNote = new System.Windows.Forms.Label();
			this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
			this.labelDescription = new System.Windows.Forms.Label();
			this.comboBoxParent = new System.Windows.Forms.ComboBox();
			this.checkBoxSubaccount = new System.Windows.Forms.CheckBox();
			this.linkLabelLearnMore = new System.Windows.Forms.LinkLabel();
			this.checkBoxOrderChecks = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.labelRemindMe = new System.Windows.Forms.Label();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.labelType = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(424, 368);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 53;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonSaveAndNew
			// 
			this.buttonSaveAndNew.Location = new System.Drawing.Point(328, 368);
			this.buttonSaveAndNew.Name = "buttonSaveAndNew";
			this.buttonSaveAndNew.Size = new System.Drawing.Size(91, 23);
			this.buttonSaveAndNew.TabIndex = 52;
			this.buttonSaveAndNew.Text = "Save && New";
			this.buttonSaveAndNew.UseVisualStyleBackColor = true;
			this.buttonSaveAndNew.Click += new System.EventHandler(this.ButtonSaveAndNewClick);
			// 
			// buttonSaveAndClose
			// 
			this.buttonSaveAndClose.Location = new System.Drawing.Point(232, 368);
			this.buttonSaveAndClose.Name = "buttonSaveAndClose";
			this.buttonSaveAndClose.Size = new System.Drawing.Size(91, 23);
			this.buttonSaveAndClose.TabIndex = 51;
			this.buttonSaveAndClose.Text = "Save && Close";
			this.buttonSaveAndClose.UseVisualStyleBackColor = true;
			this.buttonSaveAndClose.Click += new System.EventHandler(this.ButtonSaveAndCloseClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxName);
			this.groupBox1.Controls.Add(this.labelName);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.comboBoxParent);
			this.groupBox1.Controls.Add(this.checkBoxSubaccount);
			this.groupBox1.Controls.Add(this.linkLabelLearnMore);
			this.groupBox1.Controls.Add(this.checkBoxOrderChecks);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.labelRemindMe);
			this.groupBox1.Location = new System.Drawing.Point(8, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(488, 320);
			this.groupBox1.TabIndex = 50;
			this.groupBox1.TabStop = false;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(96, 16);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(288, 21);
			this.textBoxName.TabIndex = 53;
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(8, 16);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(100, 23);
			this.labelName.TabIndex = 49;
			this.labelName.Text = "Account Name";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.linkLabelHowToChoose);
			this.groupBox2.Controls.Add(this.comboBoxTaxLineMapping);
			this.groupBox2.Controls.Add(this.labelTaxLineMapping);
			this.groupBox2.Controls.Add(this.textBoxNote);
			this.groupBox2.Controls.Add(this.labelNote);
			this.groupBox2.Controls.Add(this.richTextBoxDescription);
			this.groupBox2.Controls.Add(this.labelDescription);
			this.groupBox2.Location = new System.Drawing.Point(8, 64);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(456, 176);
			this.groupBox2.TabIndex = 52;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Optional";
			// 
			// linkLabelHowToChoose
			// 
			this.linkLabelHowToChoose.Location = new System.Drawing.Point(272, 96);
			this.linkLabelHowToChoose.Name = "linkLabelHowToChoose";
			this.linkLabelHowToChoose.Size = new System.Drawing.Size(176, 23);
			this.linkLabelHowToChoose.TabIndex = 9;
			this.linkLabelHowToChoose.TabStop = true;
			this.linkLabelHowToChoose.Text = "How do I choose the right tax line?";
			// 
			// comboBoxTaxLineMapping
			// 
			this.comboBoxTaxLineMapping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTaxLineMapping.FormattingEnabled = true;
			this.comboBoxTaxLineMapping.Items.AddRange(new object[] {
									"< Unassigned >",
									"< Not tax related >"});
			this.comboBoxTaxLineMapping.Location = new System.Drawing.Point(120, 96);
			this.comboBoxTaxLineMapping.Name = "comboBoxTaxLineMapping";
			this.comboBoxTaxLineMapping.Size = new System.Drawing.Size(144, 21);
			this.comboBoxTaxLineMapping.TabIndex = 5;
			// 
			// labelTaxLineMapping
			// 
			this.labelTaxLineMapping.Location = new System.Drawing.Point(24, 96);
			this.labelTaxLineMapping.Name = "labelTaxLineMapping";
			this.labelTaxLineMapping.Size = new System.Drawing.Size(100, 23);
			this.labelTaxLineMapping.TabIndex = 4;
			this.labelTaxLineMapping.Text = "Tax-Line Mapping";
			// 
			// textBoxNote
			// 
			this.textBoxNote.Location = new System.Drawing.Point(120, 72);
			this.textBoxNote.Name = "textBoxNote";
			this.textBoxNote.Size = new System.Drawing.Size(256, 21);
			this.textBoxNote.TabIndex = 3;
			// 
			// labelNote
			// 
			this.labelNote.Location = new System.Drawing.Point(24, 72);
			this.labelNote.Name = "labelNote";
			this.labelNote.Size = new System.Drawing.Size(100, 23);
			this.labelNote.TabIndex = 2;
			this.labelNote.Text = "Note";
			// 
			// richTextBoxDescription
			// 
			this.richTextBoxDescription.Location = new System.Drawing.Point(120, 24);
			this.richTextBoxDescription.Name = "richTextBoxDescription";
			this.richTextBoxDescription.Size = new System.Drawing.Size(256, 40);
			this.richTextBoxDescription.TabIndex = 1;
			this.richTextBoxDescription.Text = "";
			// 
			// labelDescription
			// 
			this.labelDescription.Location = new System.Drawing.Point(24, 24);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(100, 23);
			this.labelDescription.TabIndex = 0;
			this.labelDescription.Text = "Description";
			// 
			// comboBoxParent
			// 
			this.comboBoxParent.Enabled = false;
			this.comboBoxParent.FormattingEnabled = true;
			this.comboBoxParent.Location = new System.Drawing.Point(192, 40);
			this.comboBoxParent.Name = "comboBoxParent";
			this.comboBoxParent.Size = new System.Drawing.Size(192, 21);
			this.comboBoxParent.TabIndex = 51;
			// 
			// checkBoxSubaccount
			// 
			this.checkBoxSubaccount.Enabled = false;
			this.checkBoxSubaccount.Location = new System.Drawing.Point(88, 40);
			this.checkBoxSubaccount.Name = "checkBoxSubaccount";
			this.checkBoxSubaccount.Size = new System.Drawing.Size(104, 24);
			this.checkBoxSubaccount.TabIndex = 50;
			this.checkBoxSubaccount.Text = "Subaccount of";
			this.checkBoxSubaccount.UseVisualStyleBackColor = true;
			// 
			// linkLabelLearnMore
			// 
			this.linkLabelLearnMore.Location = new System.Drawing.Point(304, 280);
			this.linkLabelLearnMore.Name = "linkLabelLearnMore";
			this.linkLabelLearnMore.Size = new System.Drawing.Size(96, 23);
			this.linkLabelLearnMore.TabIndex = 48;
			this.linkLabelLearnMore.TabStop = true;
			this.linkLabelLearnMore.Text = "Learn more";
			// 
			// checkBoxOrderChecks
			// 
			this.checkBoxOrderChecks.Location = new System.Drawing.Point(104, 280);
			this.checkBoxOrderChecks.Name = "checkBoxOrderChecks";
			this.checkBoxOrderChecks.Size = new System.Drawing.Size(160, 24);
			this.checkBoxOrderChecks.TabIndex = 47;
			this.checkBoxOrderChecks.Text = "Order checks I can print";
			this.checkBoxOrderChecks.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(384, 256);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(88, 21);
			this.textBox1.TabIndex = 46;
			// 
			// labelRemindMe
			// 
			this.labelRemindMe.Location = new System.Drawing.Point(104, 256);
			this.labelRemindMe.Name = "labelRemindMe";
			this.labelRemindMe.Size = new System.Drawing.Size(296, 23);
			this.labelRemindMe.TabIndex = 45;
			this.labelRemindMe.Text = "Remind me to order checks when I reach check number";
			// 
			// comboBoxType
			// 
			this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Location = new System.Drawing.Point(104, 8);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(144, 21);
			this.comboBoxType.TabIndex = 49;
			// 
			// labelType
			// 
			this.labelType.Location = new System.Drawing.Point(24, 8);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(100, 23);
			this.labelType.TabIndex = 48;
			this.labelType.Text = "Account Type";
			// 
			// AccountForm
			// 
			this.AcceptButton = this.buttonSaveAndClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 400);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSaveAndNew);
			this.Controls.Add(this.buttonSaveAndClose);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.comboBoxType);
			this.Controls.Add(this.labelType);
			this.Name = "AccountForm";
			this.Text = "New Account";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.ComboBox comboBoxType;
		private System.Windows.Forms.Label labelRemindMe;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox checkBoxOrderChecks;
		private System.Windows.Forms.LinkLabel linkLabelLearnMore;
		private System.Windows.Forms.CheckBox checkBoxSubaccount;
		private System.Windows.Forms.ComboBox comboBoxParent;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.RichTextBox richTextBoxDescription;
		private System.Windows.Forms.Label labelNote;
		private System.Windows.Forms.TextBox textBoxNote;
		private System.Windows.Forms.Label labelTaxLineMapping;
		private System.Windows.Forms.ComboBox comboBoxTaxLineMapping;
		private System.Windows.Forms.LinkLabel linkLabelHowToChoose;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonSaveAndClose;
		private System.Windows.Forms.Button buttonSaveAndNew;
		private System.Windows.Forms.Button buttonCancel;
	}
}
