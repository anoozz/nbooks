//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using NBooks.Core.Utils;

namespace NBooks.Core.Models.Formatter
{
	public interface ITruckReturnFormatter : IFormatter<TruckReturn>
	{
	}
	
	public class DefaultTruckReturnFormatter : ITruckReturnFormatter
	{
		public string Format(TruckReturn ret)
		{
			return string.Format(
				"TRUCK RETURN" + Environment.NewLine +
				"Date: {0}" + Environment.NewLine +
				"Salesman: {1}" + Environment.NewLine +
				"Route: {2}" + Environment.NewLine + 
				"Reference No: {10}" + Environment.NewLine + 
				"Customer: {8}" + Environment.NewLine + Environment.NewLine +
				"Code          Description            Unit           Qty     Price      Disc     Amount" + Environment.NewLine +
				"--------------------------------------------------------------------------------------" + Environment.NewLine +
				"{3}" +
				"--------------------------------------------------------------------------------------" + Environment.NewLine +
				"                                               {7}            {9}  {6}" + Environment.NewLine + Environment.NewLine +
				"Prepared By: {4}                   Approved By: {5}",
				ret.Date.ToString(),
				ret.SalesRep.Name,
				ret.Route.Code,
				GetPrintableDetails(ret),
				ret.PreparedBy,
				ret.ApprovedBy,
				ret.TotalAmount.ToString("###,##0.00").PadLeft(9),
				ret.TotalQuantity.ToString("###,##0.00").PadLeft(8),
				ret.Customer.Name,
				ret.TotalDiscount.ToString("###,##0.00").PadLeft(8),
				ret.Id
			);
		}
		
		IList<TruckReturnItem> SortItems(TruckReturn ret)
		{
			IList<TruckReturnItem> nonEmpties = new List<TruckReturnItem>();
			IList<TruckReturnItem> empties = new List<TruckReturnItem>();
			foreach (TruckReturnItem i in ret.Items) {
				if (ItemUtility.IsEmpty(i.Item.Name)) {
					empties.Add(i);
				} else {
					nonEmpties.Add(i);
				}
			}
			IList<TruckReturnItem> items = new List<TruckReturnItem>(nonEmpties);
			foreach (TruckReturnItem i in empties) {
				items.Add(i);
			}
			return items;
		}
		
		string GetPrintableDetails(TruckReturn ret)
		{
			string text = "";
			foreach (TruckReturnItem i in SortItems(ret)) {
				text += string.Format(
					"{0}  {1}  {2}  {3}  {4}  {6}  {5}" + Environment.NewLine,
					i.Item.Name.Length < 12 ? i.Item.Name.PadRight(12) : (i.Item.Name.Substring(0, 9) + "...").PadRight(12),
					i.Item.SalesDescription.Length < 21 ? i.Item.SalesDescription.PadRight(21) : (i.Item.SalesDescription.Substring(0, 18) + "...").PadRight(21),
					i.Item.UnitMeasure.Length < 11 ? i.Item.UnitMeasure.PadRight(11) : (i.Item.UnitMeasure.Substring(0, 8) + "...").PadRight(11),
					i.Quantity.ToString("0.00").PadLeft(5),
					i.UnitPrice.ToString("0.00").PadLeft(8),
					i.Amount.ToString("0.00").PadLeft(9),
					i.Discount.ToString("0.00").PadLeft(8)
				);
			}
			return text;
		}
	}
}
