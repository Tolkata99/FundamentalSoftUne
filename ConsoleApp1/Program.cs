using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double waterTank = 255;
            double waterCallect = 0;
            for (int i = 0; i < n; i++)
            {
                double water = double.Parse(Console.ReadLine());
                
                if (waterTank - water >= 0)
                {
                    waterTank -= water;
                    waterCallect += water;

                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(waterCallect);
        }
    }
}
