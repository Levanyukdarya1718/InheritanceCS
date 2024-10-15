using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;


namespace Academy
{
	//Single responsibility principle
	class Streamer
	{
		internal static void Print(Human[] group)
		{
			for (int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);
			}
			Console.WriteLine();
		}
		internal static string SetDirectory()
		{
			string locatoin = System.Reflection.Assembly.GetEntryAssembly().Location;
			string parth = System.IO.Path.GetDirectoryName(locatoin);
			Console.WriteLine(locatoin);
			Console.WriteLine(parth);
			Directory.SetCurrentDirectory($"{parth}\\..\\..");
			Console.WriteLine(Directory.GetCurrentDirectory());
			Console.WriteLine("\n----------------------------------\n");
			return Directory.GetCurrentDirectory();
		}

		internal static void Save(Human[] group, string filename)
		{
			SetDirectory();
			StreamWriter sw = new StreamWriter(filename);
			sw.WriteLine("Sep=,");//определяем разделитель
			for (int i = 0; i < group.Length; i++)
			{
				sw.WriteLine(group[i].ToFileString());
			}
			sw.Close();
			Process.Start("notepad", filename);
		}
		
		// CSV- Comma Separated Values (значения разделенные запятой)
		internal static Human[] Load(string filename)
		{
			SetDirectory();
			List<Human> group = new List<Human>();
			StreamReader sr = new StreamReader(filename);
			try
			{
				while (!sr.EndOfStream)
				{
					string buffer = sr.ReadLine();
					string[] values = buffer.Split(',');
					values = values.Where(s => s != "").ToArray();//удаление пустой строки из массива parts
					if (values.Length == 1) continue;
					Console.WriteLine(buffer);
					//	Human human = HumanFactory.Create(values[0]);
					//	human.Init(values);
					//	group.Add(human);
					group.Add(HumanFactory.Create(values[0]).Init(values));
				}
				sr.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return group.ToArray();

		}

	}
}
