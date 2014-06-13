using System;

namespace YoseTheGame.Worlds.Start
{
    public class PingResponse
    {
        public bool alive { get; set; }

        public PingResponse(bool value)
        {
            alive = value;
        }
    }
}
