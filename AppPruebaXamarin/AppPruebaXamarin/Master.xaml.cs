using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPruebaXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }
        private async void btnCerrar_Clicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Mensaje", "Estas Seguro de Cerrar Sesion?", "Si", "No");
                if (result)
                    await Navigation.PushAsync(new MainPage());
            });
        }

        private async void btnAcerca_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Acerca());
        }

        private async void btnPuntos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PuntosVenta());
        }
    }
}