using MAUIVerter.Models;

namespace MAUIVerter;

public partial class Mass : ContentPage
{
    public Mass()
    {
        InitializeComponent();
        FromPicker.SelectedIndex = 2; // Kilogram
        ToPicker.SelectedIndex = 1;   // Gram
    }

    private void OnInputChanged(object sender, TextChangedEventArgs e)
    {
        ConvertUnits();
    }

    private void OnUnitChanged(object sender, EventArgs e)
    {
        ConvertUnits();
    }

    private void ConvertUnits()
    {
        if (string.IsNullOrWhiteSpace(InputEntry.Text) ||
            FromPicker.SelectedIndex == -1 ||
            ToPicker.SelectedIndex == -1)
        {
            OutputLabel.Text = "0";
            return;
        }

        if (!double.TryParse(InputEntry.Text, out double inputValue))
        {
            OutputLabel.Text = "Invalid";
            return;
        }

        string fromUnit = FromPicker.SelectedItem.ToString();
        string toUnit = ToPicker.SelectedItem.ToString();

        try
        {
            double result = UnitConverter.ConvertMass(inputValue, fromUnit, toUnit);
            OutputLabel.Text = UnitConverter.FormatResult(result);
        }
        catch (Exception ex)
        {
            
            System.Diagnostics.Debug.WriteLine($"Mass conversion error: {ex.Message}");
            OutputLabel.Text = "Error";
        }
    }
}