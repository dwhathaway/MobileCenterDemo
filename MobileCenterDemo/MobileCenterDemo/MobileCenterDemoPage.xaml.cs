using Xamarin.Forms;

namespace MobileCenterDemo
{
	public partial class MobileCenterDemoPage : ContentPage
	{
		public MobileCenterDemoPage()
		{
			InitializeComponent();

			myButton.Clicked += async (object sender, System.EventArgs e) =>
			{
				myLabel.Text = "Hello, Mobile Center!";
			};
		}
	}
}
