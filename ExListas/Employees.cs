using System;
using System.Globalization;
namespace ExListas
{
	public class Employees
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Salary { get; set; }

		public Employees(int id, string name, double salary)
		{
			Id = id;
			Name = name;
			Salary = salary;
		}

        public void IncreaseSalary(double porcentage)
		{
			Salary += Salary * porcentage / 100;
		}

        public override string ToString()
        {
			return Id +
					"," +
					Name +
					"," +
					Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

