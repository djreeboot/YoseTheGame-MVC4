﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static Response DecomposeSingle(string number)
        {
            int value;

            if (int.TryParse(number, out value))
            {
                if (value <= 1000000)
                {
                    List<int> decomposition = new List<int>();

                    while (value % 2 == 0)
                    {
                        decomposition.Add(2);
                        value /= 2;
                    }

                    for (int i = 3; i <= int.Parse(number); i = i + 2)
                    {
                        if (value == 1)
                            break;

                        while (value % i == 0)
                        {
                            decomposition.Add(i);
                            value /= i;
                        }
                    }

                    return new SuccessResponse(int.Parse(number), decomposition);
                }
                else
                {
                    return new ErrorResponse(value, "too big number (>1e6)");
                }
            }
            else
            {
                return new ErrorResponse(number, "not a number");
            }
        }
    }
}
