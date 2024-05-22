using CommunityToolkit.Maui.Views;
using Plugin.Maui.Calendar.Models;
using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;
public partial class CoachDashboard : ContentPage
{
	//public EventCollection CoachEvents { get; set; }
	public CoachDashboard(CoachDashVM vm)
	{
		InitializeComponent();
		BindingContext = vm;

		//CoachEvents = new EventCollection
		//{
		//	[DateTime.Now] = new List<EventModel2>
		//	{
		//		new EventModel2{Name = "event1", Description = "This is event1's description"},
		//		new EventModel2{Name = "event2", Description = "This is event2's description"}
		//	},

		//	//5 Days from Today 
		//	[DateTime.Now.AddDays(5)] = new List<EventModel2> 
		//	{ 
		//	    new EventModel2{Name = "event3", Description = "This is event3's description"},
		//		new EventModel2{Name = "event4", Description = "This is event4's description"}
		//	},

		//	//3 Days ago
		//	[DateTime.Now.AddDays(-3)] = new List<EventModel2>
		//	{
		//		new EventModel2{Name = "event5", Description = "This is event5's description"}
		//	},

		//	//Custom Date
		//	[new DateTime(2020, 3, 16)] = new List<EventModel2>
		//	{
		//		new EventModel2{Name = "event6", Description = "This is event6's description"}
		//	}

		//};

		//BindingContext = this;
	}

    private void PopUpClicked(object sender, EventArgs e)
    {
        if (BindingContext is CoachDashVM viewModel)
        {
            viewModel.PopUpClicked(sender, e);
        }
    }




}