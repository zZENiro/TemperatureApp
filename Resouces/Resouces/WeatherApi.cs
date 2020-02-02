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
            var locationRequest = GetLocation();
            locationRequest.Wait();
            var location = locationRequest.Result;

            using (var client = new HttpClient())
            {
                var requestMessage = client.GetAsync(($"https://samples.openweathermap.org/data/2.5/weather?lat={location.Latitude}&lon={location.Longitude}&appid=b6907d289e10d714a6e88b30761fae22"));

                requestMessage.Wait();

                var responseHttp = requestMessage.Result;

                if (responseHttp.IsSuccessStatusCode)
                    return new WeatherApiResponse() { Content = await responseHttp.Content.ReadAsStringAsync() };
                else
                    return new WeatherApiResponse() { ErrorMessage = responseHttp.ReasonPhrase };
            }
        } 

        private static async Task<Location> GetLocation()
        {
            return await Geolocation.GetLastKnownLocationAsync();
        }
    }
}
