using System;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScraper
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add(
                "User-Agent",
                "Mozilla/5.0 (compatible; MyCSharpBot/1.0)"
            );

            string url = "http://quotes.toscrape.com/";

            Console.WriteLine("Starting scraper...");
            Console.WriteLine($"Fetching: {url}\n");

            try
            {
                string html = await client.GetStringAsync(url);

                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);

                var quotes = doc.DocumentNode.SelectNodes("//div[@class='quote']");

                if (quotes != null)
                {
                    Console.WriteLine($"Found {quotes.Count} quotes!\n");

                    int counter = 1;
                    foreach (var quote in quotes)
                    {
                        string text = quote.SelectSingleNode(".//span[@class='text']")?.InnerText;
                        string author = quote
                            .SelectSingleNode(".//small[@class='author']")
                            ?.InnerText;

                        Console.WriteLine($"Quote #{counter}:");
                        Console.WriteLine($"  Text: {text}");
                        Console.WriteLine($"  Author: {author}");
                        Console.WriteLine();

                        counter++;
                    }
                }
                else
                {
                    Console.WriteLine("No quotes found!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }

            Console.WriteLine("Scraping complete!");
        }
    }
}
