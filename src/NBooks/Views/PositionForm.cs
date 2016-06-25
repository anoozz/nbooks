//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class PositionForm : BaseForm
	{
		Position position;
		
		public Position Position {
			get {
				position.Name = textBoxName.Text;
				position.Inactive = checkBoxInactive.Checked;
				return position;
			}
			set { 
				position = value;
				textBoxName.Text = position.Name;
				checkBoxInactive.Checked = position.Inactive;
			}
		}
		
		public PositionForm() : this(new Position())
		{
		}
		
		public PositionForm(Position position)
		{
			InitializeComponent();
			this.Position = position;
		}
		
		public event EventHandler<PositionEventArgs> PositionSave;
		
		protected virtual void OnPositionSave(PositionEventArgs e)
		{
			if (PositionSave != null) {
				PositionSave(this, e);
			}
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			OnPositionSave(new PositionEventArgs(Position));
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
