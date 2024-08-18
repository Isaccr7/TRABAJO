using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRABAJO.View.Cur_Stu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRABAJO.View.CursosI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VCPrincipal : ContentPage
	{
		public VCPrincipal ()
		{
			InitializeComponent ();
		}

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var frame = (Frame)sender;

            string cursoSeleccionado = "";

            if (frame == MatematicaFrame)
            {
                cursoSeleccionado = "MATEMÁTICA";
            }
            else if (frame == ComunicacionFrame)
            {
                cursoSeleccionado = "COMUNICACIÓN";
            }
            else if (frame == CytFrame)
            {
                cursoSeleccionado = "CIENCIA Y TECNOLOGIA";
            }
            else if (frame == EptFrame)
            {
                cursoSeleccionado = "EDUCACION PARA EL TRABAJO";
            }
            else if (frame == InglesFrame)
            {
                cursoSeleccionado = "INGLES";
            }
            else if (frame == ArteFrame)
            {
                cursoSeleccionado = "ARTE Y CULTURA";
            }

            if (!string.IsNullOrEmpty(cursoSeleccionado))
            {
                //await Navigation.PushAsync(new Curso(cursoSeleccionado));
                await Navigation.PushModalAsync(new VCSPrincipal(cursoSeleccionado));
            }
        }
    }
}