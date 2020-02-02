using Resouces.ModelViews;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Resouces
{
    public static class WeatherApi
    {
        public static async Task<WeatherApiResponse> Get(string authId = null)
        {
            var location = await GetLocation();

            using (var client = new HttpClient())
            {
                if (!string.IsNullOrEmpty(authId))
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Authorization", authId);

                var request = await client.GetAsync(($"https://samples.openweathermap.org/data/2.5/weather?lat={location.Latitude}&lon={location.Longitude}&appid=b6907d289e10d714a6e88b30761fae22"));
                if (request.IsSuccessStatusCode)
                    return new WeatherApiResponse() { Content = await request.Content.ReadAsStringAsync() };
                else
                    return new WeatherApiResponse() { ErrorMessage = request.ReasonPhrase };
            }
        } 

        private static async Task<Location> GetLocation()
        {
            return await Geolocation.GetLastKnownLocationAsync();
        }
    }
}
