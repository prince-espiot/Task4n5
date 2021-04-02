/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 1/21/2021
 * Time: 04:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace execises
{
	/// <summary>
	/// Write a program that prints on the console the perimeter and 
	/// the area of a rectangle by given side and height entered by the user.
	/// </summary>
	public class Class1
	{
			int counter1=0;
//			int counter2=0;
//			double len;
			double side;
			
			public  Class1(string squareside)
			{
				//Console.Write("Write the side: ");
				do{
					try
					{
						side = Convert.ToDouble(squareside);
						counter1=1;
					}
					catch
					{
						Console.WriteLine("Incorrect argument");                      
              	 		Console.WriteLine("Please use the right format");         
             		   	
					}
				}while(counter1!=1);
				
				
				
		}
			
			public double getArea()
			{
				double surfArea = side*side;
				
				return surfArea;
			}
			
			public double getPerimeter(){
				double perimeter = side*4;
				
				return perimeter;
			}
			
			public void Display() 
 
			{ 
				 
				Console.WriteLine("Perimeter: {0}", getPerimeter()); 
				 
				Console.WriteLine("Area: {0}", getArea()); 
				 
			} 
		}
		
		
	
}
