using System;

namespace src.Domain
{
    public class PriceDetailsAnnouncement
    {
        public Guid Id { get; set; }
        public long Value { get; set; }
        public string CurrencySymbol { get; set; }
        public string PriceForM2 { get; protected set; }
    }
}

  
        
