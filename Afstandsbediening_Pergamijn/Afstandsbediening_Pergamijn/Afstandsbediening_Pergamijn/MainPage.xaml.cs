using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Afstandsbediening_Pergamijn
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            Button buttonNetflix = Content.FindByName<Button>("NetflixButton");

            buttonNetflix.Clicked += Button_ClickedNetflix;

            Button buttonYoutube = Content.FindByName<Button>("YoutubeButton");

            buttonYoutube.Clicked += Button_ClickedYoutube;
        }

        private async void Button_ClickedNetflix(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
	}

