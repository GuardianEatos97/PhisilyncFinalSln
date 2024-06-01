using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using PhisilyncFinal.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;


namespace PhisilyncFinal.Views;

public partial class TestAndReleasePage : ContentPage
{
    
    //public ProviderInjury _injury;
    private LocalDb db;
    
    public TreatmentAction injurieTest { get; set; }
    public TreatmentAction TreatmentAction;

    
    public TreatmentAction injurieRelease { get; set ;}
    
    public TestAndReleasePage(ProviderInjury injury)
	{
		InitializeComponent();
        db = new ();
        injurieTest =  db.GetTestTreatmentAction(injury.providerInjuryID);
        injurieRelease =  db.GetReleaseTreatmentAction(injury.providerInjuryID);
        BindingContext = this;
        OnPropertyChanged();
        OnAppearing();


    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
       
    }

   
    
}