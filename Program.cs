using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            // Prompt for package weight
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());
            
            // Check if weight exceeds 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End program
            }
            
            // Prompt for package dimensions
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter the package length:");
            float length = float.Parse(Console.ReadLine());
            
            // Check if dimensions total exceeds 50
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End program
            }
            
            // Calculate quote: (width * height * length * weight) / 100
            float quote = (width * height * length * weight) / 100;
            
            // Display quote to user
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
            
            Console.ReadLine(); // Keep console window open
        }
    }
}
