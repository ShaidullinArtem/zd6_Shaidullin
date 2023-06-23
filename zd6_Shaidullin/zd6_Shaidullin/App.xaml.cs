using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace zd6_Shaidullin
{
    public partial class App : Application
    {

        private static TourDB tourDB;

        public static TourDB TourDB
        {
            get
            {
                if (tourDB == null) tourDB = new TourDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "db.sqlite3"));
                return tourDB;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
