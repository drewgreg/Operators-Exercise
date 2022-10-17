namespace OperatorExercise
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radius of your circle?");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}");

        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;

        }

    }
}