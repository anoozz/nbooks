//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class BillPaymentForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonSelectAllBills = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.comboBoxSortedBy = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxFilterBy = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButtonDue = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonSetCredits = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.buttonSetDiscount = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonGoToBill = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.comboBoxAccount = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.buttonPaySelectedBills = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.buttonSelectAllBills);
			this.groupBox1.Controls.Add(this.listView1);
			this.groupBox1.Controls.Add(this.comboBoxSortedBy);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.comboBoxFilterBy);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.dateTimePickerDueDate);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButtonDue);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(616, 296);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select Bills to be Paid";
			// 
			// buttonSelectAllBills
			// 
			this.buttonSelectAllBills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonSelectAllBills.Location = new System.Drawing.Point(8, 264);
			this.buttonSelectAllBills.Name = "buttonSelectAllBills";
			this.buttonSelectAllBills.Size = new System.Drawing.Size(96, 23);
			this.buttonSelectAllBills.TabIndex = 9;
			this.buttonSelectAllBills.Text = "Select All Bills";
			this.buttonSelectAllBills.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6,
									this.columnHeader7,
									this.columnHeader8});
			this.listView1.FullRowSelect = true;
			this.listView1.Location = new System.Drawing.Point(8, 72);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(600, 184);
			this.listView1.TabIndex = 8;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Date Due";
			this.columnHeader1.Width = 80;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Vendor";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Ref. No.";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Disc. Date";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Amt. Due";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Disc. Used";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Credits Used";
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Amt. To Pay";
			// 
			// comboBoxSortedBy
			// 
			this.comboBoxSortedBy.FormattingEnabled = true;
			this.comboBoxSortedBy.Location = new System.Drawing.Point(376, 40);
			this.comboBoxSortedBy.Name = "comboBoxSortedBy";
			this.comboBoxSortedBy.Size = new System.Drawing.Size(121, 21);
			this.comboBoxSortedBy.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(296, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Sort By";
			// 
			// comboBoxFilterBy
			// 
			this.comboBoxFilterBy.FormattingEnabled = true;
			this.comboBoxFilterBy.Location = new System.Drawing.Point(376, 16);
			this.comboBoxFilterBy.Name = "comboBoxFilterBy";
			this.comboBoxFilterBy.Size = new System.Drawing.Size(121, 21);
			this.comboBoxFilterBy.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(296, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Filter By";
			// 
			// dateTimePickerDueDate
			// 
			this.dateTimePickerDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDueDate.Location = new System.Drawing.Point(184, 16);
			this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
			this.dateTimePickerDueDate.Size = new System.Drawing.Size(88, 21);
			this.dateTimePickerDueDate.TabIndex = 3;
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(72, 40);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Show all bills";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButtonDue
			// 
			this.radioButtonDue.Location = new System.Drawing.Point(72, 16);
			this.radioButtonDue.Name = "radioButtonDue";
			this.radioButtonDue.Size = new System.Drawing.Size(120, 24);
			this.radioButtonDue.TabIndex = 1;
			this.radioButtonDue.TabStop = true;
			this.radioButtonDue.Text = "Due on or before";
			this.radioButtonDue.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Show Bills";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.buttonSetCredits);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.buttonSetDiscount);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.buttonGoToBill);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(8, 304);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(616, 80);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Discount && Credit Information for Highlighted Bill";
			// 
			// buttonSetCredits
			// 
			this.buttonSetCredits.Location = new System.Drawing.Point(368, 48);
			this.buttonSetCredits.Name = "buttonSetCredits";
			this.buttonSetCredits.Size = new System.Drawing.Size(75, 23);
			this.buttonSetCredits.TabIndex = 8;
			this.buttonSetCredits.Text = "Set Credits";
			this.buttonSetCredits.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(368, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 23);
			this.label8.TabIndex = 7;
			this.label8.Text = "Total Credits Available";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(368, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 6;
			this.label9.Text = "Number of Credits";
			// 
			// buttonSetDiscount
			// 
			this.buttonSetDiscount.Location = new System.Drawing.Point(144, 48);
			this.buttonSetDiscount.Name = "buttonSetDiscount";
			this.buttonSetDiscount.Size = new System.Drawing.Size(80, 23);
			this.buttonSetDiscount.TabIndex = 5;
			this.buttonSetDiscount.Text = "Set Discount";
			this.buttonSetDiscount.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(144, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "Sugg. Discount";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(144, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 3;
			this.label7.Text = "Terms";
			// 
			// buttonGoToBill
			// 
			this.buttonGoToBill.Location = new System.Drawing.Point(8, 48);
			this.buttonGoToBill.Name = "buttonGoToBill";
			this.buttonGoToBill.Size = new System.Drawing.Size(75, 23);
			this.buttonGoToBill.TabIndex = 2;
			this.buttonGoToBill.Text = "Go to Bill";
			this.buttonGoToBill.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 1;
			this.label5.Text = "Bill Ref. No.";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Vendor";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.comboBoxAccount);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.radioButton4);
			this.groupBox3.Controls.Add(this.radioButton3);
			this.groupBox3.Controls.Add(this.comboBoxPaymentMethod);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.dateTimePickerDate);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Location = new System.Drawing.Point(8, 384);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(616, 80);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Payment";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(448, 56);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(160, 23);
			this.label13.TabIndex = 8;
			this.label13.Text = "Ending Balance";
			// 
			// comboBoxAccount
			// 
			this.comboBoxAccount.FormattingEnabled = true;
			this.comboBoxAccount.Location = new System.Drawing.Point(448, 32);
			this.comboBoxAccount.Name = "comboBoxAccount";
			this.comboBoxAccount.Size = new System.Drawing.Size(160, 21);
			this.comboBoxAccount.TabIndex = 7;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(448, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 6;
			this.label12.Text = "Account";
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(296, 32);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(128, 24);
			this.radioButton4.TabIndex = 5;
			this.radioButton4.Text = "Assign check number";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.Checked = true;
			this.radioButton3.Location = new System.Drawing.Point(296, 8);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(128, 24);
			this.radioButton3.TabIndex = 4;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "To be printed";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// comboBoxPaymentMethod
			// 
			this.comboBoxPaymentMethod.FormattingEnabled = true;
			this.comboBoxPaymentMethod.Location = new System.Drawing.Point(168, 32);
			this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
			this.comboBoxPaymentMethod.Size = new System.Drawing.Size(121, 21);
			this.comboBoxPaymentMethod.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(168, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 2;
			this.label11.Text = "Method";
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDate.Location = new System.Drawing.Point(8, 32);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(88, 21);
			this.dateTimePickerDate.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 0;
			this.label10.Text = "Date";
			// 
			// buttonPaySelectedBills
			// 
			this.buttonPaySelectedBills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPaySelectedBills.Location = new System.Drawing.Point(440, 472);
			this.buttonPaySelectedBills.Name = "buttonPaySelectedBills";
			this.buttonPaySelectedBills.Size = new System.Drawing.Size(107, 23);
			this.buttonPaySelectedBills.TabIndex = 3;
			this.buttonPaySelectedBills.Text = "Pay Selected Bills";
			this.buttonPaySelectedBills.UseVisualStyleBackColor = true;
			this.buttonPaySelectedBills.Click += new System.EventHandler(this.ButtonPaySelectedBillsClick);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Location = new System.Drawing.Point(552, 472);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// BillPaymentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 509);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonPaySelectedBills);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "BillPaymentForm";
			this.Text = "Pay Bills";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox comboBoxSortedBy;
		private System.Windows.Forms.ComboBox comboBoxFilterBy;
		private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
		private System.Windows.Forms.RadioButton radioButtonDue;
		private System.Windows.Forms.Button buttonSelectAllBills;
		private System.Windows.Forms.Button buttonSetCredits;
		private System.Windows.Forms.Button buttonSetDiscount;
		private System.Windows.Forms.Button buttonGoToBill;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox comboBoxAccount;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonPaySelectedBills;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
