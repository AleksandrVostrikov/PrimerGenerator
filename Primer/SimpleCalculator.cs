using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Primer
{
    internal class SimpleCalculator
    {
        int GetRandom()
        {
            int randomvalue = 0;
            using (RNGCryptoServiceProvider rg = new RNGCryptoServiceProvider())
            {
                byte[] rno = new byte[4];
                rg.GetBytes(rno);
                randomvalue = BitConverter.ToInt32(rno, 0);
            }
            return randomvalue;
        }
        public string[] GetAddition(int[] firstNumber, int[] secondNumber, int[] thirdNumber)
        {
            string[] addition = { "", "" };
            int a, b, result;
            Random randomGenerator = new Random(GetRandom());
            if (thirdNumber[1] != 0)
            {
                result = randomGenerator.Next(thirdNumber[0], thirdNumber[1]);
                a = randomGenerator.Next(0, result);
                b = result - a;
                addition[0] += a + " + " + b + " = " + result + Environment.NewLine;
                addition[1] += a + " + " + b + " = " + "[   ]" + Environment.NewLine;
            }
            else
            {
                a = randomGenerator.Next(firstNumber[0], firstNumber[1]);
                b = randomGenerator.Next(secondNumber[0], secondNumber[1]);
                result = a + b;
                addition[0] += a + " + " + b + " = " + result + Environment.NewLine;
                addition[1] += a + " + " + b + " = " + "[   ]" + Environment.NewLine;
            }
            return addition;
        }

        
    }
}
