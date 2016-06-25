//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Models;

namespace NBooks.Views
{
	/// <summary>
	/// Description of AddressForm.
	/// </summary>
	public partial class AddressForm : BaseForm
	{
		Address address;
		
		public Address Address {
			get { 
				address.Street1 = richTextBoxStreet.Text;
				address.City = textBoxCity.Text;
				address.State = textBoxState.Text;
				address.Zip = textBoxZip.Text;
				address.Country = textBoxCountry.Text;
				address.Note = textBoxNote.Text;
				return address; 
			}
			set {
				address = value;
				richTextBoxStreet.Text = address.Street1;
				textBoxCity.Text = address.City;
				textBoxState.Text = address.State;
				textBoxZip.Text = address.Zip;
				textBoxCountry.Text = address.Country;
				textBoxNote.Text = address.Note;
			}
		}
		
		public AddressForm() : this(new Address())
		{
		}
		
		public AddressForm(Address address)
		{
			InitializeComponent();
			this.Address = address;
		}
	}
}
