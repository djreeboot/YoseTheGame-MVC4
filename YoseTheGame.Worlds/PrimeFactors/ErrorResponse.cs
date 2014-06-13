namespace YoseTheGame.Worlds.PrimeFactors
{
    public class ErrorResponse : Response
    {
        public string error { get; set; }

        public ErrorResponse(object number, string error)
        {
            this.number = number;
            this.error = error;
        }
    }
}
