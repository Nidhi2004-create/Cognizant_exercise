using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

// Filter products with price > 1000
Console.WriteLine("----- Filtered Products -----");

var filteredProducts = await context.Products
    .Where(p => p.Price > 1000)
    .OrderByDescending(p => p.Price)
    .ToListAsync();

foreach (var product in filteredProducts)
{
    Console.WriteLine($"{product.Name} - ₹{product.Price}");
}

Console.WriteLine();

// Project into DTO (Anonymous Object)
Console.WriteLine("----- Product DTO -----");

var productDTOs = await context.Products
    .Select(p => new
    {
        p.Name,
        p.Price
    })
    .ToListAsync();

foreach (var item in productDTOs)
{
    Console.WriteLine($"{item.Name} - ₹{item.Price}");
}