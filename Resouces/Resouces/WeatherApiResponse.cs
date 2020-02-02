using System;
using System.Collections.Generic;
using System.Text;

namespace Resouces
{
    public class WeatherApiResponse
    {
        public bool Successful => Content != string.Empty;

        public string Content { get; set; }

        public string ErrorMessage { get; set; }
    }
}
