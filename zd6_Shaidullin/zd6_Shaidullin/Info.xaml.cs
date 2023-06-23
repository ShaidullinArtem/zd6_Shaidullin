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
    public partial class Info : ContentPage
    {
        Tour Tour;
        double daysSliderValue;


        public Info(Tour tour)
        {
            InitializeComponent();

            this.Tour = tour;

            tourTitle.Text = Tour.Title;
            tourCountry.Text = Tour.Country;
            tourCatigory.Text = Tour.Catigory;
            tourPrice.Text = Convert.ToString(Tour.Price);
            tourTourOperator.Text = Tour.TourOperator;
            tourDays.Text = Convert.ToString(Tour.Days);
            tourDescription.Text = Tour.Description;

        }

        private void daysSliderValue_Changed(object sender, ValueChangedEventArgs e)
        {
            daysSliderValue = e.NewValue;
        }

        private async void onBackBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void onGetTourBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetTour(Tour, daysSliderValue));
        }
    }
}