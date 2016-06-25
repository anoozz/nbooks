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

namespace NBooks.Views.Accounts
{
	public class BankAccountType : AccountType
	{
		public BankAccountType() : base(AccountTypeEnum.Bank, "Bank")
		{
		}
	}
	
	public class AccountsReceivableAccountType : AccountType
	{
		public AccountsReceivableAccountType() : base(AccountTypeEnum.AccountsReceivable, "Accounts Receivable")
		{
		}
	}
	
	public class OtherCurrentAssetAccountType : AccountType
	{
		public OtherCurrentAssetAccountType() : base(AccountTypeEnum.OtherCurrentAsset, "Other Current Asset")
		{
		}
	}
	
	public class FixedAssetAccountType : AccountType
	{
		public FixedAssetAccountType() : base(AccountTypeEnum.FixedAsset, "Fixed Asset")
		{
		}
	}
	
	public class OtherAssetAccountType : AccountType
	{
		public OtherAssetAccountType() : base(AccountTypeEnum.OtherAsset, "Other Asset")
		{
		}
	}
	
	public class AccountsPayableAccountType : AccountType
	{
		public AccountsPayableAccountType() : base(AccountTypeEnum.AccounstPayable, "Accounts Payable")
		{
		}
	}
	
	public class CreditCardAccountType : AccountType
	{
		public CreditCardAccountType() : base(AccountTypeEnum.CreditCard, "Credit Card")
		{
		}
	}
	
	public class OtherCurrentLiabilityAccountType : AccountType
	{
		public OtherCurrentLiabilityAccountType() : base(AccountTypeEnum.OtherCurrentLiability, "Other Current Liability")
		{
		}
	}
	
	public class LongTermLiabilityAccountType : AccountType
	{
		public LongTermLiabilityAccountType() : base(AccountTypeEnum.LongTermLiability, "Long Term Liability")
		{
		}
	}
	
	public class EquityAccountType : AccountType
	{
		public EquityAccountType() : base(AccountTypeEnum.Equity, "Equity")
		{
		}
	}
	
	public class IncomeAccountType : AccountType
	{
		public IncomeAccountType() : base(AccountTypeEnum.Income, "Income")
		{
		}
	}
	
	public class CostOfGoodsSoldAccountType : AccountType
	{
		public CostOfGoodsSoldAccountType() : base(AccountTypeEnum.CostOfGoodsSold, "Cost of Goods Sold")
		{
		}
	}
	
	public class ExpenseAccountType : AccountType
	{
		public ExpenseAccountType() : base(AccountTypeEnum.Expense, "Expense")
		{
		}
	}
	
	public class OtherIncomeAccountType : AccountType
	{
		public OtherIncomeAccountType() : base(AccountTypeEnum.OtherIncome, "Other Income")
		{
		}
	}
	
	public class OtherExpenseAccountType : AccountType
	{
		public OtherExpenseAccountType() : base(AccountTypeEnum.OtherExpense, "Other Expense")
		{
		}
	}
}
