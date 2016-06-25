//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class ItemForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
			this.checkBoxInactive = new System.Windows.Forms.CheckBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dateTimePickerValueAsOf = new System.Windows.Forms.DateTimePicker();
			this.label16 = new System.Windows.Forms.Label();
			this.textBoxTotalValue = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.textBoxOnHand = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBoxReorderPoint = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.comboBoxAssetAccount = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.comboBoxIncomeAccount = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBoxTaxCode = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxSalesPrice = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.richTextBoxSalesDescription = new System.Windows.Forms.RichTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBoxUnit = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxManufacturerPartNumber = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxParent = new System.Windows.Forms.ComboBox();
			this.checkBoxSubitemOf = new System.Windows.Forms.CheckBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.textBoxUCS = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxVendor = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBoxCOGSAccount = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxCost = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.richTextBoxPurchaseDescription = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelType = new System.Windows.Forms.Label();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkBoxInactive
			// 
			this.checkBoxInactive.Location = new System.Drawing.Point(504, 88);
			this.checkBoxInactive.Name = "checkBoxInactive";
			this.checkBoxInactive.Size = new System.Drawing.Size(104, 36);
			this.checkBoxInactive.TabIndex = 214;
			this.checkBoxInactive.Text = "Item is inactive";
			this.checkBoxInactive.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(504, 48);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 213;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(504, 24);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 212;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dateTimePickerValueAsOf);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.textBoxTotalValue);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.textBoxOnHand);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.textBoxReorderPoint);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.comboBoxAssetAccount);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Location = new System.Drawing.Point(8, 368);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(488, 64);
			this.groupBox4.TabIndex = 211;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Inventory Information";
			// 
			// dateTimePickerValueAsOf
			// 
			this.dateTimePickerValueAsOf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerValueAsOf.Location = new System.Drawing.Point(392, 32);
			this.dateTimePickerValueAsOf.Name = "dateTimePickerValueAsOf";
			this.dateTimePickerValueAsOf.Size = new System.Drawing.Size(88, 21);
			this.dateTimePickerValueAsOf.TabIndex = 9;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(392, 16);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(88, 23);
			this.label16.TabIndex = 8;
			this.label16.Text = "as of";
			// 
			// textBoxTotalValue
			// 
			this.textBoxTotalValue.Location = new System.Drawing.Point(312, 32);
			this.textBoxTotalValue.Name = "textBoxTotalValue";
			this.textBoxTotalValue.Size = new System.Drawing.Size(72, 21);
			this.textBoxTotalValue.TabIndex = 7;
			this.textBoxTotalValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(312, 16);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(72, 23);
			this.label15.TabIndex = 6;
			this.label15.Text = "Total Value";
			// 
			// textBoxOnHand
			// 
			this.textBoxOnHand.Location = new System.Drawing.Point(232, 32);
			this.textBoxOnHand.Name = "textBoxOnHand";
			this.textBoxOnHand.Size = new System.Drawing.Size(72, 21);
			this.textBoxOnHand.TabIndex = 5;
			this.textBoxOnHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(232, 16);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(72, 23);
			this.label14.TabIndex = 4;
			this.label14.Text = "On Hand";
			// 
			// textBoxReorderPoint
			// 
			this.textBoxReorderPoint.Location = new System.Drawing.Point(152, 32);
			this.textBoxReorderPoint.Name = "textBoxReorderPoint";
			this.textBoxReorderPoint.Size = new System.Drawing.Size(72, 21);
			this.textBoxReorderPoint.TabIndex = 3;
			this.textBoxReorderPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(152, 16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(72, 23);
			this.label13.TabIndex = 2;
			this.label13.Text = "Reorder Point";
			// 
			// comboBoxAssetAccount
			// 
			this.comboBoxAssetAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAssetAccount.FormattingEnabled = true;
			this.comboBoxAssetAccount.Location = new System.Drawing.Point(8, 32);
			this.comboBoxAssetAccount.Name = "comboBoxAssetAccount";
			this.comboBoxAssetAccount.Size = new System.Drawing.Size(136, 21);
			this.comboBoxAssetAccount.TabIndex = 1;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 0;
			this.label12.Text = "Asset Account";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.comboBoxIncomeAccount);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.comboBoxTaxCode);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.textBoxSalesPrice);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.richTextBoxSalesDescription);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Location = new System.Drawing.Point(256, 168);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(240, 200);
			this.groupBox3.TabIndex = 210;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Sales Information";
			// 
			// comboBoxIncomeAccount
			// 
			this.comboBoxIncomeAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxIncomeAccount.FormattingEnabled = true;
			this.comboBoxIncomeAccount.Location = new System.Drawing.Point(104, 144);
			this.comboBoxIncomeAccount.Name = "comboBoxIncomeAccount";
			this.comboBoxIncomeAccount.Size = new System.Drawing.Size(128, 21);
			this.comboBoxIncomeAccount.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 144);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 6;
			this.label8.Text = "Income Account";
			// 
			// comboBoxTaxCode
			// 
			this.comboBoxTaxCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTaxCode.FormattingEnabled = true;
			this.comboBoxTaxCode.Location = new System.Drawing.Point(104, 120);
			this.comboBoxTaxCode.Name = "comboBoxTaxCode";
			this.comboBoxTaxCode.Size = new System.Drawing.Size(128, 21);
			this.comboBoxTaxCode.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 120);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 4;
			this.label9.Text = "Tax Code";
			// 
			// textBoxSalesPrice
			// 
			this.textBoxSalesPrice.Location = new System.Drawing.Point(104, 96);
			this.textBoxSalesPrice.Name = "textBoxSalesPrice";
			this.textBoxSalesPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBoxSalesPrice.Size = new System.Drawing.Size(128, 21);
			this.textBoxSalesPrice.TabIndex = 3;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 96);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 2;
			this.label10.Text = "Sales Price";
			// 
			// richTextBoxSalesDescription
			// 
			this.richTextBoxSalesDescription.Location = new System.Drawing.Point(8, 32);
			this.richTextBoxSalesDescription.Name = "richTextBoxSalesDescription";
			this.richTextBoxSalesDescription.Size = new System.Drawing.Size(224, 56);
			this.richTextBoxSalesDescription.TabIndex = 1;
			this.richTextBoxSalesDescription.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(200, 23);
			this.label11.TabIndex = 0;
			this.label11.Text = "Description of Sales Transactions";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBoxUnit);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(8, 120);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(488, 48);
			this.groupBox2.TabIndex = 208;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Unit of Measure";
			// 
			// comboBoxUnit
			// 
			this.comboBoxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxUnit.FormattingEnabled = true;
			this.comboBoxUnit.Location = new System.Drawing.Point(72, 16);
			this.comboBoxUnit.Name = "comboBoxUnit";
			this.comboBoxUnit.Size = new System.Drawing.Size(176, 21);
			this.comboBoxUnit.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "U/M Set";
			// 
			// textBoxManufacturerPartNumber
			// 
			this.textBoxManufacturerPartNumber.Location = new System.Drawing.Point(288, 96);
			this.textBoxManufacturerPartNumber.Name = "textBoxManufacturerPartNumber";
			this.textBoxManufacturerPartNumber.Size = new System.Drawing.Size(160, 21);
			this.textBoxManufacturerPartNumber.TabIndex = 207;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(288, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 23);
			this.label2.TabIndex = 206;
			this.label2.Text = "Manufacturer\'s Part Number";
			// 
			// comboBoxParent
			// 
			this.comboBoxParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxParent.Enabled = false;
			this.comboBoxParent.FormattingEnabled = true;
			this.comboBoxParent.Location = new System.Drawing.Point(128, 96);
			this.comboBoxParent.Name = "comboBoxParent";
			this.comboBoxParent.Size = new System.Drawing.Size(152, 21);
			this.comboBoxParent.TabIndex = 205;
			// 
			// checkBoxSubitemOf
			// 
			this.checkBoxSubitemOf.Enabled = false;
			this.checkBoxSubitemOf.Location = new System.Drawing.Point(128, 72);
			this.checkBoxSubitemOf.Name = "checkBoxSubitemOf";
			this.checkBoxSubitemOf.Size = new System.Drawing.Size(104, 24);
			this.checkBoxSubitemOf.TabIndex = 204;
			this.checkBoxSubitemOf.Text = "Subitem of";
			this.checkBoxSubitemOf.UseVisualStyleBackColor = true;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(8, 96);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(112, 21);
			this.textBoxName.TabIndex = 203;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.textBoxUCS);
			this.groupBox5.Controls.Add(this.label1);
			this.groupBox5.Controls.Add(this.comboBoxVendor);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Controls.Add(this.comboBoxCOGSAccount);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Controls.Add(this.textBoxCost);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.richTextBoxPurchaseDescription);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Location = new System.Drawing.Point(8, 168);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(240, 200);
			this.groupBox5.TabIndex = 209;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Purchase Information";
			// 
			// textBoxUCS
			// 
			this.textBoxUCS.Location = new System.Drawing.Point(104, 120);
			this.textBoxUCS.Name = "textBoxUCS";
			this.textBoxUCS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBoxUCS.Size = new System.Drawing.Size(128, 21);
			this.textBoxUCS.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "UCS";
			// 
			// comboBoxVendor
			// 
			this.comboBoxVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVendor.FormattingEnabled = true;
			this.comboBoxVendor.Location = new System.Drawing.Point(104, 168);
			this.comboBoxVendor.Name = "comboBoxVendor";
			this.comboBoxVendor.Size = new System.Drawing.Size(128, 21);
			this.comboBoxVendor.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 168);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Preferred Vendor";
			// 
			// comboBoxCOGSAccount
			// 
			this.comboBoxCOGSAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCOGSAccount.FormattingEnabled = true;
			this.comboBoxCOGSAccount.Location = new System.Drawing.Point(104, 144);
			this.comboBoxCOGSAccount.Name = "comboBoxCOGSAccount";
			this.comboBoxCOGSAccount.Size = new System.Drawing.Size(128, 21);
			this.comboBoxCOGSAccount.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "COGS Account";
			// 
			// textBoxCost
			// 
			this.textBoxCost.Location = new System.Drawing.Point(104, 96);
			this.textBoxCost.Name = "textBoxCost";
			this.textBoxCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBoxCost.Size = new System.Drawing.Size(128, 21);
			this.textBoxCost.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Cost";
			// 
			// richTextBoxPurchaseDescription
			// 
			this.richTextBoxPurchaseDescription.Location = new System.Drawing.Point(8, 32);
			this.richTextBoxPurchaseDescription.Name = "richTextBoxPurchaseDescription";
			this.richTextBoxPurchaseDescription.Size = new System.Drawing.Size(224, 56);
			this.richTextBoxPurchaseDescription.TabIndex = 1;
			this.richTextBoxPurchaseDescription.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(200, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Description of Purchase Transactions";
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(8, 80);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(100, 23);
			this.labelName.TabIndex = 202;
			this.labelName.Text = "Item Name/Number";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelType);
			this.groupBox1.Controls.Add(this.comboBoxType);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(488, 64);
			this.groupBox1.TabIndex = 201;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Type";
			// 
			// labelType
			// 
			this.labelType.Location = new System.Drawing.Point(136, 24);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(344, 32);
			this.labelType.TabIndex = 1;
			// 
			// comboBoxType
			// 
			this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Location = new System.Drawing.Point(8, 24);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(121, 21);
			this.comboBoxType.TabIndex = 0;
			this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTypeSelectedIndexChanged);
			// 
			// ItemForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(606, 438);
			this.Controls.Add(this.checkBoxInactive);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.textBoxManufacturerPartNumber);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxParent);
			this.Controls.Add(this.checkBoxSubitemOf);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ItemForm";
			this.Text = "New Item";
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxUCS;
		private System.Windows.Forms.ComboBox comboBoxVendor;
		private System.Windows.Forms.ComboBox comboBoxType;
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.RichTextBox richTextBoxPurchaseDescription;
		private System.Windows.Forms.TextBox textBoxCost;
		private System.Windows.Forms.ComboBox comboBoxCOGSAccount;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.CheckBox checkBoxSubitemOf;
		private System.Windows.Forms.ComboBox comboBoxParent;
		private System.Windows.Forms.TextBox textBoxManufacturerPartNumber;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RichTextBox richTextBoxSalesDescription;
		private System.Windows.Forms.TextBox textBoxSalesPrice;
		private System.Windows.Forms.ComboBox comboBoxTaxCode;
		private System.Windows.Forms.ComboBox comboBoxIncomeAccount;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox comboBoxAssetAccount;
		private System.Windows.Forms.TextBox textBoxReorderPoint;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBoxOnHand;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBoxTotalValue;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.DateTimePicker dateTimePickerValueAsOf;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox comboBoxUnit;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBoxInactive;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.TextBox textBoxName;
	}
}
