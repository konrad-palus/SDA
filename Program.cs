using SDA.FibonacciSequence;
using SDA.PriceCalculatorT3;

namespace SDA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = new PriceCalculator();
            Console.WriteLine(x.CalculatePrice(100,5,DateTime.Now));
        }
    }
}