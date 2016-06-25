//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using NBooks.Core.Utils;

namespace NBooks.Core.Models.Formatter
{
	public interface ITruckLoadFormatter : IFormatter<TruckLoad>
	{
	}
	
	public class DefaultTruckLoadFormatter : ITruckLoadFormatter
	{
		public string Format(TruckLoad load)
		{
			return string.Format(
				"TRUCK LOAD" + Environment.NewLine +
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
				load.Date.ToString(),
				load.SalesRep.Name,
				load.Route.Code,
				GetPrintableDetails(load),
				load.PreparedBy,
				load.ApprovedBy,
				load.TotalAmount.ToString("###,##0.00").PadLeft(9),
				load.TotalQuantity.ToString("###,##0.00").PadLeft(8),
				load.Customer.Name,
				load.TotalDiscount.ToString("###,##0.00").PadLeft(8),
				load.Id
			);
		}
		
		IList<TruckLoadItem> SortItems(TruckLoad load)
		{
			IList<TruckLoadItem> nonEmpties = new List<TruckLoadItem>();
			IList<TruckLoadItem> empties = new List<TruckLoadItem>();
			foreach (TruckLoadItem item in load.Items) {
				if (ItemUtility.IsEmpty(item.Item.Name)) {
					empties.Add(item);
				} else {
					nonEmpties.Add(item);
				}
			}
			IList<TruckLoadItem> items = new List<TruckLoadItem>(nonEmpties);
			foreach (TruckLoadItem i in empties) {
				items.Add(i);
			}
			return items;
		}
		
		string GetPrintableDetails(TruckLoad load)
		{
			string text = "";
			foreach (var i in SortItems(load)) {
				text += string.Format(
					"{0}  {1}  {2}  {3}  {4}  {6}  {5}" + Environment.NewLine,
					i.Item.Name.Length < 12 ? i.Item.Name.PadRight(12) : (i.Item.Name.Substring(0, 9) + "...").PadRight(12),
					i.Item.SalesDescription.Length < 21 ? i.Item.SalesDescription.PadRight(21) : (i.Item.SalesDescription.Substring(0, 18) + "...").PadRight(21),
					i.Item.UnitMeasure.Length < 11 ? i.Item.UnitMeasure.PadRight(11) : (i.Item.UnitMeasure.Substring(0, 8) + "...").PadRight(11),
					i.Quantity.ToString("0.00").PadLeft(5),
					i.Price.ToString("0.00").PadLeft(8),
					i.Amount.ToString("0.00").PadLeft(9),
					i.Discount.ToString("0.00").PadLeft(8)
				);
			}
			return text;
		}
	}
}
