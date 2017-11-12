using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week5Vrijdag
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Youtube : ContentPage
	{
		public Youtube ()
		{
			InitializeComponent ();
            //Youtube homemenu knop
            Button buttonYoutubeBack = Content.FindByName<Button>("YoutubeBack");
            buttonYoutubeBack.Clicked += Button_ClickedYoutubeBack;
            //YouTube display tekst
            Button buttonYoutubeText = Content.FindByName<Button>("YoutubeText");
            buttonYoutubeText.Clicked += Button_ClickedYoutubeText;
        }
        //Terug naar hoofdmenu
        private async void Button_ClickedYoutubeBack(object sender, EventArgs e)
        {
            //Open hoofdmenu
            await Navigation.PushModalAsync(new MainPage());
        }
        //Open YouTube text
        private async void Button_ClickedYoutubeText(object sender, EventArgs e)
        {
            //Pop-up YouTube pagina bereikt.
            await DisplayAlert("Youtube", "Welkom op de youtube pagina", "OK");
        }
    }
}