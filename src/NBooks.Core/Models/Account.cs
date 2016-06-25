//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public class Account : BaseModel<Account>
	{
		public virtual int Type { get; set; }
		public virtual string Name { get; set; }
		public virtual string Description { get; set; }
		public virtual double Balance { get; set; }
		public virtual string Note { get; set; }
		public virtual bool Inactive { get; set; }
		
		public Account()
		{
		}
		
		public virtual void MakeInactive()
		{
			Inactive = true;
			SaveOrUpdate();
		}
	}
	
	public class AccountType
	{
		public virtual AccountTypeEnum Id { get; set; }
		public virtual string Name { get; set; }
		public virtual string Description { get; set; }

		public AccountType()
		{
		}
		
		public AccountType(AccountTypeEnum id, string name)
		{
			this.Id = id;
			this.Name = name;
		}
	}
	
	public enum AccountTypeEnum
	{
		/// <summary>
		/// 0 = Bank account.
		/// </summary>
		Bank,
		
		/// <summary>
		/// 1 = Accounts receivable.
		/// </summary>
		AccountsReceivable,
		
		/// <summary>
		/// 2 = Other current asset.
		/// </summary>
		OtherCurrentAsset,
		
		/// <summary>
		/// 3 = Fixed asset.
		/// </summary>
		FixedAsset,
		
		/// <summary>
		/// 4 = Other asset
		/// </summary>
		OtherAsset,
		
		/// <summary>
		/// 5 = Accounts payable.
		/// </summary>
		AccounstPayable,
		
		/// <summary>
		/// 6 = Credit card account.
		/// </summary>
		CreditCard,
		
		/// <summary>
		/// 7 = Other current liability.
		/// </summary>
		OtherCurrentLiability,
		
		/// <summary>
		/// 8 = Long term liability.
		/// </summary>
		LongTermLiability,
		
		/// <summary>
		/// 9 = Equity account.
		/// </summary>
		Equity,
		
		/// <summary>
		/// 10 = Income account.
		/// </summary>
		Income,
		
		/// <summary>
		/// 11 = Cost of goods sold account.
		/// </summary>
		CostOfGoodsSold,
		
		/// <summary>
		/// 12 = Expense account.
		/// </summary>
		Expense,
		
		/// <summary>
		/// 13 = Other income account.
		/// </summary>
		OtherIncome,
		
		/// <summary>
		/// 14 = Other expenses.
		/// </summary>
		OtherExpense
	}
	
	public class AccountEventArgs : EventArgs
	{
		public Account Account { get; set; }
		
		public AccountEventArgs(Account account)
		{
			this.Account = account;
		}
	}
}
