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
	public partial class Afstandsbediening : ContentPage
	{
		public Afstandsbediening ()
		{
			InitializeComponent ();

            //Channel plus
            Button buttonPlus = Content.FindByName<Button>("Plus");
            buttonPlus.Clicked += Button_ClickedPlus;
            //Channel min
            Button buttonMin = Content.FindByName<Button>("Min");
            buttonMin.Clicked += Button_ClickedMin;
            //Volume up
            Button buttonVolUp = Content.FindByName<Button>("VolUp");
            buttonVolUp.Clicked += Button_ClickedVolUp;
            //Volume down
            Button buttonVolDwn = Content.FindByName<Button>("VolDwn");
            buttonVolDwn.Clicked += Button_ClickedVolDwn;
            //TV uit
            Button buttonTVPower = Content.FindByName<Button>("TVPower");
            buttonTVPower.Clicked += Button_ClickedTVPower;
            //Content pauzeer
            Button buttonPauzeer = Content.FindByName<Button>("Pauze");
            buttonPauzeer.Clicked += Button_ClickedPauzeer;
            //Hoofdmenu knop
            Button buttonVorige = Content.FindByName<Button>("Vorigeknop");
            buttonVorige.Clicked += Button_ClickedVorige;
            //TV gids knop
            Button buttonGids = Content.FindByName<Button>("Gids");
            buttonGids.Clicked += Button_ClickedGids;
        }

        //Vol up knop
        private async void Button_ClickedVolUp(object sender, EventArgs e)
        {
            //Bericht volume wordt harder gezet.
            await DisplayAlert("Volume", "Volume wordt harder gezet.", "OK");
        }

        //Vol down knop
        private async void Button_ClickedVolDwn(object sender, EventArgs e)
        {
            //Bericht volume wordt zachter gezet.
            await DisplayAlert("Volume", "Volume wordt zachter gezet.", "OK");
        }

        //TV gids knop
        private async void Button_ClickedGids(object sender, EventArgs e)
        {
            //Bericht tv gids wordt weergegeven.
            await DisplayAlert("Gids", "De gids wordt nu geopend.", "OK");
        }
        //Channel down knop
        private async void Button_ClickedMin(object sender, EventArgs e)
        {
            //Bericht vorig kanaal wordt weergegeven.
            await DisplayAlert("Kanaal", "Vorig kanaal wordt weergegeven.", "OK");
        }
        //Channel plus knop
        private async void Button_ClickedPlus(object sender, EventArgs e)
        {
            //Bericht volgend kanaal wordt weergegeven.
            await DisplayAlert("Kanaal", "Volgend kanaal wordt weergegeven.", "OK");
        }

        //TV power knop
        private async void Button_ClickedTVPower(object sender, EventArgs e)
        {
            //Bericht tv wordt uitgeschakeld.
            await DisplayAlert("TV", "TV wordt uitgeschakeld.", "OK");
        }
        //Pauzeer knop
        private async void Button_ClickedPauzeer(object sender, EventArgs e)
        {
            //Bericht content wordt gepauzeerd.
            await DisplayAlert("Pauzeer", "Content wordt gepauzeerd.", "OK");
        }
        //Hoofdmenu knop
        private async void Button_ClickedVorige(object sender, EventArgs e)
        {
            //Teruggaan naar hoofdmenu (mainpage)
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}