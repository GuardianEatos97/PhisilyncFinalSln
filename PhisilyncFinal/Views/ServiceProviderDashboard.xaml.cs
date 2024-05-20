using Microcharts;
using SkiaSharp;

namespace PhisilyncFinal.Views;

public partial class ServiceProviderDashboard : ContentPage
{
	ChartEntry[] entry = new[]
	{
		new ChartEntry(250)
		{
			Label = "New Clients",
			ValueLabel = "300",
			Color = SKColor.Parse("#2c3e50")
	    },

		new ChartEntry(100)
		{
			Label = "Existing Clients",
			ValueLabel = "120",
			Color = SKColor.Parse("#77d065")
		},

		new ChartEntry(50)
		{
			Label = "Clients Lost",
            ValueLabel = "50",
			Color = SKColor.Parse("#b455b6"),
		
		}
	};
	public ServiceProviderDashboard()
	{
		InitializeComponent();

        clientTracker.Chart = new DonutChart
		{
            Entries = entry
        };

		BindingContext = this;
	}

    internal class EventModel2
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}