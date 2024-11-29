using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VisorAnimalesAPP.Vista;

public partial class AgregarAnimales : ContentPage
{
	public AgregarAnimales()
	{
        InitializeComponent();
    }

    [Obsolete]
    private async void OnGuardarClicked(object sender, EventArgs e)
    {
        var nuevoAnimal = new Animales
        {
            nombre = nombre.Text,
            imagen = imagen.Text,
            descripcion = descripcion.Text,
            fecha = fecha.Date.ToString("dd/MM/yyyy")
        };

        MessagingCenter.Send(this, "AgregarAnimal", nuevoAnimal);
        await Navigation.PopAsync();
    }
}