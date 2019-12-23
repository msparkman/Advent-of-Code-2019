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
                        intcodes[value3] = intcodes[value1] + intcodes[value2];
                        break;
                    case 2:
                        int product = intcodes[value1] * intcodes[value2];
                        intcodes[value3] = intcodes[value1] * intcodes[value2];
                        break;
                    default:
                        Console.WriteLine($"Not sure what to do with {intcodes[i]}");
                        return intcodes;
                        // break;
                }
            }

            return intcodes;
        }

        public int[] getNounAndVerb(int[] intcodes) 
        {
            // Need to figure out how to get 19690720
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    int[] tempIntcodes = new int[intcodes.Length];
                    intcodes.CopyTo(tempIntcodes , 0);

                    tempIntcodes[1] = i;
                    tempIntcodes[2] = j;

                    doListThing(tempIntcodes);

                    int result = tempIntcodes[0];
                    if (result == 19690720)
                    {
                        Console.WriteLine($"noun={i}, verb={j}: {result}");
                    }
                }
            }

            return intcodes;
        }
    }
}