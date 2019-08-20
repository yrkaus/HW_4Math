using System;

namespace ConsoleApp9
{
    private static void Main(string[] args)
            {

                int x = 3;
                double e = Math.E;

                double Numerator = 6 * Math.Log(Math.Sqrt(Math.Pow(e, x + 1) + Math.Pow(e, x) * Math.Cos(x)));
                double Denominator = Math.Log(x - Math.Pow(e, x + 1) * Math.Sin(x));
                double addition = Math.Abs(Math.Cos(x) / Math.Pow(e, Math.Sin(x)));
                double Z = Numerator / Denominator + addition;

                Console.WriteLine(Z);



            }
        }
    }

                  
        
  

