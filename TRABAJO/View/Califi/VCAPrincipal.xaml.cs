using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRABAJO.View.Cur_Stu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRABAJO.View.Califi
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VCAPrincipal : ContentPage
	{

        public EstudianteModel Estudiante { get; set; }
        public Command BackCommand { get; }
        public VCAPrincipal (EstudianteModel estudiante)
		{
			InitializeComponent ();
            Estudiante = estudiante;
            BackCommand = new Command(async () => await Navigation.PopAsync());
            BindingContext = this;

            this.Title = $"Calificaciones de {Estudiante.Nombre}";
            if (Estudiante != null)
            {
                Console.WriteLine($"Estudiante recibido: {Estudiante.Nombre} (ID: {Estudiante.Id})");
                this.Title = $"Calificaciones de {Estudiante.Nombre}";
            }
            else
            {
                Console.WriteLine("No se ha recibido ningún estudiante.");
            }
        }
	}
}