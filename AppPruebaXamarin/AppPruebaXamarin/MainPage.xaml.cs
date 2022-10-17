using AppPruebaXamarin.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPruebaXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registrar());
        }
        async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            if(txtUsuario.Text==null && txtContraseña.Text==null){
                    DisplayAlert("Ops..", "Usuario y Contraseña estan vacios", "Ok");
            }
            else
            {
                var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDataBase.db");
                var db = new SQLiteConnection(dbpath);
                var query = db.Table<RegUsuario>().Where(u => u.usuario.Equals(txtUsuario.Text) && u.contraseña.Equals(txtContraseña.Text)).FirstOrDefault();

                if (query != null)
                {
                    App.Current.MainPage = new NavigationPage(new Principal());
                }
                else
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        var result = await this.DisplayAlert("USUARIO NO REGISTRADO", "Desea Registar?", "Si", "No");

                        if (result)
                            await Navigation.PushAsync(new Registrar());
                    });
                }
            }
        }
    }
}
