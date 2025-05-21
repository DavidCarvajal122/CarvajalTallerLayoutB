namespace CarvajalTallerLayoutB;

public partial class Stack : ContentPage
{
	public Stack()
	{
		InitializeComponent();
	}

    private void Hola_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Flex());
    }
}