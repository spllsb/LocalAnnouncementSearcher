using HtmlAgilityPack;

namespace src.Extensions
{
    public static class HtmlExtensions
    {
        public static string getBodyFromHtmlDocument (HtmlDocument htmlDoc) => htmlDoc.DocumentNode.SelectSingleNode("//body").OuterHtml;
        public static string getHrefFromHtmlNode (HtmlNode htmlNode) => htmlNode.GetAttributeValue("href","Brak");
        
    }
}