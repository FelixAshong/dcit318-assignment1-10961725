using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade (0-100): ");
            string? input = Console.ReadLine();

            if (input != null && int.TryParse(input, out int grade))

            {
                string letterGrade = grade switch
                {
                    >= 90 => "A",
                    >= 80 => "B",
                    >= 70 => "C",
                    >= 60 => "D",
                    _ => "F",
                };

                Console.WriteLine($"The letter grade is: {letterGrade}");

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
            }
        }
    }
}
