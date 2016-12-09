using Xamarin.Forms;

namespace MobileCenterDemo
{
	public partial class MobileCenterDemoPage : ContentPage
	{
		public MobileCenterDemoPage()
		{
			InitializeComponent();

			Title = "Mobile Center Demo";

			myButton.Clicked += async (object sender, System.EventArgs e) =>
			{
				myLabel.Text = "Hello, Mobile Center!";
			};
		}
	}
}
