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
    public partial class AddTrainingPage : ContentPage
    {
        public AddTrainingPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            var training=(Training)BindingContext;

        }

        private void BurgerMenuCLicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NotificationButtonClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        async void CalendarButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calendar(), true);
        }

        private void SaveTraining(object sender, EventArgs e)
        {
            var training =(Training)BindingContext;
            if (training != null) { App.Database.SaveItem(training); }
            Navigation.PopAsync();
        }

        public void DateSelected (object sender, EventArgs e)
        {
            var training =(Training)BindingContext;
            training.StringDate =datePicker.Date.ToString("d");
            training.TrainingDateTime = DateTime.Parse(training.StringDate + " " + training.StringTime);
            training.NotificationText = "Ваша тренировка начнётся " + training.StringDate + " в " + training.StringTime;
        }
        
        public void TimeSelected (object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {
                var training = (Training)BindingContext;
                training.StringTime = timePicker.Time.ToString("hh\\:mm");
                training.TrainingDateTime = DateTime.Parse(training.StringDate + " " + training.StringTime);
                training.NotificationText = "Ваша тренировка начнётся " + training.StringDate + " в " + training.StringTime;
            }
        }
        public void TextChanged (object sender, EventArgs e)
        {
            var training=(Training)BindingContext;
            training.Note = editor.Text;
        }
    }
}