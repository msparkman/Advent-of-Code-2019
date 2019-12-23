using System;

namespace code
{
    class Intcode
    {
        public int[] doListThing(int[] intcodes)
        {
            for (int i = 0; i < intcodes.Length; i+=4)
            {
                if (intcodes[i] == 99)
                {
                    return intcodes;
                }

                var value1 = intcodes[i+1];
                var value2 = intcodes[i+2];
                var value3 = intcodes[i+3];

                switch(intcodes[i])
                {
                    case 1:
                        Console.WriteLine("Code 1");
                        intcodes[value3] = intcodes[value1] + intcodes[value2];
                        break;
                    case 2:
                        Console.WriteLine("Code 2");
                        intcodes[value3] = intcodes[value1] * intcodes[value2];
                        break;
                    default:
                        Console.WriteLine("Not sure what to do");
                        break;
                }
            }

            return intcodes;
        }
    }
}