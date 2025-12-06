using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIVerter.Models
{
    public class UnitConverter
    {
        public string CategoryName { get; set; }
        public string CategoryId { get; set; }
        public List<string> Units { get; set; }
        public Dictionary<string, double> ConversionRates { get; set; }

        public double Convert(double value, string fromUnit, string toUnit)
        {
            if (CategoryId == "temperature")
            {
                return ConvertTemperature(value, fromUnit, toUnit);
            }

            double baseValue = value * ConversionRates[fromUnit];
            return baseValue / ConversionRates[toUnit];
        }

        private double ConvertTemperature(double value, string from, string to)
        {
            double celsius;

            // Convert to Celsius first
            if (from == "Celsius") celsius = value;
            else if (from == "Fahrenheit") celsius = (value - 32) * 5 / 9;
            else celsius = value - 273.15; // Kelvin

            // Convert from Celsius to target
            if (to == "Celsius") return celsius;
            else if (to == "Fahrenheit") return celsius * 9 / 5 + 32;
            else return celsius + 273.15; // Kelvin
        }
    }
}
