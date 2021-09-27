using System;
using System.Threading.Tasks;
using src.Domain;
using src.Repositories;

namespace src.Services
{
    public class AnnouncementServices : IAnnouncementServices
    {
        private IAnnouncementRepository _announcementRepository;

        public AnnouncementServices(IAnnouncementRepository announcementRepository)
        {
            _announcementRepository = announcementRepository;
        }

        public async Task CreateAsync(string title, string description, DateTime lastRefreshTime) 
            => await _announcementRepository.AddAsync(Announcement.Create(title, description, lastRefreshTime));
    }
}