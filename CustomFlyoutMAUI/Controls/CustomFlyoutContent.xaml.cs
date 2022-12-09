namespace CustomFlyoutMAUI.Controls;

public partial class CustomFlyoutContent : ContentView
{
	public CustomFlyoutContent()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.DisplayAlert("Menu item tapped", "This item was tapped from the custom flyout content", "Ok");
    }
}