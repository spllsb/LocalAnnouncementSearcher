using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;
using Microsoft.Extensions.Logging;
using src.Domain.Enum;
using src.EF;
using src.Extensions;

namespace src.Services
{
    public class OlxHtmlAnnouncement : IHtmlAnnouncement
    {
        HtmlWeb web = new HtmlWeb();
        private readonly MyDbContext _dbContext;

        public OlxHtmlAnnouncement(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<HtmlNode> GetAllAnnouncementFromPage(string url, int page)
        {
                var htmlDoc = web.Load(url);
                string uriPage = $"url+/?page={page}";
                IList<HtmlNode> olxArticleNode = htmlDoc.QuerySelectorAll(".link .linkWithHash .detailsLink").Where(x => x.OuterHtml.Contains("www.olx.pl")).ToList();
                System.Console.WriteLine($"Ilość znalezionych artykółów na stronie {page} jest równa {olxArticleNode.Count}");
                return olxArticleNode;
        }

        public IList<HtmlNode> GetAnnouncements(string url)
        {
            var htmlDoc = web.Load(url);
            IList<HtmlNode> olxArticleNode = htmlDoc.QuerySelectorAll(".link .linkWithHash .detailsLink").Where(x => x.OuterHtml.Contains("www.olx.pl")).ToList();
            return olxArticleNode;
        }

        public int GetMaxPaginationFromHTML(HtmlDocument htmlDoc)
        {
            return OlxHtmlExtensions.getPaginationNumber(htmlDoc);
        }

        public bool IsNew (DateTime dateTime)
        {
            var configParamValue = _dbContext.Config.Where(x => x.Parameter.Equals(EnumConfig.last_announcement_datetime.ToString())).Single();
            return dateTime > DateTime.Parse(configParamValue.Value) ? true:false;
        }
    }
}