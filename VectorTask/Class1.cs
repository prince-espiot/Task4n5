/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 3/30/2021
 * Time: 21:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VectorTask
{
    public class Vectorizor
    {
    	public Dictionary<string , double []> vector = 
    		new Dictionary<string, double[]>();
    	public string First_vector = "x";  //main vectors
    	public string Sec_vector = "y";
    	
    	
    	public  Vectorizor (string m1, string p1,string m2,string p2)
    	{
    		double u1_value = 0;  //Breaking into constitute elements.
			double v1_value = 0;
			double u2_value = 0;
			double v2_value = 0;
			
			
			u1_value = Convert.ToDouble(m1); // coverting sting input to double for computation.
			v1_value = Convert.ToDouble(p1);
			u2_value = Convert.ToDouble(m2);
			v1_value = Convert.ToDouble(p2);
			
			vector.Add(First_vector, new double []{u1_value,v1_value});
			vector.Add(Sec_vector , new double []{u2_value,v2_value});
    	}
    	
    	public void Summing()
    	{
    	string Final_Vector = "w";
    		
    	double [] firstVec = GetValues(vector[First_vector][0],vector[First_vector][1]);
    	double [] seconfVec = GetValues(vector[Sec_vector][0],vector[Sec_vector][1]);
    		                                                                             
    	double [] vectorSum = new double[]{  // add the constituent element of the vectors.
    		  firstVec[0]+seconfVec[0], firstVec[1]+seconfVec[1]
    		  };
    	double Final_Magnitude = Math.Sqrt (Math.Pow(vectorSum[0],2)+Math.Pow(vectorSum[1],2));
    	double Final_phase =  Math.Atan2(vectorSum[1],vectorSum[0])*(180/Math.PI);
    	vector.Add(Final_Vector, new double []{Final_Magnitude,Final_phase});
    	
    	Console.WriteLine("   Magnitude: {0}", vector[Final_Vector][0]);
     	Console.WriteLine("   Phase:     {0} degrees", vector[Final_Vector][1]);
    	Console.WriteLine("   Phase      {0} radians", vector[Final_Vector][1]/ (180/Math.PI));
       
    	
    	}
    	private double[] GetValues(double magnitude, double phaseAngle)
        {
            double i = 0;
            double j = 0;

            if (phaseAngle > 360)
            {
                phaseAngle = phaseAngle % 360;
            }

           do
            {
                phaseAngle += 360;
            }while(phaseAngle<0);

             if (phaseAngle <= 90)
            {
                i = PolarCalculateI(magnitude, phaseAngle);
                j = PolarCalculateJ(magnitude, phaseAngle);
            }

             if (phaseAngle > 90 && phaseAngle <= 180)
            {
                i = PolarCalculateI(magnitude, phaseAngle);
                j = PolarCalculateJ(magnitude, phaseAngle);
            }

             if (phaseAngle > 180 && phaseAngle <= 270)
            {
                i = PolarCalculateI(magnitude, phaseAngle);
                j = PolarCalculateJ(magnitude, phaseAngle);
            }

             if (phaseAngle > 270 && phaseAngle <= 360)
            {
                i = PolarCalculateI(magnitude, phaseAngle);
                j = PolarCalculateJ(magnitude, phaseAngle);
            }

            return new double[] { i, j };
        }
    	
    	private double PolarCalculateI(double magn, double phaseAng)
        {
            return magn* Math.Cos(phaseAng * (Math.PI / 180));       
        }

       
        private double PolarCalculateJ(double magn, double phaseAng)
        {
            return magn * Math.Sin(phaseAng * (Math.PI / 180));
        }
    
    }
    
}