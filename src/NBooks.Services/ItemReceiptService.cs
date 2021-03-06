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
using System.Collections.Generic;
using NBooks.Core.Dao;
using NBooks.Core.Model;
using NBooks.Core.Service;

namespace NBooks.Services
{
	/// <summary>
	/// Description of ItemReceiptService.
	/// </summary>
	public class ItemReceiptService : IItemReceiptService
	{
		IItemReceiptDao dao;
		
		public ItemReceiptService(IItemReceiptDao dao)
		{
			this.dao = dao;
		}
		
		public IList<ItemReceipt> FindOpen()
		{
			return dao.FindOpen();
		}
		
		public void SaveOrUpdate(ItemReceipt t)
		{
			dao.SaveOrUpdate(t);
		}
		
		public void Delete(ItemReceipt t)
		{
			dao.Delete(t);
		}
		
		public ItemReceipt Read(int id)
		{
			return dao.Read(id);
		}
		
		public IList<ItemReceipt> FindAll()
		{
			return dao.FindAll();
		}
	}
}
