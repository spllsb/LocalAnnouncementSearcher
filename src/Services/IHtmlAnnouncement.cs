using System.Collections.Generic;
using HtmlAgilityPack;

namespace src.Services
{
    public interface IHtmlAnnouncement : IService
    {
        int GetMaxPaginationFromHTML(HtmlDocument htmlDoc);
        IList<HtmlNode> GetAllAnnouncementFromPage(string url, int page);
        IList<HtmlNode> GetAnnouncements(string url);
    }
}