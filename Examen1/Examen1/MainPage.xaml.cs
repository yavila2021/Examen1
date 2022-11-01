using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Examen1;
using Examen1.Model;
using Java.Lang;

namespace Examen1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Btnsalvar_Clicked(object sender, EventArgs e)
        {

            var contac = new Model.Contactos

            {

                Nombre = txtnombre.Text,
                Telefono = int.Parse(txtTelefono.Text),
                Edad = int.Parse(txtedad.Text),
                Nota = txtNota.Text,

            };


            if (await App.dbcontac.SaveContacAsync(contac) > 0)

                txtnombre.Text = "";
            txtTelefono.Text = "";
            txtedad.Text = "";
            txtNota.Text = "";
            await DisplayAlert("Aviso", "Registro Ingresado con exito !!", "OK");

            

            /// esto muestra el listado
            ///   var contactoLis = await App.dbcontac.GetContactosAsync();
            ///   if (contactoLis!=null)
            ///{
            ///  lstContactos.ItemsSource = contactoLis;
            /// }
            ///var page = new View.Tcontactos();

            ///await Navigation.PushAsync(page);

        }

        public bool validarDatos()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtedad.Text))
            {
                respuesta = false;
            }
            if (string.IsNullOrEmpty(txtNota.Text))
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            return respuesta;
        }

        private async void btncontacto_Clicked(object sender, EventArgs e)
        {
            var Contac = new Model.Contactos
            {
                Nombre = txtnombre.Text,
                Telefono = Convert.ToInt32(txtTelefono.Text),
                Edad = Convert.ToInt32(txtedad.Text),
                Nota = txtNota.Text,

            };
            var page = new View.Page2();
            page.BindingContext = Contac;
            await Navigation.PushAsync(page);

        }


    }
}

