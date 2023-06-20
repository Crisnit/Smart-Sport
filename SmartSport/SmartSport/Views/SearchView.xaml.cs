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
    public partial class SearchView : ContentPage
    {
        public SearchView(Training training) 
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            videoItemsList.BindingContext = new VideoItems().ItemsList;
            videoItemsList.ItemsSource = new VideoItems().ItemsList;
            Training=training;
        }
        public SearchView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            videoItemsList.BindingContext = new VideoItems().ItemsList;
            videoItemsList.ItemsSource = new VideoItems().ItemsList;
            Training=new Training();

        }
        
        public List<VideoItem> videoList=new VideoItems().ItemsList;

        public Training Training{ get; set; }

        public void VideoSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var video = (VideoItem)e.SelectedItem;
            Training.VideoId = video.Id;
            Navigation.PushAsync(new AddTrainingPage(Training),true);
        }

        private async void AddTrainingButton(object sender, EventArgs e)
        {
            Training training = new Training();
            AddTrainingPage addTrainingPage = new AddTrainingPage();
            addTrainingPage.BindingContext = training;
            await Navigation.PushAsync(addTrainingPage, true);
        }
        private async void CalendarButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calendar(), true);
        }
        public void SearchClicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(entry.Text))
            {
                videoItemsList.ItemsSource = videoList.Where(X => X.Name.Contains(entry.Text));
                videoItemsList.IsVisible = true;
            }
        }
        private void NotificationButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TrainingsListPage());
        }

    }
}