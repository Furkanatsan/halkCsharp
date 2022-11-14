// See https://aka.ms/new-console-template for more information
string[] katilimcilar = new string[21];
katilimcilar[0] = "Türkay Ürkmez";
katilimcilar[1] = "Alp Onur Kerem Yıldız";
katilimcilar[20] = "Zeynep Can";

string[] gunler = new string[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

Console.WriteLine($"toplam katılımcı sayısı: {katilimcilar.Length}");
Console.WriteLine($"array'in ilk elemanı: {katilimcilar[0]}");
Console.WriteLine($"array'in son elemanı: {katilimcilar[katilimcilar.Length - 1]}");

/*
 * Problem: Klavyeden girilen max iki haneli bir sayıyı yazılışına çeviren uygulama
 * 
 */
string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

Console.WriteLine("en fazla iki haneli olacak biçimde bir sayı giriniz");
var sayi = Convert.ToInt32(Console.ReadLine());
var onlarBasamagindakiSayi = sayi / 10;
var birlerBasamagindakiSayi = sayi % 10;

Console.WriteLine(onlar[onlarBasamagindakiSayi] + " " + birler[birlerBasamagindakiSayi]);


