using Microsoft.Maui.Controls;

namespace Areatriangulo4030347
{
    public partial class ResultPage : ContentPage
    {
        public ResultPage(double area)
        {
            InitializeComponent();
            ResultLabel.Text = $"�rea del Tri�ngulo: {area:F2}";
        }
    }
}