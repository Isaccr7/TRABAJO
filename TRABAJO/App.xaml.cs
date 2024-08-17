using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TRABAJO.View.Home;
using TRABAJO.View.producto;
using TRABAJO.View.login;
using TRABAJO.View.inicio;

namespace TRABAJO
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new VLPrincipal();
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
