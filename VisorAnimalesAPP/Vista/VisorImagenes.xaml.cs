namespace VisorAnimalesAPP.Vista;

public partial class VisorImagenes : ContentPage
{
	public VisorImagenes()
	{
		InitializeComponent();
        BindingContext = new AnimalesVM();
    }

    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Animales animalSelc)
        {
            await Navigation.PushAsync(new Detalles(animalSelc));
        }
    }

    private void OnAgregarClicked(object sender, EventArgs e)
    {

    }
}