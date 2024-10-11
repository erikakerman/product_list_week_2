// ListManager.cs
using System;
using System.Collections.Generic;

// This class manages our list of products
public class ListManager
{
    // This list will store our products
    private List<string> productList;

    // This is the constructor. It runs when we create a new ListManager
    public ListManager()
    {
        // Initialize our list as an empty list
        productList = new List<string>();
    }

    // This method adds a product to our list
    public void AddProduct(string category, string name, string price)
    {
        // Combine the product details into a single string
        string product = $"{category}, {name}, {price}";
        // Add the product to the list
        productList.Add(product);
        // Print a message to confirm the product was added
        Console.WriteLine($"Product added. List now has {productList.Count} product(s).");
    }

    // This method displays all products in the list
    public void DisplayList()
    {
        Console.WriteLine("\nProduct List:");
        // Loop through each product in the list and print it
        foreach (string product in productList)
        {
            Console.WriteLine(product);
        }
    }
}