using System;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var nombreApellidosLabel = new Label { Text = "Nombre y Apellidos:" };
            var nombreApellidosEntry = new Entry { Placeholder = "Ingrese su nombre y apellidos" };

            var fechaNacimientoLabel = new Label { Text = "Fecha de Nacimiento:" };
            var fechaNacimientoPicker = new DatePicker();

            var ocupacionLabel = new Label { Text = "Ocupación:" };
            var ocupacionEntry = new Entry { Placeholder = "Ingrese su ocupación" };

            var contactoLabel = new Label { Text = "Contacto (teléfono, email):" };
            var contactoEntry = new Entry { Placeholder = "Ingrese su contacto" };

            var nacionalidadLabel = new Label { Text = "Nacionalidad:" };
            var nacionalidadPicker = new Picker();
            nacionalidadPicker.Items.Add("Perú");
            nacionalidadPicker.Items.Add("Argentina");
            // Agrega el resto de los países

            var educacionLabel = new Label { Text = "Nivel de Educación:" };
            var educacionPicker = new Picker();
            educacionPicker.Items.Add("Educación Preescolar");
            educacionPicker.Items.Add("Educación Primaria");
            // Agrega el resto de las opciones

            var idiomasLabel = new Label { Text = "Idiomas:" };
            var inglesSwitch = new Switch { IsToggled = false };
            var indonesioSwitch = new Switch { IsToggled = false };
            // Agrega el resto de las opciones

            var lenguajesProgramacionLabel = new Label { Text = "Lenguajes de Programación:" };
            var lenguajesProgramacionPicker = new Picker();
            lenguajesProgramacionPicker.Items.Add("Java");
            lenguajesProgramacionPicker.Items.Add("Python");
            // Agrega el resto de las opciones

            var aptitudesLabel = new Label { Text = "Aptitudes:" };
            var aptitudesEntry = new Entry { Placeholder = "Ingrese sus aptitudes" };

            var habilidadesLabel = new Label { Text = "Habilidades:" };
            var liderazgoSwitch = new Switch { IsToggled = false };
            var programacionCppSwitch = new Switch { IsToggled = false };
            // Agrega el resto de las opciones

            var perfilLabel = new Label { Text = "Experiencia Laboral:" };
            var perfilEditor = new Editor { Placeholder = "Ingrese su experiencia laboral", HeightRequest = 100 };

            var enviarButton = new Button { Text = "Enviar" };
            enviarButton.Clicked += EnviarButton_Clicked;

            // Organizar la interfaz de usuario en un diseño
            var stackLayout = new StackLayout
            {
                Padding = new Thickness(20),
                Spacing = 10,
                Children =
                {
                    nombreApellidosLabel,
                    nombreApellidosEntry,
                    fechaNacimientoLabel,
                    fechaNacimientoPicker,
                    ocupacionLabel,
                    ocupacionEntry,
                    contactoLabel,
                    contactoEntry,
                    nacionalidadLabel,
                    nacionalidadPicker,
                    educacionLabel,
                    educacionPicker,
                    idiomasLabel,
                    inglesSwitch,
                    indonesioSwitch,
                    lenguajesProgramacionLabel,
                    lenguajesProgramacionPicker,
                    aptitudesLabel,
                    aptitudesEntry,
                    habilidadesLabel,
                    liderazgoSwitch,
                    programacionCppSwitch,
                    perfilLabel,
                    perfilEditor,
                    enviarButton
                }
            };

            // Establecer el diseño como contenido de la página
            Content = stackLayout;
        }

        private void EnviarButton_Clicked(object sender, EventArgs e)
        {
            // Implementa la lógica para procesar el formulario aquí
            // Puedes acceder a los valores de los controles (por ejemplo, nombreApellidosEntry.Text)
        }
    }
}
