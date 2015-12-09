using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_Simulator
{
    public class Converters
    {
        public static int  BinaryToDecimal(String str)
        {
          int a =  Convert.ToInt32("str", 2);
            return a;
        }

        public static string DecimalToBinary(int value)
        {
            
            string binary = Convert.ToString(value, 2);
            return binary;
        }

        public static string AddTwoBinary(string val1, string val2)
        {
            int number_one = Convert.ToInt32(val1, 2);
            int number_two = Convert.ToInt32(val2, 2);

            return Convert.ToString(number_one + number_two, 2);
        }
    }
}
