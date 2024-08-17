using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRABAJO.View.login;
using TRABAJO.View.producto;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRABAJO.View.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VHFooter : ContentView
    {
        public VHFooter()
        {
            InitializeComponent();
        }

        private async void btn_iniciar_session_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VLPrincipal());
        }
    }
}