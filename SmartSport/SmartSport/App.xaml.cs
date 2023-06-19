using SmartSport.Models;
using SmartSport.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.GTKSpecific;
using Xamarin.Forms.Xaml;
using System.IO;

namespace SmartSport
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "trainings.db";
        public static TrainingsRepository database;
        public static TrainingsRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new TrainingsRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new Xamarin.Forms.NavigationPage(new CarouselViewPage());
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
