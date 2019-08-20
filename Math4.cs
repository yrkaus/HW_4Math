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
using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestArray();
        }
        {
        static int[] array = new int[0];
            if (Array.Lenght != 0)
            {
                var result = array[0];
            }
            static int[] CetArray()
            {
                return null;
            }
            static void RequestArray()
            {
                try
                {
                    var array = GetArray();

                    for (int i = 0; i < Array.Length; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
        finally
        {
            Console.WriteLine("End of function");
        }
            }


        }
    }
}

        
  

