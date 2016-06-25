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
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Util;

namespace Core.Util
{
	/// <summary>
	/// Description of BToolStripButton.
	/// </summary>
	public class BToolStripButton : ToolStripButton
	{
		ICommand command;
		
		public BToolStripButton()
		{
		}
		
		public BToolStripButton(string text)
		{
			this.Text = text;
		}
		
		public BToolStripButton(string text, ICommand command)
		{
			this.Text = text;
			this.command = command;
		}
		
		public BToolStripButton(string text, ICommand command, Image image)
		{
			this.Text = text;
			this.command = command;
			this.Image = image;
		}
		
		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
			if (command != null) {
				command.Run();
			}
		}
	}
}
