namespace IntroduceCSharp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int sicaklik = 6;
            //1. Sayısal
            byte enMinik = 255;
            //Byte

            sbyte eksiOlabilenByte = -128;
            //SByte

            short suBardagi = 32767;
            //Int16
            ushort onaltiBitPozitif = 65535;

            int otuzikiBit = 2147483647;
            //Int32
            uint otuzikiBitPozitif = 4294967294;

            long enBuyukTamSayi = 11111111111111;
            //Int64
            ulong enBuyukPozitif = 22222222222222222;



            double pi = 3.14;
            float altinOran = 1.615f;
            decimal enHassasOndalikliDeger = 0.00000000000000000000000000000000001M;


            //2. Sözel

            char charakter = '!';
            string kelime = "Türkay!";//C# diline ait
            String word = "Deneme";//.NET Framework'e ait.

            //3. Mantıksal
            bool olduMu = true;

            byte x = 253;
            byte y = 3;

            checked
            {
                byte toplam = (byte)(x + y);
                Console.WriteLine(toplam);
            }

            Console.WriteLine("Bir sayı giriniz....");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam2 = sayi1 + sayi2;

            Console.WriteLine(sayi1 + " ve " + sayi2 + " değerlerinin toplamı = " + toplam2);
            Console.WriteLine($"{sayi1} ve {sayi2} değerlerinin toplamı {toplam2} sonucunu verir");










        }
    }
}