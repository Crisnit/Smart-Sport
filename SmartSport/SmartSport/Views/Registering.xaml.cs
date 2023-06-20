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
	public partial class Registering : ContentPage
	{
		public Registering ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private async void Next(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calendar(), true);
        }
    }
}