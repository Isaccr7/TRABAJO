using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRABAJO.View.Home;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRABAJO.View.inicio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VIFooter : ContentView
    {
        public VIFooter()
        {
            InitializeComponent();
        }

        private async void btn_ing_user_Clicked(object sender, EventArgs e)
        {
            string user = "73962153";
            string pass = "admin";

            string usuario_inge = dniEntry.Text;
            string passs_inge = contraseñaEntry.Text;

            if (user == usuario_inge && pass == passs_inge) {

                await Navigation.PushModalAsync(new VHPrincipal());
            }
            
            else
            {
                lblResult.Text = "DNI O CONTRASEÑA INCORRECTA";
            }




        }
    }
}