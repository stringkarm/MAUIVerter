namespace MAUIVerter;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnInformationTapped(object sender, EventArgs e)
    {
        // Navigate to Information category page
        // await Navigation.PushAsync(new CategoryPage("Information", "information"));
        await DisplayAlert("Information", "Information converter clicked", "OK");
    }

    private async void OnVolumeTapped(object sender, EventArgs e)
    {
        // Navigate to Volume category page
        // await Navigation.PushAsync(new CategoryPage("Volume", "volume"));
        await DisplayAlert("Volume", "Volume converter clicked", "OK");
    }

    private async void OnLengthTapped(object sender, EventArgs e)
    {
        // Navigate to Length category page
        // await Navigation.PushAsync(new CategoryPage("Length", "length"));
        await DisplayAlert("Length", "Length converter clicked", "OK");
    }

    private async void OnMassTapped(object sender, EventArgs e)
    {
        // Navigate to Mass category page
        // await Navigation.PushAsync(new CategoryPage("Mass", "mass"));
        await DisplayAlert("Mass", "Mass converter clicked", "OK");
    }

    private async void OnTemperatureTapped(object sender, EventArgs e)
    {
        // Navigate to Temperature category page
        // await Navigation.PushAsync(new CategoryPage("Temperature", "temperature"));
        await DisplayAlert("Temperature", "Temperature converter clicked", "OK");
    }

    private async void OnEnergyTapped(object sender, EventArgs e)
    {
        // Navigate to Energy category page
        // await Navigation.PushAsync(new CategoryPage("Energy", "energy"));
        await DisplayAlert("Energy", "Energy converter clicked", "OK");
    }

    private async void OnAreaTapped(object sender, EventArgs e)
    {
        // Navigate to Area category page
        // await Navigation.PushAsync(new CategoryPage("Area", "area"));
        await DisplayAlert("Area", "Area converter clicked", "OK");
    }

    private async void OnSpeedTapped(object sender, EventArgs e)
    {
        // Navigate to Speed category page
        // await Navigation.PushAsync(new CategoryPage("Speed", "speed"));
        await DisplayAlert("Speed", "Speed converter clicked", "OK");
    }

    private async void OnDurationTapped(object sender, EventArgs e)
    {
        // Navigate to Duration category page
        // await Navigation.PushAsync(new CategoryPage("Duration", "duration"));
        await DisplayAlert("Duration", "Duration converter clicked", "OK");
    }
}