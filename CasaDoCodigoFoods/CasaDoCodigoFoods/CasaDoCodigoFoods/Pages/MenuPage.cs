using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CasaDoCodigoFoods.Pages
{
    public class MenuPage : ContentPage
    {
        public MenuPage()
        {
            Title = "Menu de Opções";

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Button()
                    {
                        Text = "Garçons",
                        Image = "icone_garcons.png",
                        Command = new Command(() => new NavigationPage(new GarconsPage()))
                    }
                }
            };
        }
    }
}