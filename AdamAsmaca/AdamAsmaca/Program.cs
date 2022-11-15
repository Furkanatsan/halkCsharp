// See https://aka.ms/new-console-template for more information
/*
 * 1. Bir kelime koleksiyonu içinden rastgele bir kelime seç.
 * 2. Bu kelimenin, tüm harflerini *'a çevir.
 * 3. *'lardan oluşan bu bilmeceyi ekranda göster.
 * 4. Kullanıcıdan harf iste.
 * 5. Oyuncunun girdiği harfi, seçilen kelimede ara. 
 * 6 a. Harf varsa; o harfin yerinde bulunan * sembolü ile girilen harfi değiştir
 * 6 b. Harf yoksa; harf yoktur de ve hakkını bir azalt
 * 7. Kullanıcıya kelimeyi tahmin edip etmeyeceğini sor.* 
 * 
 */

do
{
    string[] kelimeler = { "bilgisayar", "endoplazmikretikulum", "adana", "mutfak", "can" };
    string secilenKelime = rastgeleKelimeSecici(kelimeler);
    string bulmaca = bulmacayaCevir(secilenKelime);
    ekrandaGoster(bulmaca);
    bool oyunBittimi = false;
    int toplamHak = 10;
    while (!oyunBittimi)
    {
        oyunBittimi = kelimeBulmaIslemi(secilenKelime, bulmaca, toplamHak);

    }
    Console.WriteLine("Tekrar oynamak ister misiniz (E/H)?");

} while (Console.ReadLine() == "E");


static string rastgeleKelimeSecici(string[] kelimeler)
{
    Random random = new Random();
    int randomIndex = random.Next(0, kelimeler.Length);
    return kelimeler[randomIndex];
}
static string bulmacayaCevir(string secilenKelime)
{
    string bulmaca = string.Empty;
    for (int i = 0; i < secilenKelime.Length; i++)
    {
        bulmaca += "*";
    }
    return bulmaca;
}

static void ekrandaGoster(string ifade)
{
    Console.WriteLine(ifade);
}

static char girilenHarf()
{
    Console.WriteLine("Bir harf giriniz");
    return Convert.ToChar(Console.ReadLine());
}

static bool harfVarMi(string kelime, char harf)
{
    return kelime.Contains(harf);
}
static string yildiziHarfeDonustur(string secilenKelime, string bulmaca, char harf)
{
    //0 1 2
    //* * *
    //a
    //* a *
    var charArray = bulmaca.ToCharArray();
    for (int i = 0; i < secilenKelime.Length; i++)
    {
        if (secilenKelime[i] == harf)
        {
            charArray[i] = harf;
        }
    }

    string sonuc = string.Empty;
    foreach (var item in charArray)
    {
        sonuc += item.ToString();
    }

    return sonuc;
}

static int kalanHak(int hak)
{
    return --hak;
}

static bool kelimeKarsilastir(string sorulan, string tahmin)
{
    return sorulan == tahmin;
}

static bool kelimeBulmaIslemi(string secilenKelime, string bulmaca, int toplamHak)
{
    bool oyunBittimi = false;
    char harf = girilenHarf();
    if (harfVarMi(secilenKelime, harf))
    {
        bulmaca = yildiziHarfeDonustur(secilenKelime, bulmaca, harf);
        ekrandaGoster(bulmaca);
    }
    else
    {
        ekrandaGoster("harf bulunamadı");
    }

    Console.WriteLine("Kelimeyi tahmin edin");
    string tahminEdilen = Console.ReadLine();
    var karsilastirmaSonucu = kelimeKarsilastir(secilenKelime, tahminEdilen);
    if (karsilastirmaSonucu)
    {

        oyunBittimi = true;
        Console.WriteLine("Tebrikler bildiniz");
    }
    else
    {
        toplamHak = kalanHak(toplamHak);
        if (toplamHak == 0)
        {
            Console.WriteLine("Üzgünüm kaybettiniz....");
            oyunBittimi = true;
        }

    }
    return oyunBittimi;
}