using System;

namespace BestHost.Model
{
    public class AvailableHost
    {
        public Host Host { get; set; }
        public HostAdmin HostAdmin{ get; set; }
        public bool HostLiveHere { get; set; }
        public CoinEnum Coin { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
