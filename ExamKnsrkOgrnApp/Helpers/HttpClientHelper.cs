using ExamKnsrkOgrnApp.Models;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExamKnsrkOgrnApp.Helpers
{
    public class HttpClientHelper
    {
        //  public static Uri endPointUri = new Uri(Config.AppSettings["NixxisUri"]);
        static readonly HttpClient client = new HttpClient();

        public static List<ArticlesViewModel> GetlastFiveArticles(string url)
        {
            HtmlWeb web = new HtmlWeb();

            HtmlDocument doc = web.Load(url);
            var document = doc.DocumentNode;
            var value = document.QuerySelectorAll("div.post-listing-component.post-listing-component--with-border > div > ul").ToArray();
            List<ArticlesViewModel> articles = new List<ArticlesViewModel>();
            foreach (var a in value[1].QuerySelectorAll("li>a"))
            {
                var heading = a.QuerySelector(".post-listing-list-item__title");
                string itemTitle = heading.InnerText;
                string itemUrl = a.Attributes["href"].Value;

                var content = GetItemContent("https://www.wired.com"+itemUrl);
                articles.Add(new ArticlesViewModel { Title = itemTitle, Content = content });
            }
            return articles;
        }

        private static string GetItemContent(string V)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(V);
            return doc.DocumentNode.QuerySelectorAll(".article__body").First().InnerText;
        }
    }
}
