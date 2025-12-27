// csusb 34.180579, -117.32535
//
using System.Net.Http.Json;
using app.models; // MUST be lowercase to match the model file exactly

namespace app.services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add(
                "User-Agent",
                "Weatherscrape (ali.becerra1224@gmail.com)"
            );
        }

        public async Task<string> GetForecastForLocationAsync(double lat, double lng)
        {
            // 1. Fetch the data
            var pointInfo = await _httpClient.GetFromJsonAsync<NoaaPointResponse>(
                $"https://api.weather.gov/points/{lat},{lng}"
            );

            // 2. Safely extract data (C# needs you to check for nulls)
            // If the internet fails, pointInfo might be null.
            if (pointInfo?.Properties?.RelativeLocation?.Data == null)
            {
                return "Error: Could not retrieve location metadata.";
            }

            string city = pointInfo.Properties.RelativeLocation.Data.City;
            string state = pointInfo.Properties.RelativeLocation.Data.State;

            Console.WriteLine($"Getting Weather for {city}, {state}...");

            string actualForecastUrl = pointInfo.Properties.ForecastUrl;

            // 3. Get the actual weather text
            var finalWeather = await _httpClient.GetStringAsync(actualForecastUrl);

            // IMPORTANT: You must return the string at the end!
            return finalWeather;
        }
    }
}
