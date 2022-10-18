using AppPruebaXamarin.Views;
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
	public partial class PuntosVenta : ContentPage
	{
		public PuntosVenta ()
		{
			InitializeComponent ();
			BindingContext = new MainPageViewModel ();
		}
	}
}