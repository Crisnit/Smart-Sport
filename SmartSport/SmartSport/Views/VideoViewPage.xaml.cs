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
    public partial class VideoViewPage : ContentPage
    {
        public VideoViewPage(string videoSource)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            videoView.Source = videoSource;
        }
    }
}