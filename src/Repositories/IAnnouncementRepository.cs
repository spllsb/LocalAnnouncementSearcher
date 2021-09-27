
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using src.Domain;

namespace src.Repositories
{
    public interface IAnnouncementRepository : IRepository
    {
        Task<Announcement> GetAsync(Guid id);
        Task<IEnumerable<Announcement>> GetAllAsync();
        Task AddAsync(Announcement announcement);
        Task RemoveAsync(Guid id);
    }
}