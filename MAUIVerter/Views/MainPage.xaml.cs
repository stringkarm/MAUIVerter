using MAUIVerter.Views;

namespace MAUIVerter;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnInformationTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Information());
    }

    private async void OnVolumeTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Volume());
    }

    private async void OnLengthTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Length());
    }

    private async void OnMassTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Mass());
    }

    private async void OnTemperatureTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Temperature());
    }

    private async void OnEnergyTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Energy());
    }

    private async void OnAreaTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Area());
    }

    private async void OnSpeedTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Speed());
    }

    private async void OnDurationTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Duration());
    }
}
