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
        public string[] GetAddition(int[] range, int[] answer)
        {
            string[] addition = { "", "" };
            int a, b, result;
            Random randomGenerator = new Random(GetRandom());
            if (answer[1] != 0)
            {
                result = randomGenerator.Next(answer[0], answer[1]);
                a = randomGenerator.Next(0, result);
                b = result - a;
                addition[0] += a + " + " + b + " = " + result + Environment.NewLine;
                addition[1] += a + " + " + b + " = " + "[   ]" + Environment.NewLine;
            }
            else
            {
                a = randomGenerator.Next(range[0], range[1]);
                b = randomGenerator.Next(range[0], range[1]);
                result = a + b;
                addition[0] += a + " + " + b + " = " + result + Environment.NewLine;
                addition[1] += a + " + " + b + " = " + "[   ]" + Environment.NewLine;
            }
            return addition;
        }
        public string[] GetSubtraction(int[] range, int[] answer)
        {
            string[] addition = { "", "" };
            int a, b, result;
            Random randomGenerator = new Random(GetRandom());
            if (answer[1] != 0)
            {
                result = randomGenerator.Next(answer[0], answer[1]);
                b = randomGenerator.Next(0, result);
                a = result + b;
                addition[0] += a + " - " + b + " = " + result + Environment.NewLine;
                addition[1] += a + " - " + b + " = " + "[   ]" + Environment.NewLine;
            }
            else
            {
                a = randomGenerator.Next(range[0], range[1]);
                b = randomGenerator.Next(range[0], range[1]);
                if (b >= a)
                {
                    result = b - a;
                    addition[0] += b + " - " + a + " = " + result + Environment.NewLine;
                    addition[1] += b + " - " + a + " = " + "[   ]" + Environment.NewLine;
                }
                else
                {
                    result = a - b;
                    addition[0] += a + " - " + b + " = " + result + Environment.NewLine;
                    addition[1] += a + " - " + b + " = " + "[   ]" + Environment.NewLine;
                }
            }
            return addition;
        }



    }
}
