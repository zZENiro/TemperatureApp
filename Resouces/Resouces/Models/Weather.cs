﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Resouces.Models
{

    public class Rootobject
    {
        public Coord coord { get; set; }
        public Weather[] weather { get; set; }
        public string _base { get; set; }
        public Main main { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

    public class Coord
    {
        public int lon { get; set; }
        public int lat { get; set; }
    }

    public class Main
    {
        public float temp { get; set; }             // Температура
        public float feels_like { get; set; }   
        public float temp_min { get; set; }         // Минимальная за сегодня
        public float temp_max { get; set; }         // Максимальная 
        public int pressure { get; set; }           // Давление
        public int humidity { get; set; }           // Влажность воздуха
    }

    public class Wind
    {
        public float speed { get; set; }
        public float deg { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public float message { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }                 
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

}