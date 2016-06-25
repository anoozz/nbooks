/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 2/23/2011
 * Time: 9:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using NBooks.Core.Gui;
using NBooks.Core.Util;
using PatientArchiver.Gui;
using PatientArchiver.Model.Dao;
using PatientArchiver.Model.Dao.NHibernate;

namespace PatientArchiver.Command
{
	public class AddVisit : AbstractCommand
	{
		public override void Run()
		{
			VisitForm form = new VisitForm();
//			IVisitDao visitDao = new NHibernateVisitDao();
//			IPatientDao patientDao = new NHibernatePatientDao();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
