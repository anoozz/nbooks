//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class CustomerMessageForm : BaseForm
	{
		CustomerMessage message;
		
		public CustomerMessage CustomerMessage {
			get { 
				message.Message = richTextBoxMessage.Text;
				message.Inactive = checkBoxInactive.Checked;
				return message;
			}
			set { 
				message = value; 
				richTextBoxMessage.Text = message.Message;
				checkBoxInactive.Checked = message.Inactive;
			}
		}
		
		public CustomerMessageForm() : this(new CustomerMessage())
		{
		}
		
		public CustomerMessageForm(CustomerMessage message)
		{
			InitializeComponent();
			this.CustomerMessage = message;
		}
		
		public event CustomerMessageEventHandler SaveCustomerMessage;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SaveCustomerMessage != null) {
				SaveCustomerMessage(CustomerMessage, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
