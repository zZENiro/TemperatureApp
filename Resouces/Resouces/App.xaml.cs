using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Resouces
{
    public partial class App : Application
    {
        public static List<int> Vs = new List<int>();

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            Vs.Add(1);
            Vs.Add(1);
            Vs.Add(1);
            Vs.Add(1);
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
