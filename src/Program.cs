using System;
using System.Collections.Generic;
using HtmlAgilityPack;
using Newtonsoft.Json;
using src.Extensions;
using src.Services;
using src.Domain;
using Microsoft.Extensions.DependencyInjection;
using src.EF;
using Microsoft.EntityFrameworkCore;
using src.Domain.Json;
using System.Threading.Tasks;
using src.Repositories;

namespace src
{
    class Program
    {
        private const string connectionString = "Host=localhost;Port=5432;Database=DEV_DB;Username=postgres;Password=postgres";
        private const string uriMain = "https://www.olx.pl/nieruchomosci/dzialki/";

        public void ConfigureRepository(IServiceCollection services)
        {
            services.AddScoped<AnnouncementRepository>();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddEntityFrameworkNpgsql()
                    .AddDbContext<MyDbContext>(options => options
                        .UseNpgsql(connectionString)
                        .UseSnakeCaseNamingConvention());


            this.ConfigureRepository(services);
        }

        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<OlxHtmlAnnouncement>();
            services.AddSingleton<AnnouncementServices>();

            services.AddScoped<IAnnouncementRepository, AnnouncementRepository>();


            // Add framework services.
            services.AddEntityFrameworkNpgsql()
                    .AddDbContext<MyDbContext>(options => options
                        .UseNpgsql(connectionString)
                        .UseSnakeCaseNamingConvention());

            ServiceProvider serviceProvider = services.BuildServiceProvider();


            var _htmlAnnouncementServices = serviceProvider.GetService<OlxHtmlAnnouncement>();
            var _announcementServices = serviceProvider.GetService<AnnouncementServices>();
            

            IList<HtmlNode> articlesNode = new List<HtmlNode>();
            string announcementUri;
            HtmlDocument htmlAnnouncementDoc;
            string htmlBody;
            IList<Welcome> olxNewAnnouncementList = new List<Welcome>();
            Welcome olxJson;
            //Adres olx z filtrem na miejscowosc
           
            //Pobranie zawartosci str   ony internetowej
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(uriMain);


            //Pobranie ilosci stron wyszukiwania
            int paginationMax = _htmlAnnouncementServices.GetMaxPaginationFromHTML(htmlDoc);

            for (int i = 1; i <= 1; i++)
            {
                articlesNode = _htmlAnnouncementServices.GetAllAnnouncementFromPage(uriMain,i);

                foreach (var item in articlesNode)
                {
                    announcementUri = HtmlExtensions.getHrefFromHtmlNode(item);
                    htmlAnnouncementDoc = web.Load(announcementUri);
                    htmlBody = HtmlExtensions.getBodyFromHtmlDocument(htmlAnnouncementDoc); 
                    try
                    {
                        olxJson = JsonConvert.DeserializeObject<Welcome>(htmlBody.ParseOlxHtmlDocToJsonStringFormat());
                        if (_htmlAnnouncementServices.IsNew(olxJson.Ad.Ad.LastRefreshTime.LocalDateTime))
                        {
                            olxNewAnnouncementList.Add(olxJson);
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch 
                    {
                        
                    }
                }
            }

            foreach (var item in olxNewAnnouncementList)    
            {
                System.Console.WriteLine(item.Ad.Ad.Id);
                await _announcementServices.CreateAsync(item.Ad.Ad.Title, item.Ad.Ad.Description, item.Ad.Ad.LastRefreshTime.LocalDateTime);

                System.Console.WriteLine(item.Ad.Ad.Title);
                System.Console.WriteLine(item.Ad.Ad.LastRefreshTime.LocalDateTime);
                System.Console.WriteLine(item.Ad.Ad.Description);
            }

            // System.Console.WriteLine(olxJson.Ad.Ad.Id);
            // System.Console.WriteLine(olxJson.Ad.Ad.Title);
            
            // System.Console.WriteLine(olxJson.Ad.Ad.Description);
            // System.Console.WriteLine(olxJson.Ad.Ad.IsActive);
            // System.Console.WriteLine(olxJson.Ad.Ad.LastRefreshTime);

            // System.Console.WriteLine(olxJson.Ad.Ad.Price.RegularPrice.Value);

            // System.Console.WriteLine(olxJson.Ad.Ad.Photos.Count());
            
            // System.Console.WriteLine(olxJson.Ad.Ad.Location.CityName);
            // System.Console.WriteLine(olxJson.Ad.Ad.Location.RegionName);
            // System.Console.WriteLine(olxJson.Ad.Ad.Params.Count());
            // System.Console.WriteLine(olxJson.Ad.Ad.Params[1].Name);

            
        }
    }
}
