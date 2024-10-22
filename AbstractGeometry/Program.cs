using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
			
			//Console.WriteLine("AbstractGeometry");
			Rectangle rectangle = new Rectangle(100, 50, 500, 200, 3, System.Drawing.Color.Red);
			rectangle.Info(e);
			Square square = new Square(75,512,16,1,Color.DarkBlue);
			square.Info(e);
			Circle circle = new Circle(55,600, 95,3,Color.Red);
			circle.Info(e);
			IsoscalesTriangle i_triangle = new IsoscalesTriangle(50, 100, 800, 50, 2, Color.Green);
			i_triangle.Info(e);
			EquilateralTriangle e_triangle=
			new EquilateralTriangle(150, 500,200,5,Color.GreenYellow); 
			e_triangle.Info(e);
		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
