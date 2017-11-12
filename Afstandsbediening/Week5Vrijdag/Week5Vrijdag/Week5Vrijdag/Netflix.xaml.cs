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
    public partial class Netflix : ContentPage
    {
        private object buttonNetflixBack;

        public Netflix()
        {
            InitializeComponent();
            //Netflix hoofdmenu knop
            Button buttonNetflixBack = Content.FindByName<Button>("NetflixBack");
            buttonNetflixBack.Clicked += Button_ClickedNetflixBack;
            //Netflix tekst 
            Button buttonNetflixText = Content.FindByName<Button>("NetflixText");
            buttonNetflixText.Clicked += Button_ClickedNetflixText;
        }
        //Knop hoofdmenu netflix
        private async void Button_ClickedNetflixBack(object sender, EventArgs e)
        {
            //Open hoofdmenu
            await Navigation.PushModalAsync(new MainPage());
        }

        //Knop netflix tekst
        private async void Button_ClickedNetflixText(object sender, EventArgs e)
        {
            // Pop-up netflix pagina bereikt.
                await DisplayAlert("Netflix", "Welkom op de netflix pagina", "OK");
        }
    } 
}