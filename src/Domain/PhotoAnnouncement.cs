using System;

namespace src.Domain
{
    public class PhotoAnnouncement
    {
        public Guid Id { get; protected set; }
        public string PhotoUrl { get; protected set; }
    }
}