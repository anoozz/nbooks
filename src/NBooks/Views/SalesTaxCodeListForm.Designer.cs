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
	partial class SalesTaxCodeListForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesTaxCodeListForm));
			this.makeInactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeaderCode = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderDescription = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderTaxable = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButtonReports = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButtonSalesTaxCode = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripDropDownButtonActivities = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.contextMenuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// makeInactiveToolStripMenuItem
			// 
			this.makeInactiveToolStripMenuItem.Name = "makeInactiveToolStripMenuItem";
			this.makeInactiveToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.makeInactiveToolStripMenuItem.Text = "Make Inactive";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeaderCode,
									this.columnHeaderDescription,
									this.columnHeaderTaxable});
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(292, 240);
			this.listView1.TabIndex = 39;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderCode
			// 
			this.columnHeaderCode.Text = "Sales Tax Code";
			this.columnHeaderCode.Width = 100;
			// 
			// columnHeaderDescription
			// 
			this.columnHeaderDescription.Text = "Description";
			// 
			// columnHeaderTaxable
			// 
			this.columnHeaderTaxable.Text = "Taxable";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.refreshToolStripMenuItem,
									this.toolStripMenuItem1,
									this.newToolStripMenuItem,
									this.editToolStripMenuItem,
									this.deleteToolStripMenuItem,
									this.toolStripMenuItem2,
									this.makeInactiveToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(148, 126);
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.refreshToolStripMenuItem.Text = "Refresh";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 6);
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.ShowShortcutKeys = false;
			this.newToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.newToolStripMenuItem.Text = "New";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 6);
			// 
			// toolStripDropDownButtonReports
			// 
			this.toolStripDropDownButtonReports.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonReports.Image")));
			this.toolStripDropDownButtonReports.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButtonReports.Name = "toolStripDropDownButtonReports";
			this.toolStripDropDownButtonReports.Size = new System.Drawing.Size(76, 20);
			this.toolStripDropDownButtonReports.Text = "Reports";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripDropDownButtonSalesTaxCode
			// 
			this.toolStripDropDownButtonSalesTaxCode.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonSalesTaxCode.Image")));
			this.toolStripDropDownButtonSalesTaxCode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButtonSalesTaxCode.Name = "toolStripDropDownButtonSalesTaxCode";
			this.toolStripDropDownButtonSalesTaxCode.Size = new System.Drawing.Size(114, 22);
			this.toolStripDropDownButtonSalesTaxCode.Text = "Sales Tax Code";
			// 
			// toolStripDropDownButtonActivities
			// 
			this.toolStripDropDownButtonActivities.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonActivities.Image")));
			this.toolStripDropDownButtonActivities.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButtonActivities.Name = "toolStripDropDownButtonActivities";
			this.toolStripDropDownButtonActivities.Size = new System.Drawing.Size(84, 22);
			this.toolStripDropDownButtonActivities.Text = "Activities";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripDropDownButtonSalesTaxCode,
									this.toolStripDropDownButtonActivities,
									this.toolStripDropDownButtonReports,
									this.toolStripSeparator1,
									this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 240);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(292, 25);
			this.toolStrip1.TabIndex = 38;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// SalesTaxCodeListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 265);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "SalesTaxCodeListForm";
			this.Text = "Sales Tax Code List";
			this.contextMenuStrip1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonActivities;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonSalesTaxCode;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonReports;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ColumnHeader columnHeaderTaxable;
		private System.Windows.Forms.ColumnHeader columnHeaderDescription;
		private System.Windows.Forms.ColumnHeader columnHeaderCode;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ToolStripMenuItem makeInactiveToolStripMenuItem;
	}
}
