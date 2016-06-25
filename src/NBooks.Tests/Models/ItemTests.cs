//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Data;
using Core.Dao;
using NBooks.Core.Models;
using NBooks.Core.Repositories;
using NUnit.Framework;

namespace NBooks.Tests.Models
{
	[TestFixture]
	public class ItemTests
	{
		[Test]
		public void TestMethod()
		{
		}
	}
	
	public class BaseRepositoryStub<T> : IBaseRepository<T>
    {
        public BaseRepositoryStub()
        {
        }

        public virtual void SaveOrUpdate(T t)
        {
            Console.WriteLine("Saved.");
        }

        public virtual void Delete(T t)
        {
            Console.WriteLine("Deleted.");
        }

        public virtual T Read(int id)
        {
            return default(T);
        }

        public virtual IList<T> FindAll()
        {
            return new List<T>();
        }

        public virtual DataSet FindAllDS()
        {
            return new DataSet();
        }
    }
	
	public class ItemRepositoryStub : BaseRepositoryStub<Item>, IItemRepository
    {
        public ItemRepositoryStub()
        {
        }

        public IList<Item> FindActive()
        {
            throw new NotImplementedException();
        }

        public IList<Item> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public void MakeInactive(Item item)
        {
            throw new NotImplementedException();
        }

        public Item ReadByName(string name)
        {
            throw new NotImplementedException();
        }

        public DataSet FindActiveDS()
        {
            throw new NotImplementedException();
        }
    }
}
