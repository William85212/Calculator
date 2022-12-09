using System;

namespace Calculator
{
    public class Calculator
    {
        public static int SumEvens(int[] number)
        {
            int sum = 0;
            foreach (int item in number)
            {
                if (item % 2 == 0)
                    sum += item;
            }
            return sum;
        }
    }
}
