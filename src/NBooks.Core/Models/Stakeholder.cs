//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public class Stakeholder<T> : BaseModel<T>, INotes
	{
		public virtual string Name { get; set; }
		public virtual string Notes { get; set; }
		public virtual Name LegalName { get; set; }
		public virtual string Address { get; set; }
		public virtual string Phone { get; set; }
		public virtual string Contact { get; set; }
		public virtual string Email { get; set; }
		public virtual string Fax { get; set; }
		public virtual string Website { get; set; }
		public virtual string AltPhone { get; set; }
		public virtual string AltContact { get; set; }
		public virtual bool Inactive { get; set; }
		public virtual string AccountNo { get; set; }
		public virtual string PrintOnCheckAs { get; set; }
		public virtual string CompanyName { get; set; }
		public virtual string CC { get; set; }
		
		public Stakeholder()
		{
		}
		
		public override string ToString()
		{
			return string.Format("Company: {0}\nContact: {1}\nPhone: {2}", Name, Contact, Phone);
		}
	}
	
	public enum StakeholderType
	{
		Customer,
		Vendor,
		Employee
	}
}
