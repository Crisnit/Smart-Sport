using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartSport.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calendar
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

        private void BurgerMenuCLicked(object sender, EventArgs e)
        {
            new MainPage();
        }

        private void NotificationButtonClicked(object sender, EventArgs e)
        {
            new MainPage();
        }
        
        public static DateTime DayOfCurrentMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

        private void ButtonRender(DateTime day, int column, int row)
        {
            if (day.Month != DayOfCurrentMonth.Month)
            {
                CalendarGrid.Children.Add(new Button { BackgroundColor = Color.White, WidthRequest = 40, HeightRequest = 40, Padding=9, CornerRadius = 1000, Text = day.ToString("dd.MM.yyyy"), TextColor =Color.FromHex("#9CBABB"), FontAttributes = FontAttributes.Bold, FontSize = 16}, column, row);
            }
            else if(day==DateTime.Today)
            {
                CalendarGrid.Children.Add(new Button { BackgroundColor = Color.FromHex("#9CBABB"), WidthRequest = 40, HeightRequest = 40, Padding = 9, CornerRadius = 1000, Text = day.ToString("dd.MM.yyyy"), TextColor = Color.White, FontAttributes = FontAttributes.Bold, FontSize = 16}, column, row);
            }
            else if ((int)day.DayOfWeek!=0 && (int)day.DayOfWeek!=6)
            {
                CalendarGrid.Children.Add(new Button { BackgroundColor = Color.White, WidthRequest = 40, HeightRequest = 40, Padding = 9, CornerRadius = 1000, Text = day.ToString("dd.MM.yyyy"), TextColor = Color.Black, FontAttributes = FontAttributes.Bold, FontSize = 16}, column, row);
            }
            else
            {
                CalendarGrid.Children.Add(new Button { BackgroundColor = Color.White, WidthRequest = 40, HeightRequest = 40, Padding = 9, CornerRadius = 1000, Text = day.ToString("dd.MM.yyyy"), TextColor = Color.FromHex("#D28EE4"), FontAttributes = FontAttributes.Bold , FontSize = 16}, column, row);
            }
        }

        private void CalendarRender(DateTime dayOfMonth)
        {
            DateTime dayOfPreviousMonth= dayOfMonth.AddDays(-1);
            if ((int)dayOfPreviousMonth.DayOfWeek!=0)
            {
                while((int)dayOfPreviousMonth.DayOfWeek>0)
                {
                    ButtonRender(dayOfPreviousMonth, (int)dayOfPreviousMonth.DayOfWeek-1, 0);
                    dayOfPreviousMonth = dayOfPreviousMonth.AddDays(-1);
                }
            }

            if ((int)dayOfMonth.DayOfWeek == 0)
            {
                ButtonRender(dayOfMonth, 6, 0);
                dayOfMonth = dayOfMonth.AddDays(1);
            }
            else
            {
                for (int dayOfFirstWeek = (int)dayOfMonth.DayOfWeek - 1; dayOfFirstWeek < 7; dayOfFirstWeek++)
                {
                    if ((int)dayOfMonth.DayOfWeek!=6 && (int)dayOfMonth.DayOfWeek!=0)
                    {
                        ButtonRender(dayOfMonth, dayOfFirstWeek, 0);
                        dayOfMonth = dayOfMonth.AddDays(1);
                    }
                    else
                    {
                        ButtonRender(dayOfMonth, dayOfFirstWeek, 0);
                        dayOfMonth = dayOfMonth.AddDays(1);
                    }
                }
            }
            for (int week = 1; week < 6; week++)
            {
                for (int day = 0; day < 7; day++)
                {
                    ButtonRender(dayOfMonth, day, week);
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

        private async void AddTrainingButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddTrainingPage(), true);
        }
    }
}