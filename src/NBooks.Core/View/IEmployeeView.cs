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
using NBooks.Core.Model;

namespace NBooks.Core.View
{
	public interface IEmployeeView : IView
	{
		Employee Employee { get; set; }
		IList<PagIbigPremium> PagIbigPremiums { get; set; }
		IList<Position> Positions { get; set; }
		IList<Department> Departments { get; set; }
		IList<Shift> Shifts { get; set; }
		IList<TaxCode> TaxCodes { get; set; }
		IList<State> States { get; set; }
		IList<EmployeeType> EmployeeTypes { get; set; }
		event EmployeeEventHandler SaveEmployee;
		event EventHandler ListPagIbigPremiums;
		event EventHandler ListPositions;
		event EventHandler ListDepartments;
		event EventHandler ListShifts;
		event EventHandler ListTaxCodes;
		event EventHandler ListStates;
		event EventHandler ListEmployeeTypes;
	}
	
	public interface IEmployeeListView
	{
		IList<Employee> Employees { get; set; }
		event EventHandler ListEmployees;
		event EmployeeEventHandler DeleteEmployee;
		event EmployeeEventHandler MakeInactiveEmployee;
	}
}
