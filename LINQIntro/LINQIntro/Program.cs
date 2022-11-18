// See https://aka.ms/new-console-template for more information
using LINQIntro;




Category phone = new() { Id = 1, Name = "Smart Phone" };
Category wearing = new() { Id = 2, Name = "Wear" };
Category elektronic = new Category();


List<Category> categories = new() { phone, wearing };

var products = new List<Product>
{
    new Product{ Id=1, Name="Samsung A51", Price=5000, Description="Android Telefon I", Rating= 4.3, IsStock=true, Category=phone},
    new Product{ Id=2, Name="Iphone 14", Price=35400, Description="IOS Phone", Rating= 4.3, IsStock=false,Category=phone},
    new Product{ Id=3, Name="Xiaomi", Price=6000, Description="Android Telefon II", Rating= 4.3, IsStock=false, Category = phone},
    new Product{ Id=4, Name="Huawei", Price=2000, Description="Android Telefon III", Rating= 4.3, IsStock=true, Category = phone},
    new Product{ Id=5, Name="Rode", Price=1000, Description="Android Telefon IV", Rating= 4.3, IsStock=true, Category = phone},
    new Product{ Id=6, Name="Nokia 3310", Price=750, Description="Android Telefon V", Rating= 4.3, IsStock=true, Category = phone},
    new Product{ Id=7, Name="Shirt", Price=150, Description="Basic Shirt", Rating= 4.3, IsStock=true, Category = wearing},
    new Product{ Id=8, Name="Pant", Price=350, Description="Smart Casual", Rating= 4.3, IsStock=true, Category = wearing},




};

var result = from product in products
             where product.Price > 1000
             select new { product.Name, product.Description };

Console.WriteLine("--- 1000 TL'den pahalı ürünler ----");

result.ToList().ForEach(p => Console.WriteLine($"{p.Name}\t{p.Description}"));

var extResult = products.Where(p => p.Price > 2000)
                        .Select(p => new { Ad = p.Name, Fiyat = p.Price })
                        .ToList();

Console.WriteLine("--- 2000 TL'den pahalı ürünler ----");
extResult.ForEach(ex => Console.WriteLine($"{ex.Ad} - {ex.Fiyat} "));


var nokia = products.FirstOrDefault(p => p.Id == 6);
//var sample = products.SingleOrDefault(p => p.Description.Contains("Android"));
//FirstOrDefault ile Single arasındaki fark; ilkinde koleksiyon varsa ilk elemanı yoksa null gibi default değer döndürürken,
//Single ise Eğer birden fazla eleman geliyorsa exception fırlatır.
Console.WriteLine("-------------- Açıklamasında Android olanlar  -------------------");
var androids = products.Where(p => p.Description.Contains("Android"));

foreach (var android in androids)
{
    Console.WriteLine($"{android.Name}-{android.Price}-{android.Rating}");
}

//var number = new Random().Next(1, 10);
var sample2 = products.Select(p => new { p.Name, p.Price, p.Description })
                      .ToList()
                      .Where(p => p.Price > 2000);

var orderedProducts = products.OrderBy(p => p.Price);

var extResult2 = products.Where(p => p.Price > 2000)
                        .Select(p => new { Ad = p.Name, Fiyat = p.Price })
                        .OrderByDescending(p => p.Fiyat)
                        .ToList();

IOrderedEnumerable<string> ordered = null;
IEnumerable<string> enumString = null;
Console.WriteLine("--------------- Aggregate Functions --------------------");
//Aggregate:
var total = products.Sum(p => p.Price);
var max = products.Max(p => p.Price);
var average = products.Average(p => p.Price);
var min = products.Min(p => p.Price);
var count = products.Count(p => p.IsStock == false);

Console.WriteLine($"Fiyatların toplamı: {total}\nEn pahalı ürün:{max}\nOrtalama fiyat:{average}\nEn düşük fiyat:{min}\nStokta olmayan ürünlerin sayısı:{count}");

Console.WriteLine("----------- JOIN -------------");


var joinQuery = categories.Join(products,
                                category => category,
                                product => product.Category,
                                (category, product) => new { KategoriAdi = category.Name, UrunAdi = product.Name });

foreach (var item in joinQuery)
{
    Console.WriteLine($"{item.KategoriAdi}: {item.UrunAdi}");
}
Console.WriteLine("---------- Alternatif -------------");
var alternative = products.Select(x => new { ProductName = x.Name, CategoryName = x.Category.Name }).ToList();
alternative.ForEach(p => Console.WriteLine($"{p.CategoryName}: {p.ProductName}"));

Console.WriteLine("---- Group By -----");

var group = products.GroupBy(
                                category => category.Category.Name,
                                product => new { product.Name, product.Price },
                                (letter, products) => new
                                {
                                    Key = letter,
                                    Count = products.Count(),
                                    Min = products.Min(x => x.Price),
                                    Max = products.Max(x => x.Price)
                                }
                                );

foreach (var item in group)
{
    Console.WriteLine($"Kategori: {item.Key}");
    Console.WriteLine($"Toplam ürün sayısı: {item.Count}");
    Console.WriteLine($"En pahalı ürün fiyatı: {item.Max}");
    Console.WriteLine($"En ucuz ürün fiyatı: {item.Min}");
}