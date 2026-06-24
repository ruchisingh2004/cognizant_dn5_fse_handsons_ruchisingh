using RetailInventory.Data;

using var context = new AppDbContext();

var products = context.Products.ToList();

foreach (var product in products)
{
    Console.WriteLine(
        $"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
}
