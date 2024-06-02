namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the lengths of the three sides of the triangle
            Console.Write("Enter the length of side 1: ");
            string input1 = Console.ReadLine() ?? "";
            
            Console.Write("Enter the length of side 2: ");
            string input2 = Console.ReadLine() ?? "";
            
            Console.Write("Enter the length of side 3: ");
            string input3 = Console.ReadLine() ?? "";

            // Parse the inputs to integers
            if (int.TryParse(input1, out int side1) && int.TryParse(input2, out int side2) && int.TryParse(input3, out int side3))
            {
                // Determine the type of the triangle based on the lengths of the sides
                string triangleType = DetermineTriangleType(side1, side2, side3);

                // Display the type of the triangle
                Console.WriteLine($"The triangle with sides {side1}, {side2}, and {side3} is: {triangleType}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numerical lengths for all three sides.");
            }
        }

        static string DetermineTriangleType(int side1, int side2, int side3)
        {
            // Check if all three sides are equal
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            // Check if any two sides are equal
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "Isosceles";
            }
            // If no sides are equal
            else
            {
                return "Scalene";
            }
        }
    }
}
