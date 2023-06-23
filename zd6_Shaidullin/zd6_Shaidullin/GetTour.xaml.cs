using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd6_Shaidullin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GetTour : ContentPage
    {

        Tour Tour;
        double Days;

        public GetTour(Tour tour, double days)
        {
            InitializeComponent();

            this.Tour = tour;
            this.Days = days;

            tourTitle.Text = Tour.Title;
            tourPrice.Text = Convert.ToString(Tour.Price);
            tourDays.Text = Convert.ToString(Days);
            totalCostValue.Text = $"Total Cost: {Tour.Price * Days}";
        }

        private void personSliderValue_Changed(object sender, ValueChangedEventArgs e)
        {
            totalCostValue.Text = $"Total Cost: {Tour.Price * Days}";
        }

        private async void onBackToCatalogBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void onBackToTourInfoBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Info(Tour));

        }
    }
}