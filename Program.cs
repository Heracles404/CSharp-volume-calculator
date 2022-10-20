using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flux
{
    
    class Program
    {
        
        // Validation
        class validation
        {
            public static double validation1(string length, string height, string width)
            {
                double l, h, w;
                try
                {
                    l = Double.Parse(length);
                    h = Double.Parse(height);
                    w = Double.Parse(width);


                    Volume.volume1(l, h, w);
                }
                catch
                {
                    Console.WriteLine("One or more inputs are invalid");
                }
                return 0;
            }
        }

        //Compute Volume
        class Volume
        {
            public static double volume1(double length, double height, double width)
            {
                double final = length * height * width;
                Console.WriteLine("Volume: " + final);

                return final;
            }
        }

        // Main Method 
        static void Main(string[] args)
        {
            String choice;

            do
            {
                Console.WriteLine("A) COMPUTE");
                Console.WriteLine("E) EXIT");
                choice = Console.ReadLine();
                if (choice.ToUpper() == "A")
                {
                    string width, height, length;
                    Console.WriteLine("Enter Length");
                    length = Console.ReadLine();

                    Console.WriteLine("Enter Width");
                    width = Console.ReadLine();

                    Console.WriteLine("Enter Height");
                    height = Console.ReadLine();

                    validation.validation1(length, height, width);
                }
                else if (choice.ToUpper() == "E")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            } while (choice != "E");

        }
    }
}
