using Android.Content.PM;
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
    public partial class TrainingPage : ContentPage
    {
        public TrainingPage(Training training)
        {
            Training = training;
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = Training;
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
        public void StartTraining (object sender, EventArgs e)
        {
            VideoViewPage videoViewPage = new VideoViewPage(VideoItem.VideoSource);
            App.database.DeleteItem(Training.Id);
            Navigation.PopAsync();
            Navigation.PopAsync();
            Navigation.PushAsync(videoViewPage, true);
        }
    }
}