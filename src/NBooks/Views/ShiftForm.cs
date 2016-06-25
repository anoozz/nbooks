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
using System.Windows.Forms;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class ShiftForm : BaseForm
	{
		Shift shift;
		
		public Shift Shift {
			get { 
				shift.Notes = textBoxNotes.Text;
				shift.RegularHours = ConvertUtility.ToInt32(textBoxRegularHours.Text);
				shift.GracePeriod = ConvertUtility.ToInt32(textBoxGracePeriod.Text);
				shift.Inactive = checkBoxInactive.Checked;
				return shift;
			}
			set {
				shift = value;
				textBoxNotes.Text = shift.Notes;
				textBoxRegularHours.Text = shift.RegularHours.ToString("0.0");
				textBoxGracePeriod.Text = shift.GracePeriod.ToString("0.0");
				checkBoxInactive.Checked = shift.Inactive;
				shift.TimesChanged += delegate { ShiftTimesChanged(); };
				ShiftTimesChanged();
			}
		}
		
		public ShiftForm() : this(new Shift())
		{
		}
		
		public ShiftForm(Shift shift)
		{
			InitializeComponent();
			this.Shift = shift;
		}
		
		void ShiftTimesChanged()
		{
			listView1.Items.Clear();
			foreach (var t in shift.Times) {
				ListViewItem li = listView1.Items.Add(t.TimeIn.ToString());
				li.SubItems.Add(t.TimeOut.ToString());
			}
		}
		
		public event ShiftEventHandler SaveShift;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SaveShift != null) {
				SaveShift(Shift, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
