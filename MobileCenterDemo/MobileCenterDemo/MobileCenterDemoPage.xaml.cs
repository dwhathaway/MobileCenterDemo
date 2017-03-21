using Xamarin.Forms;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using System.Collections.Generic;

namespace MobileCenterDemo
{
	public partial class MobileCenterDemoPage : ContentPage
	{
		int numClicks = 0;

		public MobileCenterDemoPage()
		{
			InitializeComponent();

			Title = "Mobile Center Demo";

			myButton.Clicked += async (object sender, System.EventArgs e) =>
			{
				myLabel.Text = "Hello, Mobile Center!";
				numClicks++;

				Analytics.TrackEvent("Button clicked", new Dictionary<string, string> { { "Number of Clicks", numClicks.ToString() } });
			};
		}
	}
}
