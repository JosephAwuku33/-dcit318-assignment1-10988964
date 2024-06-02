

namespace GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a numerical grade
            Console.Write("Please enter a numerical grade (0-100): ");
            string input = Console.ReadLine() ?? "";

            // Parse the input to an integer
            if (int.TryParse(input, out int grade))
            {
                // Check if the grade is within the valid range
                if (grade >= 0 && grade <= 100)
                {
                    // Determine the letter grade based on the numerical grade
                    string letterGrade = GetLetterGrade(grade);

                    // Display the letter grade
                    Console.WriteLine($"The letter grade for {grade} is: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("Please enter a grade between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numerical grade.");
            }
        }

        static string GetLetterGrade(int grade)
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
