using System;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 98.6;
            double celsius = TempConverter.FahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit} Fahrenheit is {celsius} Celsius");

            celsius = 37;
            fahrenheit = TempConverter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius} Celsius is {fahrenheit} Fahrenheit");
        }
    }
}
