using System;
using System.Collections.Generic;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileString = System.IO.File.ReadAllText(@"Intcodes.txt");
            string[] stringArray = fileString.Split(',');


            int[] intcodeArray = new int[stringArray.Length];
            int index = 0;
            foreach (var stringIntcode in stringArray)
            {
                intcodeArray[index] = Convert.ToInt32(stringIntcode);
                index++;
            }

            var intcode = new Intcode();
            
            intcodeArray = intcode.doListThing(intcodeArray);

            foreach (var intcodeElement in intcodeArray)
            {
                Console.Write($"{intcodeElement},");
            }
        }
    }
}
