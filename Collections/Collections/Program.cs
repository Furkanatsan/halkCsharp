// See https://aka.ms/new-console-template for more information
using Collections;

Console.WriteLine("Hello, World!");

ProductService productService = new ProductService();

showAllProducts();
productService.AddProduct(new Product { Id = 5, Name = "Mont", Price = 1000, Rating = 4.2, Description = "Kışlık..." });
showAllProducts();
searchProductInGallery();

void searchProductInGallery()
{
    Console.WriteLine("Aradığınız ürün adını girin");
    var products = productService.SearchProductsByName(Console.ReadLine());
    Console.WriteLine("Bulunan ürünler");
    showOnTable(products);
}

void showAllProducts()
{
    Console.Clear();
    Console.WriteLine("-------  Tüm Ürünler -------------");
    var gallery = productService.GetAllProducts();
    showOnTable(gallery);
}

static void showOnTable(List<Product> products)
{
    foreach (var product in products)
    {
        Console.WriteLine($"{product.Name.PadRight(10, ' ')}\t{product.Price}\t{product.Rating}\t{product.Description}");
    }
}