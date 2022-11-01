using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

       

     

        private async Task Map_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.PageMap());
        }

      

        private void Map_Clicked(object sender, EventArgs e)
        {

        }

        private async Task Ver_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Tcontactos());
        }

        private void contactos_Clicked(object sender, EventArgs e)
        {

        }

        private void Ver_Clicked(object sender, EventArgs e)
        {

        }
    }
}