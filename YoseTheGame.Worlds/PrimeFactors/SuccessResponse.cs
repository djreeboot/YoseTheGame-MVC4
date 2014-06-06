using System.Collections.Generic;

namespace YoseTheGame.Worlds.PrimeFactors
{
    public class SuccessResponse : Response
    {
        public List<int> decomposition { get; set; }
    }
}
