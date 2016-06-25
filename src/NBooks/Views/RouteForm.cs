//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class RouteForm : BaseForm
	{
		Route route;
		
		public Route Route {
			get {
				route.Code = textBoxCode.Text;
				route.Description = textBoxDescription.Text;
				route.Inactive = checkBoxInactive.Checked;
				return route; 
			}
			set {
				route = value;
				textBoxCode.Text = route.Code;
				textBoxDescription.Text = route.Description;
				checkBoxInactive.Checked = route.Inactive;
			}
		}
		
		public RouteForm() : this(new Route())
		{
		}
		
		public RouteForm(Route route)
		{
			InitializeComponent();
			this.Route = route;
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SaveRoute != null) {
				SaveRoute(Route, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		public event RouteEventHandler SaveRoute;
	}
}
