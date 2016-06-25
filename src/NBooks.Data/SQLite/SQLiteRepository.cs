//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Data;

using Core.Dao;
using NBooks.Core.Repositories;

namespace NBooks.Data.SQLite
{
	public class SQLiteRepository<T> : IBaseDao<T>
	{
		public SQLiteRepository()
		{
		}
		
		public virtual void SaveOrUpdate(T t)
		{
			throw new NotImplementedException();
		}
		
		public virtual void Delete(T t)
		{
			throw new NotImplementedException();
		}
		
		public virtual T Read(int id)
		{
			throw new NotImplementedException();
		}
		
		public virtual IList<T> FindAll()
		{
			throw new NotImplementedException();
		}
		
		public virtual DataSet FindAllDS()
		{
			throw new NotImplementedException();
		}
	}
}
