using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadExercise
{
	public abstract class Person
	{
		public List<string> FirstName { get; set; }
		public List<string> LastName { get; set; }

		public virtual void SayName()
		{
			foreach (string name in FirstName)
			{
				foreach (string lname in LastName)
				{
					Console.WriteLine("Name: " + name + " " + lname);
				}
			}
		}
	}
}
