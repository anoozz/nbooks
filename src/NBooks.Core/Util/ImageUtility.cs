//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.IO;

namespace NBooks.Core.Util
{
	public class ImageUtility
	{
		public ImageUtility()
		{
		}
		
		public static byte[] ToByteArray(Image image)
		{
			if (image == null) {
				return null;
			}
			MemoryStream ms = new MemoryStream();
			image.Save(ms, image.RawFormat);
			byte[] arr = ms.GetBuffer();
			return arr;
		}
		
		static Image ToImage(byte[] arr)
		{
			if (arr == null) return null;
			if (arr.Length == 0) return null;
			MemoryStream ms = new MemoryStream(arr);
			Image image = Image.FromStream(ms);
			return image;
		}
		
		public static Image ToImage(object o)
		{
			return o is System.DBNull ? null : ToImage((byte[])o);
		}
	}
}
