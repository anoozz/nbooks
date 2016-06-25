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
using System.Windows.Forms;

namespace NBooks.Core.Util
{
	/// <summary>
	/// This interface is in charge of creating menus and toolbars for the
	/// workbench.
	/// TODO: Please rename this class to something that makes sense!
	/// </summary>
	public interface IMenu
	{
		ToolStripMenuItem PreviousOpenCompaniesMenuItem { get; }
		ToolStripMenuItem WindowMenuItem { get; }
		ToolStripItem[] CreateMenuItems();
		ToolStripItem[] CreateToolBarButtons();
	}
}
