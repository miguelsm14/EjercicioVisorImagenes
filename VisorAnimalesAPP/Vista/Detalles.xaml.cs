
namespace VisorAnimalesAPP.Vista;

public partial class Detalles : ContentPage
{
    public Detalles(Animales animal)
	{
        InitializeComponent();
        BindingContext = animal;
    }
}