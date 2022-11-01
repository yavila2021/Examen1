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
    public partial class Tcontactos : ContentPage
    {
        public Tcontactos()
        {
            InitializeComponent();
        }

       

        private void listemple_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void toomap_Clicked(object sender, EventArgs e)
        {
await Navigation.PushAsync(new View.PageMap());
        }

       

        private void Eliminar_Clicked(object sender, EventArgs e)
        {

        }

        private async Task Actualizar_ClickedAsync(object sender, EventArgs e)
        {
            /// esto muestra el listado
            var contactoLis = await App.dbcontac.GetContactosAsync();
            if (contactoLis != null)
            {
                lstContactos.ItemsSource = contactoLis;
            }
            var page = new View.Tcontactos();
        }

        private void Modificar_Clicked(object sender, EventArgs e)
        {

        }

        private void Actualizar_Clicked(object sender, EventArgs e)
        {

        }
    }
}