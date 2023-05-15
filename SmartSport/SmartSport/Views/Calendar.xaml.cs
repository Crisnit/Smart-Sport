using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace SmartSport.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calendar : ContentPage
    {
        public Calendar()
        {
            InitializeComponent();
            CalendarRender(DayOfCurrentMonth);
            NavigationPage.SetHasNavigationBar(this, false);
        }       

        private void ButtonClicked(object sender, EventArgs e)
        {
            new MainPage();
        }
        public void BurgerMenuCLicked(object sender, EventArgs e)
        {
            new MainPage();
        }
        public void NotificationButtonClicked(object sender, EventArgs e)
        {
            new MainPage();
        }
        
        public static DateTime DayOfCurrentMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

        public void CalendarRender(DateTime dayOfMonth)
        {
            DateTime dayOfPreviousMonth= dayOfMonth.AddDays(-1);
            if ((int)dayOfPreviousMonth.DayOfWeek!=0)
            {
                while((int)dayOfPreviousMonth.DayOfWeek>0)
                {
                    CalendarGrid.Children.Add(new Xamarin.Forms.Button { BackgroundColor = Color.White, WidthRequest = 50, HeightRequest = 40, CornerRadius = 200, Text = dayOfPreviousMonth.Day.ToString(), TextColor =Color.FromHex("#9CBABB"), FontAttributes = FontAttributes.Bold, FontSize = 14}, (int)dayOfPreviousMonth.DayOfWeek-1, 0);
                    dayOfPreviousMonth = dayOfPreviousMonth.AddDays(-1);
                }
            }

            if ((int)dayOfMonth.DayOfWeek == 0)
            {
                CalendarGrid.Children.Add(new Xamarin.Forms.Button { BackgroundColor = Color.White, WidthRequest = 50, HeightRequest = 40, CornerRadius = 200, Text = dayOfMonth.Day.ToString(), TextColor = Color.Black, FontAttributes = FontAttributes.Bold, FontSize = 14 }, 6, 0);
                dayOfMonth = dayOfMonth.AddDays(1);
            }
            else
            {
                for (int dayOfFirstWeek = (int)dayOfMonth.DayOfWeek - 1; dayOfFirstWeek < 7; dayOfFirstWeek++)
                {
                    CalendarGrid.Children.Add(new Xamarin.Forms.Button { BackgroundColor = Color.White, WidthRequest = 50, HeightRequest = 40, CornerRadius = 200, Text = dayOfMonth.Day.ToString(), TextColor = Color.Black, FontAttributes = FontAttributes.Bold, FontSize = 14 }, dayOfFirstWeek, 0);
                    dayOfMonth = dayOfMonth.AddDays(1);
                }
            }
            for (int week = 1; week < 6; week++)
            {
                for (int day = 0; day < 7; day++)
                {
                    CalendarGrid.Children.Add(new Xamarin.Forms.Button { BackgroundColor = Color.White, WidthRequest = 50, HeightRequest = 40, CornerRadius = 200, Text = dayOfMonth.Day.ToString(), TextColor = Color.Black, FontAttributes = FontAttributes.Bold , FontSize = 14}, day, week);
                    dayOfMonth = dayOfMonth.AddDays(1);
                }
            }
        }

        private void RightButtonCLicked(object sender, EventArgs e)
        {
            DayOfCurrentMonth = DayOfCurrentMonth.AddMonths(1);
            CalendarGrid.Resources.Clear();
            CalendarRender(DayOfCurrentMonth);
        }

        private void LeftButtonClicked(object sender, EventArgs e)
        {
            DayOfCurrentMonth = DayOfCurrentMonth.AddMonths(-1);
            CalendarGrid.Resources.Clear();
            CalendarRender(DayOfCurrentMonth);
        }
    }
}