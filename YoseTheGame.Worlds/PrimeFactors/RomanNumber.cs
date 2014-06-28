using System;
using System.Text;
using System.Collections.Generic;

namespace YoseTheGame.Worlds.PrimeFactors
{
    public static class RomanNumber
    {
        static string[] roman1 = { "CM", "DCCC", "DCC", "DC", "D", "CD", "CCC", "CC", "C" };
        static string[] roman2 = { "XC", "LXXX", "LXX", "LX", "L", "XL", "XXX", "XX", "X" };
        static string[] roman3 = { "IX", "VIII", "VII", "VI", "V", "IV", "III", "II", "I" };
        static List<string[]> romans = new List<string[]>() { roman1, roman2, roman3 };

        public static bool TryParse(string text, out int value)
        {
            value = 0;
            if (String.IsNullOrEmpty(text)) return false;
            text = text.ToUpper();
            int len = 0;
            int j = 0;

            for (int mult = 100; mult >= 1; mult /= 10)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (text.StartsWith(romans[j][i]))
                    {
                        value += mult * (9 - i);
                        len = romans[j][i].Length;
                        break;
                    }
                }

                if (len > 0)
                {
                    text = text.Substring(len);
                    len = 0;
                }
                j++;
            }

            if (text.Length > len)
            {
                value = 0;
                return false;
            }

            return true;
        }

        public static string ToRoman(int num)
        {
            if (num > 999)
                throw new ArgumentException("Too big - can't exceed 999");

            if (num < 1)
                throw new ArgumentException("Too small - can't be less than 1");

            StringBuilder sb = new StringBuilder();
            int j = 0;
            for (int mult = 100; mult >= 1; mult /= 10)
            {
                int value = 0;
                
                value = num / mult;
                num %= mult;
                if (value > 0)
                    sb.Append(romans[j][9 - value]);

                j++;
            }

            return sb.ToString();
        } 
    }
}
