//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class PhysicalCountItemForm
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
			this.buttonFindItem = new System.Windows.Forms.Button();
			this.textBoxCode = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.textBoxAdjustedQuantity = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxQuantity = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonFindItem
			// 
			this.buttonFindItem.Location = new System.Drawing.Point(248, 16);
			this.buttonFindItem.Name = "buttonFindItem";
			this.buttonFindItem.Size = new System.Drawing.Size(32, 23);
			this.buttonFindItem.TabIndex = 24;
			this.buttonFindItem.Text = "...";
			this.buttonFindItem.UseVisualStyleBackColor = true;
			this.buttonFindItem.Click += new System.EventHandler(this.ButtonFindItemClick);
			// 
			// textBoxCode
			// 
			this.textBoxCode.Location = new System.Drawing.Point(88, 16);
			this.textBoxCode.Name = "textBoxCode";
			this.textBoxCode.Size = new System.Drawing.Size(160, 21);
			this.textBoxCode.TabIndex = 23;
			this.textBoxCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCodeKeyDown);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(224, 136);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 27;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(144, 136);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 26;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// textBoxAdjustedQuantity
			// 
			this.textBoxAdjustedQuantity.Location = new System.Drawing.Point(88, 88);
			this.textBoxAdjustedQuantity.Name = "textBoxAdjustedQuantity";
			this.textBoxAdjustedQuantity.Size = new System.Drawing.Size(100, 21);
			this.textBoxAdjustedQuantity.TabIndex = 25;
			this.textBoxAdjustedQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAdjustedQuantityKeyDown);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 35;
			this.label5.Text = "Adjusted Qty";
			// 
			// textBoxQuantity
			// 
			this.textBoxQuantity.Location = new System.Drawing.Point(88, 64);
			this.textBoxQuantity.Name = "textBoxQuantity";
			this.textBoxQuantity.ReadOnly = true;
			this.textBoxQuantity.Size = new System.Drawing.Size(100, 21);
			this.textBoxQuantity.TabIndex = 32;
			this.textBoxQuantity.TabStop = false;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 64);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 31;
			this.label6.Text = "Quantity";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(88, 40);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.ReadOnly = true;
			this.textBoxName.Size = new System.Drawing.Size(200, 21);
			this.textBoxName.TabIndex = 30;
			this.textBoxName.TabStop = false;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 29;
			this.label7.Text = "Name";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 28;
			this.label8.Text = "Item";
			// 
			// PhysicalCountItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 182);
			this.Controls.Add(this.buttonFindItem);
			this.Controls.Add(this.textBoxCode);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.textBoxAdjustedQuantity);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxQuantity);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Name = "PhysicalCountItemForm";
			this.Text = "Physical Count Item";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.TextBox textBoxAdjustedQuantity;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxQuantity;
		private System.Windows.Forms.TextBox textBoxCode;
		private System.Windows.Forms.Button buttonFindItem;
	}
}
