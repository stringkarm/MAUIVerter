using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using MAUIVerter.Models;

namespace MAUIVerter.ViewModels
{
    public class ConverterViewModel : INotifyPropertyChanged
    {
        private UnitConverter _converter;
        private string _inputValue = "1";
        private string _outputValue = "0";
        private string _selectedFromUnit;
        private string _selectedToUnit;

        public event PropertyChangedEventHandler PropertyChanged;

        public ConverterViewModel(string categoryName, string categoryId)
        {
            CategoryName = categoryName;
            InitializeConverter(categoryId);
        }

        public string CategoryName { get; set; }

        public ObservableCollection<string> Units { get; set; }

        public string InputValue
        {
            get => _inputValue;
            set
            {
                _inputValue = value;
                OnPropertyChanged();
                PerformConversion();
            }
        }

        public string OutputValue
        {
            get => _outputValue;
            set
            {
                _outputValue = value;
                OnPropertyChanged();
            }
        }

        public string SelectedFromUnit
        {
            get => _selectedFromUnit;
            set
            {
                _selectedFromUnit = value;
                OnPropertyChanged();
                PerformConversion();
            }
        }

        public string SelectedToUnit
        {
            get => _selectedToUnit;
            set
            {
                _selectedToUnit = value;
                OnPropertyChanged();
                PerformConversion();
            }
        }

        private void InitializeConverter(string categoryId)
        {
            _converter = new UnitConverter { CategoryId = categoryId };

            switch (categoryId)
            {
                case "information":
                    Units = new ObservableCollection<string> { "Bit", "Byte", "Kilobyte", "Megabyte", "Gigabyte", "Terabyte" };
                    _converter.ConversionRates = new Dictionary<string, double>
                    {
                        { "Bit", 1 },
                        { "Byte", 8 },
                        { "Kilobyte", 8000 },
                        { "Megabyte", 8000000 },
                        { "Gigabyte", 8000000000 },
                        { "Terabyte", 8000000000000 }
                    };
                    break;

                case "volume":
                    Units = new ObservableCollection<string> { "Milliliter", "Liter", "Cubic Meter", "Gallon (US)", "Fluid Ounce (US)", "Cup (US)" };
                    _converter.ConversionRates = new Dictionary<string, double>
                    {
                        { "Milliliter", 1 },
                        { "Liter", 1000 },
                        { "Cubic Meter", 1000000 },
                        { "Gallon (US)", 3785.41 },
                        { "Fluid Ounce (US)", 29.5735 },
                        { "Cup (US)", 236.588 }
                    };
                    break;

                case "length":
                    Units = new ObservableCollection<string> { "Millimeter", "Centimeter", "Meter", "Kilometer", "Inch", "Foot", "Yard", "Mile" };
                    _converter.ConversionRates = new Dictionary<string, double>
                    {
                        { "Millimeter", 0.001 },
                        { "Centimeter", 0.01 },
                        { "Meter", 1 },
                        { "Kilometer", 1000 },
                        { "Inch", 0.0254 },
                        { "Foot", 0.3048 },
                        { "Yard", 0.9144 },
                        { "Mile", 1609.34 }
                    };
                    break;

                case "mass":
                    Units = new ObservableCollection<string> { "Milligram", "Gram", "Kilogram", "Metric Ton", "Ounce", "Pound", "Ton (US)" };
                    _converter.ConversionRates = new Dictionary<string, double>
                    {
                        { "Milligram", 0.001 },
                        { "Gram", 1 },
                        { "Kilogram", 1000 },
                        { "Metric Ton", 1000000 },
                        { "Ounce", 28.3495 },
                        { "Pound", 453.592 },
                        { "Ton (US)", 907185 }
                    };
                    break;

                case "temperature":
                    Units = new ObservableCollection<string> { "Celsius", "Fahrenheit", "Kelvin" };
                    _converter.ConversionRates = new Dictionary<string, double>(); // Not used for temperature
                    break;

                case "energy":
                    Units = new ObservableCollection<string> { "Joule", "Kilojoule", "Calorie", "Kilocalorie", "Watt-hour", "Kilowatt-hour" };
                    _converter.ConversionRates = new Dictionary<string, double>
                    {
                        { "Joule", 1 },
                        { "Kilojoule", 1000 },
                        { "Calorie", 4.184 },
                        { "Kilocalorie", 4184 },
                        { "Watt-hour", 3600 },
                        { "Kilowatt-hour", 3600000 }
                    };
                    break;

                case "area":
                    Units = new ObservableCollection<string> { "Square Millimeter", "Square Centimeter", "Square Meter", "Hectare", "Square Kilometer", "Square Inch", "Square Foot", "Acre", "Square Mile" };
                    _converter.ConversionRates = new Dictionary<string, double>
                    {
                        { "Square Millimeter", 0.000001 },
                        { "Square Centimeter", 0.0001 },
                        { "Square Meter", 1 },
                        { "Hectare", 10000 },
                        { "Square Kilometer", 1000000 },
                        { "Square Inch", 0.00064516 },
                        { "Square Foot", 0.092903 },
                        { "Acre", 4046.86 },
                        { "Square Mile", 2589988 }
                    };
                    break;

                case "speed":
                    Units = new ObservableCollection<string> { "Meters/second", "Kilometers/hour", "Miles/hour", "Feet/second", "Knots" };
                    _converter.ConversionRates = new Dictionary<string, double>
                    {
                        { "Meters/second", 1 },
                        { "Kilometers/hour", 0.277778 },
                        { "Miles/hour", 0.44704 },
                        { "Feet/second", 0.3048 },
                        { "Knots", 0.514444 }
                    };
                    break;

                case "duration":
                    Units = new ObservableCollection<string> { "Millisecond", "Second", "Minute", "Hour", "Day", "Week", "Month", "Year" };
                    _converter.ConversionRates = new Dictionary<string, double>
                    {
                        { "Millisecond", 0.001 },
                        { "Second", 1 },
                        { "Minute", 60 },
                        { "Hour", 3600 },
                        { "Day", 86400 },
                        { "Week", 604800 },
                        { "Month", 2628000 },
                        { "Year", 31536000 }
                    };
                    break;
            }

            SelectedFromUnit = Units[0];
            SelectedToUnit = Units.Count > 1 ? Units[1] : Units[0];
        }

        private void PerformConversion()
        {
            if (double.TryParse(InputValue, out double value) &&
                !string.IsNullOrEmpty(SelectedFromUnit) &&
                !string.IsNullOrEmpty(SelectedToUnit))
            {
                double result = _converter.Convert(value, SelectedFromUnit, SelectedToUnit);
                OutputValue = result.ToString("0.##########");
            }
            else
            {
                OutputValue = "0";
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}