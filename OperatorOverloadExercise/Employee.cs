using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadExercise
{
	public class Employee : Person
	{
		////public List<int> Id { get; set; }
		public int IdCheck { get; set; }
		public int Id { get; set; }
		
		public Employee()
		{
			Id = 0;
		}
		public Employee(int x)
		{
			Id = x;
		}
		

		public override void SayName()
		{
			foreach (string name in FirstName)
			{
				foreach (string lname in LastName)
				{
					Console.WriteLine("Name: " + name + " " + lname);

				}


			}
		}
		public void Quit(Person person)
		{
			throw new NotImplementedException();
		}

		public static bool operator == (Employee Id, Employee IdCheck)
		{
			if (Id == IdCheck)
				return true;
			else
				return false;

		}
		public static bool operator !=(Employee Id, Employee IdCheck)
		{
			if (Id != IdCheck)
				return true;
			else
				return false;
		}
	}
}
