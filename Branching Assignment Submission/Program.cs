namespace BranchingAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {// Entry point of the program
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            // Prompt the user for the package details
            Console.WriteLine("Please enter the package weight in pounds:");
            // Read the package weight from user input and Convert it to an integer saving it in packageWeight variable
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            // Check if the package weight is too heavy
            Console.WriteLine(packageWeight > 50 ? "Package too heavy to be shipped via Package Express.Have a good day." : "Please enter the package width in inches:");
            // If the package weight is acceptable, continue to ask for dimensions
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            // Read the package width from user input and Convert it to an integer saving it in packageWidth variable
            Console.WriteLine("Please enter the package height in inches:");
            // Read the package height from user input and Convert it to an integer saving it in packageHeight variable
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            // Read the package length from user input and Convert it to an integer saving it in packageLength variable
            Console.WriteLine("Please enter the package length in inches:");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            // Check if the package dimensions are too large
            Console.WriteLine("Calculating total dimensions...");
            int totalDimensions = packageWidth + packageHeight + packageLength;
            // Calculate the total dimensions of the package
            Console.WriteLine(totalDimensions > 50 ? "Package too big to be shipped via Package Express." : "Calculating shipping cost...");
            // If the total dimensions are acceptable, calculate the shipping cost
            int shippingCost = (packageWidth * packageHeight * packageLength) * packageWeight / 100;
            // Calculate the shipping cost based on the dimensions and weight
            Console.WriteLine("Your estimated total for shipping this package is: $" + shippingCost + ". Thank you.");
            // Display the estimated shipping cost to the user
            Console.ReadLine();
            // End the program and wait for user input before closing

        }
    }
}
