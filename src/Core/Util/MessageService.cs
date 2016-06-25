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
using System.Collections.Generic;

namespace NBooks.Core.Util
{
	/// <summary>
	/// Description of MessageService.
	/// </summary>
	public class MessageService
	{
		public MessageService()
		{
		}
		
		public static DialogResult ShowWarning(string text)
		{
			return MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		
		public static DialogResult ShowWarning(string text, MessageBoxButtons buttons)
		{
			return MessageBox.Show(text, "Warning", buttons, MessageBoxIcon.Warning);
		}
		
		public static DialogResult ShowYesNo(string text)
		{
			return MessageBox.Show(text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}
		
		public static DialogResult ShowWarning(IList<string> texts)
		{
			string text = "";
			foreach (string t in texts) {
				text += t + Environment.NewLine;
			}
			return MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		
		public static DialogResult ShowError(string text)
		{
			return MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		public static DialogResult ShowError(IList<string> texts)
		{
			string text = "";
			foreach (string t in texts) {
				text += t + Environment.NewLine;
			}
			return MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		
		public static DialogResult ShowInfo(string text)
		{
			return MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
