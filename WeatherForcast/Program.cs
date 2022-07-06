using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WeatherForcast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var weatherURL = "https://api.openweathermap.org/data/2.5/weather?lat=30.4383&lon=84.2807&appid=39626552851cd3ee9afbc77157d6b50e&units=imperial";

            var weather = client.GetStringAsync(weatherURL).Result;

            Console.WriteLine(weather);
        }
    }
}
