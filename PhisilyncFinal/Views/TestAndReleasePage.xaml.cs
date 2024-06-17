using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using PhisilyncFinal.ViewModels;
using Plugin.Maui.Calendar.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;


namespace PhisilyncFinal.Views;

public partial class TestAndReleasePage : ContentPage
{
    
    //public ProviderInjury _injury;
    private LocalDb db;
    public TreatmentAction TreatmentAction;
    public ProviderInjury _injury { get; set; }
    public TreatmentAction injurieTest { get; set; }
    public TreatmentAction injurieRelease { get; set; }
    public Treatment treatment { get; set; }
    
    public EventCollection _event;
    public EventCollection Events { get { return _event; } set { _event = value; OnPropertyChanged(); } }

    
    public TestAndReleasePage(ProviderInjury injury)
	{
		InitializeComponent();
        db = new ();
        injurieTest =  db.GetTestTreatmentAction(injury.providerInjuryID);
        injurieRelease =  db.GetReleaseTreatmentAction(injury.providerInjuryID);
        treatment = db.GetTreatment(injury.providerInjuryID);
        BindingContext = this;
        OnPropertyChanged();
        OnAppearing();


    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
       
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (treatment.treatmentTreatmentFrequency == 1)
        {
            DailyTreatment();
            await DisplayAlert("Success", "Treatment Has Been Added To Your Dashboard", "OK");


        }
        else if (treatment.treatmentTreatmentFrequency == 2)
        {
            WeeklyTreatment();
            await DisplayAlert("Success", "Treatment Has Been Added To Your Dashboard", "OK");

        }
        else
        {
            MonthlyTreatment();
            await DisplayAlert("Success", "Treatment Has Been Added To Your Dashboard", "OK");

        }
        await Shell.Current.GoToAsync("//athleteDash");

    }

    public void DailyTreatment()
    {

        for (int i = 0; i < 8; i++)
        {
            db.SaveEvent(new Event
            {
                Name = injurieTest.treatmentActionName,
                Description = injurieTest.treatmentActionStepAction,
                TreatmentID = injurieTest.treatmentActionTreatment,
                EventDate = DateTime.Now.AddDays(i),
                Category = "Test",
                Frequency = 1,
                UserID = 1
            });
            db.SaveEvent(new Event
            {
                Name = injurieRelease.treatmentActionName,
                Description = injurieRelease.treatmentActionStepAction,
                TreatmentID = injurieRelease.treatmentActionTreatment,
                EventDate = DateTime.Now.AddDays(i),
                Category = "Release",
                UserID = 1,
                Frequency = 1
            });
        }


    }

    public void WeeklyTreatment()
    {
        for (int i = 0; i < 22; i += 7)
        {
            db.SaveEvent(new Event
            {
                Name = injurieTest.treatmentActionName,
                Description = injurieTest.treatmentActionStepAction,
                TreatmentID = injurieTest.treatmentActionTreatment,
                EventDate = DateTime.Now.AddDays(i),
                UserID = 1,
                Category = "Test",
                Frequency = 2
            });
            db.SaveEvent(new Event
            {
                Name = injurieRelease.treatmentActionName,
                Description = injurieRelease.treatmentActionStepAction,
                TreatmentID = injurieRelease.treatmentActionTreatment,
                EventDate = DateTime.Now.AddDays(i),
                Category = "Release",
                UserID = 1,
                Frequency = 2
            });
        }






    }
    public void MonthlyTreatment()
    {
        for (int i = 0; i < 31; i += 30)
        {
            db.SaveEvent(new Event
            {
                Name = injurieTest.treatmentActionName,
                Description = injurieTest.treatmentActionStepAction,
                TreatmentID = injurieTest.treatmentActionTreatment,
                EventDate = DateTime.Now.AddDays(i),
                Category = "Test",
                UserID = 1,
                Frequency = 3
            });
            db.SaveEvent(new Event
            {
                Name = injurieRelease.treatmentActionName,
                Description = injurieRelease.treatmentActionStepAction,
                TreatmentID = injurieRelease.treatmentActionTreatment,
                EventDate = DateTime.Now.AddDays(i),
                Category = "Release",
                UserID = 1,
                Frequency = 3
            });
        }


    }
}