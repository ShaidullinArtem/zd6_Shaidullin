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
    public partial class CreateTour : ContentPage
    {

        double daysSliderValue;

        public CreateTour()
        {
            InitializeComponent();
        }

        private void daysSliderValue_Changed(object sender, ValueChangedEventArgs e)
        {
            daysSliderValue = e.NewValue;
        }		

        private async void onBackBtn_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new MainPage());
        }

        private async void onCreateBtn_Clicked(object sender, EventArgs e) 
        {

            string title = titleField.Text.Trim();
            string country = countryField.Text.Trim();
            string catigory = catigoryField.Text.Trim();
            double price = double.Parse(priceField.Text.Trim());
            string tourOperator = tourOperatorField.Text.Trim();
            string description = descriptionField.Text.Trim();

            if (
                string.IsNullOrEmpty(title) ||
                string.IsNullOrEmpty(country) ||
                string.IsNullOrEmpty(catigory) ||
                string.IsNullOrEmpty(tourOperator) ||
                string.IsNullOrEmpty(description)
                ) 
            {
                await DisplayAlert("Error", "Enter All Data", "Ok");
                return;
            }

            if (price <= 0) { await DisplayAlert("Error", "Price must be positive number", "Ok"); return; }

            Tour tour = new Tour {
                Title = title,
                Country = country,
                Catigory = catigory,
                Price = price,
                TourOperator = tourOperator,
                Days = daysSliderValue,
                Description = description,
            };

            App.TourDB.SaveTour(tour);
            await DisplayAlert("Success", "New Tour has been added", "Ok");
            await Navigation.PushAsync(new MainPage());

        }
    }
}