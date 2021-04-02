/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 2/30/2021
 * Time: 21:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VectorTask
{
	class Program
	{
		
		public static void Main(string[] args)
		
		{
			 //Request value from console
			Console.WriteLine("Enter the magnitude for the first vector:");     
            string m1 = Console.ReadLine();                                    

            Console.WriteLine("Enter the phase angle for the first vector:");      
            string p1 = Console.ReadLine();                                     

            Console.WriteLine("Enter the magnitude for the second vector:");   
            string m2 = Console.ReadLine();                                    

            Console.WriteLine("Enter the phase angle for the second vector:");     
            string p2 = Console.ReadLine();                                   
           
            Vectorizor Vectorizor = new Vectorizor (m1,p1,m2,p2);
            Vectorizor.Summing();
            
            Console.WriteLine("Press any key to exit");                   //Asks user to press any key to exit the console
            Console.ReadKey(); 
   
            
	}
	}
}
