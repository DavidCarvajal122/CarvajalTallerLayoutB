namespace CarvajalTallerLayoutB;

public partial class Flex : ContentPage
{
	public Flex()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsolutLayout());
    }
}