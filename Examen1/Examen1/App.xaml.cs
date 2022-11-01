using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Examen1.Controller;
using System.IO;


namespace Examen1
{
    public partial class App : Application
    {

        static Controller.SQLiteHelper dBContac;

        public static Controller.SQLiteHelper dbcontac
        {
            get
            {
                if (dBContac == null)
                {
                    String DBName = "contac.db3";
                    String PathDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DBName);
                    dBContac = new Controller.SQLiteHelper(PathDB);
                }

                return dBContac;
            }

        }


        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            /// MainPage = new NavigationPage(new MainPage());

        }

       



        protected override void OnStart()
        {
        }

        

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
