/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 1/21/2021
 * Time: 03:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace execises
{
	class Program
	{
		public static void Main(string[] args)
		{
			// TODO: Implement Functionality Here
			
			
			
			Console.Write(" Please Enter value for a square side: ");
			
			string input = Console.ReadLine();
			
			
			Class1 myclass = new Class1(input);
			myclass.Display();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}