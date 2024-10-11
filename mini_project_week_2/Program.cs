// Program.cs
using System;

// This is our main program class
class Program
{
    // This is the main method, where our program starts
    static void Main()
    {
        // Create a new ListManager to handle our list of products
        ListManager manager = new ListManager();

        Console.WriteLine("Enter product details. Type 'q' at any prompt to quit.");

        // Keep asking for input until the user types 'q'
        while (true)
        {
            // Ask for category
            Console.Write("Enter category: ");
            string category = Console.ReadLine();

            // If the user types 'q', stop asking for more products
            if (category.ToLower() == "q")
                break;

            // Ask for product name
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            if (name.ToLower() == "q")
                break;

            // Ask for price
            Console.Write("Enter price: ");
            string price = Console.ReadLine();
            if (price.ToLower() == "q")
                break;

            // Add the product to our list
            manager.AddProduct(category, name, price);

            // Add a blank line for readability
            Console.WriteLine();
        }

        // After the user is done, display the final list of products
        manager.DisplayList();
    }
}