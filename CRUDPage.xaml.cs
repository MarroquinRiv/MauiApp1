using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;
using MauiApp1.Carros;

namespace MauiApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CRUDPage : ContentPage
    {
        public CRUDPage()
        {
            InitializeComponent();
        }

        private void Crear_Clicked(object sender, System.EventArgs e)
        {
            CarrosDB crud = new CarrosDB();
            crud.insertarCarro();
        }

        private void Leer_Clicked(object sender, System.EventArgs e)
        {
            CarrosDB crud = new CarrosDB();
            crud.mostrarTodosLosCarros();
        }

        private void Actualizar_Clicked(object sender, System.EventArgs e)
        {
             CarrosDB crud = new CarrosDB();
             crud.asignarDuenio();
        }

        private void Eliminar_Clicked(object sender, System.EventArgs e)
        {
            CarrosDB crud = new CarrosDB();
            crud.eliminarCarro();
        }
    }
}
