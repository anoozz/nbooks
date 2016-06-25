//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class ListOfValueForm<T>
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxItem = new System.Windows.Forms.TextBox();
			this.buttonGo = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Search";
			// 
			// textBoxItem
			// 
			this.textBoxItem.Location = new System.Drawing.Point(64, 8);
			this.textBoxItem.Name = "textBoxItem";
			this.textBoxItem.Size = new System.Drawing.Size(256, 21);
			this.textBoxItem.TabIndex = 1;
			this.textBoxItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxItemKeyDown);
			// 
			// buttonGo
			// 
			this.buttonGo.Location = new System.Drawing.Point(328, 8);
			this.buttonGo.Name = "buttonGo";
			this.buttonGo.Size = new System.Drawing.Size(75, 23);
			this.buttonGo.TabIndex = 2;
			this.buttonGo.Text = "Go";
			this.buttonGo.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.FullRowSelect = true;
			this.listView1.Location = new System.Drawing.Point(8, 40);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(456, 216);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(312, 264);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 4;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(392, 264);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// ListOfValueForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 294);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.buttonGo);
			this.Controls.Add(this.textBoxItem);
			this.Controls.Add(this.label1);
			this.Name = "ListOfValueForm";
			this.Text = "List of Value";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBoxItem;
		private System.Windows.Forms.Button buttonGo;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		protected System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label label1;
	}
}
