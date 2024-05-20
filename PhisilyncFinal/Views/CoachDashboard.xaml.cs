using CommunityToolkit.Maui.Views;
using Plugin.Maui.Calendar.Models;

namespace PhisilyncFinal.Views;
public partial class CoachDashboard : ContentPage
{
	public EventCollection CoachEvents { get; set; }
	public CoachDashboard()
	{
		InitializeComponent();
		Routing.RegisterRoute("TreatmentPage", typeof(TreatmentPage));

		CoachEvents = new EventCollection
		{
			[DateTime.Now] = new List<EventModel2>
			{
				new EventModel2{Name = "event1", Description = "This is event1's description"},
				new EventModel2{Name = "event2", Description = "This is event2's description"}
			},

			//5 Days from Today 
			[DateTime.Now.AddDays(5)] = new List<EventModel2> 
			{ 
			    new EventModel2{Name = "event3", Description = "This is event3's description"},
				new EventModel2{Name = "event4", Description = "This is event4's description"}
			},

			//3 Days ago
			[DateTime.Now.AddDays(-3)] = new List<EventModel2>
			{
				new EventModel2{Name = "event5", Description = "This is event5's description"}
			},

			//Custom Date
			[new DateTime(2020, 3, 16)] = new List<EventModel2>
			{
				new EventModel2{Name = "event6", Description = "This is event6's description"}
			}

		};

		BindingContext = this;
	}

	internal class EventModel2
	{
		public string Name { get; set; }
		public string Description { get; set; }
	}

    private void PopUpClicked(object sender, EventArgs e)
    {
		this.ShowPopup(new TeamStatsPopUp());
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("TreatmentPage");
    }
}