﻿// one line to give the library's name and an idea of what it does.
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
using NBooks.Core;
using NBooks.Core.Gui;
using NBooks.Core.Util;
using NBooks.Data;

namespace NBooks.Reports.Command
{
	public class ViewVendorPhoneListReport : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.AddChild(
				new ReportForm(new VendorPhoneListReport(), RepositoryFactory.GetDaoFactory().CreateVendorDao().FindActiveDS()),
				"Vendor Phone List"
			);
		}
	}
	
	public class ViewVendorContactListReport : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.AddChild(
				new ReportForm(new VendorContactListReport(), RepositoryFactory.GetDaoFactory().CreateVendorDao().FindActiveDS()),
				"Vendor Contact List"
			);
		}
	}
	
	public class ViewVendorBalanceSummaryReport : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.AddChild(
				new ReportForm(new VendorBalanceSummaryReport(), RepositoryFactory.GetDaoFactory().CreateVendorDao().FindActiveDS()),
				"Vendor Balance Summary"
			);
		}
	}
	
	public class ViewVendorBalanceDetailReport : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.AddChild(
				new ReportForm(new VendorBalanceDetailReport(), RepositoryFactory.GetDaoFactory().CreateVendorDao().FindActiveDS()),
				"Vendor Balance Detail"
			);
		}
	}
	
	public class ViewAPAgingSummaryReport : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.AddChild(
				new ReportForm(new APAgingSummaryReport(), RepositoryFactory.GetDaoFactory().CreateVendorDao().FindActiveDS()),
				"A/P Aging Summary"
			);
		}
	}
	
	public class ViewAPAgingDetailReport : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.AddChild(
				new ReportForm(new APAgingDetailReport(), RepositoryFactory.GetDaoFactory().CreateVendorDao().FindActiveDS()),
				"A/P Aging Detail"
			);
		}
	}
}
