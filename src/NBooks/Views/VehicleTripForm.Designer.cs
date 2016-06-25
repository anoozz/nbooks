// one line to give the library's name and an idea of what it does.
// Copyright (C) 2010 Ian Escarro <ian.escarro@gmail.com>
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

namespace NBooks.Views
{
	partial class VehicleTripForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleTripForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonVehicleList = new System.Windows.Forms.ToolStripButton();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSaveAndClear = new System.Windows.Forms.Button();
			this.buttonSaveAndClose = new System.Windows.Forms.Button();
			this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxTotalMiles = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxOdometerEnd = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxOdometerStart = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxVehicle = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButtonSave,
									this.toolStripButtonPrint,
									this.toolStripSeparator1,
									this.toolStripButtonVehicleList});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(499, 25);
			this.toolStrip1.TabIndex = 35;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButtonSave
			// 
			this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
			this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSave.Name = "toolStripButtonSave";
			this.toolStripButtonSave.Size = new System.Drawing.Size(51, 22);
			this.toolStripButtonSave.Text = "Save";
			this.toolStripButtonSave.Click += new System.EventHandler(this.ToolStripButtonSaveClick);
			// 
			// toolStripButtonPrint
			// 
			this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
			this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonPrint.Name = "toolStripButtonPrint";
			this.toolStripButtonPrint.Size = new System.Drawing.Size(49, 22);
			this.toolStripButtonPrint.Text = "Print";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonVehicleList
			// 
			this.toolStripButtonVehicleList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonVehicleList.Image")));
			this.toolStripButtonVehicleList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonVehicleList.Name = "toolStripButtonVehicleList";
			this.toolStripButtonVehicleList.Size = new System.Drawing.Size(79, 22);
			this.toolStripButtonVehicleList.Text = "Vehicle List";
			this.toolStripButtonVehicleList.Click += new System.EventHandler(this.ToolStripButtonVehicleListClick);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(408, 216);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 34;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonSaveAndClear
			// 
			this.buttonSaveAndClear.Location = new System.Drawing.Point(320, 216);
			this.buttonSaveAndClear.Name = "buttonSaveAndClear";
			this.buttonSaveAndClear.Size = new System.Drawing.Size(83, 23);
			this.buttonSaveAndClear.TabIndex = 33;
			this.buttonSaveAndClear.Text = "Save && Clear";
			this.buttonSaveAndClear.UseVisualStyleBackColor = true;
			this.buttonSaveAndClear.Click += new System.EventHandler(this.ButtonSaveAndClearClick);
			// 
			// buttonSaveAndClose
			// 
			this.buttonSaveAndClose.Location = new System.Drawing.Point(232, 216);
			this.buttonSaveAndClose.Name = "buttonSaveAndClose";
			this.buttonSaveAndClose.Size = new System.Drawing.Size(83, 23);
			this.buttonSaveAndClose.TabIndex = 32;
			this.buttonSaveAndClose.Text = "Save && Close";
			this.buttonSaveAndClose.UseVisualStyleBackColor = true;
			this.buttonSaveAndClose.Click += new System.EventHandler(this.ButtonSaveAndCloseClick);
			// 
			// richTextBoxNotes
			// 
			this.richTextBoxNotes.Location = new System.Drawing.Point(208, 96);
			this.richTextBoxNotes.Name = "richTextBoxNotes";
			this.richTextBoxNotes.Size = new System.Drawing.Size(272, 104);
			this.richTextBoxNotes.TabIndex = 31;
			this.richTextBoxNotes.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(208, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 30;
			this.label7.Text = "Notes";
			// 
			// textBoxTotalMiles
			// 
			this.textBoxTotalMiles.Location = new System.Drawing.Point(96, 176);
			this.textBoxTotalMiles.Name = "textBoxTotalMiles";
			this.textBoxTotalMiles.Size = new System.Drawing.Size(100, 21);
			this.textBoxTotalMiles.TabIndex = 29;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 28;
			this.label6.Text = "Total Miles";
			// 
			// textBoxOdometerEnd
			// 
			this.textBoxOdometerEnd.Location = new System.Drawing.Point(96, 152);
			this.textBoxOdometerEnd.Name = "textBoxOdometerEnd";
			this.textBoxOdometerEnd.Size = new System.Drawing.Size(100, 21);
			this.textBoxOdometerEnd.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 26;
			this.label5.Text = "Odometer End";
			// 
			// textBoxOdometerStart
			// 
			this.textBoxOdometerStart.Location = new System.Drawing.Point(96, 128);
			this.textBoxOdometerStart.Name = "textBoxOdometerStart";
			this.textBoxOdometerStart.Size = new System.Drawing.Size(100, 21);
			this.textBoxOdometerStart.TabIndex = 25;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 24;
			this.label4.Text = "Odometer Start";
			// 
			// dateTimePickerEndDate
			// 
			this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerEndDate.Location = new System.Drawing.Point(96, 80);
			this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
			this.dateTimePickerEndDate.Size = new System.Drawing.Size(96, 21);
			this.dateTimePickerEndDate.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 22;
			this.label3.Text = "Trip End Date";
			// 
			// dateTimePickerStartDate
			// 
			this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerStartDate.Location = new System.Drawing.Point(96, 56);
			this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
			this.dateTimePickerStartDate.Size = new System.Drawing.Size(96, 21);
			this.dateTimePickerStartDate.TabIndex = 21;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 20;
			this.label2.Text = "Trip Start Date";
			// 
			// comboBoxVehicle
			// 
			this.comboBoxVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVehicle.FormattingEnabled = true;
			this.comboBoxVehicle.Location = new System.Drawing.Point(96, 32);
			this.comboBoxVehicle.Name = "comboBoxVehicle";
			this.comboBoxVehicle.Size = new System.Drawing.Size(121, 21);
			this.comboBoxVehicle.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 18;
			this.label1.Text = "Vehicle";
			// 
			// VehicleTripForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(499, 296);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSaveAndClear);
			this.Controls.Add(this.buttonSaveAndClose);
			this.Controls.Add(this.richTextBoxNotes);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxTotalMiles);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxOdometerEnd);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxOdometerStart);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dateTimePickerEndDate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dateTimePickerStartDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxVehicle);
			this.Controls.Add(this.label1);
			this.Name = "VehicleTripForm";
			this.Text = "New Vehicle Trip";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
		private System.Windows.Forms.ToolStripButton toolStripButtonSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxVehicle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxOdometerStart;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxOdometerEnd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxTotalMiles;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RichTextBox richTextBoxNotes;
		private System.Windows.Forms.Button buttonSaveAndClose;
		private System.Windows.Forms.Button buttonSaveAndClear;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ToolStripButton toolStripButtonVehicleList;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
