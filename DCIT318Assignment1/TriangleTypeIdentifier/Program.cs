using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side 1: ");
            string? input1 = Console.ReadLine();
            Console.Write("Enter side 2: ");
            string? input2 = Console.ReadLine();
            Console.Write("Enter side 3: ");
            string? input3 = Console.ReadLine();

            if (input1 != null && input2 != null && input3 != null &&
                double.TryParse(input1, out double side1) &&
                double.TryParse(input2, out double side2) &&
                double.TryParse(input3, out double side3))
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }

            }
            else
            {

                Console.WriteLine("Invalid input. Please enter valid numerical values for the sides of the triangle.");
            }
        }
    }
}
