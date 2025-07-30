namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var temp1 = TempConverter.CelsiusToFahrenheit(30);
            Console.WriteLine($" 30 degrees celsius = {temp1} fahrenheit");
            var temp2 = TempConverter.FahrenheitToCelsius(86);
            Console.WriteLine($" 86 degrees fahrenheit = {temp2} celsius");
            
        }
    }
}
