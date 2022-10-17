using AppPruebaXamarin.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPruebaXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrar : ContentPage
    {
        public Registrar()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if(txtUsuario.Text==null && txtContraseña.Text==null && txtCorreo.Text==null && txtTelefono.Text==null){
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("INGRESE DATOS", "Campos Vacios", "Ok", "Cancel");
                });
            }
            else
            {
                var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDataBase.db");
                var db = new SQLiteConnection(dbpath);
                db.CreateTable<RegUsuario>();
                var item = new RegUsuario()
                {
                    usuario = txtUsuario.Text,
                    contraseña = txtContraseña.Text,
                    correo = txtCorreo.Text,
                    telefono = txtTelefono.Text
                };

                db.Insert(item);

                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("USUARIO REGISTRADO!!", "Desea Iniciar Sesion?", "Si", "No");
                    if (result)
                        await Navigation.PushAsync(new MainPage());
                });
            }
        }
    }
}