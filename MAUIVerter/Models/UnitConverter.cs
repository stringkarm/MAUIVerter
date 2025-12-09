namespace MAUIVerter.Models
{
    public static class UnitConverter
    {
        public static double ConvertVolume(double value, string fromUnit, string toUnit)
        {
            double liters = fromUnit switch
            {
                "Milliliter" => value / 1000,
                "Liter" => value,
                "Gallon (US)" => value * 3.78541,
                "Gallon (UK)" => value * 4.54609,
                "Cup" => value * 0.236588,
                "Fluid Ounce" => value * 0.0295735,
                "Cubic Meter" => value * 1000,
                _ => value
            };

            return toUnit switch
            {
                "Milliliter" => liters * 1000,
                "Liter" => liters,
                "Gallon (US)" => liters / 3.78541,
                "Gallon (UK)" => liters / 4.54609,
                "Cup" => liters / 0.236588,
                "Fluid Ounce" => liters / 0.0295735,
                "Cubic Meter" => liters / 1000,
                _ => liters
            };
        }

        // Length Conversions (to Meters)
        public static double ConvertLength(double value, string fromUnit, string toUnit)
        {
            double meters = fromUnit switch
            {
                "Millimeter" => value / 1000,
                "Centimeter" => value / 100,
                "Meter" => value,
                "Kilometer" => value * 1000,
                "Inch" => value * 0.0254,
                "Foot" => value * 0.3048,
                "Yard" => value * 0.9144,
                "Mile" => value * 1609.34,
                _ => value
            };

            return toUnit switch
            {
                "Millimeter" => meters * 1000,
                "Centimeter" => meters * 100,
                "Meter" => meters,
                "Kilometer" => meters / 1000,
                "Inch" => meters / 0.0254,
                "Foot" => meters / 0.3048,
                "Yard" => meters / 0.9144,
                "Mile" => meters / 1609.34,
                _ => meters
            };
        }

        // Mass Conversions (to Kilograms)
        public static double ConvertMass(double value, string fromUnit, string toUnit)
        {
            double kilograms = fromUnit switch
            {
                "Milligram" => value / 1000000,
                "Gram" => value / 1000,
                "Kilogram" => value,
                "Ton" => value * 1000,
                "Ounce" => value * 0.0283495,
                "Pound" => value * 0.453592,
                "Stone" => value * 6.35029,
                _ => value
            };

            return toUnit switch
            {
                "Milligram" => kilograms * 1000000,
                "Gram" => kilograms * 1000,
                "Kilogram" => kilograms,
                "Ton" => kilograms / 1000,
                "Ounce" => kilograms / 0.0283495,
                "Pound" => kilograms / 0.453592,
                "Stone" => kilograms / 6.35029,
                _ => kilograms
            };
        }

        // Speed Conversions (to m/s)
        public static double ConvertSpeed(double value, string fromUnit, string toUnit)
        {
            double metersPerSecond = fromUnit switch
            {
                "m/s" => value,
                "km/h" => value / 3.6,
                "mph" => value * 0.44704,
                "ft/s" => value * 0.3048,
                "Knot" => value * 0.514444,
                _ => value
            };

            return toUnit switch
            {
                "m/s" => metersPerSecond,
                "km/h" => metersPerSecond * 3.6,
                "mph" => metersPerSecond / 0.44704,
                "ft/s" => metersPerSecond / 0.3048,
                "Knot" => metersPerSecond / 0.514444,
                _ => metersPerSecond
            };
        }

        // Temperature Conversions
        public static double ConvertTemperature(double value, string fromUnit, string toUnit)
        {
            // Convert to Celsius first
            double celsius = fromUnit switch
            {
                "Celsius" => value,
                "Fahrenheit" => (value - 32) * 5 / 9,
                "Kelvin" => value - 273.15,
                _ => value
            };

            // Convert from Celsius to target
            return toUnit switch
            {
                "Celsius" => celsius,
                "Fahrenheit" => celsius * 9 / 5 + 32,
                "Kelvin" => celsius + 273.15,
                _ => celsius
            };
        }

        // Energy Conversions (to Joules)
        public static double ConvertEnergy(double value, string fromUnit, string toUnit)
        {
            double joules = fromUnit switch
            {
                "Joule" => value,
                "Kilojoule" => value * 1000,
                "Calorie" => value * 4.184,
                "Kilocalorie" => value * 4184,
                "Watt-hour" => value * 3600,
                "Kilowatt-hour" => value * 3600000,
                "Electronvolt" => value * 1.60218e-19,
                _ => value
            };

            return toUnit switch
            {
                "Joule" => joules,
                "Kilojoule" => joules / 1000,
                "Calorie" => joules / 4.184,
                "Kilocalorie" => joules / 4184,
                "Watt-hour" => joules / 3600,
                "Kilowatt-hour" => joules / 3600000,
                "Electronvolt" => joules / 1.60218e-19,
                _ => joules
            };
        }

        // Area Conversions (to Square Meters)
        public static double ConvertArea(double value, string fromUnit, string toUnit)
        {
            double squareMeters = fromUnit switch
            {
                "Square Millimeter" => value / 1000000,
                "Square Centimeter" => value / 10000,
                "Square Meter" => value,
                "Square Kilometer" => value * 1000000,
                "Square Inch" => value * 0.00064516,
                "Square Foot" => value * 0.092903,
                "Square Yard" => value * 0.836127,
                "Acre" => value * 4046.86,
                "Hectare" => value * 10000,
                _ => value
            };

            return toUnit switch
            {
                "Square Millimeter" => squareMeters * 1000000,
                "Square Centimeter" => squareMeters * 10000,
                "Square Meter" => squareMeters,
                "Square Kilometer" => squareMeters / 1000000,
                "Square Inch" => squareMeters / 0.00064516,
                "Square Foot" => squareMeters / 0.092903,
                "Square Yard" => squareMeters / 0.836127,
                "Acre" => squareMeters / 4046.86,
                "Hectare" => squareMeters / 10000,
                _ => squareMeters
            };
        }

        // Duration Conversions (to Seconds)
        public static double ConvertDuration(double value, string fromUnit, string toUnit)
        {
            double seconds = fromUnit switch
            {
                "Millisecond" => value / 1000,
                "Second" => value,
                "Minute" => value * 60,
                "Hour" => value * 3600,
                "Day" => value * 86400,
                "Week" => value * 604800,
                "Month" => value * 2629800, // Average month (30.44 days)
                "Year" => value * 31557600, // Average year (365.25 days)
                _ => value
            };

            return toUnit switch
            {
                "Millisecond" => seconds * 1000,
                "Second" => seconds,
                "Minute" => seconds / 60,
                "Hour" => seconds / 3600,
                "Day" => seconds / 86400,
                "Week" => seconds / 604800,
                "Month" => seconds / 2629800,
                "Year" => seconds / 31557600,
                _ => seconds
            };
        }

        public static string FormatResult(double value)
        {
            if (double.IsInfinity(value) || double.IsNaN(value))
                return "Error";

            if (System.Math.Abs(value) >= 1000000 || (System.Math.Abs(value) < 0.0001 && value != 0))
                return value.ToString("E2");
            else if (System.Math.Abs(value) >= 100)
                return value.ToString("F2");
            else if (System.Math.Abs(value) >= 1)
                return value.ToString("F3");
            else if (System.Math.Abs(value) >= 0.01)
                return value.ToString("F4");
            else if (value == 0)
                return "0";
            else
                return value.ToString("E2");
        }
    }
}