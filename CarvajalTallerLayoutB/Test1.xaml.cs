namespace CarvajalTallerLayoutB;

public partial class Test1 : ContentPage
{
	public Test1()
	{
		InitializeComponent();
	}

    private void BtnCambiarPag_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}