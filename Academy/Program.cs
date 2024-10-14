using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Academy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Human humah = new Human("Montana", "Antonio", 25);
			humah.Print();
			Console.WriteLine(humah);

			Student student = new Student("Pincman", "Jessie", 22, "Chimestry", "ww_220", 95, 96);
			student.Print();
			Console.WriteLine(student);

			Teacher teacher = new Teacher("White", "Walter", 50, "Ghimestry", 25);
			teacher.Print();
			Console.WriteLine(teacher);
			Graduate graduate = new Graduate("Schrader", "Hank", 40, "Criminalistic", "OBN", 70, 75, "How to catch Heisenberg");
	
			graduate.Print();
			Console.WriteLine(graduate);

			Human[] group = new Human[]
			{
				new Human("Montana", "Antonio", 25),
				new Teacher("White", "Walter", 50, "Chemistry", 25),
				new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96),
				new Graduate("Schrader", "Hank", 40, "Criminalistic", "OBN", 70, 75, "How to catch Heisenberg"),
				new Student ("Vercetty", "Tommy", 30, "Theft", "Vice", 97,98),
				new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20)
			};
			Print(group);
			Save(group, "group.txt");
			
			////заппись в файл 
			//StreamWriter sw = File.AppendText("Group.txt");
			//foreach (Human person in group)
			//{
			//	sw.WriteLine(person.ToString());
			//	sw.WriteLine();
			//}
			//sw.Close();
		
			////чтоение из файла 

			//StreamReader sr = new StreamReader("Group.txt");
			//while (!sr.EndOfStream)
			//{
			//	string buffer = sr.ReadLine();
			//	Console.WriteLine(buffer);
			//}
			//sr.Close();
			//Process.Start("notepad", "Group.txt");

		}
		static void Print(Human[] group)
		{
			for (int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);
			}
			Console.WriteLine();
		}
		static void Save(Human[] group, string filename)
		{
			StreamWriter sw = new StreamWriter(filename);
			for (int i = 0; i < group.Length; i++)
			{
				sw.WriteLine(group[i]);
			}
			sw.Close();
			Process.Start("notepad", filename);
		}
	}
}
