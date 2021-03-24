using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.BackgroundColor = ConsoleColor.DarkMagenta;
			Console.ForegroundColor = ConsoleColor.Blue;
			string nama = BacaInput("Silahkan Masukkan Nama Anda :");

		}

		public static string BacaInput(string msg)
		{
			Console.Write(msg);
			return System.Console.ReadLine();
		}
	}
}
