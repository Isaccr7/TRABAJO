using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRABAJO.View.Califi;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRABAJO.View.Cur_Stu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]


	public partial class VCSPrincipal : ContentPage
	{

        public ObservableCollection<EstudianteModel> Estudiantes { get; set; }
        public VCSPrincipal (string nombreCurso)
		{
			InitializeComponent ();

			this.Title= nombreCurso;

            Estudiantes = new ObservableCollection<EstudianteModel>
            {
                new EstudianteModel { Id = 1, Nombre = "Pedro Pablo Huaman Meza", Foto = "https://definicion.de/wp-content/uploads/2019/07/perfil-de-usuario.png" },
                new EstudianteModel { Id = 2, Nombre = "Alejandro Morales Pérez", Foto = "https://definicion.de/wp-content/uploads/2019/07/perfil-de-usuario.png" },
                new EstudianteModel { Id = 3, Nombre = "Catalina Ruiz Gómez", Foto = "https://definicion.de/wp-content/uploads/2019/07/perfil-de-usuario.png" },
                new EstudianteModel { Id = 4, Nombre = "Javier González Martínez", Foto = "https://definicion.de/wp-content/uploads/2019/07/perfil-de-usuario.png" },
                new EstudianteModel { Id = 5, Nombre = "Isabella Fernández López", Foto = "https://definicion.de/wp-content/uploads/2019/07/perfil-de-usuario.png" },
                new EstudianteModel { Id = 6, Nombre = "Tomás Ortega Castillo", Foto = "https://definicion.de/wp-content/uploads/2019/07/perfil-de-usuario.png" }
            };

            CreateStudentGrid();
        }
        private void CreateStudentGrid()
        {
            int rowIndex = 0;

            EstudiantesGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

            
            foreach (var estudiante in Estudiantes)
            {
                EstudiantesGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                var studentFrame = new Frame
                {
                    CornerRadius = 20,
                    Padding = 10,
                    Margin = new Thickness(0, 0, 0, 10),
                    BackgroundColor = Color.FromHex("#5179ef"),
                    Content = new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                {
                    new Image
                    {
                        Source = estudiante.Foto,
                        WidthRequest = 50,
                        HeightRequest = 50,
                        Aspect = Aspect.Fill,
                        VerticalOptions = LayoutOptions.Center,
                        Margin = new Thickness(0, 0, 10, 0)
                    },
                    new Label
                    {
                        Text = estudiante.Nombre,
                        FontSize = 16,
                        VerticalOptions = LayoutOptions.Center
                    }
                }
                    }
                };

                studentFrame.GestureRecognizers.Add(new TapGestureRecognizer
                {
                    Command = new Command(() => OnEstudianteSelected(estudiante))
                });

              
                EstudiantesGrid.Children.Add(studentFrame, 0, rowIndex);
                rowIndex++;
            }
        }


        private async void OnEstudianteSelected(EstudianteModel estudiante)
        {
            Console.WriteLine($"Estudiante seleccionado: {estudiante.Nombre} (ID: {estudiante.Id})");
            await Navigation.PushModalAsync(new VCAPrincipal(estudiante));

        }
    }
    public class EstudianteModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
    }
}