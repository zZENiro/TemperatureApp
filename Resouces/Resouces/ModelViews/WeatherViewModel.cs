using Newtonsoft.Json;
using Resouces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Resouces.ModelViews
{
    public class WeatherViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand UpdateData;

        public WeatherViewModel()
        {
            UpdateData = new Command(
                execute: () =>
                {
                    Task<WeatherApiResponse> response = WeatherApi.Get();

                    WeatherApiResponse resp = response.Result;

                    if (resp.Successful)
                    {
                        var WeatherInfo = JsonConvert.DeserializeObject<Weather>(resp.Content);
                        var MainInfo = JsonConvert.DeserializeObject<Main>(resp.Content);

                        WeatherName = WeatherInfo.main;
                        Temperature = MainInfo.temp;
                        MaxTemperature = MainInfo.temp_max;
                        MinTemperature = MainInfo.temp_min;

                    }
                },
                canExecute: () =>
                {
                    if (!IsExecuting)
                        return true;
                    else
                        return false;
                });

            // initial execute
            UpdateData.Execute(new object());
        }

        public string WeatherName
        {
            get { return _weatherType; }
            set
            {
                SetValue(ref _weatherType, value); 
            }
        }

        public float Temperature
        {
            get { return _temp; }
            set { SetValue(ref _temp, value); }
        }
        
        public float MaxTemperature
        {
            get { return _maxTemp; }
            set { SetValue(ref _maxTemp, value); }
        }
        
        public float MinTemperature
        {
            get { return _minTemp; }
            set { SetValue(ref _minTemp, value); }
        }
        
        public int Pressure
        {
            get { return _pressure; }
            set { SetValue(ref _pressure, value); }
        }
        
        public int Humidity
        {
            get { return _vlazhnost; }
            set { SetValue(ref _vlazhnost, value); }
        }

        private bool SetValue<T>(ref T target, T value, [CallerMemberName] string propName = null)
        {
            if (!object.Equals(target, value))
                return false;

            target = value;
            OnPropertyChanged(propName);
            return true;
        }

        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        bool IsExecuting = false;
        string _weatherType;
        float _temp;
        float _minTemp;
        float _maxTemp;
        int _pressure;
        int _vlazhnost;
    }
}
