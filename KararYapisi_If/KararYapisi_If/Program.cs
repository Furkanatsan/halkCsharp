// See https://aka.ms/new-console-template for more information

Random rastgeleSayiUretici = new Random();
int uretilenSayi = rastgeleSayiUretici.Next(1, 100);
Console.WriteLine("Tutulan sayıyı tahmin edin");
var tahmin = int.Parse(Console.ReadLine());
if (uretilenSayi > tahmin)
{
    Console.WriteLine($"üretilen sayı, {tahmin} sayısından büyük....");
}
else if (uretilenSayi < tahmin)
{
    Console.WriteLine($"üretilen sayı, {tahmin} sayısından küçük....");

}
else
{
    Console.WriteLine("Bildiniz!");
}

