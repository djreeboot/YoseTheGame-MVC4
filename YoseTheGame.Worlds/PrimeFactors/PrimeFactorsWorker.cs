using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace YoseTheGame.Worlds.PrimeFactors
{
    public class PrimeFactorsWorker
    {
        public static object Decompose(object numbers)
        {
            if (numbers is string)
            {
                return DecomposeSingle((string)numbers);
            }
            else
            {
                List<Response> responses = new List<Response>();
                foreach (string number in (string[])numbers)
                {
                    responses.Add(DecomposeSingle(number));
                }
                return responses;
            }
        }

        private static Response DecomposeSingle(string number)
        {
            int value;
            bool isInteger = int.TryParse(number, out value);
            bool isRoman = false;

            try
            {
                if (!isInteger)
                {
                    if (RomanNumber.TryParse(number, out value))
                        isRoman = true;
                    else
                        throw new StringGuardException();
                }

                if (value > 1000000)
                    throw new BigNumberException();

                if (value < 0)
                    throw new NegativeNumberException(value);

                List<int> decomposition = new List<int>();

                int limit = value;
                for (int i = 2; i <= limit; i++)
                {
                    if (value == 1)
                        break;

                    while (value % i == 0)
                    {
                        decomposition.Add(i);
                        value /= i;
                    }
                }

                if (!isRoman)
                    return new SuccessResponse(limit, decomposition);
                else
                {
                    List<string> romanDecomposition = new List<string>();
                    foreach (int i in decomposition)
                        romanDecomposition.Add(RomanNumber.ToRoman(i));

                    return new RomanResponse(number, romanDecomposition);
                }
            }
            catch (StringGuardException e)
            {
                return new ErrorResponse(number, e.Message);
            }
            catch (Exception e)
            {
                return new ErrorResponse(value, e.Message);
            }
        }
    }
}
