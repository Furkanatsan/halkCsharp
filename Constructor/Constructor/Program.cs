using Constructor;

CamasirMakinesi makine = new CamasirMakinesi();
Console.WriteLine($"makine instance'i: {makine.Renk}");
CamasirMakinesi baska = new CamasirMakinesi("Samsung");
Console.WriteLine($"baska instance'inin marka değeri:{baska.Marka}");

ExcelRaporOlusturucu raporOlusturucu = new ExcelRaporOlusturucu("C:\\bilmemne.xslx");
Ekmek ekmek = new Ekmek();

Product tablet = new Product()
{
    Id = 1,
    Name = "Samsung",
    Price = 7000,
    Rating = 4.8
};
