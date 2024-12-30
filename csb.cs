using System;
using System.IO;

namespace consoleBufferScreenPrinter
{
	public class buffer
	{
		public static string frame()
		{
			//
		}
	}
	public class consoler
	{
		public static void Main()
		{
			bool continue = true;
			while (continue)
			{
				print(buffer.frame());
			}
		}
		public static void print(string)
		{
			Console.Write(string);
		}
	}
}
