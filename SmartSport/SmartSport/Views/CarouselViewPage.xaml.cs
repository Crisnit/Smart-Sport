using SmartSport.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartSport
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarouselViewPage : ContentPage
	{
		ObservableCollection<Carouselitems> descriptions;


        public CarouselViewPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            descriptions = new ObservableCollection<Carouselitems>
			{
				new Carouselitems {Description = "Добро пожаловать в наше приложение SMART SPORT! " },
				new Carouselitems {Description = "Сегодня у вас есть уникальная возможность начать новый путь в своей жизни - заняться спортом и стать лучшей версией себя. Наше приложение - ваш надежный помощник на этом сложном пути." },
				new Carouselitems {Description = "В нашем приложении вы найдете календарь тренировок, который поможет вам всегда быть в курсе, какие тренировки нужно выполнять на текущей неделе. Также у нас есть большая база видео тренировок, с которыми вы можете заниматься в любое удобное время. Мы сделали все возможное, чтобы они были максимально полезны и эффективны, так что просто выбирайте нужную категорию и начинайте тренироваться. " },
                new Carouselitems {Description = "Ну что же, начните свой новый путь вместе с нашим приложением о спорте!" }

            };
            MyCarousel.ItemsSource = descriptions;
        }
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new login(), true);
        }
    }


}