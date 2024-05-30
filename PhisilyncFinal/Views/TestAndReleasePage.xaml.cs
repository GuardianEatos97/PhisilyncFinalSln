using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using PhisilyncFinal.ViewModels;
using System.Collections.ObjectModel;


namespace PhisilyncFinal.Views;

public partial class TestAndReleasePage : ContentPage
{
    
    public ProviderInjury _injury;
    private LocalDb db;

    public ObservableCollection<TreatmentAction> injurieTest { get; set; }
    public ObservableCollection<TreatmentAction> injurieRelease { get; set; }
    
    public TestAndReleasePage(ProviderInjury injury)
	{
		 InitializeComponent();
       
        db = new ();
        BindingContext = this;
        OnPropertyChanged();


        injurieTest = new ObservableCollection<TreatmentAction>(db.GetTestTreatmentAction(injury.providerInjuryID));
       injurieRelease = new ObservableCollection<TreatmentAction>(db.GetReleaseTreatmentAction(injury.providerInjuryID));
    }
   

	
		


}