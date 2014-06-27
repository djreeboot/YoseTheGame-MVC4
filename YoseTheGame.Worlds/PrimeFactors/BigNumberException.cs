using System;

namespace YoseTheGame.Worlds.PrimeFactors
{
    public class BigNumberException : Exception
    {
        public BigNumberException() : base("too big number (>1e6)")
        {
        }
    }
}
