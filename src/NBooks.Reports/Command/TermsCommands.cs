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
	public class ViewTermsListReport : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.AddChild(
				new ReportForm(new TermsListReport(), RepositoryFactory.GetDaoFactory().CreateTermsDao().FindActiveDS()),
				"Terms Listing"
			);
		}
	}
}
