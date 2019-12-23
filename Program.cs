using System;
using System.Collections.Generic;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new FuelCalculator();
            string[] moduleMassArray = System.IO.File.ReadAllLines(@"ModuleMasses.txt");
           
            int sum = 0;
            foreach (var moduleMass in moduleMassArray)
            {
                int requiredFuel = calculator.calculate(Convert.ToDecimal(moduleMass));
                sum += requiredFuel;
                Console.WriteLine($"Module Mass: {moduleMass} | Fuel Required: {requiredFuel}");
            }

            Console.WriteLine($"Total Required Fueld: {sum}");
        }
    }
}
