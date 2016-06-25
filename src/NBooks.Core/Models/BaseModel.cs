//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using NBooks.Core.Util;
using NBooks.Data.NHibernate;
using NHibernate;

namespace NBooks.Core.Models
{
	public interface IBaseModel
	{
		int Id { get; set; }
	}
	
	public class BaseModel<T> : IBaseModel
	{
		IList<string> errors = new List<string>();
		public virtual int Id { get; set; }
		
		public virtual bool HasErrors {
			get { return errors.Count > 0; }
		}
		
		public virtual IList<string> Errors {
			get { return errors; }
		}
		
		public BaseModel()
		{
		}
		
		public virtual void Validate()
		{
			Errors.Clear();
		}
		
		public virtual void SaveOrUpdate()
		{
			ITransaction trans = null;
			try {
				ISession session = NHibernateHelper.OpenSession();
				trans = session.BeginTransaction();
				session.SaveOrUpdate(this);
				session.Flush();
				trans.Commit();
			} catch (Exception ex) {
				LoggingService.Error(ex.Message);
				MessageService.ShowError(ex.Message);
				trans.Rollback();
			}
		}
		
		public virtual void Delete()
		{
			ITransaction trans = null;
			try {
				ISession session = NHibernateHelper.OpenSession();
				trans = session.BeginTransaction();
				session.Delete(this);
				session.Flush();
				trans.Commit();
			} catch (Exception ex) {
				LoggingService.Error(ex.Message);
				MessageService.ShowError(ex.Message);
				trans.Rollback();
			}
		}
		
		public static T Read(int id)
		{
			return NHibernateHelper.OpenSession().Load<T>(id);
		}
		
		public static IList<T> FindAll()
		{
			return NHibernateHelper.OpenSession().CreateCriteria(typeof(T)).List<T>();
		}
	}
}
