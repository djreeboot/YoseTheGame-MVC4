using System;

namespace YoseTheGame.Worlds.PrimeFactors
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(int number)
            : base(string.Format("{0} is not an integer > 1", number.ToString()))
        {
        }
    }
}
