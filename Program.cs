using System; 

namespace NumericTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            double length;
            double width;
            double area;
            string input;

            Console.WriteLine("Length of rectangle is:");
            input = Console.ReadLine();
            length = double.Parse(input);

            Console.WriteLine("Width of rectangle is:");
            input = Console.ReadLine();
            width = double.Parse(input);

            area = (length * width);
            Console.WriteLine("The area is: ");
            Console.ReadLine();

        }
    }
}