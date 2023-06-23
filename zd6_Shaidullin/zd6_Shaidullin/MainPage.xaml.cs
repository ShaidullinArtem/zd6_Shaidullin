using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zd6_Shaidullin
{
    public partial class MainPage : ContentPage
    {

        Tour tourCollectionSelectedItem;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            ShowTours();
        }

        private void onTourCollection_Selection(object sender, SelectionChangedEventArgs e)
        {
            tourCollectionSelectedItem = e.CurrentSelection.FirstOrDefault() as Tour;
        }

        private void ShowTours()
        {
            toursCollection.ItemsSource = App.TourDB.GetTours();
        }

        private async void onCreateBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateTour());
        }

        private async void onMoreInfoBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Info(tourCollectionSelectedItem));
        }

        private async void onGetTourBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetTour(tourCollectionSelectedItem, 1));
        }
    }
}
