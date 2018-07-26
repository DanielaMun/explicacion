using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace explicacionxamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Views : ContentPage
    {
        public Views()
        {

            InitializeComponent();
            

            dtpfecha.MininumDate = new DateTime(1970,1,23);
            dtpfecha.DateSelected += Dtpfecha_dateSelectd;

        }

        private void btnEnviarClicked(object sender, EventArgs args)
        {
            DisplayAlert("Ingreso", "Bienvenido a la aplicacion", "Aceptar");

        }


    }
}
