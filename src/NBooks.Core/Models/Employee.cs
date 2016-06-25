//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Drawing;

namespace NBooks.Core.Models
{
	public class Employee : Stakeholder<Employee>
	{
		IList<Timesheet> timesheets = new List<Timesheet>();
		public virtual PagIbigPremium PagIbigPremium { get; set; }
		public virtual PhilHealthPremium PhilHealthPremium { get; set; }
		public virtual string Cellular { get; set; }
		public virtual State State { get; set; }
		public virtual new Address Address { get; set; }
		public virtual double Salary { get; set; }
		public virtual double DailyRate { get; set; }
		public virtual string HDMF { get; set; }
		public virtual string Religion { get; set; }
		public virtual string Course { get; set; }
		public virtual string School { get; set; }
		public virtual DateTime DateReleased { get; set; }
		public virtual SSPremium SSSPremium { get; set; }
		public virtual TaxCode TaxCode { get; set; }
		public virtual double PhilHealthContribution { get; set; }
		public virtual double WithholdingTax { get; set; }
		public virtual double SeniorityPay { get; set; }
		public virtual double MonthlyRate { get; set; }
		public virtual double HourlyRate { get; set; }
		public virtual object FingerprintSignature { get; set; }
		public virtual Shift Shift { get; set; }
		public virtual bool LogExemption { get; set; }
		public virtual DateTime DateOfBirth { get; set; }
		public virtual DateTime DateHired { get; set; }
		public virtual EmployeeType EmployeeType { get; set; }
		public virtual string SSSNo { get; set; }
		public virtual string PagIBIGNo { get; set; }
		public virtual string PhilHealthNo { get; set; }
		public virtual string IdNo { get; set; }
		public virtual string TIN { get; set; }
		public virtual Image Image { get; set; }
		public virtual byte[] ImageByte { get; set; }
		public virtual int Gender { get; set; }
		public virtual int MaritalStatus { get; set; }
		public virtual Position Position { get; set; }
		public virtual Branch Branch { get; set; }
		public virtual Department Department { get; set; }
		public virtual WorkersComp WorkersComp { get; set; }
		
		public override string Name {
			get { return LegalName.ToString(); }
			set { base.Name = value; }
		}

		public virtual IList<Timesheet> Timesheets {
			get { return timesheets; }
			set { timesheets = value; }
		}
		
		public Employee()
		{
		}
		
		public override void Validate()
		{
			base.Validate();
//			if (LegalName.Last == "") Errors.Add("Last name is required!");
//			if (LegalName.First == "") Errors.Add("First name is required!");
//			if (Address == "") Errors.Add("Address is required!");
//			if (Position == null) Errors.Add("Position is required!");
//			if (Branch ==  null) Errors.Add("Branch is required!");
//			if (Department == null) Errors.Add("Department is required!");
//			if (EmploymentStatus == null) Errors.Add("Employment status is required!");
//			if (Shift == null) Errors.Add("Shift is required!");
		}
	}
	
	public class EmployeeEventArgs : EventArgs
	{
		public Employee Employee { get; set; }
		
		public EmployeeEventArgs(Employee employee)
		{
			this.Employee = employee;
		}
	}
	
	public delegate void EmployeeEventHandler(Employee sender, EventArgs e);
}
