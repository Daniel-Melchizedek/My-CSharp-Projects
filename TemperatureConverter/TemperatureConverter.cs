public static class TemperatureConverter
{
    public static double CelsiusToFahrenheit(string temperatureCelcius)
    {
        //Convert argument to double for calculations
        double celsius = Double.Parse(temperatureCelcius);
        //Convert Celsius to Fahrenheit
        double fahrenheit = (celsius * 9/5) + 32;
        return fahrenheit;
    }
    public static double FahrenheitToCelsius(string temperatureFahrenheit)
    {
        //Convert argument to dou
        double fahrenheit = Double.Parse(temperatureFahrenheit);
        //Convert Fahrenheit to Celsius
        double celsius = (fahrenheit - 32)*5/9;
        return celsius;
    }
}