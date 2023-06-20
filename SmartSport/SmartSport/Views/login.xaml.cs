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
	public partial class login : ContentPage
	{
		public login ()
		{
			InitializeComponent ();
		}
        private async void Entering(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calendar(), true);
        }
        private async void Reging(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registering(), true);
        }
    }

}