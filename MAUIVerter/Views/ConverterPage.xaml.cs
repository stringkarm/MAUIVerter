using MAUIVerter.ViewModels;

namespace MAUIVerter.Views;

public partial class ConverterPage : ContentPage
{
    public ConverterPage(string categoryName, string categoryId)
    {
        InitializeComponent();
        BindingContext = new ConverterViewModel(categoryName, categoryId);
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}