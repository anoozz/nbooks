//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Util
{
	public class ItemSuggestionUtility
	{
		public ItemSuggestionUtility()
		{
		}
		
		public static string Suggest(string code)
		{
			switch (code.ToUpper()) {
				case "MT-C8":
				case "MT-TO8":
				case "MT-SP8":
				case "MT-C12":
				case "MT-TO12":
				case "MT-SP12":
				case "MT-LIFT":
				case "MT-J1":
				case "MT-J3":
				case "MT-SAKTO":
				case "MT-CZERO 237":
				case "MT-SAMURAI":
					return "MT-C8";
				case "MT-CL":
				case "MT-TOL":
				case "MT-SPL":
					return "MT-CL";
				case "MT-J2":
				case "MT-J5":
					return "MT-J2";
				case "MT-C 500ML":
				case "MT-SP 500ML":
				case "MT-TO 500ML":
					return "MT-C 500ML";
				case "SMBMT-GRANDE":
				case "SMBMT-RH1000":
				case "SMBMT-RH500":
					return "SMBMT-GRANDE";
				case "SMBMT-SANMIG LIGHT":
				case "SMBMT-BEER REG.":
					return "SMBMT-BEER REG.";
				default:
					return code;
			}
		}
	}
}
