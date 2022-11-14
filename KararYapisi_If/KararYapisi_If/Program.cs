// See https://aka.ms/new-console-template for more information

Random rastgeleSayiUretici = new Random();
int uretilenSayi = rastgeleSayiUretici.Next(1, 100);
bool oyuncuBildiMi = false;

while (!oyuncuBildiMi)
{
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
        oyuncuBildiMi = true;
        Console.WriteLine("Bildiniz!");
    }

}


