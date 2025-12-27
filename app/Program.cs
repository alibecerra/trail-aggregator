using System;
using System.Threading.Tasks;
using app.models; // Tells the program where your Models are
using app.services; // Tells the program where your WeatherService is
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace app // 1. The main "Room" for your application
{
    public class Program // 2. The class that contains your app logic
    {
        // 3. The "Main" method is the first thing the computer runs.
        // We use 'static async Task' so we can use 'await' for the internet calls.
        public static async Task Main(string[] args)
        {
            // 4. Setup the Host (This manages logging, configuration, and DI)
            var builder = Host.CreateApplicationBuilder(args);

            // 5. Register our Service
            // This tells the app: "If someone asks for a WeatherService,
            // build it and give it an HttpClient automatically."
            builder.Services.AddHttpClient<WeatherService>();

            using IHost host = builder.Build();

            // 6. Start the actual work
            await RunWeatherApp(host.Services);
        }

        // We create a separate method to keep 'Main' clean (Industry Best Practice)
        static async Task RunWeatherApp(IServiceProvider services)
        {
            // 7. Ask the system for our service
            var weatherService = services.GetRequiredService<WeatherService>();

            try
            {
                double lat = 34.1805;
                double lng = -117.325;

                Console.WriteLine("--- NOAA Weather Tool ---");
                Console.WriteLine($"Requesting data for: {lat}, {lng}");

                // 8. Call our logic!
                string forecast = await weatherService.GetForecastForLocationAsync(lat, lng);

                Console.WriteLine("\nReceived Forecast Data:");
                Console.WriteLine(forecast);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
