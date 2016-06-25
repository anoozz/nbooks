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

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class TermsListForm : BaseForm
	{
		IList<Terms> terms;
		
		public Terms SelectedTerm {
			get {
				if (listViewTerms.SelectedItems.Count > 0) {
					return terms[listViewTerms.SelectedItems[0].Index];
				}
				return null;
			}
		}
		
		public IList<Terms> SelectedTerms {
			get {
				IList<Terms> selectedTerms = new List<Terms>();
				foreach (ListViewItem li in listViewTerms.SelectedItems) {
					selectedTerms.Add(terms[li.Index]);
				}
				return selectedTerms;
			}
		}
		
		public IList<Terms> Terms {
			get { return terms; }
			set {
				terms = value;
				listViewTerms.Items.Clear();
				foreach (Terms t in terms) {
					ListViewItem li = listViewTerms.Items.Add(t.Name);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public TermsListForm()
		{
			InitializeComponent();
			listViewTerms.Resize += delegate { columnHeader1.Width = listViewTerms.Width - 22; };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { OnTermsAdd(null); };
			editToolStripMenuItem.Click += delegate { 
				if (SelectedTerm != null) {
					OnTermsEdit(new TermsEventArgs(SelectedTerm));
				}
			};
			listViewTerms.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				foreach (var terms in SelectedTerms) {
					OnTermsDelete(new TermsEventArgs(terms));
				}
				OnActivated(null);
			};
			makeInactiveToolStripMenuItem.Click += delegate {
				foreach (var terms in SelectedTerms) {
					OnTermsMakeInactive(new TermsEventArgs(terms));
				}
				OnActivated(null);
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnTermsList(e);
		}
		
		public event EventHandler TermsList;
		
		protected virtual void OnTermsList(EventArgs e)
		{
			if (TermsList != null) {
				TermsList(this, e);
			}
		}
		public event EventHandler TermsAdd;
		
		protected virtual void OnTermsAdd(EventArgs e)
		{
			if (TermsAdd != null) {
				TermsAdd(this, e);
			}
		}
		public event EventHandler<TermsEventArgs> TermsEdit;
		
		protected virtual void OnTermsEdit(TermsEventArgs e)
		{
			if (TermsEdit != null) {
				TermsEdit(this, e);
			}
		}
		public event EventHandler<TermsEventArgs> TermsDelete;
		
		protected virtual void OnTermsDelete(TermsEventArgs e)
		{
			if (TermsDelete != null) {
				TermsDelete(this, e);
			}
		}
		public event EventHandler<TermsEventArgs> TermsMakeInactive;
		
		protected virtual void OnTermsMakeInactive(TermsEventArgs e)
		{
			if (TermsMakeInactive != null) {
				TermsMakeInactive(this, e);
			}
		}
	}
}
