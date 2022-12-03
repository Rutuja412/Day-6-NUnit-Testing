using System;

namespace TempertureConversion
{
    internal class Program
    {
        public class TempConv
        {
            static void Main(string[] args)
            {
                Console.Write("Enter value for Celcius to Fahrenheit conversion: ");
                temperatureConversion.C = Convert.ToInt32(Console.ReadLine());
                temperatureConversion.temperaturConversionToFahrenheit();

                Console.WriteLine(" \n ");

                Console.Write("Enter value for Fahrenheit to celsius conversion: ");
                temperatureConversion.F = Convert.ToInt32(Console.ReadLine()); ;
                temperatureConversion.temperaturConversionToCelsius();
                Console.WriteLine(" \n ");
            }
        }
    }
}
