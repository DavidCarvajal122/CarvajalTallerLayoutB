﻿namespace CarvajalTallerLayoutB
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void IrATest1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Test1());
        }

        private void IrAGridLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridLayout());
        }

        private void IrAStack_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Stack());
        }
    }

}
