using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Graduate: Student
	{
		public string Topic { get; set; }
		public Graduate(
				string lastName, string firstName, int age,
				string speciality, string group, double rating, double attendance,
				string topic
			) : base(lastName, firstName, age, speciality, group, rating, attendance)
		{
			Topic = topic;
			Console.WriteLine($"GConstructor:{GetHashCode()}");
		}

		~Graduate()
		{
			Console.WriteLine($"GDestructor:{GetHashCode()}");
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine($"{Topic}");
		}

		public override string ToString()
		{
			return base.ToString() + $" {Topic}";
		}
		public override string ToFileString()
		{
			return base.ToFileString()+$", {Topic}";
		}
		public override Human Init(string[] values)
		{
			base.Init(values);
			Topic = values[4];
			return this;
		}
	}
}
