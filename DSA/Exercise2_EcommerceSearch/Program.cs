using System;

class Program
{
    static void Main()
    {
        Product[] products =
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Phone", "Electronics"),
            new Product(103, "Shoes", "Fashion"),
            new Product(104, "Watch", "Accessories"),
            new Product(105, "Bag", "Fashion")
        };

        int searchId = 104;

        Console.WriteLine("Linear Search:");

        Product ? linearResult =
            SearchOperations.LinearSearch(products, searchId);

        if (linearResult != null)
        {
            Console.WriteLine($"Found: {linearResult.ProductName}");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }

        Console.WriteLine();

        Console.WriteLine("Binary Search:");

        Product ? binaryResult =
            SearchOperations.BinarySearch(products, searchId);

        if (binaryResult != null)
        {
            Console.WriteLine($"Found: {binaryResult.ProductName}");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }
}