namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ekranaYazdir("Bir sayı girin");
            int sayi = girilenSayiyiOku();
            if (ciftMi(sayi))
            {
                ekranaYazdir($"{sayi} sayısı çifttir");
            }
            else
            {
                ekranaYazdir($"{sayi} sayısı tektir");
            }
        }

        static void ekranaYazdir(string message)
        {
            Console.WriteLine(message);

        }

        static int girilenSayiyiOku()
        {
            return int.Parse(Console.ReadLine());
        }

        static bool ciftMi(int sayi)
        {
            return sayi % 2 == 0;
        }
    }


}