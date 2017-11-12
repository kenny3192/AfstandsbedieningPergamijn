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
	public partial class Ziggo : ContentPage
	{
		public Ziggo ()
		{
			InitializeComponent ();
            //Ziggo hoofdmenu knop
            Button buttonZiggoBack = Content.FindByName<Button>("ZiggoBack");
            buttonZiggoBack.Clicked += Button_ClickedZiggoBack;
            //Ziggo tekst knop
            Button buttonZiggoText = Content.FindByName<Button>("ZiggoText");
            buttonZiggoText.Clicked += Button_ClickedZiggoText;
        }

        //Ziggo hoofdmenu knop
        private async void Button_ClickedZiggoBack(object sender, EventArgs e)
        {
            //Terug naar hoofdmenu
            await Navigation.PushModalAsync(new MainPage());
        }

        //Ziggo tekst knop
        private async void Button_ClickedZiggoText(object sender, EventArgs e)
        {
            //Pop-up ziggo pagina bereikt.
            await DisplayAlert("Ziggo", "Welkom op de ziggo pagina", "OK");
        }
    }
}