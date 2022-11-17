// See https://aka.ms/new-console-template for more information
Dictionary<int, string> plakalar = new Dictionary<int, string>();

do
{
    Console.WriteLine("Bir plaka kodu giriniz:");
    int plaka = int.Parse(Console.ReadLine());
    Console.WriteLine("İl adını giriniz");
    string sehir = Console.ReadLine();

    if (plakalar.ContainsKey(plaka))
    {
        Console.WriteLine("Bu plaka zaten eklenmiş. Başka bir plaka deneyin");

    }
    else
    {
        plakalar.Add(plaka, sehir);
    }
    Console.WriteLine("Devam edelim mi (E/H)? ");


} while (Console.ReadLine() == "E");

do
{
    Console.WriteLine("Aradığınız ilin plaka kodunu giriniz");
    string bulunanSehir = plakalar[Convert.ToInt32(Console.ReadLine())];
    Console.WriteLine($"aradığınız şehir: {bulunanSehir}");
    Console.WriteLine("Başka plaka kodu sormak ister misiniz (E/H)?");

} while (Console.ReadLine() == "E");

//plakalar.Add(6, "Ankara");
//plakalar.Add(26, "Eskişehir");
//plakalar.Add(34, "İstanbul");




//Console.WriteLine(sehir);

