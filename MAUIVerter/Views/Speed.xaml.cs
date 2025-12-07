using MAUIVerter.Models;

namespace MAUIVerter;

public partial class Speed : ContentPage
{
    public Speed()
    {
        InitializeComponent();
        FromPicker.SelectedIndex = 1; 
        ToPicker.SelectedIndex = 0;  
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
            double result = UnitConverter.ConvertSpeed(inputValue, fromUnit, toUnit);
            OutputLabel.Text = UnitConverter.FormatResult(result);
        }
        catch (Exception ex)
        {
          
            System.Diagnostics.Debug.WriteLine($"Speed conversion error: {ex.Message}");
            OutputLabel.Text = "Error";
        }
    }
}