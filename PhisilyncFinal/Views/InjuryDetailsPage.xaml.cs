namespace PhisilyncFinal.Views;

public partial class InjuryDetailsPage : ContentPage
{
	public InjuryDetailsPage()
	{
		InitializeComponent();
	}

    private void GlossaryBtn_Clicked(object sender, EventArgs e)
    {
<<<<<<< HEAD

=======
		await Shell.Current.GoToAsync("GlossaryView");
>>>>>>> parent of d194181 (Glossary Navigation added)
    }
}