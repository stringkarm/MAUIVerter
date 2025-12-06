using MAUIVerter.Models;
namespace MAUIVerter;
public partial class Duration : ContentPage
{
    public Duration()
    {
        InitializeComponent();
        FromPicker.SelectedIndex = 3; // Hour
        ToPicker.SelectedIndex = 2;   // Minute
    }
    private void OnInputChanged(object sender, TextChangedEventArgs e) => ConvertUnits();
    private void OnUnitChanged(object sender, EventArgs e) => ConvertUnits();
    private void ConvertUnits()
    {
        if (string.IsNullOrWhiteSpace(InputEntry.Text) || FromPicker.SelectedIndex == -1 || ToPicker.SelectedIndex == -1)
        {
            OutputLabel.Text = "0";
            return;
        }
        if (!double.TryParse(InputEntry.Text, out double inputValue))
        {
            OutputLabel.Text = "Invalid";
            return;
        }
        string fromUnit = FromPicker.Items[FromPicker.SelectedIndex];
        string toUnit = ToPicker.Items[ToPicker.SelectedIndex];
        double result = UnitConverter.ConvertDuration(inputValue, fromUnit, toUnit);
        OutputLabel.Text = UnitConverter.FormatResult(result);
    }
}