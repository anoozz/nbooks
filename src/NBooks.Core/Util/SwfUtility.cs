//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Models;

namespace NBooks.Core.Util
{
	public static class SwfUtility
	{
		public static void AlternateBackColor(ListViewItem li)
		{
			li.BackColor = li.Index % 2 == 0 ? Color.White : Color.Beige;
		}
		
		public static void SetupComboBox(ComboBox box, object ds)
		{
			SetupComboBox(box, ds, "", "");
		}
		
		public static void SetupComboBox(ComboBox box, object ds, string vm, string dm)
		{
			box.DataSource = ds;
			box.ValueMember = vm;
			box.DisplayMember = dm;
		}
		
		public static void SetupComboBox(ComboBox box, object ds, string vm, string dm, IBaseModel sv)
		{
			box.DataSource = ds;
			box.ValueMember = vm;
			box.DisplayMember = dm;
			if (sv != null) {
				box.SelectedValue = sv.Id;
			}
		}
		
		public static T GetComboBoxValue<T>(ComboBox box)
		{
			if (box.SelectedIndex >= 0) {
				return (box.DataSource as IList<T>)[box.SelectedIndex];
			}
			return default(T);
		}
	}
}
