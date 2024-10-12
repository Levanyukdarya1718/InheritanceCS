//#define WRITE_TO_FILE
#define WRITE_TO_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
namespace File
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if WRITE_TO_FILE
			//StreamWriter sw = new StreamWriter("File.txt");
			//sw.WriteLine("Hello Files");
			//sw.Close();
			StreamWriter sw = System.IO.File.AppendText("File.txt");
			sw.WriteLine("Append to File");
			sw.Close();
			Process.Start("notepad", "File.txt");
#endif
#if WRITE_TO_FILE
			StreamReader sr = new StreamReader("File.txt");
			while(! sr.EndOfStream)
			{
				string buffer = sr.ReadLine();
				Console.WriteLine(buffer);
			}
			sr.Close();
#endif
		}
	}
}
