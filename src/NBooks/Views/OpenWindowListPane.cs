//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace NBooks.Views
{
	/// <summary>
	/// Description of OpenWindowListPane.
	/// </summary>
	public partial class OpenWindowListPane : UserControl
	{
		IList<Form> forms = new List<Form>();
		
		public IList<Form> Forms {
			get { return forms; }
		}
		
		public OpenWindowListPane()
		{
			InitializeComponent();
		}
		
		public void AddForm(Form form)
		{
			forms.Add(form);
			form.Closed += delegate { RemoveForm(form); };
			RefreshList();
		}
		
		void RefreshList()
		{
			listBox1.Items.Clear();
			foreach (Form form in forms) {
				listBox1.Items.Add(form.Text);
			}
			if (forms.Count > 12) {
				listBox1.Height = 160 + ((forms.Count - 12) * 13);
			} else {
				listBox1.Height = 160;
			}
		}
		
		public void RemoveForm(Form form)
		{
			forms.Remove(form);
			RefreshList();
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedItems.Count > 0) {
				forms[listBox1.SelectedIndex].Activate();
			}
		}
	}
}
