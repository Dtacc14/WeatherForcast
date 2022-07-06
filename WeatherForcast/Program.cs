using System;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WeatherForcast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");           
            string APIkey = JObject.Parse(key).GetValue("APIkey").ToString();

            Console.WriteLine("Please enter Zipcode: ");
            var zipCode = Console.ReadLine();

            var APICall = $"http://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIkey}";

            Console.WriteLine();

            Console.WriteLine($"It is currently {WeatherSpecs.GetTemp(APICall)} degrees f in your location.");
        }
    }
}
