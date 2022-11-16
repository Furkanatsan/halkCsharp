// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");
Product gunesGozlugu = new Product();
gunesGozlugu.SetPrice(1500);
Console.WriteLine($"Gözlüğün fiyatı: {gunesGozlugu.GetPrice()}");

gunesGozlugu.Name = "Rayban";
gunesGozlugu.Description = "2023 Yazına damga vuracak modeller";

Console.WriteLine(gunesGozlugu.Name);