using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CasaDoCodigoFoods.Pages
{
    public class GarconsListPage : ContentPage
    {
        public GarconsListPage()
        {
            Content = GetGarcons();
        }

        private ListView GetGarcons()
        {
            var garcons = new ListView();
            garcons.ItemsSource = new string[]
            {
                "Brauzio", "Asdrugio", "Entencius", "Gesfredio", "Cartucious", "Gesfrundio", "Adoliterio", "Kentencio", "Castrogildo", "Gesifrelio"
            };

            return garcons;
        }
    }
}