//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Views
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelProductName = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.linkLabelSite = new System.Windows.Forms.LinkLabel();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(256, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(88, 72);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// labelProductName
			// 
			this.labelProductName.Location = new System.Drawing.Point(24, 16);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(184, 23);
			this.labelProductName.TabIndex = 1;
			this.labelProductName.Text = "label1";
			// 
			// labelVersion
			// 
			this.labelVersion.Location = new System.Drawing.Point(24, 40);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(184, 23);
			this.labelVersion.TabIndex = 2;
			this.labelVersion.Text = "label2";
			// 
			// linkLabelSite
			// 
			this.linkLabelSite.Location = new System.Drawing.Point(24, 64);
			this.linkLabelSite.Name = "linkLabelSite";
			this.linkLabelSite.Size = new System.Drawing.Size(224, 23);
			this.linkLabelSite.TabIndex = 3;
			this.linkLabelSite.TabStop = true;
			this.linkLabelSite.Text = "http://nbooks.codeplex.com/";
			this.linkLabelSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSiteLinkClicked);
			// 
			// labelCopyright
			// 
			this.labelCopyright.Location = new System.Drawing.Point(24, 104);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(200, 32);
			this.labelCopyright.TabIndex = 4;
			this.labelCopyright.Text = "Copyright 2009-2010. NBooks Accounting. Some rights reserved.";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(272, 128);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Ok";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// AboutForm
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(359, 176);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.labelCopyright);
			this.Controls.Add(this.linkLabelSite);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.labelProductName);
			this.Controls.Add(this.pictureBox1);
			this.Name = "AboutForm";
			this.Text = "AboutForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.LinkLabel linkLabelSite;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
