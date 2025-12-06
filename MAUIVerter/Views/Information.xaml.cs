namespace MAUIVerter;

public partial class Information : ContentPage
{
    public Information()
    {
        InitializeComponent();
        FromPicker.SelectedIndex = 0; // Bit
        ToPicker.SelectedIndex = 1;   // Byte
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

        // Convert to bits first (base unit)
        double bits = ConvertToBits(inputValue, FromPicker.SelectedIndex);

        // Convert from bits to target unit
        double result = ConvertFromBits(bits, ToPicker.SelectedIndex);

        OutputLabel.Text = FormatResult(result);
    }

    private double ConvertToBits(double value, int unitIndex)
    {
        return unitIndex switch
        {
            0 => value,                                  // Bit
            1 => value * 8,                              // Byte
            2 => value * 8 * 1024,                       // Kilobyte
            3 => value * 8 * 1024 * 1024,                // Megabyte
            4 => value * 8L * 1024 * 1024 * 1024,        // Gigabyte
            5 => value * 8L * 1024 * 1024 * 1024 * 1024, // Terabyte
            _ => value
        };
    }

    private double ConvertFromBits(double bits, int unitIndex)
    {
        return unitIndex switch
        {
            0 => bits,                                   // Bit
            1 => bits / 8,                               // Byte
            2 => bits / (8 * 1024),                      // Kilobyte
            3 => bits / (8 * 1024 * 1024),               // Megabyte
            4 => bits / (8L * 1024 * 1024 * 1024),       // Gigabyte
            5 => bits / (8L * 1024 * 1024 * 1024 * 1024),// Terabyte
            _ => bits
        };
    }

    private string FormatResult(double value)
    {
        if (double.IsInfinity(value) || double.IsNaN(value))
            return "Error";

        if (Math.Abs(value) >= 1000000 || (Math.Abs(value) < 0.0001 && value != 0))
            return value.ToString("E2");
        else if (Math.Abs(value) >= 100)
            return value.ToString("F2");
        else if (Math.Abs(value) >= 1)
            return value.ToString("F3");
        else if (Math.Abs(value) >= 0.01)
            return value.ToString("F4");
        else if (value == 0)
            return "0";
        else
            return value.ToString("E2");
    }
}