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
using NBooks.Core.Models;

namespace NBooks.Views
{
	public class ServiceItemType : ItemType
	{
		public ServiceItemType() : base(ItemTypeEnum.Service, "Service", "Use for services you charge for or purchase, like specialized labor, consulting hours, or professional fees.")
		{
		}
	}
	
	public class InventoryPartItemType : ItemType
	{
		public InventoryPartItemType() : base(ItemTypeEnum.InventoryPart, "Inventory Part", "Use for goods you purchase, track as inventory, and resell.")
		{
		}
	}
	
	public class NonInventoryPartItemType : ItemType
	{
		public NonInventoryPartItemType() : base(ItemTypeEnum.NonInventoryPart, "Non-inventory Part", "Use for goods you buy but don't track, like office supplies, or materials for a specific job that you charge back to the customer.")
		{
		}
	}
}
