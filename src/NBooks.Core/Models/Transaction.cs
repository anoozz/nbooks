//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public class Transaction<T> : BaseModel<T>
	{
		public virtual DateTime Date { get; set; }
		public virtual TransactionStatus Status { get; set; }
		public virtual string Memo { get; set; }
		public virtual User Creator { get; set; }
		public virtual DateTime CreationDate { get; set; }
		public virtual User Updater { get; set; }
		public virtual DateTime UpdateDate { get; set; }
		
		public Transaction()
		{
		}
	}
	
	public enum TransactionStatus
	{
		/// <summary>
		/// 0 = Open
		/// </summary>
		Open,
		
		/// <summary>
		/// 1 = Closed
		/// </summary>
		Closed
	}
}
