using Newtonsoft.Json.Linq;
using Resouces.ModelViews;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Resouces
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            WeatherViewModel weatherModel = new WeatherViewModel();

            BindingContext = weatherModel;
        }
    }
}
