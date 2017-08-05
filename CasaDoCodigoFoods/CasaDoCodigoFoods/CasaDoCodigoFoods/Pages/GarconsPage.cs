using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CasaDoCodigoFoods.Pages
{
    public class GarconsPage : TabbedPage
    {
        public GarconsPage()
        {
            Children.Add(new GarconsListPage()
            {
                Title = "Listagem",
                Icon = "Icone_list.png"
            });
            Children.Add(new GarconsNewPage()
            {
                Title = "Inserir Novo",
                Icon = "Icone_new.png"
            });
        }
    }
}