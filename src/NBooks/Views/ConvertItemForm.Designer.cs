//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class ConvertItemForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxQuantity = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonFindItem = new System.Windows.Forms.Button();
			this.textBoxCode = new System.Windows.Forms.TextBox();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxUnit = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonFindItem2 = new System.Windows.Forms.Button();
			this.textBoxCode2 = new System.Windows.Forms.TextBox();
			this.textBoxPrice2 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxUnit2 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxName2 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(304, 40);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(304, 16);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 3;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxQuantity);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.buttonFindItem);
			this.groupBox1.Controls.Add(this.textBoxCode);
			this.groupBox1.Controls.Add(this.textBoxPrice);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBoxUnit);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBoxName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(288, 160);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "From";
			// 
			// textBoxQuantity
			// 
			this.textBoxQuantity.Location = new System.Drawing.Point(80, 112);
			this.textBoxQuantity.Name = "textBoxQuantity";
			this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
			this.textBoxQuantity.TabIndex = 31;
			this.textBoxQuantity.TabStop = false;
			this.textBoxQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxQuantityKeyDown);
			this.textBoxQuantity.Leave += new System.EventHandler(this.TextBoxQuantityLeave);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 30;
			this.label5.Text = "Quantity";
			// 
			// buttonFindItem
			// 
			this.buttonFindItem.Location = new System.Drawing.Point(240, 16);
			this.buttonFindItem.Name = "buttonFindItem";
			this.buttonFindItem.Size = new System.Drawing.Size(32, 23);
			this.buttonFindItem.TabIndex = 23;
			this.buttonFindItem.Text = "...";
			this.buttonFindItem.UseVisualStyleBackColor = true;
			this.buttonFindItem.Click += new System.EventHandler(this.ButtonFindItemClick);
			// 
			// textBoxCode
			// 
			this.textBoxCode.Location = new System.Drawing.Point(80, 16);
			this.textBoxCode.Name = "textBoxCode";
			this.textBoxCode.Size = new System.Drawing.Size(160, 20);
			this.textBoxCode.TabIndex = 22;
			this.textBoxCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCodeKeyDown);
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(80, 88);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.ReadOnly = true;
			this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
			this.textBoxPrice.TabIndex = 29;
			this.textBoxPrice.TabStop = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 28;
			this.label4.Text = "Price";
			// 
			// textBoxUnit
			// 
			this.textBoxUnit.Location = new System.Drawing.Point(80, 64);
			this.textBoxUnit.Name = "textBoxUnit";
			this.textBoxUnit.ReadOnly = true;
			this.textBoxUnit.Size = new System.Drawing.Size(100, 20);
			this.textBoxUnit.TabIndex = 27;
			this.textBoxUnit.TabStop = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 26;
			this.label3.Text = "Unit";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(80, 40);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.ReadOnly = true;
			this.textBoxName.Size = new System.Drawing.Size(200, 20);
			this.textBoxName.TabIndex = 25;
			this.textBoxName.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 24;
			this.label2.Text = "Name";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 21;
			this.label1.Text = "Item";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.buttonFindItem2);
			this.groupBox2.Controls.Add(this.textBoxCode2);
			this.groupBox2.Controls.Add(this.textBoxPrice2);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.textBoxUnit2);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.textBoxName2);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Location = new System.Drawing.Point(8, 192);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(288, 160);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "To";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(80, 112);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 31;
			this.textBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 112);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 30;
			this.label6.Text = "Quantity";
			// 
			// buttonFindItem2
			// 
			this.buttonFindItem2.Location = new System.Drawing.Point(240, 16);
			this.buttonFindItem2.Name = "buttonFindItem2";
			this.buttonFindItem2.Size = new System.Drawing.Size(32, 23);
			this.buttonFindItem2.TabIndex = 23;
			this.buttonFindItem2.Text = "...";
			this.buttonFindItem2.UseVisualStyleBackColor = true;
			this.buttonFindItem2.Click += new System.EventHandler(this.ButtonFindItem2Click);
			// 
			// textBoxCode2
			// 
			this.textBoxCode2.Location = new System.Drawing.Point(80, 16);
			this.textBoxCode2.Name = "textBoxCode2";
			this.textBoxCode2.Size = new System.Drawing.Size(160, 20);
			this.textBoxCode2.TabIndex = 22;
			this.textBoxCode2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCode2KeyDown);
			// 
			// textBoxPrice2
			// 
			this.textBoxPrice2.Location = new System.Drawing.Point(80, 88);
			this.textBoxPrice2.Name = "textBoxPrice2";
			this.textBoxPrice2.ReadOnly = true;
			this.textBoxPrice2.Size = new System.Drawing.Size(100, 20);
			this.textBoxPrice2.TabIndex = 29;
			this.textBoxPrice2.TabStop = false;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 88);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 28;
			this.label7.Text = "Price";
			// 
			// textBoxUnit2
			// 
			this.textBoxUnit2.Location = new System.Drawing.Point(80, 64);
			this.textBoxUnit2.Name = "textBoxUnit2";
			this.textBoxUnit2.ReadOnly = true;
			this.textBoxUnit2.Size = new System.Drawing.Size(100, 20);
			this.textBoxUnit2.TabIndex = 27;
			this.textBoxUnit2.TabStop = false;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 26;
			this.label8.Text = "Unit";
			// 
			// textBoxName2
			// 
			this.textBoxName2.Location = new System.Drawing.Point(80, 40);
			this.textBoxName2.Name = "textBoxName2";
			this.textBoxName2.ReadOnly = true;
			this.textBoxName2.Size = new System.Drawing.Size(200, 20);
			this.textBoxName2.TabIndex = 25;
			this.textBoxName2.TabStop = false;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 24;
			this.label9.Text = "Name";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 21;
			this.label10.Text = "Item";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 8);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 33;
			this.label11.Text = "Date";
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDate.Location = new System.Drawing.Point(64, 8);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(104, 20);
			this.dateTimePickerDate.TabIndex = 0;
			// 
			// ConvertItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(390, 353);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Name = "ConvertItemForm";
			this.Text = "Convert Items";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBoxQuantity;
		private System.Windows.Forms.Button buttonFindItem2;
		private System.Windows.Forms.TextBox textBoxCode2;
		private System.Windows.Forms.TextBox textBoxPrice2;
		private System.Windows.Forms.TextBox textBoxUnit2;
		private System.Windows.Forms.TextBox textBoxName2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxUnit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.TextBox textBoxCode;
		private System.Windows.Forms.Button buttonFindItem;
	}
}
