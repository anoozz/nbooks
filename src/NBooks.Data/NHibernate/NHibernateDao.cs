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
using System.Collections.Generic;
using System.Data;

using Core.Dao;
using NBooks.Core.Repositories;
using NBooks.Core.Util;
using NHibernate;

namespace NBooks.Data.NHibernate
{
	/// <summary>
	/// Description of NHibernateDao.
	/// </summary>
	public class NHibernateDao<T> : IBaseDao<T>
	{
		public NHibernateDao()
		{
		}
		
		public virtual void SaveOrUpdate(T t)
		{
			ITransaction trans = null;
			try {
				ISession session = NHibernateHelper.OpenSession();
				trans = session.BeginTransaction();
				session.SaveOrUpdate(t);
				session.Flush();
				trans.Commit();
			} catch (Exception ex) {
				LoggingService.Error(ex.Message);
				MessageService.ShowError(ex.Message);
				trans.Rollback();
			}
		}
		
		public virtual void Delete(T t)
		{
			ITransaction trans = null;
			try {
				ISession session = NHibernateHelper.OpenSession();
				trans = session.BeginTransaction();
				session.Delete(t);
				session.Flush();
				trans.Commit();
			} catch (Exception ex) {
				LoggingService.Error(ex.Message);
				MessageService.ShowError(ex.Message);
				trans.Rollback();
			}
		}
		
		public virtual T Read(int id)
		{
			return NHibernateHelper.OpenSession().Load<T>(id);
		}
		
		public virtual IList<T> FindAll()
		{
			return NHibernateHelper.OpenSession().CreateCriteria(typeof(T)).List<T>();
		}
		
		public virtual DataSet FindAllDS()
		{
			throw new NotImplementedException();
		}
	}
}
