using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week5Vrijdag
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Knop netflix
            Button buttonNetflix = Content.FindByName<Button>("NetflixButton");
            buttonNetflix.Clicked += Button_ClickedNetflix;
            // Knop Youtube
            Button buttonYoutube = Content.FindByName<Button>("YoutubeButton");
            buttonYoutube.Clicked += Button_ClickedYoutube;
            // Knop Ziggo
            Button buttonZiggo = Content.FindByName<Button>("ZiggoButton");
            buttonZiggo.Clicked += Button_ClickedZiggo;
            // Knop RandomSerie
            Button buttonRandomSerie = Content.FindByName<Button>("RandomSerie");
            buttonRandomSerie.Clicked += Button_ClickedRandomSerie;
            // Zoekbalk 
            SearchBar zoekBalk = Content.FindByName<SearchBar>("Zoekbalk");
            zoekBalk.SearchButtonPressed += ZoekBalk_SearchButtonPressed;


        }

        // Zoekbalk
        private async void ZoekBalk_SearchButtonPressed(object sender, EventArgs e)
        {
            // Pop-up zoekbalk geslaagd
            await DisplayAlert("Zoeken", "De gezochten content wordt weergegeven.", "OK");
        }

        // Netflix knop
        private async void Button_ClickedNetflix(object sender, EventArgs e)
        {
            // Pop-up vraag TV of Tablet
            var answer = await DisplayAlert("Keuzemenu", "Wilt u kijken op de TV of op de tablet?", "TV", "Tablet");
            // Antwoord = TV
            if (answer)
            {
                await Navigation.PushModalAsync(new Afstandsbediening());
            }

            // Antwoord = Tablet
            else
            {
                await Navigation.PushModalAsync(new Netflix());
            }

        }
        // YouTube knop
        private async void Button_ClickedYoutube(object sneder, EventArgs e)
        {
            // Pop-up vraag TV of Tablet
            var answer = await DisplayAlert("Keuzemenu", "Wilt u kijken op de TV of op de tablet?", "TV", "Tablet");
            // Antwoord = TV
            if (answer)
            {
                await Navigation.PushModalAsync(new Afstandsbediening());
            }
            // Antwoord = Tablet
            else
            {
                await Navigation.PushModalAsync(new Youtube());
            }
        }
        // Ziggo Knop
        private async void Button_ClickedZiggo(object sneder, EventArgs e)
        {
            // Pop-up vraag TV of Tablet
            var answer = await DisplayAlert("Keuzemenu", "Wilt u kijken op de TV of op de tablet?", "TV", "Tablet");
            // Antwoord = TV
            if (answer)
            {
                await Navigation.PushModalAsync(new Afstandsbediening());
            }
            // Antwoord = Tablet
            else
            {
                await Navigation.PushModalAsync(new Ziggo());
            }

        }

        // Willekeurige serie knop
        private async void Button_ClickedRandomSerie(object sneder, EventArgs e)
        {
            // Pop-up vraag TV of Tablet
            var answer = await DisplayAlert("Keuzemenu", "Wilt u kijken op de TV of op de tablet?", "TV", "Tablet");
            // Antwoord = TV
            if (answer)
            {
                await Navigation.PushModalAsync(new Afstandsbediening());
            }
            // Antwoord = Tablet
            else
            {
                await DisplayAlert("Serie", "Een serie gebaseerd op je interesses wordt nu gestart", "OK");
            }
        }
    }
}
