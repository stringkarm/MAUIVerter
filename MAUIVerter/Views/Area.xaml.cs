using MAUIVerter.Models;
namespace MAUIVerter;
public partial class Area : ContentPage
{
    public Area()
    {
        InitializeComponent();
        FromPicker.SelectedIndex = 2; 
        ToPicker.SelectedIndex = 7;   
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
        double result = UnitConverter.ConvertArea(inputValue, fromUnit, toUnit);
        OutputLabel.Text = UnitConverter.FormatResult(result);
    }
}