using System;

namespace code 
{
    public class FuelCalculator
    {
        public int calculate(decimal moduleMass)
        {
            int totalRequiredFuel = (int) (Math.Floor(moduleMass/3) - 2);
            if (totalRequiredFuel <= 0)
            {
                return 0;
            }
            
            Console.WriteLine($"Current required fuel: {totalRequiredFuel}");
            totalRequiredFuel += calculate(totalRequiredFuel);
            
            return totalRequiredFuel;
        }
    }
}