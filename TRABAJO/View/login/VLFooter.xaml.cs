using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRABAJO.View.inicio;
using TRABAJO.View.producto;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRABAJO.View.login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VLFooter : ContentView
    {
        public VLFooter()
        {
            InitializeComponent();
        }

        private async void btn_ingresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VIPrincipal());
        }
    }
}