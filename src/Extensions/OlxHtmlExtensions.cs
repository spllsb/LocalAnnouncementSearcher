using System.Collections.Generic;
using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;

namespace src.Extensions
{
    public static class OlxHtmlExtensions
    {
        public static int getPaginationNumber (HtmlDocument htmlDoc)
        {
            IList<HtmlNode> paginationNode = htmlDoc.QuerySelectorAll(".item .fleft");
            return int.Parse(paginationNode[paginationNode.Count-1].InnerText.Trim());
        }

        public static string getCreateAnnouncementTime (HtmlDocument htmlNode) => htmlNode.QuerySelector("span[data-cy='ad-posted-at']").InnerText;



    }
}