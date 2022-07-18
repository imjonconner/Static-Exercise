namespace Static_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celcius = Temp_Converter.FahrenheightToCelsius(68);
            var fahrenheight = Temp_Converter.CelsiusTorFahrenheight(20);

            Console.WriteLine("After Conversion:");
            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"fahrenheight {fahrenheight}");
            
        }
    }
}