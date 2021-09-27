using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using src.Domain;
using src.EF;

namespace src.Repositories
{
    public class AnnouncementRepository : IAnnouncementRepository
    {
        private readonly MyDbContext _context;

        public AnnouncementRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Announcement>> GetAllAsync()
            => await _context.Announcements.ToListAsync();
        public async Task AddAsync(Announcement announcement)
        {
            await _context.Announcements.AddAsync(announcement);
            await _context.SaveChangesAsync();
        }
        public async Task RemoveAsync(Guid id)
        {
            var announcement = await GetAsync(id);
            _context.Announcements.Remove(announcement);
            await _context.SaveChangesAsync();
        }

        public async Task<Announcement> GetAsync(Guid id)
            => await _context.Announcements.SingleOrDefaultAsync(x => x.Id == id);
    }
}