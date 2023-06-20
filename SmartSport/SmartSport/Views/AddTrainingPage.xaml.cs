using SmartSport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.Provider.MediaStore;

namespace SmartSport.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTrainingPage : ContentPage
    {
        public AddTrainingPage(Training training)
        { 
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Training=training;
            var videoDictionary = new VideoItems().ItemsDictionary;
            if (Training.VideoId != 0)
            {
                VideoItem = videoDictionary[Training.VideoId];
                Video.ImageSource = VideoItem.PreviewSource;
                Video.Text = VideoItem.Name;
            }
        }
        public AddTrainingPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Training=(Training)BindingContext;
            var videoDictionary = new VideoItems().ItemsDictionary;
            if (Training.VideoId != 0)
            {
                VideoItem = videoDictionary[Training.VideoId];
                Video.ImageSource = VideoItem.PreviewSource;
                Video.Text = VideoItem.Name;
            }
        }
        public VideoItem VideoItem { get; set; }
        public Training Training { get; set; }
        private void BurgerMenuCLicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NotificationButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TrainingsListPage());
        }

        async void CalendarButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calendar(), true);
        }

        private void SaveTraining(object sender, EventArgs e)
        {
            if (Training != null) { App.Database.SaveItem(Training); }
            Navigation.PopAsync();
        }

        public void DateSelected (object sender, EventArgs e)
        {
            Training.StringDate =datePicker.Date.ToString("d");
            Training.TrainingDateTime = DateTime.Parse(Training.StringDate + " " + Training.StringTime);
            Training.NotificationText = "Ваша тренировка начнётся " + Training.StringDate + " в " + Training.StringTime;
        }
        
        public void TimeSelected (object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {
                Training.StringTime = timePicker.Time.ToString("hh\\:mm");
                Training.TrainingDateTime = DateTime.Parse(Training.StringDate + " " + Training.StringTime);
                Training.NotificationText = "Ваша тренировка начнётся " + Training.StringDate + " в " + Training.StringTime;
            }
        }
        public void TextChanged (object sender, EventArgs e)
        {
            Training.Note = editor.Text;
        }
        public void SearchButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SearchView(Training), true);
        }
    }
}