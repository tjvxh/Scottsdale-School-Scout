namespace ScottsdaleSchoolScout
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void getStartedButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Quiz());
		}
	}
}