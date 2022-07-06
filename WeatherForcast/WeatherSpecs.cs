using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WeatherForcast
{
    public class WeatherSpecs
    {
        public static double GetTemp(string APICall)
        {
            var client = new HttpClient();

            var response = client.GetStringAsync(APICall).Result;
             
            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

            return temp;
        }
    }
}
