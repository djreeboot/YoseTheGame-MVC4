using System.Collections.Generic;

namespace YoseTheGame.Worlds.PrimeFactors
{
    public class RomanResponse : Response
    {
        public List<string> decomposition { get; set; }

        public RomanResponse(string number, List<string> decomposition)
        {
            this.number = number;
            this.decomposition = decomposition;
        }
    }
}
