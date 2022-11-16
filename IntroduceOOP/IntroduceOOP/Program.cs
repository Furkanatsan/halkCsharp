using IntroduceOOP;

Kitap ilkKitap = new Kitap();
Kitap ikinciKitap = new Kitap();
int sayi = 8;


ilkKitap.Ad = "Kör Saatçi";
ilkKitap.YazarAdi = "Richard Dawkins";
ilkKitap.SayfaSayisi = -124;

CamasirMakinesi arcelikAPlus = new CamasirMakinesi();
arcelikAPlus.Calistir(CamasirTuru.Pamuklu);
arcelikAPlus.Yika();
arcelikAPlus.Kurut();


Personel yazilimci1 = new Personel();
yazilimci1.Ad = "Türkay";

Personel yazilimci2 = yazilimci1;
yazilimci2.Ad = "Alp Onur Kerem";

Console.WriteLine(yazilimci1.Ad);