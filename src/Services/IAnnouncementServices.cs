using System;
using System.Threading.Tasks;

namespace src.Services
{
    public interface IAnnouncementServices : IService
    {
        Task CreateAsync(string title, string description, DateTime lastRefreshTime);

    }
}