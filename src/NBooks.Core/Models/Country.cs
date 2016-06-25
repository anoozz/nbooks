//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Country : BaseModel<Country>
	{
		public virtual string ShortName { get; set; }
		public virtual string LongName { get; set; }
		public virtual bool Inactive { get; set; }
		IList<State> states = new List<State>();
		
		public virtual IList<State> States {
			get { return states; }
			set { states = value; }
		}
		
		public Country()
		{
		}
		
		public Country(string shortName)
		{
			this.ShortName = shortName;
		}
		
		public virtual void AddState(State state)
		{
			state.Country = this;
			states.Add(state);
		}
	}
	
	public class State : BaseModel<State>
	{
		public virtual string ShortName { get; set; }
		public virtual Country Country { get; set; }
		
		public State()
		{
		}
		
		public State(string shortName)
		{
			this.ShortName = shortName;
		}
	}
	
	public delegate void CountryEventHandler(Country sender, EventArgs e);
	public delegate void StateEventHandler(State sender, EventArgs e);
}
