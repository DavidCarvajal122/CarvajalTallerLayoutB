namespace CarvajalTallerLayoutB;

public partial class AbsolutLayout : ContentPage
{
	public AbsolutLayout()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GridLayout());
    }
}