using SmartSport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartSport.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrainingsListPage : ContentPage
    {
        public TrainingsListPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            trainingsList.ItemsSource = App.Database.GetItems().OrderBy(x=>x.TrainingDateTime);
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var training=(Training)e.SelectedItem;
            TrainingPage selectedTraining =new TrainingPage();
            selectedTraining.BindingContext = training;
            Navigation.PushAsync(selectedTraining, true);

        }
    }
}