using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Areatriangulo4030347.ViewModels
{
   
        public class MainViewModel : INotifyPropertyChanged
        {
            private string _result;
            public string Result
            {
                get { return _result; }
                set
                {
                    _result = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
                }
            }

            private string _side1;
            public string Side1
            {
                get { return _side1; }
                set
                {
                    _side1 = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Side1)));
                }
            }

            private string _side2;
            public string Side2
            {
                get { return _side2; }
                set
                {
                    _side2 = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Side2)));
                }
            }

            private string _side3;
            public string Side3
            {
                get { return _side3; }
                set
                {
                    _side3 = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Side3)));
                }
            }

            public ICommand CalculateAreaCommand => new Command(() =>
            {
                if (double.TryParse(Side1, out double a) && double.TryParse(Side2, out double b) && double.TryParse(Side3, out double c))
                {
                    double s = (a + b + c) / 2;
                    double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                    Result = $"Área: {area:F2}";
                    Application.Current.MainPage.Navigation.PushAsync(new ResultPage(area));
                }
                else
                {
                    Result = "Por favor, ingrese números válidos.";
                }
            });

            public event PropertyChangedEventHandler PropertyChanged;
        }
    
}
