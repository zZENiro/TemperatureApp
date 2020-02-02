using System;
using System.Collections.Generic;
using System.Text;

namespace Resouces.Models
{

    public class RootobjectForecast
    {
        public string cod { get; set; }
        public int message { get; set; }
        public City city { get; set; }
        public int cnt { get; set; }
        public List[] list { get; set; }
    }

    public class City
    {
        public int geoname_id { get; set; }
        public string name { get; set; }
        public float lat { get; set; }
        public float lon { get; set; }
        public string country { get; set; }
        public string iso2 { get; set; }
        public string type { get; set; }
        public int population { get; set; }
    }

    public class List
    {
        public int dt { get; set; }
        public Temp temp { get; set; }
        public float pressure { get; set; }
        public int humidity { get; set; }
        public Weather[] weather { get; set; }
        public float speed { get; set; }
        public int deg { get; set; }
        public int clouds { get; set; }
        public float rain { get; set; }
        public float snow { get; set; }
    }

    public class Temp
    {
        public float day { get; set; }
        public float min { get; set; }
        public float max { get; set; }
        public float night { get; set; }
        public float eve { get; set; }
        public float morn { get; set; }
    }

}
