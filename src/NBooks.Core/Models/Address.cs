//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public class Address
	{
		public string Street1 { get; set; }
		public string Street2 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Country { get; set; }
		public string Note { get; set; }
		
		public Address()
		{
		}
		
		public Address(string street1, string street2, string city, string state, string zip, string country)
		{
			this.Street1 = street1;
			this.Street2 = street2;
			this.City = city;
			this.State = state;
			this.Zip = zip;
			this.Country = country;
		}
		
		public override string ToString()
		{
			return string.Format("{0}\n{1}, {2} {3}", Street1, City, State, Zip, Country);
		}
	}
}
