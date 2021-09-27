using System;
using System.Collections.Generic;

namespace src.Domain
{
    public class Announcement
    {
        public Guid Id { get; protected set; }  
        public string Title {get; protected set;}
        public string Description { get; protected set; }  
        public DateTime LastRefreshTime { get; protected set; }
        public DateTime AddAt { get; protected set; }


        public static Announcement Create(string title, string description, DateTime lastRefreshTime)
            => new Announcement(title, description, lastRefreshTime);
        
        protected Announcement (string title, string description, DateTime lastRefreshTime)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            LastRefreshTime = lastRefreshTime;
            AddAt = DateTime.UtcNow;
        }

        // public string CityName { get; protected set; } 
        // public string CityNormalizedName { get; set; }
        // public string RegionName { get; protected set; }
        // public string RegionNormalizedName { get; set; }

        // public string Area { get; set; }
        // public string Type { get; set; }
        
        // public List<PhotoAnnouncement> Photos { get; protected set; }
        // public PriceDetailsAnnouncement PriceDetails {get; protected set; } 
        // public LandAnnouncement Land {get; protected set; }
    }
}