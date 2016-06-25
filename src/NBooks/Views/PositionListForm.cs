//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class PositionListForm : BaseForm
	{
		IList<Position> positions;
		
		public Position SelectedPosition {
			get {
				if (listViewPositions.SelectedItems.Count > 0) {
					return positions[listViewPositions.SelectedItems[0].Index];
				}
				return null;
			}
		}
		
		public IList<Position> SelectedPositions {
			get {
				IList<Position> selectedPositions = new List<Position>();
				foreach (ListViewItem li in listViewPositions.SelectedItems) {
					selectedPositions.Add(positions[li.Index]);
				}
				return selectedPositions;
			}
		}
		
		public IList<Position> Positions {
			get { return positions; }
			set { 
				positions = value;
				listViewPositions.Items.Clear();
				foreach (var d in positions) {
					ListViewItem li = listViewPositions.Items.Add(d.Name);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public PositionListForm()
		{
			InitializeComponent();
			listViewPositions.Resize += delegate { columnHeader1.Width = listViewPositions.Width - 22; };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { OnPositionAdd(null); };
			editToolStripMenuItem.Click += delegate { 
				if (SelectedPosition != null) {
					OnPositionEdit(new PositionEventArgs(SelectedPosition));
				}
			};
			listViewPositions.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				foreach (var position in SelectedPositions) {
					OnPositionDelete(new PositionEventArgs(position));
				}
				OnActivated(null);
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				foreach (var position in SelectedPositions) {
					OnPositionMakeInactive(new PositionEventArgs(position));
				}
				OnActivated(null);
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnPositionsList(e);
		}
		
		public event EventHandler PositionsList;
		
		protected virtual void OnPositionsList(EventArgs e)
		{
			if (PositionsList != null) {
				PositionsList(this, e);
			}
		}
		public event EventHandler PositionAdd;
		
		protected virtual void OnPositionAdd(EventArgs e)
		{
			if (PositionAdd != null) {
				PositionAdd(this, e);
			}
		}
		public event EventHandler<PositionEventArgs> PositionEdit;
		
		protected virtual void OnPositionEdit(PositionEventArgs e)
		{
			if (PositionEdit != null) {
				PositionEdit(this, e);
			}
		}
		public event EventHandler<PositionEventArgs> PositionDelete;
		
		protected virtual void OnPositionDelete(PositionEventArgs e)
		{
			if (PositionDelete != null) {
				PositionDelete(this, e);
			}
		}
		public event EventHandler<PositionEventArgs> PositionMakeInactive;
		
		protected virtual void OnPositionMakeInactive(PositionEventArgs e)
		{
			if (PositionMakeInactive != null) {
				PositionMakeInactive(this, e);
			}
		}
	}
}
