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
        await Navigation.PushAsync(new ConverterPage("Information", "information"));
    }

    private async void OnVolumeTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConverterPage("Volume", "volume"));
    }

    private async void OnLengthTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConverterPage("Length", "length"));
    }

    private async void OnMassTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConverterPage("Mass", "mass"));
    }

    private async void OnTemperatureTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConverterPage("Temperature", "temperature"));
    }

    private async void OnEnergyTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConverterPage("Energy", "energy"));
    }

    private async void OnAreaTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConverterPage("Area", "area"));
    }

    private async void OnSpeedTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConverterPage("Speed", "speed"));
    }

    private async void OnDurationTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConverterPage("Duration", "duration"));
    }
}