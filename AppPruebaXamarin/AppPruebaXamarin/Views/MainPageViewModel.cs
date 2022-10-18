using AppPruebaXamarin.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using static Xamarin.Essentials.Permissions;

namespace AppPruebaXamarin.Views
{
    public class MainPageViewModel
    {
        public ObservableCollection<PuntosdeVenta> Puntos { get; set; }
        public MainPageViewModel()
        {
            Puntos = new ObservableCollection<PuntosdeVenta> { 
                new PuntosdeVenta
                {
                    Nombre = "TOTTUS",
                    Codigo = "DSA234",
                    Direccion= "Calle Los Ruiseñores",
                    Image = "mapa.png"
                },

                new PuntosdeVenta
                {
                    Nombre = "NIKE",
                    Codigo = "DSAD43",
                    Direccion= "Av. Las Gardenias",
                    Image = "mapa.png"
                },

                new PuntosdeVenta
                {
                    Nombre = "PLAZA VEA",
                    Codigo = "DSA234",
                    Direccion= "Av. Angamos",
                    Image = "mapa.png"
                },
                
                new PuntosdeVenta
                {
                    Nombre = "WONG",
                    Codigo = "D323DS",
                    Direccion= "Av. Carlos Izaguirre",
                    Image = "mapa.png"
                },

                new PuntosdeVenta
                {
                    Nombre = "MOVISTAR",
                    Codigo = "DBB342",
                    Direccion= "Av. Lecaros",
                    Image = "mapa.png"
                },

                new PuntosdeVenta
                {
                    Nombre = "INKAFARMA",
                    Codigo = "GHF4F3",
                    Direccion= "Av. Jose Luis",
                    Image = "mapa.png"
                },
            };
        }
    }
}

