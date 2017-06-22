using System;
using System.Linq;

namespace ConsoleDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			string inputString = "one two three four five";
			
			inputString.Split(' ').Select(x => new String(x.Reverse().ToArray()))
		}
	}
}