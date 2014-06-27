using System;

namespace YoseTheGame.Worlds.PrimeFactors
{
    public class StringGuardException : Exception 
    {
        public StringGuardException(): base("not a number")
        {
        }
    }
}
