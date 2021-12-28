using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    public static class Loader
    {
        private static readonly string url = "https://ru.wikipedia.org/wiki/Список_комнатных_растений";

        private static bool stop = false;

        public static event Action OnComplete;

        static Loader()
        {
            try
            {
                int a = 1;
            }
            catch (Exception)
            {
                int a = 0;
            }
        }

        public static void StartReading()
        {
            stop = false;
            GetPlantFromSite();
        }

        public static void StopReading()
        {
            stop = true;
        }

        public static void TruncateTable()
        {
            Database.TruncateTable();
            //Reload();
        }

        private static async void GetPlantFromSite()
        {
            await Task.Run(() =>
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                byte[] img = { };

                if (stop) return;                                                               //?

                var document = htmlWeb.Load(url);
                var htmlNodes = document.DocumentNode.SelectNodes("//td");

                for (int i = 0; i < 30*4; i += 4)
                {
                    var genus = $"{ htmlNodes[i].SelectSingleNode(".//center//a").InnerText.Trim() } ({ htmlNodes[i].SelectSingleNode(".//center//i").InnerText.Trim()})";             // РОД

                    string variety = String.Empty;
                    var varietyNodes = htmlNodes[i + 1].SelectSingleNode(".//center").ChildNodes;
                    foreach (var item in varietyNodes)
                    {
                        if (item.InnerText.Trim() != String.Empty)
                            variety += $"{item.InnerText}\n";                                               // ВИД
                    }

                    var imgUrl = "https:"+htmlNodes[i + 2].SelectSingleNode(".//a//img").Attributes["src"].Value;

                    if (imgUrl != null)
                    {
                        using (WebClient client = new WebClient())
                        {
                            img = client.DownloadData(imgUrl);                                              // ФОТО
                        }
                    }

                    var decorative_qualities = htmlNodes[i + 3].InnerText.Trim();                           // ДЕКОРАТИВНЫЕ КАЧЕСТВА

                    var plant = new Plant(genus, variety, img, decorative_qualities);

                    img = null;
                }

                if (stop) return;

                OnComplete?.Invoke();
            });
        }
    }
}
